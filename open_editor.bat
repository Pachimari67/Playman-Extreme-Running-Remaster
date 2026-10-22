@echo off
cd /d "%~dp0"
if exist "%USERPROFILE%\.dotnet\dotnet.exe" (
    set "DOTNET_ROOT=%USERPROFILE%\.dotnet"
    set "PATH=%USERPROFILE%\.dotnet;%PATH%"
)

set "GODOT_EXE="
if defined GODOT_BIN if exist "%GODOT_BIN%" set "GODOT_EXE=%GODOT_BIN%"
if not defined GODOT_EXE if exist "Godot_v4.3-stable_mono_win64.exe" set "GODOT_EXE=Godot_v4.3-stable_mono_win64.exe"
if not defined GODOT_EXE if exist "C:\Users\ARC\Downloads\Gish\Godot_v4.3-stable_mono_win64\Godot_v4.3-stable_mono_win64.exe" set "GODOT_EXE=C:\Users\ARC\Downloads\Gish\Godot_v4.3-stable_mono_win64\Godot_v4.3-stable_mono_win64.exe"
if not defined GODOT_EXE set "GODOT_EXE=godot"

echo Opening Playman Extreme Running Remaster in Godot 4.3 Mono Editor...
start "" "%GODOT_EXE%" --editor --path .
