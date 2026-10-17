using System.IO;
using System.Security.Cryptography;

namespace Farsight.Utils;

public static class CredentialProtector
{
	private static readonly byte[] s_entropy = new byte[8] { 104, 13, 94, 135, 204, 100, 219, 219 };

	public static byte[] Protect(byte[] plaintext)
	{
		byte[] array = new byte[32];
		byte[] array2 = new byte[12];
		RandomNumberGenerator.Fill(array);
		RandomNumberGenerator.Fill(array2);
		byte[] array3 = new byte[plaintext.Length];
		byte[] array4 = new byte[16];
		using (ChaCha20Poly1305 chaCha20Poly = new ChaCha20Poly1305(array))
		{
			chaCha20Poly.Encrypt(array2, plaintext, array3, array4);
		}
		byte[] userData;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			binaryWriter.Write(array);
			binaryWriter.Write(array2);
			binaryWriter.Write(array4);
			binaryWriter.Write(array3);
			userData = memoryStream.ToArray();
		}
		return ProtectedData.Protect(userData, s_entropy, DataProtectionScope.CurrentUser);
	}

	public static byte[] Unprotect(byte[] protectedData)
	{
		using MemoryStream memoryStream = new MemoryStream(ProtectedData.Unprotect(protectedData, s_entropy, DataProtectionScope.CurrentUser));
		using BinaryReader binaryReader = new BinaryReader(memoryStream);
		byte[] key = binaryReader.ReadBytes(32);
		byte[] nonce = binaryReader.ReadBytes(12);
		byte[] tag = binaryReader.ReadBytes(16);
		byte[] array = binaryReader.ReadBytes((int)(memoryStream.Length - memoryStream.Position));
		byte[] array2 = new byte[array.Length];
		using (ChaCha20Poly1305 chaCha20Poly = new ChaCha20Poly1305(key))
		{
			chaCha20Poly.Decrypt(nonce, array, tag, array2);
		}
		return array2;
	}
}
