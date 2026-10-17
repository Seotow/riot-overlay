namespace Farsight.Utils;

public static class HashUtils
{
	private const uint FNV1A_PRIME = 16777619u;

	private const uint FNV1A_SEED = 2166136261u;

	public static uint HashStringFNV1a(string str)
	{
		uint num = 2166136261u;
		foreach (char c in str)
		{
			num ^= c;
			num *= 16777619;
		}
		return num;
	}

	public static uint HashStringCaseInsensitiveFNV1a(string str)
	{
		uint num = 2166136261u;
		foreach (char c in str)
		{
			num ^= char.ToLowerInvariant(c);
			num *= 16777619;
		}
		return num;
	}

	public static uint HashStringCaseInsensitiveELF(string str)
	{
		uint num = 0u;
		foreach (char c in str)
		{
			num = (num << 4) + char.ToLowerInvariant(c);
			uint num2 = num & 0xF0000000u;
			if (num2 != 0)
			{
				num ^= num2 >> 24;
				num &= ~num2;
			}
		}
		return num;
	}
}
