using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace Farsight.Utils;

public static class ByteUtils
{
	public static float[] ConvertToFloatArray(this byte[] bytes)
	{
		if (bytes.Length % 4 != 0)
		{
			throw new ArgumentException("Byte array length must be a multiple of 4");
		}
		float[] array = new float[bytes.Length / 4];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = BitConverter.ToSingle(bytes, i * 4);
		}
		return array;
	}

	public static nint ToIntPtr(this byte[] bytes, int offset = 0)
	{
		return new IntPtr(BitConverter.ToInt64(bytes, offset));
	}

	public static long ToLong(this byte[] bytes, int offset = 0)
	{
		return BitConverter.ToInt64(bytes, offset);
	}

	public static ulong ToULong(this byte[] bytes, int offset = 0)
	{
		return BitConverter.ToUInt64(bytes, offset);
	}

	public static int ToInt(this byte[] bytes, int offset = 0)
	{
		return BitConverter.ToInt32(bytes, offset);
	}

	public static uint ToUInt(this byte[] bytes, int offset = 0)
	{
		return BitConverter.ToUInt32(bytes, offset);
	}

	public static short ToShort(this byte[] bytes, int offset = 0)
	{
		return BitConverter.ToInt16(bytes, offset);
	}

	public static float ToFloat(this byte[] bytes, int offset = 0)
	{
		return BitConverter.ToSingle(bytes, offset);
	}

	public static double ToDouble(this byte[] bytes, int offset = 0)
	{
		return BitConverter.ToDouble(bytes, offset);
	}

	public static Vector3 ToVector3(this byte[] bytes, int offset = 0)
	{
		return new Vector3(bytes.ToFloat(offset), bytes.ToFloat(offset + 4), bytes.ToFloat(offset + 8));
	}

	public static Quaternion ToQuaternion(this byte[] bytes, int offset = 0)
	{
		return new Quaternion
		{
			X = bytes.ToFloat(offset),
			Y = bytes.ToFloat(offset + 4),
			Z = bytes.ToFloat(offset + 8),
			W = bytes.ToFloat(offset + 12)
		};
	}

	public static Matrix4x4 ToMatrix4X4(this byte[] bytes, int offset = 0)
	{
		return new Matrix4x4
		{
			M11 = bytes.ToFloat(offset),
			M12 = bytes.ToFloat(offset + 4),
			M13 = bytes.ToFloat(offset + 8),
			M14 = bytes.ToFloat(offset + 12),
			M21 = bytes.ToFloat(offset + 16),
			M22 = bytes.ToFloat(offset + 20),
			M23 = bytes.ToFloat(offset + 24),
			M24 = bytes.ToFloat(offset + 28),
			M31 = bytes.ToFloat(offset + 32),
			M32 = bytes.ToFloat(offset + 36),
			M33 = bytes.ToFloat(offset + 40),
			M34 = bytes.ToFloat(offset + 44),
			M41 = bytes.ToFloat(offset + 48),
			M42 = bytes.ToFloat(offset + 52),
			M43 = bytes.ToFloat(offset + 56),
			M44 = bytes.ToFloat(offset + 60)
		};
	}

	public static bool IsAscii(this IEnumerable<byte> bytes)
	{
		return bytes.All((byte t) => t <= 127);
	}

	public static string DecodeAscii(this byte[] bytes)
	{
		int num = Array.IndexOf(bytes, (byte)0, 0);
		if (num < 0)
		{
			num = bytes.Length;
		}
		return Encoding.ASCII.GetString(bytes, 0, num);
	}

	public static T ToStructure<T>(this byte[] bytes) where T : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
		try
		{
			return (T)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(T));
		}
		finally
		{
			gCHandle.Free();
		}
	}

	public static T[] SubArray<T>(this T[] array, int offset, int length)
	{
		T[] array2 = new T[length];
		Array.Copy(array, offset, array2, 0, length);
		return array2;
	}

	public static void Write(this byte[] dest, byte[] input)
	{
		dest.Write(0, input);
	}

	public static void Write(this byte[] dest, int offset, byte[] input)
	{
		Array.Copy(input, 0, dest, offset, input.Length);
	}

	public static void Write(this char[] dest, byte[] input)
	{
		dest.Write(0, input);
	}

	public static void Write(this char[] dest, int offset, byte[] input)
	{
		Array.Copy(input, 0, dest, offset, input.Length);
	}

	public static float ReadSingle(this byte[] bytes, ref int offset)
	{
		float result = BitConverter.ToSingle(bytes, offset);
		offset += 4;
		return result;
	}

	public static double ReadDouble(this byte[] bytes, ref int offset)
	{
		double result = BitConverter.ToDouble(bytes, offset);
		offset += 8;
		return result;
	}

	public static int ReadInt32(this byte[] bytes, ref int offset)
	{
		int result = BitConverter.ToInt32(bytes, offset);
		offset += 4;
		return result;
	}

	public static uint ReadUInt32(this byte[] bytes, ref int offset)
	{
		uint result = BitConverter.ToUInt32(bytes, offset);
		offset += 4;
		return result;
	}

	public static long ReadInt64(this byte[] bytes, ref int offset)
	{
		long result = BitConverter.ToInt64(bytes, offset);
		offset += 8;
		return result;
	}

	public static ulong ReadUInt64(this byte[] bytes, ref int offset)
	{
		ulong result = BitConverter.ToUInt64(bytes, offset);
		offset += 8;
		return result;
	}

	public static Vector3 ReadVector3(this byte[] bytes, ref int offset)
	{
		return new Vector3(bytes.ReadSingle(ref offset), bytes.ReadSingle(ref offset), bytes.ReadSingle(ref offset));
	}

	public static short ReadInt16(this byte[] bytes, ref int offset)
	{
		short result = BitConverter.ToInt16(bytes, offset);
		offset += 2;
		return result;
	}

	public static ushort ReadUInt16(this byte[] bytes, ref int offset)
	{
		ushort result = BitConverter.ToUInt16(bytes, offset);
		offset += 2;
		return result;
	}

	public static byte ReadByte(this byte[] bytes, ref int offset)
	{
		byte result = bytes[offset];
		offset++;
		return result;
	}

	public static byte[] ReadBytes(this byte[] bytes, ref int offset, int length)
	{
		byte[] result = bytes.SubArray(offset, length);
		offset += length;
		return result;
	}

	public static T ReadEnum<T>(this byte[] bytes, ref int offset) where T : Enum
	{
		Type underlyingType = Enum.GetUnderlyingType(typeof(T));
		int num = Marshal.SizeOf(underlyingType);
		byte[] array = bytes.SubArray(offset, num);
		offset += num;
		Type type = underlyingType;
		if ((object)type != null)
		{
			object obj;
			if (type == typeof(byte))
			{
				obj = array[0];
			}
			else if (type == typeof(short))
			{
				obj = BitConverter.ToInt16(array, 0);
			}
			else if (type == typeof(ushort))
			{
				obj = BitConverter.ToUInt16(array, 0);
			}
			else if (type == typeof(int))
			{
				obj = BitConverter.ToInt32(array, 0);
			}
			else if (type == typeof(uint))
			{
				obj = BitConverter.ToUInt32(array, 0);
			}
			else if (type == typeof(long))
			{
				obj = BitConverter.ToInt64(array, 0);
			}
			else
			{
				if (!(type == typeof(ulong)))
				{
					goto IL_012e;
				}
				obj = BitConverter.ToUInt64(array, 0);
			}
			object value = obj;
			return (T)Enum.ToObject(typeof(T), value);
		}
		goto IL_012e;
		IL_012e:
		throw new NotSupportedException($"Unsupported underlying type {underlyingType}");
	}
}
