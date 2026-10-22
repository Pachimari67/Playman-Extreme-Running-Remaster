using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Godot;
using MeltySynth;
using PlaymanExtremeRunning.J2ME;

public partial class MainScene : Node2D
{
    private class_6 _midlet;
    private class_5 _canvas;
    private Godot.Image _godotImg;
    private ImageTexture _texture;
    private byte[] _rgbaBytes;

    private readonly Dictionary<Player, AudioStreamPlayer> _audioPlayers = new Dictionary<Player, AudioStreamPlayer>();
    private static readonly Dictionary<int, AudioStreamWav> _midiStreamCache = new Dictionary<int, AudioStreamWav>();
    private static readonly Dictionary<string, AudioStreamWav> _remasterWavCache = new Dictionary<string, AudioStreamWav>();

    // Pause/Resume music position tracking
    private int _pausedMusicSoundId = -1;
    private float _pausedMusicPositionSec = 0f;

    // Smooth audio crossfade on mode switch
    private AudioStreamPlayer _fadingOutAudioPlayer;
    private AudioStreamPlayer _fadingInAudioPlayer;
    private float _audioFadeTargetDb = 0f;
    private float _audioCrossfadeTimer = 0f;
    private const float AudioCrossfadeDuration = 0.28f;

    // Smooth visual transition on mode switch
    private ImageTexture _transitionFromTexture;
    private Rect2 _transitionFromRect;
    private float _visualTransitionTimer = 0f;
    private const float VisualTransitionDuration = 0.26f;

    private bool _showControlsOverlay = true;

    // Unified modes:
    // Remaster = 712x400 logical (1424x800 2x gentle xBR internal render, studio WAV audio)
    // Original = 240x320 (1x original pixel render, Nokia phone audio)
    private const int RemasterW = 712;
    private const int RemasterH = 400;
    private const int OriginalW = 240;
    private const int OriginalH = 320;

    // Fixed native 33.3 FPS (30 ms per simulation step) in all modes
    private const double NativeTickInterval = 0.030;
    private const int NativeDeltaMs = 30;
    private double _tickAccumulator = 0.0;

    private static SoundFont _soundFont;
    private bool _wasInNameEntry = false;
    private bool _clearDefaultNameOnFirstKey = false;

    // Gamepad analog stick digital state tracking
    private bool _stickLeftPressed = false;
    private bool _stickRightPressed = false;
    private bool _stickUpPressed = false;
    private bool _stickDownPressed = false;
    private const float StickDeadzone = 0.38f;

    private static string SettingsFilePath => Path.Combine(JavaLang.SaveRoot, "remaster_settings.cfg");

    public override void _Ready()
    {
        Engine.MaxFps = 0;

        JavaLang.InitPaths();
        LoadPersistentSettings();
        SetupAudioCallbacks();

        ApplyWindowMode(class_5.WindowModeIndex, save: false);
        Displayable.ConfiguredWidth = class_5.UseRemasterMode ? RemasterW : OriginalW;
        Displayable.ConfiguredHeight = class_5.UseRemasterMode ? RemasterH : OriginalH;
        Displayable.RenderScale = class_5.UseRemasterMode ? 2 : 1;
        TextureFilter = class_5.UseRemasterMode ? TextureFilterEnum.Linear : TextureFilterEnum.Nearest;

        _midlet = new class_6();
        _midlet.startApp();
        _canvas = class_6.field_406;
        _canvas.InitGame();

        // Ensure loaded language is applied even if ropt was newly created
        if (class_5.field_133 != null && class_5.field_133.Length > 2)
            class_5.field_133[2] = (sbyte)class_5.CurrentLanguageIndex;
        Localization.ApplyLanguage(class_5.field_145, class_5.CurrentLanguageIndex);
        class_5.RecenterLayoutForResolutionChange();

        GetViewport().SizeChanged += OnViewportSizeChanged;
    }

    public override void _Notification(int what)
    {
        if (what == NotificationWMCloseRequest)
        {
            SavePersistentSettings();
        }
    }

    private void LoadPersistentSettings()
    {
        // Defaults: Remaster = true, WindowMode = 1 (Borderless Windowed), Language = 0 (English), ShowHelp = true
        class_5.UseRemasterMode = true;
        class_5.WindowModeIndex = 1;
        class_5.CurrentLanguageIndex = 0;
        _showControlsOverlay = true;

        try
        {
            if (File.Exists(SettingsFilePath))
            {
                foreach (string rawLine in File.ReadAllLines(SettingsFilePath))
                {
                    string line = rawLine.Trim();
                    int eq = line.IndexOf('=');
                    if (eq <= 0) continue;
                    string k = line.Substring(0, eq).Trim();
                    string v = line.Substring(eq + 1).Trim();
                    if (k == "remaster" && bool.TryParse(v, out bool rem))
                        class_5.UseRemasterMode = rem;
                    else if (k == "window_mode" && int.TryParse(v, out int wm))
                        class_5.WindowModeIndex = Math.Clamp(wm, 0, 2);
                    else if (k == "language" && int.TryParse(v, out int lang))
                        class_5.CurrentLanguageIndex = Math.Clamp(lang, 0, Localization.LanguageNames.Length - 1);
                    else if (k == "show_help" && bool.TryParse(v, out bool sh))
                        _showControlsOverlay = sh;
                }
            }
        }
        catch { }
    }

    private void SavePersistentSettings()
    {
        try
        {
            JavaLang.InitPaths();
            string content =
                $"remaster={class_5.UseRemasterMode}\n" +
                $"window_mode={class_5.WindowModeIndex}\n" +
                $"language={class_5.CurrentLanguageIndex}\n" +
                $"show_help={_showControlsOverlay}\n";
            File.WriteAllText(SettingsFilePath, content);
        }
        catch { }
    }

    private void OnViewportSizeChanged()
    {
        QueueRedraw();
    }

    private void ApplyWindowMode(int modeIndex, bool save = true)
    {
        class_5.WindowModeIndex = Math.Clamp(modeIndex, 0, 2);
        int screenIdx = DisplayServer.WindowGetCurrentScreen();
        Vector2I screenSize = DisplayServer.ScreenGetSize(screenIdx);
        Vector2I screenPos = DisplayServer.ScreenGetPosition(screenIdx);

        if (class_5.WindowModeIndex == 2)
        {
            // Fullscreen
            DisplayServer.WindowSetFlag(DisplayServer.WindowFlags.Borderless, false);
            DisplayServer.WindowSetMode(DisplayServer.WindowMode.Fullscreen);
        }
        else if (class_5.WindowModeIndex == 1)
        {
            // Borderless Windowed (Not Fullscreen, No Borders)
            DisplayServer.WindowSetMode(DisplayServer.WindowMode.Windowed);
            DisplayServer.WindowSetFlag(DisplayServer.WindowFlags.Borderless, true);
            DisplayServer.WindowSetSize(screenSize);
            DisplayServer.WindowSetPosition(screenPos);
        }
        else
        {
            // Windowed (With Borders)
            DisplayServer.WindowSetMode(DisplayServer.WindowMode.Windowed);
            DisplayServer.WindowSetFlag(DisplayServer.WindowFlags.Borderless, false);
            Vector2I winSize = new Vector2I(Math.Min(1600, screenSize.X - 80), Math.Min(900, screenSize.Y - 80));
            DisplayServer.WindowSetSize(winSize);
            DisplayServer.WindowSetPosition(screenPos + (screenSize - winSize) / 2);
        }
        if (save)
            SavePersistentSettings();
        QueueRedraw();
    }

    private void SetupAudioCallbacks()
    {
        Player.OnStartPlayer = player =>
        {
            CallDeferred(nameof(StartPlayerOnMainThread), new VariantWrapper(player));
        };
        Player.OnStopPlayer = player =>
        {
            CallDeferred(nameof(StopPlayerOnMainThread), new VariantWrapper(player));
        };
        Player.OnVolumeChanged = player =>
        {
            CallDeferred(nameof(UpdatePlayerVolumeOnMainThread), new VariantWrapper(player));
        };
        class_5.OnPauseGame = () =>
        {
            SaveMusicPositionOnPause();
        };
        class_5.OnModeChanged = () =>
        {
            CallDeferred(nameof(ToggleUnifiedMode));
        };
        class_5.OnWindowModeChanged = modeIdx =>
        {
            CallDeferred(nameof(ApplyWindowModeFromMenu), modeIdx);
        };
        class_5.OnSettingsChanged = () =>
        {
            CallDeferred(nameof(SavePersistentSettings));
        };
    }

    private void ApplyWindowModeFromMenu(int modeIdx)
    {
        ApplyWindowMode(modeIdx, save: true);
    }

    private void SaveMusicPositionOnPause()
    {
        var musicPlayer = class_5.GetActiveMusicPlayer();
        if (musicPlayer == null || (musicPlayer.SoundId < 7 && musicPlayer.SoundId != 2)) return;
        lock (_audioPlayers)
        {
            if (_audioPlayers.TryGetValue(musicPlayer, out var asp) && IsInstanceValid(asp) && asp.Playing)
            {
                _pausedMusicSoundId = musicPlayer.SoundId;
                _pausedMusicPositionSec = asp.GetPlaybackPosition();
            }
        }
    }

    private void ToggleUnifiedMode()
    {
        // Capture current visual frame and draw rect for smooth visual transition
        if (_texture != null && _godotImg != null)
        {
            var imgCopy = (Godot.Image)_godotImg.Duplicate();
            _transitionFromTexture = ImageTexture.CreateFromImage(imgCopy);
            _transitionFromRect = ComputeDrawRect(_texture.GetWidth(), _texture.GetHeight());
            _visualTransitionTimer = VisualTransitionDuration;
        }

        // Toggle unified mode
        class_5.UseRemasterMode = !class_5.UseRemasterMode;
        Displayable.ConfiguredWidth = class_5.UseRemasterMode ? RemasterW : OriginalW;
        Displayable.ConfiguredHeight = class_5.UseRemasterMode ? RemasterH : OriginalH;
        Displayable.RenderScale = class_5.UseRemasterMode ? 2 : 1;
        TextureFilter = class_5.UseRemasterMode ? TextureFilterEnum.Linear : TextureFilterEnum.Nearest;
        SavePersistentSettings();

        if (_canvas != null)
        {
            _canvas.EnsureFramebuffer();
            class_5.RecenterLayoutForResolutionChange();
            class_5.field_152 = true;
            _canvas.repaint();
            UpdateFramebufferTexture();
        }

        // Smooth position-synced audio transition for active music track (including Prize screen Sound 2!)
        float currentMusicPos = 0f;
        bool wasMusicPlaying = false;
        Player activeMusic = class_5.GetActiveMusicPlayer();

        lock (_audioPlayers)
        {
            if (activeMusic != null && _audioPlayers.TryGetValue(activeMusic, out var oldMusicAsp) && IsInstanceValid(oldMusicAsp) && oldMusicAsp.Playing)
            {
                currentMusicPos = oldMusicAsp.GetPlaybackPosition();
                wasMusicPlaying = true;

                // Detach old music player to fade it out smoothly instead of cutting abruptly
                if (_fadingOutAudioPlayer != null && IsInstanceValid(_fadingOutAudioPlayer))
                {
                    _fadingOutAudioPlayer.Stop();
                    _fadingOutAudioPlayer.QueueFree();
                }
                _fadingOutAudioPlayer = oldMusicAsp;
                _audioPlayers.Remove(activeMusic);
            }

            foreach (var kv in _audioPlayers)
            {
                if (IsInstanceValid(kv.Value))
                {
                    kv.Value.Stop();
                    kv.Value.QueueFree();
                }
            }
            _audioPlayers.Clear();
        }

        if (activeMusic != null && (wasMusicPlaying || activeMusic.State == 400) && class_5.field_133 != null && class_5.field_133[0] != 0)
        {
            StartMusicAtPosition(activeMusic, currentMusicPos, smoothFadeIn: wasMusicPlaying);
        }

        QueueRedraw();
    }

    private void StartMusicAtPosition(Player p, float positionSec, bool smoothFadeIn)
    {
        if (p == null || p.RawBytes == null || p.RawBytes.Length == 0) return;

        bool loop = (p.LoopCount == -1) || (class_5.field_159 && class_5.field_276 == 11 && p.SoundId == 2);
        AudioStream targetStream = null;
        if (class_5.UseRemasterMode)
        {
            string remasterFile = GetRemasterWavFileName(p.SoundId);
            targetStream = LoadRemasterWavFile(remasterFile, loop);
        }
        targetStream ??= CreateGodotAudioStream(p.RawBytes, p.MimeType, loop);

        if (targetStream is AudioStreamWav wav)
            wav.LoopMode = loop ? AudioStreamWav.LoopModeEnum.Forward : AudioStreamWav.LoopModeEnum.Disabled;

        var asp = new AudioStreamPlayer();
        AddChild(asp);
        asp.Stream = targetStream;

        lock (_audioPlayers)
        {
            _audioPlayers[p] = asp;
        }

        float targetDb = p.Volume <= 0 ? -80f : Mathf.LinearToDb(Mathf.Clamp(p.Volume / 100f, 0.001f, 1f));
        double streamLen = targetStream?.GetLength() ?? 0.0;
        float seekPos = (streamLen > 0.1) ? (float)(positionSec % streamLen) : 0f;

        if (smoothFadeIn && p.Volume > 0)
        {
            _audioFadeTargetDb = targetDb;
            _fadingInAudioPlayer = asp;
            _audioCrossfadeTimer = AudioCrossfadeDuration;
            asp.VolumeDb = -28f;
        }
        else
        {
            asp.VolumeDb = targetDb;
        }

        asp.Play(seekPos);
    }

    private static string GetRemasterWavFileName(int soundId)
    {
        return soundId switch
        {
            0 or 20 => "xr_menu_in.wav",
            1 => "xr_menu_out.wav",
            2 => "xr_final.wav",
            3 => "xr_checkpoint.wav",
            4 => "xr_intro_2.wav",
            5 => (class_5.field_343 >> 10) >= 2 ? "xr_multi_2.wav" : "xr_multi_1.wav",
            6 => "xr_multi_off.wav",
            7 => "xr_menu.wav",
            8 => "xr_1_1.wav",
            9 => "xr_1_2.wav",
            10 => "xr_1_3.wav",
            11 => "xr_2_1.wav",
            12 => "xr_2_2.wav",
            13 => "xr_2_3.wav",
            14 => "xr_3_1.wav",
            15 => "xr_3_2.wav",
            16 => "xr_3_3.wav",
            17 => "xr_4_1.wav",
            18 => "xr_4_2.wav",
            19 => "xr_4_3.wav",
            _ => null
        };
    }

    private static AudioStreamWav LoadRemasterWavFile(string fileName, bool loop)
    {
        if (string.IsNullOrEmpty(fileName)) return null;
        if (_remasterWavCache.TryGetValue(fileName, out var cached))
        {
            cached.LoopMode = loop ? AudioStreamWav.LoopModeEnum.Forward : AudioStreamWav.LoopModeEnum.Disabled;
            return cached;
        }

        string fullPath = Path.Combine(JavaLang.ResourcesRoot, "RemasterAudio", fileName);
        if (!File.Exists(fullPath))
            return null;

        byte[] raw = File.ReadAllBytes(fullPath);
        if (CreateGodotAudioStream(raw, "audio/x-wav", loop) is AudioStreamWav wav)
        {
            _remasterWavCache[fileName] = wav;
            return wav;
        }
        return null;
    }

    private partial class VariantWrapper : RefCounted
    {
        public readonly Player Player;
        public VariantWrapper() { }
        public VariantWrapper(Player p) { Player = p; }
    }

    private void StartPlayerOnMainThread(VariantWrapper wrapper)
    {
        Player p = wrapper?.Player;
        if (p == null || p.State != 400 || p.RawBytes == null || p.RawBytes.Length == 0) return;

        bool loop = (p.LoopCount == -1) || (class_5.field_159 && class_5.field_276 == 11 && p.SoundId == 2);
        AudioStream targetStream = null;
        if (class_5.UseRemasterMode)
        {
            string remasterFile = GetRemasterWavFileName(p.SoundId);
            targetStream = LoadRemasterWavFile(remasterFile, loop);
        }
        targetStream ??= CreateGodotAudioStream(p.RawBytes, p.MimeType, loop);

        AudioStreamPlayer asp;
        lock (_audioPlayers)
        {
            if (!_audioPlayers.TryGetValue(p, out asp) || !IsInstanceValid(asp))
            {
                asp = new AudioStreamPlayer();
                AddChild(asp);
                _audioPlayers[p] = asp;
            }
            asp.Stream = targetStream;
        }

        if (asp.Stream is AudioStreamWav wav)
            wav.LoopMode = loop ? AudioStreamWav.LoopModeEnum.Forward : AudioStreamWav.LoopModeEnum.Disabled;

        float volDb = p.Volume <= 0 ? -80f : Mathf.LinearToDb(Mathf.Clamp(p.Volume / 100f, 0.001f, 1f));
        asp.VolumeDb = volDb;

        float startPosSec = 0f;
        if (p.SoundId >= 7 || p.SoundId == 2)
        {
            if (class_5.IsResumingFromPause && _pausedMusicSoundId == p.SoundId && _pausedMusicPositionSec > 0f)
            {
                double len = targetStream?.GetLength() ?? 0.0;
                startPosSec = (len > 0.1) ? (float)(_pausedMusicPositionSec % len) : 0f;
            }
            else
            {
                _pausedMusicSoundId = p.SoundId;
                _pausedMusicPositionSec = 0f;
            }
            class_5.IsResumingFromPause = false;
        }

        asp.Play(startPosSec);
    }

    private void StopPlayerOnMainThread(VariantWrapper wrapper)
    {
        Player p = wrapper?.Player;
        if (p == null) return;
        lock (_audioPlayers)
        {
            if (_audioPlayers.TryGetValue(p, out var asp) && IsInstanceValid(asp))
                asp.Stop();
        }
    }

    private void UpdatePlayerVolumeOnMainThread(VariantWrapper wrapper)
    {
        Player p = wrapper?.Player;
        if (p == null) return;
        lock (_audioPlayers)
        {
            if (_audioPlayers.TryGetValue(p, out var asp) && IsInstanceValid(asp))
                asp.VolumeDb = p.Volume <= 0 ? -80f : Mathf.LinearToDb(Mathf.Clamp(p.Volume / 100f, 0.001f, 1f));
        }
    }

    private static AudioStream CreateGodotAudioStream(byte[] raw, string mimeType, bool loop)
    {
        if (mimeType == "audio/midi" || (raw.Length >= 4 && raw[0] == 'M' && raw[1] == 'T' && raw[2] == 'h' && raw[3] == 'd'))
        {
            return SynthesizeMidiToWav(raw, loop);
        }

        int pos = 12;
        int channels = 1;
        int sampleRate = 8000;
        int bitsPerSample = 8;
        byte[] pcmData = Array.Empty<byte>();

        while (pos + 8 <= raw.Length)
        {
            string chunkId = Encoding.ASCII.GetString(raw, pos, 4);
            int chunkSize = BitConverter.ToInt32(raw, pos + 4);
            pos += 8;
            if (pos + chunkSize > raw.Length)
                chunkSize = raw.Length - pos;

            if (chunkId == "fmt " && chunkSize >= 16)
            {
                channels = BitConverter.ToInt16(raw, pos + 2);
                sampleRate = BitConverter.ToInt32(raw, pos + 4);
                bitsPerSample = BitConverter.ToInt16(raw, pos + 14);
            }
            else if (chunkId == "data")
            {
                pcmData = new byte[chunkSize];
                Buffer.BlockCopy(raw, pos, pcmData, 0, chunkSize);
                break;
            }
            pos += chunkSize + (chunkSize & 1);
        }

        if (bitsPerSample == 8)
        {
            for (int i = 0; i < pcmData.Length; i++)
                pcmData[i] = (byte)(pcmData[i] ^ 0x80);
        }

        return new AudioStreamWav
        {
            Format = bitsPerSample == 16 ? AudioStreamWav.FormatEnum.Format16Bits : AudioStreamWav.FormatEnum.Format8Bits,
            MixRate = sampleRate,
            Stereo = channels > 1,
            LoopMode = loop ? AudioStreamWav.LoopModeEnum.Forward : AudioStreamWav.LoopModeEnum.Disabled,
            LoopEnd = pcmData.Length / Math.Max(1, (bitsPerSample / 8) * channels),
            Data = pcmData
        };
    }

    // =========================================================================
    // Authentic Nokia S40/S60 Firmware SoundFont (nokialyd.sf2) Synthesizer
    // =========================================================================
    private static AudioStreamWav SynthesizeMidiToWav(byte[] midi, bool loop)
    {
        int hash = (midi.Length * 397) ^ (midi.Length > 20 ? BitConverter.ToInt32(midi, midi.Length - 8) : 0);
        if (_midiStreamCache.TryGetValue(hash, out var cached))
        {
            cached.LoopMode = loop ? AudioStreamWav.LoopModeEnum.Forward : AudioStreamWav.LoopModeEnum.Disabled;
            return cached;
        }

        const int sampleRate = 44100;
        try
        {
            if (_soundFont == null)
            {
                string sf2Path = Path.Combine(JavaLang.ResourcesRoot, "nokia_s40.sf2");
                _soundFont = new SoundFont(sf2Path);
            }

            var midiFile = new MidiFile(new MemoryStream(midi));
            var synth = new Synthesizer(_soundFont, sampleRate);
            var sequencer = new MidiFileSequencer(synth);
            sequencer.Play(midiFile, false);

            int totalSamples = Math.Max(sampleRate, (int)Math.Round(midiFile.Length.TotalSeconds * sampleRate));
            float[] left = new float[totalSamples];
            float[] right = new float[totalSamples];
            sequencer.Render(left, right);

            float peak = 0.01f;
            for (int i = 0; i < totalSamples; i++)
            {
                float al = MathF.Abs(left[i]);
                float ar = MathF.Abs(right[i]);
                if (al > peak) peak = al;
                if (ar > peak) peak = ar;
            }
            float gain = Math.Min(2.5f, 0.92f / peak);

            byte[] pcm = new byte[totalSamples * 4];
            int pIdx = 0;
            for (int i = 0; i < totalSamples; i++)
            {
                short l = (short)(Math.Clamp(left[i] * gain, -0.99f, 0.99f) * 32767f);
                short r = (short)(Math.Clamp(right[i] * gain, -0.99f, 0.99f) * 32767f);
                pcm[pIdx++] = (byte)(l & 0xFF);
                pcm[pIdx++] = (byte)((l >> 8) & 0xFF);
                pcm[pIdx++] = (byte)(r & 0xFF);
                pcm[pIdx++] = (byte)((r >> 8) & 0xFF);
            }

            var stream = new AudioStreamWav
            {
                Format = AudioStreamWav.FormatEnum.Format16Bits,
                MixRate = sampleRate,
                Stereo = true,
                LoopMode = loop ? AudioStreamWav.LoopModeEnum.Forward : AudioStreamWav.LoopModeEnum.Disabled,
                LoopEnd = totalSamples,
                Data = pcm
            };
            _midiStreamCache[hash] = stream;
            return stream;
        }
        catch (Exception ex)
        {
            GD.PrintErr("MIDI Synth error: " + ex.Message);
            return new AudioStreamWav();
        }
    }

    // =========================================================================
    // Keyboard & Gamepad Input Handling:
    // F1: Show/Hide Key Hints
    // F2 / Gamepad Back(Select): Smooth Toggle Remaster / Original (Screen + Audio)
    // F11: Unlock All Levels & Missions
    // F12: Full Reset
    // =========================================================================
    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventJoypadButton joyBtn)
        {
            HandleGamepadButton(joyBtn);
            return;
        }
        if (@event is InputEventJoypadMotion joyMotion)
        {
            HandleGamepadMotion(joyMotion);
            return;
        }

        if (@event is not InputEventKey keyEvent)
            return;

        Key key = keyEvent.Keycode;

        if (keyEvent.Pressed && !keyEvent.Echo)
        {
            if (key == Key.Enter && keyEvent.AltPressed)
            {
                int nextWinMode = class_5.WindowModeIndex == 2 ? 1 : 2;
                ApplyWindowMode(nextWinMode, save: true);
                return;
            }
            if (key == Key.F1)
            {
                _showControlsOverlay = !_showControlsOverlay;
                SavePersistentSettings();
                QueueRedraw();
                return;
            }
            if (key == Key.F2)
            {
                ToggleUnifiedMode();
                return;
            }
            if (key == Key.F11)
            {
                class_5.UnlockAllLevelsCheat();
                return;
            }
            if (key == Key.F12)
            {
                class_5.ResetAllProgress();
                return;
            }
        }

        if (_canvas == null)
            return;

        // Direct PC keyboard typing in High Score / Multiplayer Name Entry (class_5.field_225)
        if (class_5.field_225)
        {
            if (keyEvent.Pressed)
            {
                if ((key == Key.Enter || key == Key.KpEnter) && !keyEvent.Echo)
                {
                    class_5.field_232 = true;
                }
                else if (key == Key.Backspace || key == Key.Delete || key == Key.Escape)
                {
                    _clearDefaultNameOnFirstKey = false;
                    if (!string.IsNullOrEmpty(class_5.field_224))
                        class_5.field_224 = class_5.field_224.Substring(0, class_5.field_224.Length - 1);
                }
                else
                {
                    char ch = ResolveTypedChar(keyEvent);
                    if (ch != '\0')
                    {
                        if (_clearDefaultNameOnFirstKey)
                        {
                            class_5.field_224 = "";
                            _clearDefaultNameOnFirstKey = false;
                        }
                        int maxLen = class_5.field_226 > 0 ? Math.Max(8, class_5.field_226) : 8;
                        if ((class_5.field_224?.Length ?? 0) < maxLen)
                        {
                            if (string.IsNullOrEmpty(class_5.field_224) && char.IsLetter(ch))
                                ch = char.ToUpperInvariant(ch);
                            class_5.field_224 = (class_5.field_224 ?? "") + ch;
                        }
                    }
                }
            }
            return;
        }

        if (keyEvent.Echo)
            return;

        int j2meKey = MapKeyToJ2ME(key);
        if (j2meKey != int.MinValue)
        {
            if (keyEvent.Pressed)
                _canvas.keyPressed(j2meKey);
            else
                _canvas.keyReleased(j2meKey);
        }
    }

    private void HandleGamepadButton(InputEventJoypadButton joyBtn)
    {
        if (joyBtn.ButtonIndex == JoyButton.Back && joyBtn.Pressed)
        {
            ToggleUnifiedMode();
            return;
        }

        if (_canvas == null) return;

        if (class_5.field_225)
        {
            if (joyBtn.Pressed && (joyBtn.ButtonIndex == JoyButton.A || joyBtn.ButtonIndex == JoyButton.Start))
                class_5.field_232 = true;
            return;
        }

        int j2meKey = joyBtn.ButtonIndex switch
        {
            JoyButton.DpadUp or JoyButton.Y or JoyButton.RightShoulder => -1,
            JoyButton.DpadDown or JoyButton.LeftShoulder => -2,
            JoyButton.DpadLeft => -3,
            JoyButton.DpadRight => -4,
            JoyButton.A => IsInActiveRunning() ? -1 : -5,
            JoyButton.B => IsInActiveRunning() ? -2 : -7,
            JoyButton.X => -5,
            JoyButton.Start => -7,
            _ => int.MinValue
        };

        if (j2meKey != int.MinValue)
        {
            if (joyBtn.Pressed)
                _canvas.keyPressed(j2meKey);
            else
                _canvas.keyReleased(j2meKey);
        }
    }

    private void HandleGamepadMotion(InputEventJoypadMotion joyMotion)
    {
        if (_canvas == null || class_5.field_225) return;

        if (joyMotion.Axis == JoyAxis.LeftX)
        {
            bool leftNow = joyMotion.AxisValue < -StickDeadzone;
            bool rightNow = joyMotion.AxisValue > StickDeadzone;
            if (leftNow != _stickLeftPressed)
            {
                _stickLeftPressed = leftNow;
                if (leftNow) _canvas.keyPressed(-3);
                else _canvas.keyReleased(-3);
            }
            if (rightNow != _stickRightPressed)
            {
                _stickRightPressed = rightNow;
                if (rightNow) _canvas.keyPressed(-4);
                else _canvas.keyReleased(-4);
            }
        }
        else if (joyMotion.Axis == JoyAxis.LeftY)
        {
            bool upNow = joyMotion.AxisValue < -StickDeadzone;
            bool downNow = joyMotion.AxisValue > StickDeadzone;
            if (upNow != _stickUpPressed)
            {
                _stickUpPressed = upNow;
                if (upNow) _canvas.keyPressed(-1);
                else _canvas.keyReleased(-1);
            }
            if (downNow != _stickDownPressed)
            {
                _stickDownPressed = downNow;
                if (downNow) _canvas.keyPressed(-2);
                else _canvas.keyReleased(-2);
            }
        }
    }

    private static char ResolveTypedChar(InputEventKey keyEvent)
    {
        if (keyEvent.Unicode >= 32 && keyEvent.Unicode < 127)
            return (char)keyEvent.Unicode;

        Key k = keyEvent.Keycode;
        if (k >= Key.A && k <= Key.Z)
        {
            char baseChar = (char)('a' + (k - Key.A));
            return keyEvent.ShiftPressed ? char.ToUpperInvariant(baseChar) : baseChar;
        }
        if (k >= Key.Key0 && k <= Key.Key9)
            return (char)('0' + (k - Key.Key0));
        if (k >= Key.Kp0 && k <= Key.Kp9)
            return (char)('0' + (k - Key.Kp0));
        if (k == Key.Space)
            return ' ';
        if (k == Key.Minus || k == Key.KpSubtract)
            return keyEvent.ShiftPressed ? '_' : '-';

        return '\0';
    }

    private static bool IsInActiveRunning()
    {
        return class_5.field_159
            && class_5.field_276 == 5
            && (class_5.field_267 == -1 || class_5.field_122 < class_5.field_267);
    }

    private static int MapKeyToJ2ME(Key key)
    {
        if (key == Key.Space)
            return IsInActiveRunning() ? -1 : -5;

        return key switch
        {
            Key.Up or Key.W => -1,
            Key.Down or Key.S => -2,
            Key.Left or Key.A => -3,
            Key.Right or Key.D => -4,
            Key.Enter or Key.KpEnter => -5,
            Key.Escape => -7,
            _ => int.MinValue
        };
    }

    // =========================================================================
    // Main Loop (Fixed Native 33.3 FPS = 30 ms per step)
    // =========================================================================
    public override void _Process(double delta)
    {
        // Update smooth visual mode transition
        if (_visualTransitionTimer > 0f)
        {
            _visualTransitionTimer = MathF.Max(0f, _visualTransitionTimer - (float)delta);
            if (_visualTransitionTimer <= 0f)
                _transitionFromTexture = null;
        }

        // Update smooth audio crossfade on mode switch
        if (_audioCrossfadeTimer > 0f)
        {
            _audioCrossfadeTimer = MathF.Max(0f, _audioCrossfadeTimer - (float)delta);
            float t = 1f - (_audioCrossfadeTimer / AudioCrossfadeDuration);
            float targetLin = Mathf.DbToLinear(_audioFadeTargetDb);
            if (_fadingInAudioPlayer != null && IsInstanceValid(_fadingInAudioPlayer))
            {
                float inLin = Mathf.Max(0.0001f, targetLin * t);
                _fadingInAudioPlayer.VolumeDb = Mathf.LinearToDb(inLin);
            }
            if (_fadingOutAudioPlayer != null && IsInstanceValid(_fadingOutAudioPlayer))
            {
                float outLin = Mathf.Max(0.0001f, targetLin * (1f - t));
                _fadingOutAudioPlayer.VolumeDb = Mathf.LinearToDb(outLin);
                if (_audioCrossfadeTimer <= 0f)
                {
                    _fadingOutAudioPlayer.Stop();
                    _fadingOutAudioPlayer.QueueFree();
                    _fadingOutAudioPlayer = null;
                    _fadingInAudioPlayer = null;
                }
            }
        }

        if (_canvas != null && class_5.field_164 == null)
        {
            SavePersistentSettings();
            GetTree().Quit();
            return;
        }

        if (_canvas != null)
        {
            _tickAccumulator += Math.Min(delta, 0.1);

            int maxTicks = 4;
            while (_tickAccumulator >= NativeTickInterval && maxTicks-- > 0)
            {
                _tickAccumulator -= NativeTickInterval;
                _canvas.StepOneTick(NativeDeltaMs);
            }

            if (class_5.field_225 && !_wasInNameEntry)
            {
                _clearDefaultNameOnFirstKey = true;
            }
            _wasInNameEntry = class_5.field_225;
        }

        UpdateFramebufferTexture();
        QueueRedraw();
    }

    private void UpdateFramebufferTexture()
    {
        if (_canvas?.Framebuffer == null) return;

        lock (_canvas.RenderLock)
        {
            var fb = _canvas.Framebuffer;
            int w = fb.PhysicalWidth;
            int h = fb.PhysicalHeight;
            int byteLen = w * h * 4;
            if (_rgbaBytes == null || _rgbaBytes.Length != byteLen)
                _rgbaBytes = new byte[byteLen];

            uint[] src = fb.Pixels;
            int bIdx = 0;
            for (int i = 0; i < src.Length; i++)
            {
                uint c = src[i];
                _rgbaBytes[bIdx++] = (byte)((c >> 16) & 0xFF);
                _rgbaBytes[bIdx++] = (byte)((c >> 8) & 0xFF);
                _rgbaBytes[bIdx++] = (byte)(c & 0xFF);
                _rgbaBytes[bIdx++] = (byte)((c >> 24) & 0xFF);
            }

            if (_godotImg == null || _godotImg.GetWidth() != w || _godotImg.GetHeight() != h)
            {
                _godotImg = Godot.Image.CreateFromData(w, h, false, Godot.Image.Format.Rgba8, _rgbaBytes);
                _texture = ImageTexture.CreateFromImage(_godotImg);
            }
            else
            {
                _godotImg.SetData(w, h, false, Godot.Image.Format.Rgba8, _rgbaBytes);
                _texture.Update(_godotImg);
            }
        }
    }

    private Rect2 ComputeDrawRect(float texW, float texH)
    {
        Vector2 vpSize = GetViewportRect().Size;
        int hudHeight = _showControlsOverlay ? 30 : 0;
        float availW = vpSize.X;
        float availH = Math.Max(100, vpSize.Y - hudHeight);

        float scale = Math.Min(availW / texW, availH / texH);
        float drawW = texW * scale;
        float drawH = texH * scale;
        float drawX = (availW - drawW) * 0.5f;
        float drawY = (availH - drawH) * 0.5f;
        return new Rect2(drawX, drawY, drawW, drawH);
    }

    public override void _Draw()
    {
        Vector2 vpSize = GetViewportRect().Size;
        DrawRect(new Rect2(Vector2.Zero, vpSize), new Color(0.05f, 0.05f, 0.07f, 1f));

        if (_texture == null)
            return;

        int hudHeight = _showControlsOverlay ? 30 : 0;
        Rect2 targetRect = ComputeDrawRect(_texture.GetWidth(), _texture.GetHeight());

        if (_visualTransitionTimer > 0f && _transitionFromTexture != null)
        {
            float t = 1f - (_visualTransitionTimer / VisualTransitionDuration);
            float smoothT = t * t * (3f - 2f * t);
            Rect2 interpRect = new Rect2(
                _transitionFromRect.Position.Lerp(targetRect.Position, smoothT),
                _transitionFromRect.Size.Lerp(targetRect.Size, smoothT)
            );
            DrawTextureRect(_texture, interpRect, false);
            DrawTextureRect(_transitionFromTexture, interpRect, false, new Color(1f, 1f, 1f, 1f - smoothT));
        }
        else
        {
            DrawTextureRect(_texture, targetRect, false);
        }

        var font = ThemeDB.FallbackFont;
        if (_showControlsOverlay && font != null)
        {
            Rect2 barRect = new Rect2(0, vpSize.Y - hudHeight, vpSize.X, hudHeight);
            DrawRect(barRect, new Color(0f, 0f, 0f, 0.88f));
            DrawLine(new Vector2(0, barRect.Position.Y), new Vector2(vpSize.X, barRect.Position.Y), new Color(0.35f, 0.35f, 0.4f), 1f);

            string barText = Localization.GetF1OverlayBarText(class_5.CurrentLanguageIndex);
            DrawString(font, new Vector2(14, vpSize.Y - 10), barText, HorizontalAlignment.Center, vpSize.X - 28, 13, new Color(0.85f, 0.9f, 0.95f));
        }
    }
}
