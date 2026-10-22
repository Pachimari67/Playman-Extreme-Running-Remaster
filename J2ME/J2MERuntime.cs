using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using Godot;

namespace PlaymanExtremeRunning.J2ME
{
    public static class JavaLang
    {
        public static string ProjectRoot = "";
        public static string ResourcesRoot = "";
        public static string SaveRoot = "";

        public static void InitPaths()
        {
            if (!string.IsNullOrEmpty(ResourcesRoot) && Directory.Exists(ResourcesRoot))
                return;

            string baseDir = ProjectSettings.GlobalizePath("res://");
            if (string.IsNullOrEmpty(baseDir) || !Directory.Exists(baseDir))
                baseDir = AppDomain.CurrentDomain.BaseDirectory;

            ProjectRoot = baseDir;
            ResourcesRoot = Path.Combine(baseDir, "Resources");
            SaveRoot = Path.Combine(baseDir, "SaveData");
            Directory.CreateDirectory(SaveRoot);
        }

        public static long CurrentTimeMillis()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }

        public static void Gc()
        {
        }

        public static string GetProperty(string key)
        {
            if (key == "microedition.platform") return "GodotMono-PC";
            if (key == "microedition.locale") return "en-US";
            if (key == "microedition.encoding") return "UTF-8";
            return null;
        }

        public static void ArrayCopy(Array src, int srcPos, Array dest, int destPos, int length)
        {
            if (src != null && dest != null && length > 0)
                Array.Copy(src, srcPos, dest, destPos, length);
        }

        public static T[][] NewArray2D<T>(int d1, int d2)
        {
            T[][] arr = new T[d1][];
            for (int i = 0; i < d1; i++)
                arr[i] = new T[d2];
            return arr;
        }
    }

    public static class JavaExtensions
    {
        public static int length(this string s) => s.Length;
        public static char charAt(this string s, int i) => s[i];
        public static int compareTo(this string s, string other) => string.CompareOrdinal(s, other);
        public static bool equalsIgnoreCase(this string s, string other) => string.Equals(s, other, StringComparison.OrdinalIgnoreCase);
        public static bool startsWith(this string s, string prefix) => s.StartsWith(prefix, StringComparison.Ordinal);
        public static bool endsWith(this string s, string suffix) => s.EndsWith(suffix, StringComparison.Ordinal);
        public static int indexOf(this string s, int ch) => s.IndexOf((char)ch);
        public static int indexOf(this string s, char ch) => s.IndexOf(ch);
        public static int indexOf(this string s, string sub) => s.IndexOf(sub, StringComparison.Ordinal);
        public static int indexOf(this string s, int ch, int fromIndex) => s.IndexOf((char)ch, fromIndex);
        public static int indexOf(this string s, string sub, int fromIndex) => s.IndexOf(sub, fromIndex, StringComparison.Ordinal);
        public static int lastIndexOf(this string s, int ch) => s.LastIndexOf((char)ch);
        public static int lastIndexOf(this string s, char ch) => s.LastIndexOf(ch);
        public static string substring(this string s, int beginIndex) => s.Substring(beginIndex);
        public static string substring(this string s, int beginIndex, int endIndex) => s.Substring(beginIndex, endIndex - beginIndex);
        public static string trim(this string s) => s.Trim();
        public static string toLowerCase(this string s) => s.ToLowerInvariant();
        public static string replace(this string s, char oldChar, char newChar) => s.Replace(oldChar, newChar);
        public static string intern(this string s) => string.Intern(s);

        public static sbyte[] getBytes(this string s)
        {
            byte[] b = Encoding.UTF8.GetBytes(s);
            return (sbyte[])(Array)b;
        }

        public static bool equals(this object a, object b) => Equals(a, b);
        public static string toString(this object a) => a?.ToString() ?? "null";
        public static Class getClass(this object a) => new Class(a?.GetType().Name ?? "Object");
        public static string getMessage(this Exception e) => e.Message;
        public static void printStackTrace(this Exception e) { }
    }

    public class InterruptedException : Exception
    {
        public InterruptedException(string msg = "") : base(msg) { }
    }

    public class Class
    {
        public string Name;
        public Class(string name) { Name = name; }

        public InputStream getResourceAsStream(string path)
        {
            JavaLang.InitPaths();
            if (string.IsNullOrEmpty(path)) return null;
            string rel = path.TrimStart('/', '\\').Replace('/', Path.DirectorySeparatorChar);
            string full = Path.Combine(JavaLang.ResourcesRoot, rel);
            if (!File.Exists(full))
                return null;
            byte[] bytes = File.ReadAllBytes(full);
            return new ByteArrayInputStream((sbyte[])(Array)bytes);
        }
    }

    public class Integer
    {
        public const int MIN_VALUE = int.MinValue;
        public const int MAX_VALUE = int.MaxValue;
        public int Value;
        public Integer(int v) { Value = v; }
        public int intValue() => Value;
        public static implicit operator int(Integer i) => i.Value;
        public static int parseInt(string s) => int.Parse(s.Trim());
        public override string ToString() => Value.ToString();
        public override bool Equals(object obj) => obj is Integer other && other.Value == Value;
        public override int GetHashCode() => Value.GetHashCode();
    }

    public interface Runnable
    {
        void run();
    }

    public class JavaThread
    {
        private readonly Thread _thread;
        public JavaThread(Runnable target)
        {
            _thread = new Thread(() =>
            {
                try { target.run(); }
                catch (Exception) { }
            });
            _thread.IsBackground = true;
        }

        public void start()
        {
            // Driven deterministically by Godot's _Process loop
        }

        public void setPriority(int p) { }
        public bool isAlive() => false;
        public static void sleep(long ms)
        {
            if (ms > 0) Thread.Sleep((int)Math.Min(ms, 10));
        }
        public static void yield() { }
    }

    public interface Enumeration
    {
        bool hasMoreElements();
        object nextElement();
    }

    internal class ListEnumeration : Enumeration
    {
        private readonly List<object> _items;
        private int _idx = 0;
        public ListEnumeration(List<object> items) { _items = items; }
        public bool hasMoreElements() => _idx < _items.Count;
        public object nextElement() => _items[_idx++];
    }

    public class Hashtable
    {
        private readonly Dictionary<object, object> _dict = new Dictionary<object, object>();
        public Hashtable() { }
        public Hashtable(int cap) { }

        public object put(object k, object v)
        {
            lock (_dict)
            {
                _dict.TryGetValue(k, out object prev);
                _dict[k] = v;
                return prev;
            }
        }
        public object get(object k)
        {
            lock (_dict)
                return _dict.TryGetValue(k, out object v) ? v : null;
        }
        public object remove(object k)
        {
            lock (_dict)
            {
                if (_dict.TryGetValue(k, out object v))
                {
                    _dict.Remove(k);
                    return v;
                }
                return null;
            }
        }
        public bool containsKey(object k) { lock (_dict) return _dict.ContainsKey(k); }
        public int size() { lock (_dict) return _dict.Count; }
        public Enumeration keys() { lock (_dict) return new ListEnumeration(new List<object>(_dict.Keys)); }
        public Enumeration elements() { lock (_dict) return new ListEnumeration(new List<object>(_dict.Values)); }
    }

    public class JavaRandom
    {
        private long _seed;
        public JavaRandom() : this(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()) { }
        public JavaRandom(long seed)
        {
            _seed = (seed ^ 0x5DEECE66DL) & ((1L << 48) - 1);
        }
        protected int next(int bits)
        {
            _seed = (_seed * 0x5DEECE66DL + 0xBL) & ((1L << 48) - 1);
            return (int)((ulong)_seed >> (48 - bits));
        }
        public int nextInt() => next(32);
    }

    public abstract class InputStream : IDisposable
    {
        public abstract int read();
        public virtual int read(sbyte[] b) => read(b, 0, b.Length);
        public virtual int read(sbyte[] b, int off, int len)
        {
            if (len == 0) return 0;
            int c = read();
            if (c == -1) return -1;
            b[off] = (sbyte)c;
            int i = 1;
            for (; i < len; i++)
            {
                c = read();
                if (c == -1) break;
                b[off + i] = (sbyte)c;
            }
            return i;
        }
        public virtual long skip(long n)
        {
            long skipped = 0;
            while (skipped < n && read() != -1)
                skipped++;
            return skipped;
        }
        public virtual int available() => 0;
        public virtual void close() { }
        public virtual void reset() { }
        public void Dispose() => close();
    }

    public abstract class OutputStream : IDisposable
    {
        public abstract void write(int b);
        public virtual void write(sbyte[] b) => write(b, 0, b.Length);
        public virtual void write(sbyte[] b, int off, int len)
        {
            for (int i = 0; i < len; i++)
                write(b[off + i]);
        }
        public virtual void flush() { }
        public virtual void close() { }
        public void Dispose() => close();
    }

    public class ByteArrayInputStream : InputStream
    {
        private readonly sbyte[] _buf;
        private int _pos;
        private readonly int _mark;
        private readonly int _count;

        public ByteArrayInputStream(sbyte[] buf)
        {
            _buf = buf ?? Array.Empty<sbyte>();
            _pos = 0;
            _mark = 0;
            _count = _buf.Length;
        }

        public ByteArrayInputStream(sbyte[] buf, int offset, int length)
        {
            _buf = buf ?? Array.Empty<sbyte>();
            _pos = offset;
            _mark = offset;
            _count = Math.Min(offset + length, _buf.Length);
        }

        public override int read()
        {
            return (_pos < _count) ? (_buf[_pos++] & 0xFF) : -1;
        }

        public override int read(sbyte[] b, int off, int len)
        {
            if (_pos >= _count) return -1;
            int avail = _count - _pos;
            if (len > avail) len = avail;
            if (len <= 0) return 0;
            Array.Copy(_buf, _pos, b, off, len);
            _pos += len;
            return len;
        }

        public override long skip(long n)
        {
            int avail = _count - _pos;
            long k = Math.Min(n, Math.Max(0, avail));
            _pos += (int)k;
            return k;
        }

        public override int available() => Math.Max(0, _count - _pos);
        public override void reset() => _pos = _mark;
    }

    public class ByteArrayOutputStream : OutputStream
    {
        private readonly MemoryStream _ms = new MemoryStream();
        public override void write(int b) => _ms.WriteByte((byte)(b & 0xFF));
        public override void write(sbyte[] b, int off, int len)
        {
            byte[] u = (byte[])(Array)b;
            _ms.Write(u, off, len);
        }
        public sbyte[] toByteArray()
        {
            byte[] u = _ms.ToArray();
            return (sbyte[])(Array)u;
        }
        public void reset() => _ms.SetLength(0);
        public int size() => (int)_ms.Length;
    }

    public class DataInputStream : InputStream
    {
        private readonly InputStream _in;
        public DataInputStream(InputStream @in) { _in = @in; }

        public override int read() => _in.read();
        public override int read(sbyte[] b) => _in.read(b, 0, b.Length);
        public override int read(sbyte[] b, int off, int len) => _in.read(b, off, len);
        public override long skip(long n) => _in.skip(n);
        public override int available() => _in.available();
        public override void close() => _in.close();

        public void readFully(sbyte[] b) => readFully(b, 0, b.Length);
        public void readFully(sbyte[] b, int off, int len)
        {
            int n = 0;
            while (n < len)
            {
                int count = _in.read(b, off + n, len - n);
                if (count < 0) throw new EndOfStreamException();
                n += count;
            }
        }

        public bool readBoolean()
        {
            int ch = _in.read();
            if (ch < 0) throw new EndOfStreamException();
            return ch != 0;
        }

        public sbyte readByte()
        {
            int ch = _in.read();
            if (ch < 0) throw new EndOfStreamException();
            return (sbyte)ch;
        }

        public int readUnsignedByte()
        {
            int ch = _in.read();
            if (ch < 0) throw new EndOfStreamException();
            return ch;
        }

        public short readShort()
        {
            int ch1 = _in.read();
            int ch2 = _in.read();
            if ((ch1 | ch2) < 0) throw new EndOfStreamException();
            return (short)((ch1 << 8) + ch2);
        }

        public int readUnsignedShort()
        {
            int ch1 = _in.read();
            int ch2 = _in.read();
            if ((ch1 | ch2) < 0) throw new EndOfStreamException();
            return (ch1 << 8) + ch2;
        }

        public int readInt()
        {
            int ch1 = _in.read();
            int ch2 = _in.read();
            int ch3 = _in.read();
            int ch4 = _in.read();
            if ((ch1 | ch2 | ch3 | ch4) < 0) throw new EndOfStreamException();
            return (ch1 << 24) + (ch2 << 16) + (ch3 << 8) + ch4;
        }

        public string readUTF()
        {
            int utflen = readUnsignedShort();
            sbyte[] bytearr = new sbyte[utflen];
            readFully(bytearr, 0, utflen);
            return Encoding.UTF8.GetString((byte[])(Array)bytearr);
        }
    }

    public class DataOutputStream : OutputStream
    {
        private readonly OutputStream _out;
        public DataOutputStream(OutputStream @out) { _out = @out; }

        public override void write(int b) => _out.write(b);
        public override void write(sbyte[] b) => _out.write(b, 0, b.Length);
        public override void write(sbyte[] b, int off, int len) => _out.write(b, off, len);
        public override void flush() => _out.flush();
        public override void close() => _out.close();

        public void writeBoolean(bool v) => _out.write(v ? 1 : 0);
        public void writeByte(int v) => _out.write(v & 0xFF);
        public void writeShort(int v)
        {
            _out.write((v >>> 8) & 0xFF);
            _out.write(v & 0xFF);
        }
        public void writeInt(int v)
        {
            _out.write((v >>> 24) & 0xFF);
            _out.write((v >>> 16) & 0xFF);
            _out.write((v >>> 8) & 0xFF);
            _out.write(v & 0xFF);
        }
        public void writeUTF(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str ?? "");
            writeShort(bytes.Length);
            _out.write((sbyte[])(Array)bytes, 0, bytes.Length);
        }
    }

    // =========================================================================
    // Crisp Proportional Bitmap Font for J2ME (Small=11px, Medium=13px, Large=15px)
    // =========================================================================
    public class Font
    {
        public readonly int Face;
        public readonly int Style;
        public readonly int Size;
        private readonly int _height;
        private readonly bool _bold;

        public Font(int face = 0, int style = 0, int size = 8)
        {
            Face = face;
            Style = style;
            Size = size;
            _bold = (style & 1) != 0 && size != 8; // Medium/Large bold get 1px extra weight
            _height = size == 16 ? 15 : (size == 0 ? 13 : 11);
        }

        public static Font getFont(int face, int style, int size) => new Font(face, style, size);
        public int getHeight() => _height;

        public int charWidth(char c)
        {
            GetGlyph(c, out int adv, out _);
            return adv + (_bold ? 1 : 0);
        }

        public int stringWidth(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int w = 0;
            for (int i = 0; i < s.Length; i++)
                w += charWidth(s[i]);
            return w;
        }

        public bool IsBold => _bold;

        // 5x7 bitmap font (each byte in rows[0..6] has bits 4..0 for columns 0..4)
        public static void GetGlyph(char ch, out int advance, out byte[] rows)
        {
            char c = ch switch
            {
                'é' or 'è' or 'ê' or 'ë' or 'ì' or 'î' or 'ï' => ch is 'ì' or 'î' or 'ï' ? 'i' : 'e',
                'ä' or 'à' or 'á' or 'â' or 'å' or 'ã' => 'a',
                'ö' or 'ò' or 'ó' or 'ô' or 'õ' => 'o',
                'ü' or 'ù' or 'ú' or 'û' => 'u',
                'í' => 'i',
                'ñ' => 'n',
                'ç' => 'c',
                'ß' => 's',
                'Ä' or 'Å' or 'À' or 'Á' or 'Â' => 'A',
                'É' or 'È' or 'Ê' or 'Ë' => 'E',
                'Í' or 'Ì' or 'Î' or 'Ï' => 'I',
                'Ñ' => 'N',
                'Ö' or 'Ò' or 'Ó' or 'Ô' => 'O',
                'Ü' or 'Ù' or 'Ú' or 'Û' => 'U',
                'Ç' => 'C',
                'ё' => 'е',
                'Ё' => 'Е',
                '«' or '»' => '"',
                '—' or '–' => '-',
                '\ufffd' or '©' => '@',
                _ => ch
            };

            if (Glyphs.TryGetValue(c, out var g))
            {
                advance = g.Adv;
                rows = g.Rows;
                return;
            }

            advance = 6;
            rows = DefaultGlyph;
        }

        private static readonly byte[] DefaultGlyph = { 0x1F, 0x11, 0x11, 0x11, 0x11, 0x1F, 0x00 };

        private static readonly Dictionary<char, (int Adv, byte[] Rows)> Glyphs = new Dictionary<char, (int, byte[])>
        {
            [' '] = (3, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            ['!'] = (2, new byte[] { 0x10, 0x10, 0x10, 0x10, 0x00, 0x10, 0x00 }),
            ['"'] = (4, new byte[] { 0x14, 0x14, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            ['#'] = (6, new byte[] { 0x0A, 0x1F, 0x0A, 0x1F, 0x0A, 0x00, 0x00 }),
            ['$'] = (6, new byte[] { 0x04, 0x0F, 0x14, 0x0E, 0x05, 0x1E, 0x04 }),
            ['%'] = (6, new byte[] { 0x18, 0x19, 0x02, 0x04, 0x08, 0x13, 0x03 }),
            ['&'] = (6, new byte[] { 0x0C, 0x12, 0x14, 0x08, 0x15, 0x12, 0x0D }),
            ['\''] = (2, new byte[] { 0x10, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            ['('] = (3, new byte[] { 0x08, 0x10, 0x10, 0x10, 0x10, 0x08, 0x00 }),
            [')'] = (3, new byte[] { 0x10, 0x08, 0x08, 0x08, 0x08, 0x10, 0x00 }),
            ['*'] = (6, new byte[] { 0x00, 0x04, 0x15, 0x0E, 0x15, 0x04, 0x00 }),
            ['+'] = (6, new byte[] { 0x00, 0x04, 0x04, 0x1F, 0x04, 0x04, 0x00 }),
            [','] = (3, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x08, 0x08, 0x10 }),
            ['-'] = (4, new byte[] { 0x00, 0x00, 0x00, 0x1C, 0x00, 0x00, 0x00 }),
            ['.'] = (2, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x10, 0x00 }),
            ['/'] = (5, new byte[] { 0x01, 0x02, 0x04, 0x04, 0x08, 0x10, 0x00 }),
            ['0'] = (6, new byte[] { 0x0E, 0x11, 0x13, 0x15, 0x19, 0x0E, 0x00 }),
            ['1'] = (4, new byte[] { 0x08, 0x18, 0x08, 0x08, 0x08, 0x1C, 0x00 }),
            ['2'] = (6, new byte[] { 0x0E, 0x11, 0x01, 0x06, 0x08, 0x1F, 0x00 }),
            ['3'] = (6, new byte[] { 0x1F, 0x02, 0x06, 0x01, 0x11, 0x0E, 0x00 }),
            ['4'] = (6, new byte[] { 0x02, 0x06, 0x0A, 0x12, 0x1F, 0x02, 0x00 }),
            ['5'] = (6, new byte[] { 0x1F, 0x10, 0x1E, 0x01, 0x11, 0x0E, 0x00 }),
            ['6'] = (6, new byte[] { 0x06, 0x08, 0x1E, 0x11, 0x11, 0x0E, 0x00 }),
            ['7'] = (6, new byte[] { 0x1F, 0x01, 0x02, 0x04, 0x08, 0x08, 0x00 }),
            ['8'] = (6, new byte[] { 0x0E, 0x11, 0x0E, 0x11, 0x11, 0x0E, 0x00 }),
            ['9'] = (6, new byte[] { 0x0E, 0x11, 0x11, 0x0F, 0x01, 0x0E, 0x00 }),
            [':'] = (2, new byte[] { 0x00, 0x10, 0x00, 0x00, 0x10, 0x00, 0x00 }),
            [';'] = (3, new byte[] { 0x00, 0x08, 0x00, 0x00, 0x08, 0x08, 0x10 }),
            ['<'] = (4, new byte[] { 0x04, 0x08, 0x10, 0x08, 0x04, 0x00, 0x00 }),
            ['='] = (4, new byte[] { 0x00, 0x1C, 0x00, 0x1C, 0x00, 0x00, 0x00 }),
            ['>'] = (4, new byte[] { 0x10, 0x08, 0x04, 0x08, 0x10, 0x00, 0x00 }),
            ['?'] = (6, new byte[] { 0x0E, 0x11, 0x02, 0x04, 0x00, 0x04, 0x00 }),
            ['@'] = (6, new byte[] { 0x0E, 0x11, 0x17, 0x15, 0x17, 0x10, 0x0E }),
            ['A'] = (6, new byte[] { 0x0E, 0x11, 0x11, 0x1F, 0x11, 0x11, 0x00 }),
            ['B'] = (6, new byte[] { 0x1E, 0x11, 0x1E, 0x11, 0x11, 0x1E, 0x00 }),
            ['C'] = (6, new byte[] { 0x0E, 0x11, 0x10, 0x10, 0x11, 0x0E, 0x00 }),
            ['D'] = (6, new byte[] { 0x1E, 0x11, 0x11, 0x11, 0x11, 0x1E, 0x00 }),
            ['E'] = (6, new byte[] { 0x1F, 0x10, 0x1E, 0x10, 0x10, 0x1F, 0x00 }),
            ['F'] = (6, new byte[] { 0x1F, 0x10, 0x1E, 0x10, 0x10, 0x10, 0x00 }),
            ['G'] = (6, new byte[] { 0x0E, 0x11, 0x10, 0x17, 0x11, 0x0F, 0x00 }),
            ['H'] = (6, new byte[] { 0x11, 0x11, 0x1F, 0x11, 0x11, 0x11, 0x00 }),
            ['I'] = (4, new byte[] { 0x1C, 0x08, 0x08, 0x08, 0x08, 0x1C, 0x00 }),
            ['J'] = (6, new byte[] { 0x07, 0x02, 0x02, 0x02, 0x12, 0x0C, 0x00 }),
            ['K'] = (6, new byte[] { 0x11, 0x12, 0x1C, 0x12, 0x11, 0x11, 0x00 }),
            ['L'] = (6, new byte[] { 0x10, 0x10, 0x10, 0x10, 0x10, 0x1F, 0x00 }),
            ['M'] = (6, new byte[] { 0x11, 0x1B, 0x15, 0x15, 0x11, 0x11, 0x00 }),
            ['N'] = (6, new byte[] { 0x11, 0x19, 0x15, 0x13, 0x11, 0x11, 0x00 }),
            ['O'] = (6, new byte[] { 0x0E, 0x11, 0x11, 0x11, 0x11, 0x0E, 0x00 }),
            ['P'] = (6, new byte[] { 0x1E, 0x11, 0x11, 0x1E, 0x10, 0x10, 0x00 }),
            ['Q'] = (6, new byte[] { 0x0E, 0x11, 0x11, 0x15, 0x12, 0x0D, 0x00 }),
            ['R'] = (6, new byte[] { 0x1E, 0x11, 0x11, 0x1E, 0x12, 0x11, 0x00 }),
            ['S'] = (6, new byte[] { 0x0F, 0x10, 0x0E, 0x01, 0x01, 0x1E, 0x00 }),
            ['T'] = (6, new byte[] { 0x1F, 0x04, 0x04, 0x04, 0x04, 0x04, 0x00 }),
            ['U'] = (6, new byte[] { 0x11, 0x11, 0x11, 0x11, 0x11, 0x0E, 0x00 }),
            ['V'] = (6, new byte[] { 0x11, 0x11, 0x11, 0x11, 0x0A, 0x04, 0x00 }),
            ['W'] = (6, new byte[] { 0x11, 0x11, 0x15, 0x15, 0x1B, 0x11, 0x00 }),
            ['X'] = (6, new byte[] { 0x11, 0x0A, 0x04, 0x04, 0x0A, 0x11, 0x00 }),
            ['Y'] = (6, new byte[] { 0x11, 0x0A, 0x04, 0x04, 0x04, 0x04, 0x00 }),
            ['Z'] = (6, new byte[] { 0x1F, 0x02, 0x04, 0x08, 0x10, 0x1F, 0x00 }),
            ['_'] = (6, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x1F, 0x00 }),
            ['a'] = (6, new byte[] { 0x00, 0x0E, 0x01, 0x0F, 0x11, 0x0F, 0x00 }),
            ['b'] = (6, new byte[] { 0x10, 0x1E, 0x11, 0x11, 0x11, 0x1E, 0x00 }),
            ['c'] = (5, new byte[] { 0x00, 0x0E, 0x10, 0x10, 0x10, 0x0E, 0x00 }),
            ['d'] = (6, new byte[] { 0x01, 0x0F, 0x11, 0x11, 0x11, 0x0F, 0x00 }),
            ['e'] = (6, new byte[] { 0x00, 0x0E, 0x11, 0x1F, 0x10, 0x0F, 0x00 }),
            ['f'] = (5, new byte[] { 0x06, 0x08, 0x1E, 0x08, 0x08, 0x08, 0x00 }),
            ['g'] = (6, new byte[] { 0x00, 0x0F, 0x11, 0x11, 0x0F, 0x01, 0x0E }),
            ['h'] = (6, new byte[] { 0x10, 0x1E, 0x11, 0x11, 0x11, 0x11, 0x00 }),
            ['i'] = (2, new byte[] { 0x10, 0x00, 0x10, 0x10, 0x10, 0x10, 0x00 }),
            ['j'] = (4, new byte[] { 0x04, 0x00, 0x04, 0x04, 0x04, 0x14, 0x08 }),
            ['k'] = (5, new byte[] { 0x10, 0x12, 0x14, 0x18, 0x14, 0x12, 0x00 }),
            ['l'] = (2, new byte[] { 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x00 }),
            ['m'] = (6, new byte[] { 0x00, 0x1A, 0x15, 0x15, 0x11, 0x11, 0x00 }),
            ['n'] = (6, new byte[] { 0x00, 0x1E, 0x11, 0x11, 0x11, 0x11, 0x00 }),
            ['o'] = (6, new byte[] { 0x00, 0x0E, 0x11, 0x11, 0x11, 0x0E, 0x00 }),
            ['p'] = (6, new byte[] { 0x00, 0x1E, 0x11, 0x11, 0x1E, 0x10, 0x10 }),
            ['q'] = (6, new byte[] { 0x00, 0x0F, 0x11, 0x11, 0x0F, 0x01, 0x01 }),
            ['r'] = (5, new byte[] { 0x00, 0x16, 0x18, 0x10, 0x10, 0x10, 0x00 }),
            ['s'] = (5, new byte[] { 0x00, 0x0F, 0x10, 0x0E, 0x01, 0x1E, 0x00 }),
            ['t'] = (5, new byte[] { 0x08, 0x1C, 0x08, 0x08, 0x08, 0x06, 0x00 }),
            ['u'] = (6, new byte[] { 0x00, 0x11, 0x11, 0x11, 0x11, 0x0F, 0x00 }),
            ['v'] = (6, new byte[] { 0x00, 0x11, 0x11, 0x11, 0x0A, 0x04, 0x00 }),
            ['w'] = (6, new byte[] { 0x00, 0x11, 0x11, 0x15, 0x15, 0x0A, 0x00 }),
            ['x'] = (5, new byte[] { 0x00, 0x12, 0x0C, 0x0C, 0x12, 0x12, 0x00 }),
            ['y'] = (6, new byte[] { 0x00, 0x11, 0x11, 0x11, 0x0F, 0x01, 0x0E }),
            ['z'] = (5, new byte[] { 0x00, 0x1E, 0x02, 0x04, 0x08, 0x1E, 0x00 }),
            // Cyrillic uppercase (А..Я)
            ['А'] = (6, new byte[] { 0x0E, 0x11, 0x11, 0x1F, 0x11, 0x11, 0x00 }),
            ['Б'] = (6, new byte[] { 0x1F, 0x10, 0x1E, 0x11, 0x11, 0x1E, 0x00 }),
            ['В'] = (6, new byte[] { 0x1E, 0x11, 0x1E, 0x11, 0x11, 0x1E, 0x00 }),
            ['Г'] = (5, new byte[] { 0x1E, 0x10, 0x10, 0x10, 0x10, 0x10, 0x00 }),
            ['Д'] = (6, new byte[] { 0x0E, 0x12, 0x12, 0x12, 0x1F, 0x11, 0x00 }),
            ['Е'] = (6, new byte[] { 0x1F, 0x10, 0x1E, 0x10, 0x10, 0x1F, 0x00 }),
            ['Ж'] = (6, new byte[] { 0x15, 0x15, 0x0E, 0x15, 0x15, 0x15, 0x00 }),
            ['З'] = (6, new byte[] { 0x0E, 0x11, 0x06, 0x01, 0x11, 0x0E, 0x00 }),
            ['И'] = (6, new byte[] { 0x11, 0x13, 0x15, 0x19, 0x11, 0x11, 0x00 }),
            ['Й'] = (6, new byte[] { 0x0E, 0x13, 0x15, 0x19, 0x11, 0x11, 0x00 }),
            ['К'] = (6, new byte[] { 0x11, 0x12, 0x1C, 0x12, 0x11, 0x11, 0x00 }),
            ['Л'] = (6, new byte[] { 0x07, 0x09, 0x09, 0x09, 0x09, 0x11, 0x00 }),
            ['М'] = (6, new byte[] { 0x11, 0x1B, 0x15, 0x15, 0x11, 0x11, 0x00 }),
            ['Н'] = (6, new byte[] { 0x11, 0x11, 0x1F, 0x11, 0x11, 0x11, 0x00 }),
            ['О'] = (6, new byte[] { 0x0E, 0x11, 0x11, 0x11, 0x11, 0x0E, 0x00 }),
            ['П'] = (6, new byte[] { 0x1F, 0x11, 0x11, 0x11, 0x11, 0x11, 0x00 }),
            ['Р'] = (6, new byte[] { 0x1E, 0x11, 0x11, 0x1E, 0x10, 0x10, 0x00 }),
            ['С'] = (6, new byte[] { 0x0E, 0x11, 0x10, 0x10, 0x11, 0x0E, 0x00 }),
            ['Т'] = (6, new byte[] { 0x1F, 0x04, 0x04, 0x04, 0x04, 0x04, 0x00 }),
            ['У'] = (6, new byte[] { 0x11, 0x11, 0x0F, 0x01, 0x11, 0x0E, 0x00 }),
            ['Ф'] = (6, new byte[] { 0x0E, 0x15, 0x15, 0x15, 0x0E, 0x04, 0x00 }),
            ['Х'] = (6, new byte[] { 0x11, 0x0A, 0x04, 0x04, 0x0A, 0x11, 0x00 }),
            ['Ц'] = (6, new byte[] { 0x12, 0x12, 0x12, 0x12, 0x1F, 0x01, 0x00 }),
            ['Ч'] = (6, new byte[] { 0x11, 0x11, 0x11, 0x0F, 0x01, 0x01, 0x00 }),
            ['Ш'] = (6, new byte[] { 0x15, 0x15, 0x15, 0x15, 0x15, 0x1F, 0x00 }),
            ['Щ'] = (6, new byte[] { 0x15, 0x15, 0x15, 0x15, 0x1F, 0x01, 0x00 }),
            ['Ъ'] = (6, new byte[] { 0x18, 0x08, 0x0E, 0x09, 0x09, 0x0E, 0x00 }),
            ['Ы'] = (6, new byte[] { 0x11, 0x11, 0x19, 0x15, 0x15, 0x19, 0x00 }),
            ['Ь'] = (5, new byte[] { 0x10, 0x10, 0x1C, 0x12, 0x12, 0x1C, 0x00 }),
            ['Э'] = (6, new byte[] { 0x0E, 0x11, 0x07, 0x01, 0x11, 0x0E, 0x00 }),
            ['Ю'] = (6, new byte[] { 0x12, 0x15, 0x1D, 0x15, 0x15, 0x12, 0x00 }),
            ['Я'] = (6, new byte[] { 0x0F, 0x11, 0x0F, 0x05, 0x09, 0x11, 0x00 }),
            // Cyrillic lowercase (а..я)
            ['а'] = (6, new byte[] { 0x00, 0x0E, 0x01, 0x0F, 0x11, 0x0F, 0x00 }),
            ['б'] = (6, new byte[] { 0x07, 0x08, 0x1E, 0x11, 0x11, 0x0E, 0x00 }),
            ['в'] = (5, new byte[] { 0x00, 0x1C, 0x12, 0x1C, 0x12, 0x1C, 0x00 }),
            ['г'] = (5, new byte[] { 0x00, 0x1E, 0x10, 0x10, 0x10, 0x10, 0x00 }),
            ['д'] = (6, new byte[] { 0x00, 0x0E, 0x12, 0x12, 0x1F, 0x11, 0x00 }),
            ['е'] = (6, new byte[] { 0x00, 0x0E, 0x11, 0x1F, 0x10, 0x0F, 0x00 }),
            ['ж'] = (6, new byte[] { 0x00, 0x15, 0x0E, 0x0E, 0x15, 0x15, 0x00 }),
            ['з'] = (5, new byte[] { 0x00, 0x1C, 0x02, 0x0C, 0x02, 0x1C, 0x00 }),
            ['и'] = (6, new byte[] { 0x00, 0x11, 0x13, 0x15, 0x19, 0x11, 0x00 }),
            ['й'] = (6, new byte[] { 0x0E, 0x00, 0x13, 0x15, 0x19, 0x11, 0x00 }),
            ['к'] = (5, new byte[] { 0x00, 0x12, 0x14, 0x18, 0x14, 0x12, 0x00 }),
            ['л'] = (6, new byte[] { 0x00, 0x07, 0x09, 0x09, 0x09, 0x11, 0x00 }),
            ['м'] = (6, new byte[] { 0x00, 0x11, 0x1B, 0x15, 0x11, 0x11, 0x00 }),
            ['н'] = (6, new byte[] { 0x00, 0x11, 0x11, 0x1F, 0x11, 0x11, 0x00 }),
            ['о'] = (6, new byte[] { 0x00, 0x0E, 0x11, 0x11, 0x11, 0x0E, 0x00 }),
            ['п'] = (6, new byte[] { 0x00, 0x1F, 0x11, 0x11, 0x11, 0x11, 0x00 }),
            ['р'] = (6, new byte[] { 0x00, 0x1E, 0x11, 0x11, 0x1E, 0x10, 0x10 }),
            ['с'] = (5, new byte[] { 0x00, 0x0E, 0x10, 0x10, 0x10, 0x0E, 0x00 }),
            ['т'] = (6, new byte[] { 0x00, 0x1F, 0x04, 0x04, 0x04, 0x04, 0x00 }),
            ['у'] = (6, new byte[] { 0x00, 0x11, 0x11, 0x11, 0x0F, 0x01, 0x0E }),
            ['ф'] = (6, new byte[] { 0x04, 0x0E, 0x15, 0x15, 0x0E, 0x04, 0x00 }),
            ['х'] = (5, new byte[] { 0x00, 0x12, 0x0C, 0x0C, 0x12, 0x12, 0x00 }),
            ['ц'] = (6, new byte[] { 0x00, 0x12, 0x12, 0x12, 0x1F, 0x01, 0x00 }),
            ['ч'] = (6, new byte[] { 0x00, 0x11, 0x11, 0x0F, 0x01, 0x01, 0x00 }),
            ['ш'] = (6, new byte[] { 0x00, 0x15, 0x15, 0x15, 0x15, 0x1F, 0x00 }),
            ['щ'] = (6, new byte[] { 0x00, 0x15, 0x15, 0x15, 0x1F, 0x01, 0x00 }),
            ['ъ'] = (6, new byte[] { 0x00, 0x18, 0x08, 0x0E, 0x09, 0x0E, 0x00 }),
            ['ы'] = (6, new byte[] { 0x00, 0x11, 0x19, 0x15, 0x15, 0x19, 0x00 }),
            ['ь'] = (5, new byte[] { 0x00, 0x10, 0x1C, 0x12, 0x12, 0x1C, 0x00 }),
            ['э'] = (5, new byte[] { 0x00, 0x1C, 0x02, 0x0E, 0x02, 0x1C, 0x00 }),
            ['ю'] = (6, new byte[] { 0x00, 0x12, 0x15, 0x1D, 0x15, 0x12, 0x00 }),
            ['я'] = (6, new byte[] { 0x00, 0x0F, 0x11, 0x0F, 0x09, 0x11, 0x00 }),
        };
    }

    public class J2MEImage
    {
        public readonly int Width;
        public readonly int Height;
        public readonly int Scale;
        public readonly int PhysicalWidth;
        public readonly int PhysicalHeight;
        public readonly uint[] Pixels; // 0xAARRGGBB
        private uint[] _pixels2x;

        public J2MEImage(int w, int h, uint fillColor = 0xFFFFFFFFu, int scale = 1)
        {
            Width = Math.Max(1, w);
            Height = Math.Max(1, h);
            Scale = Math.Max(1, scale);
            PhysicalWidth = Width * Scale;
            PhysicalHeight = Height * Scale;
            Pixels = new uint[PhysicalWidth * PhysicalHeight];
            if (fillColor != 0)
                Array.Fill(Pixels, fillColor);
        }

        public J2MEImage(int w, int h, uint[] pixels)
        {
            Width = w;
            Height = h;
            Scale = 1;
            PhysicalWidth = w;
            PhysicalHeight = h;
            Pixels = pixels;
        }

        public int getWidth() => Width;
        public int getHeight() => Height;
        public J2MEGraphics getGraphics() => new J2MEGraphics(this);

        public uint[] GetPixels2x()
        {
            if (_pixels2x != null)
                return _pixels2x;
            _pixels2x = UpscaleXbr2x(Pixels, Width, Height);
            return _pixels2x;
        }

        private static int ColorDist(uint c1, uint c2)
        {
            if (c1 == c2) return 0;
            uint a1 = c1 >> 24;
            uint a2 = c2 >> 24;
            if (a1 == 0 && a2 == 0) return 0;
            if ((a1 == 0) != (a2 == 0)) return 12000;
            int dr = Math.Abs((int)((c1 >> 16) & 0xFF) - (int)((c2 >> 16) & 0xFF));
            int dg = Math.Abs((int)((c1 >> 8) & 0xFF) - (int)((c2 >> 8) & 0xFF));
            int db = Math.Abs((int)(c1 & 0xFF) - (int)(c2 & 0xFF));
            return 3 * dr + 4 * dg + 2 * db;
        }

        private static uint BlendColors(uint c1, uint c2, int w1, int w2)
        {
            if (c1 == c2) return c1;
            uint a1 = c1 >> 24;
            uint a2 = c2 >> 24;
            int total = w1 + w2;
            if (a1 == 0 && a2 == 0) return 0u;
            if (a1 == 0)
            {
                uint a = (uint)((a2 * w2) / total);
                return (a << 24) | (c2 & 0x00FFFFFFu);
            }
            if (a2 == 0)
            {
                uint a = (uint)((a1 * w1) / total);
                return (a << 24) | (c1 & 0x00FFFFFFu);
            }
            uint oa = (uint)((a1 * w1 + a2 * w2) / total);
            uint or = (uint)((((c1 >> 16) & 0xFF) * w1 + ((c2 >> 16) & 0xFF) * w2) / total);
            uint og = (uint)((((c1 >> 8) & 0xFF) * w1 + ((c2 >> 8) & 0xFF) * w2) / total);
            uint ob = (uint)(((c1 & 0xFF) * w1 + (c2 & 0xFF) * w2) / total);
            return (oa << 24) | (or << 16) | (og << 8) | ob;
        }

        private static void XbrCorner(
            uint E, uint B, uint D, uint F, uint H, uint C, uint G, uint I,
            uint H5, uint F4, uint I4, uint I5,
            ref uint e1, ref uint e2, ref uint e3)
        {
            if (E == H || E == F) return;

            int wd1 = ColorDist(E, G) + ColorDist(E, C) + ColorDist(I, H5) + ColorDist(I, F4) + 4 * ColorDist(H, F);
            int wd2 = ColorDist(H, D) + ColorDist(H, I5) + ColorDist(F, B) + ColorDist(F, I4) + 4 * ColorDist(E, I);
            if (wd1 >= wd2) return;

            uint nc = ColorDist(E, F) <= ColorDist(E, H) ? F : H;
            if (ColorDist(F, H) < 96)
                nc = BlendColors(F, H, 1, 1);

            int ke = ColorDist(F, G);
            int ki = ColorDist(H, C);
            bool left2 = (ke * 2 <= ki) && E != G && D != G;
            bool up2 = (ki * 2 <= ke) && E != C && B != C;

            if (left2 && up2)
            {
                e3 = BlendColors(nc, E, 7, 1);
                e2 = BlendColors(nc, e2, 1, 3);
                e1 = BlendColors(nc, e1, 1, 3);
            }
            else if (left2)
            {
                e3 = BlendColors(nc, E, 3, 1);
                e2 = BlendColors(nc, e2, 1, 3);
            }
            else if (up2)
            {
                e3 = BlendColors(nc, E, 3, 1);
                e1 = BlendColors(nc, e1, 1, 3);
            }
            else
            {
                e3 = BlendColors(nc, E, 3, 1);
            }
        }

        public static uint[] UpscaleXbr2x(uint[] src, int w, int h)
        {
            int dw = w * 2;
            int dh = h * 2;
            uint[] dst = new uint[dw * dh];

            bool hasAlpha = false;
            for (int i = 0; i < src.Length; i++)
            {
                if ((src[i] >> 24) == 0) { hasAlpha = true; break; }
            }

            uint Sample(int x, int y)
            {
                if (x < 0 || x >= w || y < 0 || y >= h)
                {
                    if (hasAlpha) return 0u;
                    int cx = Math.Clamp(x, 0, w - 1);
                    int cy = Math.Clamp(y, 0, h - 1);
                    return src[cy * w + cx];
                }
                return src[y * w + x];
            }

            for (int y = 0; y < h; y++)
            {
                int dy0 = (y * 2) * dw;
                int dy1 = (y * 2 + 1) * dw;
                for (int x = 0; x < w; x++)
                {
                    uint A1 = Sample(x - 1, y - 2), B1 = Sample(x, y - 2), C1 = Sample(x + 1, y - 2);
                    uint A0 = Sample(x - 2, y - 1), A  = Sample(x - 1, y - 1), B  = Sample(x, y - 1), C  = Sample(x + 1, y - 1), C4 = Sample(x + 2, y - 1);
                    uint D0 = Sample(x - 2, y),     D  = Sample(x - 1, y),     E  = Sample(x, y),     F  = Sample(x + 1, y),     F4 = Sample(x + 2, y);
                    uint G0 = Sample(x - 2, y + 1), G  = Sample(x - 1, y + 1), H  = Sample(x, y + 1), I  = Sample(x + 1, y + 1), I4 = Sample(x + 2, y + 1);
                    uint G5 = Sample(x - 1, y + 2), H5 = Sample(x, y + 2),     I5 = Sample(x + 1, y + 2);

                    uint e0 = E, e1 = E, e2 = E, e3 = E;

                    XbrCorner(E, B, D, F, H, C, G, I, H5, F4, I4, I5, ref e1, ref e2, ref e3);
                    XbrCorner(E, D, H, B, F, A, I, C, F4, B1, C1, C4, ref e0, ref e3, ref e1);
                    XbrCorner(E, F, B, H, D, I, A, G, D0, H5, G5, G0, ref e3, ref e0, ref e2);
                    XbrCorner(E, H, F, D, B, G, C, A, B1, D0, A0, A1, ref e2, ref e1, ref e0);

                    int dx = x * 2;
                    dst[dy0 + dx] = e0;
                    dst[dy0 + dx + 1] = e1;
                    dst[dy1 + dx] = e2;
                    dst[dy1 + dx + 1] = e3;
                }
            }

            return dst;
        }

        public static J2MEImage createImage(int w, int h) => new J2MEImage(w, h, 0xFFFFFFFFu);

        public static J2MEImage createRGBImage(int[] rgb, int width, int height, bool processAlpha)
        {
            uint[] dst = new uint[width * height];
            if (rgb != null)
            {
                int len = Math.Min(rgb.Length, dst.Length);
                if (processAlpha)
                {
                    for (int i = 0; i < len; i++)
                        dst[i] = (uint)rgb[i];
                }
                else
                {
                    for (int i = 0; i < len; i++)
                        dst[i] = 0xFF000000u | ((uint)rgb[i] & 0x00FFFFFFu);
                }
            }
            return new J2MEImage(width, height, dst);
        }
    }

    public class J2MEGraphics
    {
        public const int HCENTER = 1;
        public const int VCENTER = 2;
        public const int LEFT = 4;
        public const int RIGHT = 8;
        public const int TOP = 16;
        public const int BOTTOM = 32;
        public const int BASELINE = 64;

        public readonly J2MEImage Target;
        public int TransX = 0;
        public int TransY = 0;
        private int _clipX = 0;
        private int _clipY = 0;
        private int _clipW;
        private int _clipH;
        private uint _color = 0xFF000000u;
        private Font _font = new Font();

        public J2MEGraphics(J2MEImage target)
        {
            Target = target;
            _clipW = target.Width;
            _clipH = target.Height;
        }

        public void Reset()
        {
            TransX = 0;
            TransY = 0;
            _clipX = 0;
            _clipY = 0;
            _clipW = Target.Width;
            _clipH = Target.Height;
            _color = 0xFF000000u;
        }

        public void translate(int x, int y)
        {
            TransX += x;
            TransY += y;
        }

        public int getColor() => (int)(_color & 0x00FFFFFFu);

        public void setColor(int rgb)
        {
            _color = 0xFF000000u | ((uint)rgb & 0x00FFFFFFu);
        }

        public void setColor(int r, int g, int b)
        {
            _color = 0xFF000000u | (((uint)(r & 0xFF)) << 16) | (((uint)(g & 0xFF)) << 8) | ((uint)(b & 0xFF));
        }

        public void setFont(Font f) { _font = f ?? new Font(); }
        public Font getFont() => _font;

        public void setClip(int x, int y, int width, int height)
        {
            _clipX = x + TransX;
            _clipY = y + TransY;
            _clipW = width;
            _clipH = height;
        }

        public int getClipX() => _clipX - TransX;
        public int getClipY() => _clipY - TransY;
        public int getClipWidth() => _clipW;
        public int getClipHeight() => _clipH;

        private void GetPhysicalClippedBounds(out int minX, out int minY, out int maxX, out int maxY)
        {
            int s = Target.Scale;
            minX = Math.Max(0, _clipX * s);
            minY = Math.Max(0, _clipY * s);
            maxX = Math.Min(Target.PhysicalWidth, (_clipX + _clipW) * s);
            maxY = Math.Min(Target.PhysicalHeight, (_clipY + _clipH) * s);
        }

        private static void ApplyAnchor(ref int x, ref int y, int w, int h, int anchor)
        {
            if ((anchor & RIGHT) != 0) x -= w;
            else if ((anchor & HCENTER) != 0) x -= w >> 1;

            if ((anchor & BOTTOM) != 0 || (anchor & BASELINE) != 0) y -= h;
            else if ((anchor & VCENTER) != 0) y -= h >> 1;
        }

        private static uint BlendPixel(uint dst, uint src)
        {
            uint sa = src >> 24;
            if (sa == 255) return src;
            if (sa == 0) return dst;
            uint invA = 255 - sa;
            uint r = (((src >> 16) & 0xFF) * sa + ((dst >> 16) & 0xFF) * invA) >> 8;
            uint g = (((src >> 8) & 0xFF) * sa + ((dst >> 8) & 0xFF) * invA) >> 8;
            uint b = ((src & 0xFF) * sa + (dst & 0xFF) * invA) >> 8;
            return 0xFF000000u | (r << 16) | (g << 8) | b;
        }

        public void fillRect(int x, int y, int width, int height)
        {
            if (width <= 0 || height <= 0) return;
            int s = Target.Scale;
            int rx = (x + TransX) * s;
            int ry = (y + TransY) * s;
            GetPhysicalClippedBounds(out int minX, out int minY, out int maxX, out int maxY);
            int x0 = Math.Max(minX, rx);
            int y0 = Math.Max(minY, ry);
            int x1 = Math.Min(maxX, rx + width * s);
            int y1 = Math.Min(maxY, ry + height * s);
            if (x0 >= x1 || y0 >= y1) return;

            uint[] pixels = Target.Pixels;
            int stride = Target.PhysicalWidth;
            int spanLen = x1 - x0;
            for (int py = y0; py < y1; py++)
                Array.Fill(pixels, _color, py * stride + x0, spanLen);
        }

        public void fillTriangle(int x0, int y0, int x1, int y1, int x2, int y2)
        {
            int s = Target.Scale;
            int v0 = (x0 + TransX) * s, v1 = (y0 + TransY) * s;
            int v2 = (x1 + TransX) * s, v3 = (y1 + TransY) * s;
            int v4 = (x2 + TransX) * s, v5 = (y2 + TransY) * s;

            if (v3 < v1) { (v1, v3) = (v3, v1); (v0, v2) = (v2, v0); }
            if (v5 < v3) { (v3, v5) = (v5, v3); (v2, v4) = (v4, v2); }
            if (v3 < v1) { (v1, v3) = (v3, v1); (v0, v2) = (v2, v0); }

            GetPhysicalClippedBounds(out int minX, out int minY, out int maxX, out int maxY);
            if (v5 < minY || v1 >= maxY) return;

            int dy01 = v3 - v1;
            int dy02 = v5 - v1;
            int dy12 = v5 - v3;
            int step01 = dy01 != 0 ? ((v2 - v0) << 16) / dy01 : 0;
            int step02 = dy02 != 0 ? ((v4 - v0) << 16) / dy02 : 0;
            int step12 = dy12 != 0 ? ((v4 - v2) << 16) / dy12 : 0;

            uint[] pixels = Target.Pixels;
            int stride = Target.PhysicalWidth;

            int curA = 0, curB = 0;
            for (int py = v1; py < v3; py++)
            {
                if (py >= minY && py < maxY)
                {
                    int xa = v0 + (curA >> 16);
                    int xb = v0 + (curB >> 16);
                    if (xb < xa) (xa, xb) = (xb, xa);
                    int sx0 = Math.Max(minX, xa);
                    int sx1 = Math.Min(maxX, xb);
                    if (sx1 > sx0)
                        Array.Fill(pixels, _color, py * stride + sx0, sx1 - sx0);
                }
                curA += step01;
                curB += step02;
            }

            curA = 0;
            for (int py = v3; py < v5; py++)
            {
                if (py >= minY && py < maxY)
                {
                    int xa = v2 + (curA >> 16);
                    int xb = v0 + (curB >> 16);
                    if (xb < xa) (xa, xb) = (xb, xa);
                    int sx0 = Math.Max(minX, xa);
                    int sx1 = Math.Min(maxX, xb);
                    if (sx1 > sx0)
                        Array.Fill(pixels, _color, py * stride + sx0, sx1 - sx0);
                }
                curA += step12;
                curB += step02;
            }
        }

        public void drawRect(int x, int y, int width, int height)
        {
            if (width < 0 || height < 0) return;
            drawLine(x, y, x + width, y);
            drawLine(x + width, y, x + width, y + height);
            drawLine(x, y + height, x + width, y + height);
            drawLine(x, y, x, y + height);
        }

        public void drawLine(int x1, int y1, int x2, int y2)
        {
            int s = Target.Scale;
            int px0 = (x1 + TransX) * s;
            int py0 = (y1 + TransY) * s;
            int px1 = (x2 + TransX) * s;
            int py1 = (y2 + TransY) * s;
            GetPhysicalClippedBounds(out int minX, out int minY, out int maxX, out int maxY);

            int dx = Math.Abs(px1 - px0), sx = px0 < px1 ? 1 : -1;
            int dy = -Math.Abs(py1 - py0), sy = py0 < py1 ? 1 : -1;
            int err = dx + dy;
            uint[] pixels = Target.Pixels;
            int stride = Target.PhysicalWidth;

            while (true)
            {
                for (int by = 0; by < s; by++)
                {
                    int py = py0 + by;
                    if (py < minY || py >= maxY) continue;
                    int row = py * stride;
                    for (int bx = 0; bx < s; bx++)
                    {
                        int px = px0 + bx;
                        if (px >= minX && px < maxX)
                            pixels[row + px] = _color;
                    }
                }
                if (px0 == px1 && py0 == py1) break;
                int e2 = 2 * err;
                if (e2 >= dy) { err += dy; px0 += sx; }
                if (e2 <= dx) { err += dx; py0 += sy; }
            }
        }

        public void drawImage(J2MEImage img, int x, int y, int anchor)
        {
            if (img == null) return;
            int dx = x + TransX;
            int dy = y + TransY;
            ApplyAnchor(ref dx, ref dy, img.Width, img.Height, anchor);

            int s = Target.Scale;
            int pdx = dx * s;
            int pdy = dy * s;
            int srcW = img.Width * s;
            int srcH = img.Height * s;

            GetPhysicalClippedBounds(out int minX, out int minY, out int maxX, out int maxY);
            int x0 = Math.Max(minX, pdx);
            int y0 = Math.Max(minY, pdy);
            int x1 = Math.Min(maxX, pdx + srcW);
            int y1 = Math.Min(maxY, pdy + srcH);
            if (x0 >= x1 || y0 >= y1) return;

            uint[] dstPixels = Target.Pixels;
            uint[] srcPixels = s == 2 ? img.GetPixels2x() : img.Pixels;
            int dstStride = Target.PhysicalWidth;

            for (int py = y0; py < y1; py++)
            {
                int sy = py - pdy;
                int dstRow = py * dstStride;
                int srcRow = sy * srcW;
                for (int px = x0; px < x1; px++)
                {
                    int sx = px - pdx;
                    uint sc = srcPixels[srcRow + sx];
                    uint sa = sc >> 24;
                    if (sa == 255)
                        dstPixels[dstRow + px] = sc;
                    else if (sa > 0)
                        dstPixels[dstRow + px] = BlendPixel(dstPixels[dstRow + px], sc);
                }
            }
        }

        private static bool GetGlyphBit(byte[] rows, int c, int r)
        {
            if (r < 0 || r >= 7 || c < 0 || c >= 5) return false;
            return (rows[r] & (1 << (4 - c))) != 0;
        }

        public void drawString(string str, int x, int y, int anchor)
        {
            if (string.IsNullOrEmpty(str)) return;
            int strW = _font.stringWidth(str);
            int strH = _font.getHeight();
            int dx = x + TransX;
            int dy = y + TransY;
            ApplyAnchor(ref dx, ref dy, strW, strH, anchor);

            int yPad = Math.Max(1, (strH - 7) >> 1);
            int curX = dx;
            int baseY = dy + yPad;
            bool bold = _font.IsBold;
            int s = Target.Scale;

            GetPhysicalClippedBounds(out int minX, out int minY, out int maxX, out int maxY);
            uint[] pixels = Target.Pixels;
            int stride = Target.PhysicalWidth;

            if (s == 1)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    Font.GetGlyph(str[i], out int adv, out byte[] rows);
                    for (int r = 0; r < 7; r++)
                    {
                        int py = baseY + r;
                        if (py < minY || py >= maxY) continue;
                        byte bits = rows[r];
                        if (bits == 0) continue;
                        int rowOff = py * stride;
                        for (int c = 0; c < 5; c++)
                        {
                            if ((bits & (1 << (4 - c))) != 0)
                            {
                                int px = curX + c;
                                if (px >= minX && px < maxX)
                                    pixels[rowOff + px] = _color;
                                if (bold && px + 1 >= minX && px + 1 < maxX)
                                    pixels[rowOff + px + 1] = _color;
                            }
                        }
                    }
                    curX += adv + (bold ? 1 : 0);
                }
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    Font.GetGlyph(str[i], out int adv, out byte[] rows);
                    for (int r = 0; r < 7; r++)
                    {
                        for (int c = 0; c < 5; c++)
                        {
                            bool E = GetGlyphBit(rows, c, r);
                            bool B = GetGlyphBit(rows, c, r - 1);
                            bool H = GetGlyphBit(rows, c, r + 1);
                            bool D = GetGlyphBit(rows, c - 1, r);
                            bool F = GetGlyphBit(rows, c + 1, r);
                            bool A = GetGlyphBit(rows, c - 1, r - 1);
                            bool C = GetGlyphBit(rows, c + 1, r - 1);
                            bool G = GetGlyphBit(rows, c - 1, r + 1);
                            bool I = GetGlyphBit(rows, c + 1, r + 1);

                            bool e0 = E || (D && B && !A);
                            bool e1 = E || (B && F && !C);
                            bool e2 = E || (D && H && !G);
                            bool e3 = E || (H && F && !I);

                            if (!e0 && !e1 && !e2 && !e3) continue;

                            int px0 = (curX + c) * 2;
                            int py0 = (baseY + r) * 2;
                            int boldExtra = bold ? 2 : 0;

                            void PlotSub(int sx, int sy)
                            {
                                if (sy < minY || sy >= maxY) return;
                                int rowOff = sy * stride;
                                for (int bx = 0; bx <= boldExtra; bx++)
                                {
                                    int px = sx + bx;
                                    if (px >= minX && px < maxX)
                                        pixels[rowOff + px] = _color;
                                }
                            }

                            if (e0) PlotSub(px0, py0);
                            if (e1) PlotSub(px0 + 1, py0);
                            if (e2) PlotSub(px0, py0 + 1);
                            if (e3) PlotSub(px0 + 1, py0 + 1);
                        }
                    }
                    curX += adv + (bold ? 1 : 0);
                }
            }
        }
    }

    public abstract class Displayable
    {
        public static int ConfiguredWidth = 712;
        public static int ConfiguredHeight = 400;
        public static int RenderScale = 2;
        public virtual int getWidth() => ConfiguredWidth;
        public virtual int getHeight() => ConfiguredHeight;
        public virtual bool isShown() => true;
    }

    public abstract class Canvas : Displayable
    {
        public J2MEImage Framebuffer;
        private J2MEGraphics _fbGraphics;
        public readonly object RenderLock = new object();

        protected Canvas()
        {
            EnsureFramebuffer();
        }

        public void EnsureFramebuffer()
        {
            lock (RenderLock)
            {
                if (Framebuffer == null
                    || Framebuffer.Width != ConfiguredWidth
                    || Framebuffer.Height != ConfiguredHeight
                    || Framebuffer.Scale != RenderScale)
                {
                    Framebuffer = new J2MEImage(ConfiguredWidth, ConfiguredHeight, 0xFF000000u, RenderScale);
                    _fbGraphics = new J2MEGraphics(Framebuffer);
                }
            }
        }

        public void setFullScreenMode(bool mode) { }

        public void repaint()
        {
            lock (RenderLock)
            {
                EnsureFramebuffer();
                _fbGraphics.Reset();
                paint(_fbGraphics);
            }
        }

        public void serviceRepaints() { }

        public virtual void paint(J2MEGraphics g) { }
        public virtual void keyPressed(int keyCode) { }
        public virtual void keyReleased(int keyCode) { }
        public virtual void hideNotify() { }
        public virtual void showNotify() { }
        public virtual void sizeChanged(int w, int h) { }
    }

    public abstract class GameCanvas : Canvas
    {
        protected GameCanvas(bool suppressKeyEvents) : base() { }
    }

    public class Display
    {
        private static readonly Display _instance = new Display();
        public Displayable Current;
        public static Display getDisplay(MIDlet m) => _instance;
        public void setCurrent(Displayable d) { Current = d; }
    }

    public abstract class MIDlet
    {
        public void notifyDestroyed() { }
        public void notifyPaused() { }
    }

    // =========================================================================
    // J2ME RMS: RecordStore & InvalidRecordIDException
    // =========================================================================
    public class RecordStoreException : Exception
    {
        public RecordStoreException(string msg = "") : base(msg) { }
    }

    public class InvalidRecordIDException : RecordStoreException
    {
        public InvalidRecordIDException(string msg = "") : base(msg) { }
    }

    public class RecordStoreNotFoundException : RecordStoreException
    {
        public RecordStoreNotFoundException(string msg = "") : base(msg) { }
    }

    public class RecordStore
    {
        private readonly string _filePath;
        private readonly SortedDictionary<int, sbyte[]> _records = new SortedDictionary<int, sbyte[]>();
        private int _nextId = 1;

        private RecordStore(string filePath)
        {
            _filePath = filePath;
            Load();
        }

        private static string GetStorePath(string name)
        {
            JavaLang.InitPaths();
            foreach (char c in Path.GetInvalidFileNameChars())
                name = name.Replace(c, '_');
            return Path.Combine(JavaLang.SaveRoot, name + ".rms");
        }

        private void Load()
        {
            if (!File.Exists(_filePath)) return;
            try
            {
                using BinaryReader br = new BinaryReader(File.OpenRead(_filePath));
                int count = br.ReadInt32();
                _nextId = br.ReadInt32();
                for (int i = 0; i < count; i++)
                {
                    int id = br.ReadInt32();
                    int len = br.ReadInt32();
                    byte[] data = br.ReadBytes(len);
                    _records[id] = (sbyte[])(Array)data;
                }
            }
            catch { }
        }

        private void Save()
        {
            try
            {
                using BinaryWriter bw = new BinaryWriter(File.Create(_filePath));
                bw.Write(_records.Count);
                bw.Write(_nextId);
                foreach (var kv in _records)
                {
                    bw.Write(kv.Key);
                    bw.Write(kv.Value.Length);
                    bw.Write((byte[])(Array)kv.Value);
                }
            }
            catch { }
        }

        public static string[] listRecordStores()
        {
            JavaLang.InitPaths();
            var files = Directory.GetFiles(JavaLang.SaveRoot, "*.rms");
            string[] names = new string[files.Length];
            for (int i = 0; i < files.Length; i++)
                names[i] = Path.GetFileNameWithoutExtension(files[i]);
            return names;
        }

        public static RecordStore openRecordStore(string name, bool createIfNecessary)
        {
            string path = GetStorePath(name);
            if (!File.Exists(path) && !createIfNecessary)
                throw new RecordStoreNotFoundException(name);
            if (!File.Exists(path) && createIfNecessary)
            {
                var rs = new RecordStore(path);
                rs.Save();
                return rs;
            }
            return new RecordStore(path);
        }

        public static void deleteRecordStore(string name)
        {
            string path = GetStorePath(name);
            if (File.Exists(path))
                File.Delete(path);
        }

        public int getNumRecords() => _records.Count;

        public sbyte[] getRecord(int recordId)
        {
            if (!_records.TryGetValue(recordId, out sbyte[] data))
                throw new InvalidRecordIDException("Record not found: " + recordId);
            sbyte[] copy = new sbyte[data.Length];
            Array.Copy(data, copy, data.Length);
            return copy;
        }

        public int addRecord(sbyte[] data, int offset, int numBytes)
        {
            sbyte[] rec = new sbyte[numBytes];
            if (data != null && numBytes > 0)
                Array.Copy(data, offset, rec, 0, numBytes);
            int id = _nextId++;
            if (_records.Count == 0) id = 1;
            _records[id] = rec;
            Save();
            return id;
        }

        public void setRecord(int recordId, sbyte[] newData, int offset, int numBytes)
        {
            sbyte[] rec = new sbyte[numBytes];
            if (newData != null && numBytes > 0)
                Array.Copy(newData, offset, rec, 0, numBytes);
            _records[recordId] = rec;
            if (recordId >= _nextId) _nextId = recordId + 1;
            Save();
        }

        public void closeRecordStore() => Save();
    }

    // =========================================================================
    // J2ME Media: Manager, Player, VolumeControl (WAV & Synthesized MIDI)
    // =========================================================================
    public interface VolumeControl
    {
        void setLevel(int level);
    }

    public class Player : VolumeControl
    {
        public int SoundId = -1;
        public byte[] RawBytes;
        public string MimeType;
        public int State = 100;
        public int LoopCount = 1;
        public int Volume = 100;

        public static Action<Player> OnStartPlayer;
        public static Action<Player> OnStopPlayer;
        public static Action<Player> OnVolumeChanged;

        public void realize() => State = 200;
        public void prefetch() => State = 300;
        public void setLoopCount(int count) => LoopCount = count;
        public long setMediaTime(long now) => 0L;

        public void start()
        {
            State = 400;
            OnStartPlayer?.Invoke(this);
        }

        public void stop()
        {
            State = 300;
            OnStopPlayer?.Invoke(this);
        }

        public void deallocate() => stop();

        public void close()
        {
            stop();
            State = 0;
        }

        public VolumeControl getControl(string type) => this;

        public void setLevel(int level)
        {
            Volume = Math.Clamp(level, 0, 100);
            OnVolumeChanged?.Invoke(this);
        }
    }

    public static class Manager
    {
        public static Player createPlayer(InputStream stream, string type)
        {
            MemoryStream ms = new MemoryStream();
            if (stream != null)
            {
                int b;
                while ((b = stream.read()) != -1)
                    ms.WriteByte((byte)b);
            }
            return new Player
            {
                RawBytes = ms.ToArray(),
                MimeType = type ?? "audio/x-wav"
            };
        }
    }
}
