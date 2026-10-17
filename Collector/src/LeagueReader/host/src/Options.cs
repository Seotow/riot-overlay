using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace IndependentCollector;

internal sealed record Options(int? ProcessId, string? Profile, string? Fixture, ulong[]? Heroes,
    bool AllowUnverified, bool Identity, int Port, int Interval, string? Record)
{
    public static Options Parse(string[] args)
    {
        int? pid = null;
        string? profile = null, fixture = null, record = null;
        ulong[]? heroes = null;
        bool allow = false, identity = false;
        int port = 18801, interval = 100;
        var used = new HashSet<string>(StringComparer.Ordinal);
        for (int i = 0; i < args.Length; i++)
        {
            string key = args[i];
            if (!used.Add(key)) throw new ArgumentException("Duplicate option: " + key);
            string Value() => ++i < args.Length ? args[i] : throw new ArgumentException("Missing option value");
            switch (key)
            {
                case "--pid": pid = int.Parse(Value(), CultureInfo.InvariantCulture); break;
                case "--profile": profile = Value(); break;
                case "--fixture": fixture = Value(); break;
                case "--record": record = Value(); break;
                case "--heroes":
                    heroes = Value().Split(',').Select(Address).ToArray();
                    if (heroes.Length is < 1 or > 64) throw new ArgumentException("Expected 1..64 hero addresses");
                    break;
                case "--allow-unverified-profile": allow = true; break;
                case "--identity": identity = true; break;
                case "--port": port = int.Parse(Value(), CultureInfo.InvariantCulture); break;
                case "--interval": interval = int.Parse(Value(), CultureInfo.InvariantCulture); break;
                default: throw new ArgumentException("Unknown option: " + key);
            }
        }
        if (pid is <= 0 || port is < 1024 or > 65535 || interval is < 50 or > 5000)
            throw new ArgumentException("Invalid PID, port or interval");
        if (identity)
        {
            if (!pid.HasValue || fixture != null || profile != null || heroes != null || allow || record != null)
                throw new ArgumentException("--identity requires only --pid");
        }
        else
        {
            if (string.IsNullOrWhiteSpace(profile) || pid.HasValue == (fixture != null))
                throw new ArgumentException("Provide --profile and exactly one of --pid or --fixture");
            if (fixture != null && (heroes != null || allow))
                throw new ArgumentException("Fixture supplies its own roots and cannot enable real experimental profiles");
        }
        return new Options(pid, profile, fixture, heroes, allow, identity, port, interval, record);
    }

    public static ulong Address(string value)
    {
        if (!value.StartsWith("0x", StringComparison.OrdinalIgnoreCase) || value.Length < 3)
            throw new ArgumentException("Addresses must use 0x hexadecimal form");
        return ulong.Parse(value.AsSpan(2), NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture);
    }
}
