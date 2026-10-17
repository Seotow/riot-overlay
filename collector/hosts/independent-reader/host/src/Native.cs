using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace IndependentCollector;

internal static class Native
{
    internal const string Library = "lc_reader";
    internal const uint AllowFixture = 1, AllowUnverified = 2;
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate nuint ReadMemory(IntPtr context, ulong address, IntPtr destination, nuint requested);

    [StructLayout(LayoutKind.Sequential)]
    internal struct Target
    {
        public uint StructSize;
        [MarshalAs(UnmanagedType.LPUTF8Str)] public string Module;
        [MarshalAs(UnmanagedType.LPUTF8Str)] public string Version;
        [MarshalAs(UnmanagedType.LPUTF8Str)] public string Sha256;
        public ulong ModuleBase;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct Request
    {
        public uint StructSize;
        public IntPtr HeroAddresses;
        public nuint HeroCount;
        public uint HeroesKnown;
    }
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    internal struct Error
    {
        public int Code;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)] public string Message;
    }

    static Native()
    {
        NativeLibrary.SetDllImportResolver(typeof(Native).Assembly, (name, assembly, search) =>
        {
            if (name != Library) return IntPtr.Zero;
            string file = OperatingSystem.IsWindows() ? "lc_reader.dll" : "liblc_reader.so";
            return NativeLibrary.Load(Path.Combine(AppContext.BaseDirectory, file));
        });
    }

    [DllImport(Library, CallingConvention = CallingConvention.Cdecl)]
    internal static extern uint lc_reader_api_version();
    [DllImport(Library, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int lc_reader_create(byte[] profile, nuint length, ref Target target,
        ReadMemory callback, IntPtr context, uint flags, out IntPtr reader, ref Error error);
    [DllImport(Library, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int lc_reader_snapshot(IntPtr reader, ref Request request,
        out IntPtr json, out nuint length, ref Error error);
    [DllImport(Library, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void lc_reader_free_buffer(IntPtr buffer);
    [DllImport(Library, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void lc_reader_destroy(IntPtr reader);
    [DllImport(Library, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int lc_reader_win32_open(uint processId, out IntPtr context, ref Error error);
    [DllImport(Library, CallingConvention = CallingConvention.Cdecl)]
    internal static extern nuint lc_reader_win32_read(IntPtr context, ulong address, IntPtr destination, nuint requested);
    [DllImport(Library, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void lc_reader_win32_close(IntPtr context);
}

internal sealed class ReaderException(string code, string message) : Exception(message)
{
    public string Code { get; } = code;
}
