using System;
using System.IO;
using System.Text;

namespace Farsight.Launch;

public static class ReplayFile
{
	private static readonly byte[] RiotMagic = new byte[6] { 82, 73, 79, 84, 2, 0 };

	private const int VersionLengthOffset = 14;

	public static bool TryReadGameVersion(string roflPath, out string? gameVersion)
	{
		gameVersion = null;
		try
		{
			using FileStream stream = new FileStream(roflPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			Span<byte> buffer = stackalloc byte[270];
			int num = ReadFull(stream, buffer);
			if (num < 15)
			{
				return false;
			}
			if (!((ReadOnlySpan<byte>)buffer.Slice(0, RiotMagic.Length)).SequenceEqual((ReadOnlySpan<byte>)RiotMagic))
			{
				return false;
			}
			int num2 = buffer[14];
			int num3 = 15;
			if (num2 == 0 || num3 + num2 > num)
			{
				return false;
			}
			gameVersion = Encoding.ASCII.GetString(buffer.Slice(num3, num2));
			return !string.IsNullOrWhiteSpace(gameVersion);
		}
		catch
		{
			return false;
		}
	}

	public static string? PatchOf(string? version)
	{
		if (string.IsNullOrWhiteSpace(version))
		{
			return null;
		}
		string[] array = version.Split('.');
		if (array.Length < 2)
		{
			return null;
		}
		return array[0] + "." + array[1];
	}

	private static int ReadFull(Stream stream, Span<byte> buffer)
	{
		int i;
		int num;
		for (i = 0; i < buffer.Length; i += num)
		{
			num = stream.Read(buffer.Slice(i));
			if (num == 0)
			{
				break;
			}
		}
		return i;
	}
}
