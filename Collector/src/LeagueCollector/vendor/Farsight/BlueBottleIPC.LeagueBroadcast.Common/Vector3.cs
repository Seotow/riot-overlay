using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Common;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[JsonConverter(typeof(SnapshotVector3JsonConverter))]
[FlatBufferStruct]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_valueStruct", "0")]
public struct Vector3
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

	public static Vector3 Zero { get; } = new Vector3(0f, 0f, 0f);

	public static Vector3 One { get; } = new Vector3(1f, 1f, 1f);

	public unsafe System.Numerics.Vector3 ToNumerics()
	{
		fixed (float* x = &X)
		{
			return *(System.Numerics.Vector3*)x;
		}
	}

	public Vector3(float x, float y, float z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public Vector3(Vector3 other)
	{
		X = other.X;
		Y = other.Y;
		Z = other.Z;
	}

	public static Vector3 operator -(Vector3 a, Vector3 b)
	{
		return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
	}

	public static Vector3 operator +(Vector3 a, Vector3 b)
	{
		return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
	}

	public static Vector3 operator *(Vector3 a, float b)
	{
		return new Vector3(a.X * b, a.Y * b, a.Z * b);
	}

	public static Vector3 operator *(float a, Vector3 b)
	{
		return new Vector3(a * b.X, a * b.Y, a * b.Z);
	}

	public static Vector3 operator *(Vector3 a, Vector3 b)
	{
		return new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
	}

	public static Vector3 operator /(Vector3 a, float b)
	{
		return new Vector3(a.X / b, a.Y / b, a.Z / b);
	}

	public static Vector3 operator /(float a, Vector3 b)
	{
		return new Vector3(a / b.X, a / b.Y, a / b.Z);
	}

	public static Vector3 operator /(Vector3 a, Vector3 b)
	{
		return new Vector3(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
	}

	public static implicit operator System.Numerics.Vector3(Vector3 v)
	{
		return v.ToNumerics();
	}

	public static implicit operator Vector3(System.Numerics.Vector3 v)
	{
		return new Vector3(v.X, v.Y, v.Z);
	}

	public readonly float DistanceSquared(Vector3 other)
	{
		float num = X - other.X;
		float num2 = Y - other.Y;
		float num3 = Z - other.Z;
		return num * num + num2 * num2 + num3 * num3;
	}

	public static float DistanceSquared(Vector3 a, Vector3 b)
	{
		float num = a.X - b.X;
		float num2 = a.Y - b.Y;
		float num3 = a.Z - b.Z;
		return num * num + num2 * num2 + num3 * num3;
	}

	public readonly float Distance(Vector3? other)
	{
		if (!other.HasValue)
		{
			return Length();
		}
		return MathF.Sqrt(DistanceSquared(other.Value));
	}

	public static float Distance(Vector3 a, Vector3 b)
	{
		return MathF.Sqrt(DistanceSquared(a, b));
	}

	public readonly Vector3 Normalized()
	{
		Vector3 result = new Vector3(this);
		result.Normalize();
		return result;
	}

	public static Vector3 Normalized(Vector3 instance)
	{
		Vector3 result = new Vector3(instance);
		result.Normalize();
		return result;
	}

	public void Normalize()
	{
		float num = Length();
		if (num != 0f)
		{
			X /= num;
			Y /= num;
			Z /= num;
		}
	}

	public readonly float Length()
	{
		return MathF.Sqrt(X * X + Y * Y + Z * Z);
	}
}
