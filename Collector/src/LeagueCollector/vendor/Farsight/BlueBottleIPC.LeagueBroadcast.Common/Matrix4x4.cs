using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using FlatSharp.Attributes;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Common;

[StructLayout(LayoutKind.Explicit, Size = 64)]
[JsonConverter(typeof(Matrix4x4JsonConverter))]
[FlatBufferStruct]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_valueStruct", "0")]
public struct Matrix4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33) : IEnumerable<float>, IEnumerable
{
	[FieldOffset(0)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(0)")]
	private float __flatsharp__M_0 = m00;

	[FieldOffset(4)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(1)")]
	private float __flatsharp__M_1 = m01;

	[FieldOffset(8)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(2)")]
	private float __flatsharp__M_2 = m02;

	[FieldOffset(12)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(3)")]
	private float __flatsharp__M_3 = m03;

	[FieldOffset(16)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(4)")]
	private float __flatsharp__M_4 = m10;

	[FieldOffset(20)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(5)")]
	private float __flatsharp__M_5 = m11;

	[FieldOffset(24)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(6)")]
	private float __flatsharp__M_6 = m12;

	[FieldOffset(28)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(7)")]
	private float __flatsharp__M_7 = m13;

	[FieldOffset(32)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(8)")]
	private float __flatsharp__M_8 = m20;

	[FieldOffset(36)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(9)")]
	private float __flatsharp__M_9 = m21;

	[FieldOffset(40)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(10)")]
	private float __flatsharp__M_10 = m22;

	[FieldOffset(44)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(11)")]
	private float __flatsharp__M_11 = m23;

	[FieldOffset(48)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(12)")]
	private float __flatsharp__M_12 = m30;

	[FieldOffset(52)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(13)")]
	private float __flatsharp__M_13 = m31;

	[FieldOffset(56)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(14)")]
	private float __flatsharp__M_14 = m32;

	[FieldOffset(60)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(15)")]
	private float __flatsharp__M_15 = m33;

	public unsafe float this[int row, int column]
	{
		get
		{
			if (row < 0 || row > 3 || column < 0 || column > 3)
			{
				throw new ArgumentOutOfRangeException("row", "Row and column indices must be between 0 and 3.");
			}
			fixed (float* _flatsharp__M_ = &__flatsharp__M_0)
			{
				return (_flatsharp__M_ + row * 4)[column];
			}
		}
		set
		{
			if (row < 0 || row > 3 || column < 0 || column > 3)
			{
				throw new ArgumentOutOfRangeException("row", "Row and column indices must be between 0 and 3.");
			}
			fixed (float* _flatsharp__M_ = &__flatsharp__M_0)
			{
				(_flatsharp__M_ + row * 4)[column] = value;
			}
		}
	}

	public unsafe float this[int index]
	{
		get
		{
			if ((index < 0 || index > 15) ? true : false)
			{
				throw new ArgumentOutOfRangeException("index", "Index must be between 0 and 15.");
			}
			fixed (float* _flatsharp__M_ = &__flatsharp__M_0)
			{
				return _flatsharp__M_[index];
			}
		}
		set
		{
			if ((index < 0 || index > 15) ? true : false)
			{
				throw new ArgumentOutOfRangeException("index", "Index must be between 0 and 15.");
			}
			fixed (float* _flatsharp__M_ = &__flatsharp__M_0)
			{
				_flatsharp__M_[index] = value;
			}
		}
	}

	public static Matrix4x4 Zero { get; }

	public int M_Length => 16;

	public unsafe System.Numerics.Matrix4x4 AsNumerics()
	{
		fixed (float* _flatsharp__M_ = &__flatsharp__M_0)
		{
			return *(System.Numerics.Matrix4x4*)_flatsharp__M_;
		}
	}

	public unsafe static Matrix4x4 FromNumerics(System.Numerics.Matrix4x4 matrix)
	{
		return *(Matrix4x4*)(&matrix);
	}

	public bool Invert(out Matrix4x4? result)
	{
		if (!System.Numerics.Matrix4x4.Invert(AsNumerics(), out var result2))
		{
			result = default(Matrix4x4);
			return false;
		}
		result = FromNumerics(result2);
		return true;
	}

	public static Matrix4x4 operator *(Matrix4x4 left, Matrix4x4 right)
	{
		return FromNumerics(left.AsNumerics() * right.AsNumerics());
	}

	public unsafe Vector4 GetRow(int row)
	{
		switch (row)
		{
		case 0:
			fixed (float* _flatsharp__M_ = &__flatsharp__M_0)
			{
				return *(Vector4*)_flatsharp__M_;
			}
		case 1:
			fixed (float* _flatsharp__M_ = &__flatsharp__M_4)
			{
				return *(Vector4*)_flatsharp__M_;
			}
		case 2:
			fixed (float* _flatsharp__M_ = &__flatsharp__M_8)
			{
				return *(Vector4*)_flatsharp__M_;
			}
		case 3:
			fixed (float* _flatsharp__M_ = &__flatsharp__M_12)
			{
				return *(Vector4*)_flatsharp__M_;
			}
		default:
			throw new ArgumentOutOfRangeException("row", "Row index must be between 0 and 3.");
		}
	}

	public IEnumerator<float> GetEnumerator()
	{
		for (int i = 0; i < 16; i++)
		{
			yield return this[i];
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public static ref float M_Item(ref Matrix4x4 item, int index)
	{
		switch (index)
		{
		case 0:
			return ref item.__flatsharp__M_0;
		case 1:
			return ref item.__flatsharp__M_1;
		case 2:
			return ref item.__flatsharp__M_2;
		case 3:
			return ref item.__flatsharp__M_3;
		case 4:
			return ref item.__flatsharp__M_4;
		case 5:
			return ref item.__flatsharp__M_5;
		case 6:
			return ref item.__flatsharp__M_6;
		case 7:
			return ref item.__flatsharp__M_7;
		case 8:
			return ref item.__flatsharp__M_8;
		case 9:
			return ref item.__flatsharp__M_9;
		case 10:
			return ref item.__flatsharp__M_10;
		case 11:
			return ref item.__flatsharp__M_11;
		case 12:
			return ref item.__flatsharp__M_12;
		case 13:
			return ref item.__flatsharp__M_13;
		case 14:
			return ref item.__flatsharp__M_14;
		case 15:
			return ref item.__flatsharp__M_15;
		default:
			FSThrow.IndexOutOfRange();
			goto case 0;
		}
	}
}
