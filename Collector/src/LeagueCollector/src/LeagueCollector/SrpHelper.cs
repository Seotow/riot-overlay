// Recovered SRP helper from LB; namespace/type name adapted. See THIRD-PARTY.md.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace LeagueCollector.Auth;

internal sealed class SrpHelper
{
	private const string N_HEX = "FFFFFFFFFFFFFFFFC90FDAA22168C234C4C6628B80DC1CD129024E088A67CC74020BBEA63B139B22514A08798E3404DDEF9519B3CD3A431B302B0A6DF25F14374FE1356D6D51C245E485B576625E7EC6F44C42E9A637ED6B0BFF5CB6F406B7EDEE386BFB5A899FA5AE9F24117C4B1FE649286651ECE45B3DC2007CB8A163BF0598DA48361C55D39A69163FA8FD24CF5F83655D23DCA3AD961C62F356208552BB9ED529077096966D670C354E4ABC9804F1746C08CA18217C32905E462E36CE3BE39E772C180E86039B2783A2EC07A28FB5C55DF06F4C52C9DE2BCBF6955817183995497CEA956AE515D2261898FA051015728E5A8AAAC42DAD33170D04507A33A85521ABDF1CBA64ECFB850458DBEF0A8AEA71575D060C7DB3970F85A6E1E4C7ABF5AE8CDB0933D71E8C94E04A25619DCEE3D2261AD2EE6BF12FFA06D98A0864D87602733EC86A64521F2B18177B200CBBE117577A615D6C770988C0BAD946E208E24FA074E5AB3143DB5BFCE0FD108E4B82D120A93AD2CAFFFFFFFFFFFFFFFF";

	private const string G_HEX = "2";

	private static readonly BigInteger N = HexToLong("FFFFFFFFFFFFFFFFC90FDAA22168C234C4C6628B80DC1CD129024E088A67CC74020BBEA63B139B22514A08798E3404DDEF9519B3CD3A431B302B0A6DF25F14374FE1356D6D51C245E485B576625E7EC6F44C42E9A637ED6B0BFF5CB6F406B7EDEE386BFB5A899FA5AE9F24117C4B1FE649286651ECE45B3DC2007CB8A163BF0598DA48361C55D39A69163FA8FD24CF5F83655D23DCA3AD961C62F356208552BB9ED529077096966D670C354E4ABC9804F1746C08CA18217C32905E462E36CE3BE39E772C180E86039B2783A2EC07A28FB5C55DF06F4C52C9DE2BCBF6955817183995497CEA956AE515D2261898FA051015728E5A8AAAC42DAD33170D04507A33A85521ABDF1CBA64ECFB850458DBEF0A8AEA71575D060C7DB3970F85A6E1E4C7ABF5AE8CDB0933D71E8C94E04A25619DCEE3D2261AD2EE6BF12FFA06D98A0864D87602733EC86A64521F2B18177B200CBBE117577A615D6C770988C0BAD946E208E24FA074E5AB3143DB5BFCE0FD108E4B82D120A93AD2CAFFFFFFFFFFFFFFFF");

	private static readonly BigInteger g = HexToLong("2");

	private static readonly BigInteger k = HexToLong(HexHash("00FFFFFFFFFFFFFFFFC90FDAA22168C234C4C6628B80DC1CD129024E088A67CC74020BBEA63B139B22514A08798E3404DDEF9519B3CD3A431B302B0A6DF25F14374FE1356D6D51C245E485B576625E7EC6F44C42E9A637ED6B0BFF5CB6F406B7EDEE386BFB5A899FA5AE9F24117C4B1FE649286651ECE45B3DC2007CB8A163BF0598DA48361C55D39A69163FA8FD24CF5F83655D23DCA3AD961C62F356208552BB9ED529077096966D670C354E4ABC9804F1746C08CA18217C32905E462E36CE3BE39E772C180E86039B2783A2EC07A28FB5C55DF06F4C52C9DE2BCBF6955817183995497CEA956AE515D2261898FA051015728E5A8AAAC42DAD33170D04507A33A85521ABDF1CBA64ECFB850458DBEF0A8AEA71575D060C7DB3970F85A6E1E4C7ABF5AE8CDB0933D71E8C94E04A25619DCEE3D2261AD2EE6BF12FFA06D98A0864D87602733EC86A64521F2B18177B200CBBE117577A615D6C770988C0BAD946E208E24FA074E5AB3143DB5BFCE0FD108E4B82D120A93AD2CAFFFFFFFFFFFFFFFF02"));

	private readonly string _poolShortName;

	private readonly BigInteger _a;

	private readonly BigInteger _A;

	public string SrpA { get; }

	public SrpHelper(string userPoolId)
	{
		int num = userPoolId.IndexOf('_');
		_poolShortName = ((num >= 0) ? userPoolId.Substring(num + 1) : userPoolId);
		byte[] array = new byte[128];
		RandomNumberGenerator.Fill(array);
		_a = HexToLong(Convert.ToHexString(array).ToLowerInvariant()) % N;
		_A = BigInteger.ModPow(g, _a, N);
		if (_A % N == BigInteger.Zero)
		{
			throw new InvalidOperationException("A mod N is zero — regenerate a.");
		}
		SrpA = LongToHex(_A);
	}

	public Dictionary<string, string> GetClaimResponse(string password, string username, string saltHex, string serverBHex, string secretBlock, string clientId)
	{
		BigInteger bigInteger = HexToLong(serverBHex);
		if (bigInteger % N == BigInteger.Zero) throw new InvalidOperationException("Invalid SRP B.");
		BigInteger bigInteger2 = HexToLong(HexHash(PadHex(_A) + PadHex(bigInteger)));
		if (bigInteger2.IsZero)
		{
			throw new InvalidOperationException("u is zero.");
		}
		string text = HashSha256Hex(Encoding.UTF8.GetBytes(_poolShortName + username + ":" + password));
		BigInteger bigInteger3 = HexToLong(HexHash(PadHex(HexToLong(saltHex)) + text));
		BigInteger bigInteger4 = BigInteger.ModPow(g, bigInteger3, N);
		BigInteger bigInteger5 = k * bigInteger4;
		byte[] key = ComputeHkdf(FromHex(PadHex(BigInteger.ModPow(((bigInteger - bigInteger5) % N + N) % N, _a + bigInteger2 * bigInteger3, N))), FromHex(PadHex(bigInteger2)));
		string text2 = DateTime.UtcNow.ToString("ddd MMM d HH:mm:ss \"UTC\" yyyy", CultureInfo.InvariantCulture);
		List<byte> list = new List<byte>();
		list.AddRange(Encoding.UTF8.GetBytes(_poolShortName));
		list.AddRange(Encoding.UTF8.GetBytes(username));
		list.AddRange(Convert.FromBase64String(secretBlock));
		list.AddRange(Encoding.UTF8.GetBytes(text2));
		byte[] data = list.ToArray();
		byte[] inArray = HmacSha256(key, data);
		return new Dictionary<string, string>
		{
			["USERNAME"] = username,
			["PASSWORD_CLAIM_SECRET_BLOCK"] = secretBlock,
			["PASSWORD_CLAIM_SIGNATURE"] = Convert.ToBase64String(inArray),
			["TIMESTAMP"] = text2
		};
	}

	private static string PadHex(BigInteger n)
	{
		string text = LongToHex(n);
		if (text.Length % 2 == 1)
		{
			text = "0" + text;
		}
		else if ("89abcdef".Contains(text[0]))
		{
			text = "00" + text;
		}
		return text;
	}

	private static string HexHash(string hexStr)
	{
		return HashSha256Hex(FromHex(hexStr));
	}

	private static string HashSha256Hex(byte[] data)
	{
		return Convert.ToHexString(SHA256.HashData(data)).ToLowerInvariant().PadLeft(64, '0');
	}

	private static byte[] ComputeHkdf(byte[] ikm, byte[] salt)
	{
		byte[] key = HmacSha256(salt, ikm);
		byte[] bytes = Encoding.UTF8.GetBytes("Caldera Derived Key");
		int num = 0;
		byte[] array = new byte[1 + bytes.Length];
		ReadOnlySpan<byte> readOnlySpan = new ReadOnlySpan<byte>(bytes);
		readOnlySpan.CopyTo(new Span<byte>(array).Slice(num, readOnlySpan.Length));
		num += readOnlySpan.Length;
		array[num] = 1;
		byte[] data = array;
		return HmacSha256(key, data)[..16];
	}

	private static byte[] HmacSha256(byte[] key, byte[] data)
	{
		using HMACSHA256 hMACSHA = new HMACSHA256(key);
		return hMACSHA.ComputeHash(data);
	}

	private static BigInteger HexToLong(string hex)
	{
		return BigInteger.Parse("0" + hex, NumberStyles.HexNumber);
	}

	private static string LongToHex(BigInteger n)
	{
		return n.ToString("x");
	}

	private static byte[] FromHex(string hex)
	{
		if (hex.Length % 2 != 0)
		{
			hex = "0" + hex;
		}
		return Convert.FromHexString(hex);
	}
}
