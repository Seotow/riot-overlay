using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.Json;

namespace IndependentCollector;

internal sealed record TargetIdentity(string Module, string Version, string Sha256, string ModuleBase,
    int? ProcessId, string? ImagePath, long? ProcessStartTimeUtcTicks, bool Measured, bool Synthetic)
{
    internal static TargetIdentity Measure(int processId)
    {
        if (!OperatingSystem.IsWindows() || !Environment.Is64BitProcess)
            throw new ReaderException("windows_x64_required", "Process identity and game memory mode require Windows x64");
        using var process = Process.GetProcessById(processId);
        long started = process.StartTime.ToUniversalTime().Ticks;
        var module = process.MainModule ?? throw new ReaderException("module_unavailable", "Cannot inspect target main module");
        string path = module.FileName;
        using var file = File.OpenRead(path);
        string sha256 = Convert.ToHexString(SHA256.HashData(file)).ToLowerInvariant();
        string version = FileVersionInfo.GetVersionInfo(path).FileVersion ?? "unknown";
        if (process.HasExited || process.StartTime.ToUniversalTime().Ticks != started)
            throw new ReaderException("target_changed", "Target exited or changed while measuring identity");
        return new TargetIdentity(Path.GetFileName(path), version, sha256,
            "0x" + module.BaseAddress.ToInt64().ToString("x", CultureInfo.InvariantCulture), processId, path, started, true, false);
    }
}

internal static class BoundedFile
{
    internal static byte[] Read(string path, int limit, string errorCode)
    {
        if (new FileInfo(path).Length > limit) throw new ReaderException(errorCode, "Input file exceeds its size bound");
        using var input = File.OpenRead(path);
        if (input.Length > limit) throw new ReaderException(errorCode, "Input file exceeds its size bound");
        byte[] bytes = new byte[checked((int)input.Length)];
        input.ReadExactly(bytes);
        if (input.ReadByte() != -1) throw new ReaderException(errorCode, "Input file grew while being read");
        return bytes;
    }
}

internal sealed class SparseFixture
{
    private readonly Dictionary<ulong, byte> memory = [];
    internal TargetIdentity Identity { get; }
    internal ulong[]? Heroes { get; }
    internal SparseFixture(string path)
    {
        byte[] raw = BoundedFile.Read(path, 8 * 1024 * 1024, "fixture_too_large");
        using var doc = JsonDocument.Parse(raw);
        var root = doc.RootElement;
        if (!root.GetProperty("fixtureOnly").GetBoolean()) throw new ReaderException("fixture_label_required", "Expected explicitly synthetic fixture");
        ulong moduleBase = Options.Address(root.GetProperty("moduleBase").GetString()!);
        var roots = new List<ulong>();
        foreach (var item in root.GetProperty("heroAddresses").EnumerateArray()) roots.Add(Options.Address(item.GetString()!));
        if (roots.Count > 64) throw new ReaderException("fixture_bounds", "Fixture has too many hero roots");
        bool known = !root.TryGetProperty("heroesKnown", out var knownElement) || knownElement.GetBoolean();
        if (!known && roots.Count != 0) throw new ReaderException("fixture_roots", "Unknown fixture roots must have an empty heroAddresses array");
        Heroes = known ? roots.ToArray() : null;
        int segments = 0;
        foreach (var segment in root.GetProperty("segments").EnumerateArray())
        {
            if (++segments > 1024) throw new ReaderException("fixture_bounds", "Fixture has too many segments");
            ulong address = Options.Address(segment.GetProperty("address").GetString()!);
            byte[] bytes = Convert.FromHexString(segment.GetProperty("hex").GetString()!);
            if (memory.Count + bytes.Length > 2 * 1024 * 1024 || address < 0x10000 || address > 0x7fffffffffff || (ulong)bytes.Length > 0x800000000000 - address)
                throw new ReaderException("fixture_bounds", "Fixture segment exceeds memory bounds");
            for (int i = 0; i < bytes.Length; i++)
                if (!memory.TryAdd(address + (ulong)i, bytes[i])) throw new ReaderException("fixture_overlap", "Fixture segments overlap");
        }
        Identity = new TargetIdentity("sparse-fixture.bin", "fixture-v1",
            Convert.ToHexString(SHA256.HashData(raw)).ToLowerInvariant(), "0x" + moduleBase.ToString("x", CultureInfo.InvariantCulture), null, null, null, true, true);
    }
    internal nuint Read(IntPtr context, ulong address, IntPtr destination, nuint requested)
    {
        if (requested > 4096 || destination == IntPtr.Zero) return 0;
        byte[] bytes = new byte[(int)requested];
        int count = 0;
        while (count < bytes.Length && memory.TryGetValue(address + (ulong)count, out bytes[count])) count++;
        if (count > 0) Marshal.Copy(bytes, 0, destination, count);
        return (nuint)count;
    }
}

internal sealed class ReaderSession : IDisposable
{
    private IntPtr reader, readContext;
    private GCHandle pinnedHeroes;
    private readonly Native.ReadMemory callback;
    private Native.Request request;
    private Process? process;
    internal TargetIdentity Identity { get; }
    internal bool Synthetic { get; }
    internal bool RootsKnown => request.HeroesKnown != 0;
    internal string ProfileValidation { get; }

    internal ReaderSession(Options options)
    {
        byte[] profile = BoundedFile.Read(options.Profile!, 128 * 1024, "profile_too_large");
        using var profileDoc = JsonDocument.Parse(profile);
        ProfileValidation = profileDoc.RootElement.GetProperty("validation").GetProperty("status").GetString()!;
        ulong[]? heroes;
        uint flags;
        if (options.Fixture != null)
        {
            if (ProfileValidation != "fixture-only") throw new ReaderException("fixture_profile_required", "Fixture mode requires fixture-only profile");
            var fixture = new SparseFixture(options.Fixture);
            Identity = fixture.Identity;
            heroes = fixture.Heroes;
            callback = fixture.Read;
            Synthetic = true;
            flags = Native.AllowFixture;
        }
        else
        {
            if (!OperatingSystem.IsWindows() || !Environment.Is64BitProcess)
                throw new ReaderException("windows_x64_required", "Game memory source requires Windows x64; no synthetic fallback");
            if (ProfileValidation == "fixture-only") throw new ReaderException("fixture_forbidden", "Fixture profile cannot be used against a process");
            Identity = TargetIdentity.Measure(options.ProcessId!.Value);
            process = Process.GetProcessById(options.ProcessId.Value);
            heroes = options.Heroes;
            callback = Native.lc_reader_win32_read;
            Synthetic = false;
            flags = options.AllowUnverified ? Native.AllowUnverified : 0;
        }
        try
        {
            if (Native.lc_reader_api_version() != 1) throw new ReaderException("native_api_mismatch", "Expected native ABI version 1");
            var error = new Native.Error { Message = "" };
            if (!Synthetic)
            {
                CheckProcessBinding(true);
                int opened = Native.lc_reader_win32_open((uint)options.ProcessId!.Value, out readContext, ref error);
                if (opened != 0) throw NativeFailure(opened, error);
                CheckProcessBinding(true);
            }
            var target = new Native.Target { StructSize = (uint)Marshal.SizeOf<Native.Target>(),
                Module = Identity.Module, Version = Identity.Version, Sha256 = Identity.Sha256,
                ModuleBase = Options.Address(Identity.ModuleBase) };
            int created = Native.lc_reader_create(profile, (nuint)profile.Length, ref target, callback, readContext, flags, out reader, ref error);
            if (created != 0) throw NativeFailure(created, error);
            if (heroes is { Length: > 0 }) pinnedHeroes = GCHandle.Alloc(heroes, GCHandleType.Pinned);
            request = new Native.Request { StructSize = (uint)Marshal.SizeOf<Native.Request>(),
                HeroAddresses = pinnedHeroes.IsAllocated ? pinnedHeroes.AddrOfPinnedObject() : IntPtr.Zero,
                HeroCount = (nuint)(heroes?.Length ?? 0), HeroesKnown = heroes == null ? 0u : 1u };
        }
        catch { Dispose(); throw; }
    }

    internal JsonElement Snapshot()
    {
        CheckProcessBinding(false);
        var error = new Native.Error { Message = "" };
        int result = Native.lc_reader_snapshot(reader, ref request, out IntPtr bytes, out nuint length, ref error);
        if (result != 0) throw NativeFailure(result, error);
        try
        {
            if (length > 4 * 1024 * 1024) throw new ReaderException("snapshot_bounds", "Native snapshot exceeds 4 MiB");
            byte[] copied = new byte[(int)length];
            Marshal.Copy(bytes, copied, 0, copied.Length);
            using var doc = JsonDocument.Parse(copied);
            var root = doc.RootElement;
            if (root.GetProperty("synthetic").GetBoolean() != Synthetic)
                throw new ReaderException("synthetic_mismatch", "Native provenance does not match selected source");
            return root.Clone();
        }
        finally { Native.lc_reader_free_buffer(bytes); }
    }
    private static ReaderException NativeFailure(int code, Native.Error error) =>
        new(code switch { 3 => "profile_target_mismatch", 4 => "profile_not_verified", 2 => "invalid_profile", _ => "native_error_" + code }, error.Message);
    private void CheckProcessBinding(bool checkModule)
    {
        if (process == null) return;
        if (process.HasExited) throw new ReaderException("target_exited", "Target process exited; start host again for a new measured identity");
        if (process.StartTime.ToUniversalTime().Ticks != Identity.ProcessStartTimeUtcTicks)
            throw new ReaderException("target_changed", "PID start time changed; refusing stale measured identity");
        if (checkModule)
        {
            process.Refresh();
            var module = process.MainModule;
            if (module == null || !string.Equals(Path.GetFullPath(module.FileName), Path.GetFullPath(Identity.ImagePath!), StringComparison.OrdinalIgnoreCase)
                || "0x" + module.BaseAddress.ToInt64().ToString("x", CultureInfo.InvariantCulture) != Identity.ModuleBase)
                throw new ReaderException("target_changed", "PID module changed; refusing stale measured identity");
        }
    }
    public void Dispose()
    {
        if (reader != IntPtr.Zero) { Native.lc_reader_destroy(reader); reader = IntPtr.Zero; }
        if (pinnedHeroes.IsAllocated) pinnedHeroes.Free();
        if (readContext != IntPtr.Zero) { Native.lc_reader_win32_close(readContext); readContext = IntPtr.Zero; }
        process?.Dispose();
        process = null;
        GC.KeepAlive(callback);
    }
}
