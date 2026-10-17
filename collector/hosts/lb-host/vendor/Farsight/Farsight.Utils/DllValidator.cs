using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Farsight.Exceptions;

namespace Farsight.Utils;

public static class DllValidator
{
	private const ushort DOS_MAGIC = 23117;

	private const uint PE_SIGNATURE = 17744u;

	private const ushort IMAGE_FILE_MACHINE_AMD64 = 34404;

	private const string EXPECTED_EXPORT = "BlueBottleHook";

	public static void Validate(string dllPath)
	{
		if (!File.Exists(dllPath))
		{
			throw new FileNotFoundException("DLL not found: " + dllPath);
		}
		byte[] data;
		try
		{
			data = File.ReadAllBytes(dllPath);
		}
		catch (IOException ex)
		{
			throw new LibValidationException("Cannot read DLL file: " + ex.Message, ex);
		}
		ValidateBytes(data, dllPath);
	}

	public static void ValidateBytes(byte[] data, string? sourceName = null)
	{
		string text = sourceName ?? "DLL";
		if (data.Length < 64)
		{
			throw new LibValidationException($"{text}: File too small to be a valid PE ({data.Length} bytes).");
		}
		ushort num = BitConverter.ToUInt16(data, 0);
		if (num != 23117)
		{
			throw new LibValidationException($"{text}: Invalid DOS header (expected MZ, got 0x{num:X4}). File is corrupt or not a DLL.");
		}
		int num2 = BitConverter.ToInt32(data, 60);
		if (num2 < 0 || num2 + 24 > data.Length)
		{
			throw new LibValidationException($"{text}: Invalid PE header offset (0x{num2:X}). File is corrupt.");
		}
		uint num3 = BitConverter.ToUInt32(data, num2);
		if (num3 != 17744)
		{
			throw new LibValidationException($"{text}: Invalid PE signature (expected 0x{17744u:X8}, got 0x{num3:X8}). File is corrupt.");
		}
		ushort num4 = BitConverter.ToUInt16(data, num2 + 4);
		if (num4 != 34404)
		{
			throw new LibValidationException($"{text}: Wrong architecture (expected x64/AMD64 0x{34404:X4}, got 0x{num4:X4}).");
		}
		ushort num5 = BitConverter.ToUInt16(data, num2 + 4 + 18);
		if ((num5 & 0x2000) == 0)
		{
			throw new LibValidationException($"{text}: PE file is not a DLL (characteristics: 0x{num5:X4}).");
		}
		int num6 = num2 + 24;
		ushort num7 = BitConverter.ToUInt16(data, num6);
		if (num7 != 523)
		{
			throw new LibValidationException($"{text}: Expected PE32+ (x64) optional header magic (0x020B), got 0x{num7:X4}.");
		}
		int num8 = num6 + 112;
		if (num8 + 8 > data.Length)
		{
			throw new LibValidationException(text + ": File truncated before export directory entry.");
		}
		uint num9 = BitConverter.ToUInt32(data, num8);
		uint num10 = BitConverter.ToUInt32(data, num8 + 4);
		if (num9 == 0 || num10 == 0)
		{
			throw new LibValidationException(text + ": DLL has no export directory. Expected 'BlueBottleHook' export.");
		}
		byte[] bytes = Encoding.ASCII.GetBytes("BlueBottleHook");
		if (!ContainsSequence(data, bytes))
		{
			throw new LibValidationException(text + ": Export 'BlueBottleHook' not found in DLL. The file may be corrupt or the wrong version.");
		}
	}

	public static string ComputeMd5Hash(string filePath)
	{
		using FileStream source = File.OpenRead(filePath);
		return Convert.ToHexStringLower(MD5.HashData(source));
	}

	public static string ComputeMd5Hash(byte[] data)
	{
		return Convert.ToHexStringLower(MD5.HashData(data));
	}

	public static bool VerifyMd5(string filePath, string expectedMd5)
	{
		if (string.IsNullOrWhiteSpace(expectedMd5))
		{
			return true;
		}
		string text = expectedMd5.Trim('"');
		if (text.Contains('-'))
		{
			return true;
		}
		return string.Equals(ComputeMd5Hash(filePath), text, StringComparison.OrdinalIgnoreCase);
	}

	private static bool ContainsSequence(byte[] data, byte[] sequence)
	{
		if (sequence.Length == 0)
		{
			return true;
		}
		if (data.Length < sequence.Length)
		{
			return false;
		}
		for (int i = 0; i <= data.Length - sequence.Length; i++)
		{
			bool flag = true;
			for (int j = 0; j < sequence.Length; j++)
			{
				if (data[i + j] != sequence[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return true;
			}
		}
		return false;
	}
}
