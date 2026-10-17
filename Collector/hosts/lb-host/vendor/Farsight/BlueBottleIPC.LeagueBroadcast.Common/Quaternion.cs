using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Common;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[JsonConverter(typeof(SnapshotQuaternionJsonConverter))]
[FlatBufferStruct]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_valueStruct", "0")]
public struct Quaternion : IEnumerable<float>, IEnumerable
{
	[FieldOffset(0)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "X")]
	public float X;

	[FieldOffset(4)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Y")]
	public float Y;

	[FieldOffset(8)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Z")]
	public float Z;

	[FieldOffset(12)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "W")]
	public float W;

	public unsafe float this[int index]
	{
		get
		{
			if ((index < 0 || index > 3) ? true : false)
			{
				throw new ArgumentOutOfRangeException("index", "Index must be between 0 and 3.");
			}
			fixed (float* x = &X)
			{
				return x[index];
			}
		}
		set
		{
			if ((index < 0 || index > 3) ? true : false)
			{
				throw new ArgumentOutOfRangeException("index", "Index must be between 0 and 3.");
			}
			fixed (float* x = &X)
			{
				x[index] = value;
			}
		}
	}

	public static Quaternion Identity { get; } = new Quaternion(0f, 0f, 0f, 1f);

	public Quaternion(float x, float y, float z, float w)
	{
		X = x;
		Y = y;
		Z = z;
		W = w;
	}

	public Quaternion(Quaternion other)
	{
		X = other.X;
		Y = other.Y;
		Z = other.Z;
		W = other.W;
	}

	public IEnumerator<float> GetEnumerator()
	{
		for (int i = 0; i < 4; i++)
		{
			yield return this[i];
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public static implicit operator System.Numerics.Quaternion(Quaternion q)
	{
		return new System.Numerics.Quaternion(q.X, q.Y, q.Z, q.W);
	}

	public static implicit operator Quaternion(System.Numerics.Quaternion q)
	{
		return new Quaternion(q.X, q.Y, q.Z, q.W);
	}

	public static bool operator ==(Quaternion a, Quaternion b)
	{
		if (a.X == b.X && a.Y == b.Y && a.Z == b.Z)
		{
			return a.W == b.W;
		}
		return false;
	}

	public static bool operator !=(Quaternion a, Quaternion b)
	{
		return !(a == b);
	}

	public override readonly bool Equals(object? obj)
	{
		if (!(obj is Quaternion quaternion))
		{
			return false;
		}
		return this == quaternion;
	}

	public override readonly int GetHashCode()
	{
		return HashCode.Combine(X, Y, Z, W);
	}

	public static Quaternion operator +(Quaternion a, Quaternion b)
	{
		System.Numerics.Quaternion quaternion = a;
		System.Numerics.Quaternion quaternion2 = b;
		return quaternion + quaternion2;
	}

	public static Quaternion operator -(Quaternion a, Quaternion b)
	{
		System.Numerics.Quaternion quaternion = a;
		System.Numerics.Quaternion quaternion2 = b;
		return quaternion - quaternion2;
	}

	public static Quaternion operator *(Quaternion a, Quaternion b)
	{
		System.Numerics.Quaternion quaternion = a;
		System.Numerics.Quaternion quaternion2 = b;
		return quaternion * quaternion2;
	}

	public static Quaternion operator /(Quaternion a, Quaternion b)
	{
		System.Numerics.Quaternion quaternion = a;
		System.Numerics.Quaternion quaternion2 = b;
		return quaternion / quaternion2;
	}
}
