using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using FlatSharp.Attributes;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Common;

[StructLayout(LayoutKind.Explicit, Size = 36)]
[JsonConverter(typeof(SnapshotMatrix3x3JsonConverter))]
[FlatBufferStruct]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_valueStruct", "0")]
public struct Matrix3x3 : IEnumerable<float>, IEnumerable
{
	[FieldOffset(0)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(0)")]
	private float __flatsharp__M_0;

	[FieldOffset(4)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(1)")]
	private float __flatsharp__M_1;

	[FieldOffset(8)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(2)")]
	private float __flatsharp__M_2;

	[FieldOffset(12)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(3)")]
	private float __flatsharp__M_3;

	[FieldOffset(16)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(4)")]
	private float __flatsharp__M_4;

	[FieldOffset(20)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(5)")]
	private float __flatsharp__M_5;

	[FieldOffset(24)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(6)")]
	private float __flatsharp__M_6;

	[FieldOffset(28)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(7)")]
	private float __flatsharp__M_7;

	[FieldOffset(32)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "M(8)")]
	private float __flatsharp__M_8;

	public unsafe float this[int row, int column]
	{
		get
		{
			if (row < 0 || row > 2 || column < 0 || column > 2)
			{
				throw new ArgumentOutOfRangeException("row", "Row and column indices must be between 0 and 2.");
			}
			fixed (float* _flatsharp__M_ = &__flatsharp__M_0)
			{
				return (_flatsharp__M_ + row * 3)[column];
			}
		}
		set
		{
			if (row < 0 || row > 2 || column < 0 || column > 2)
			{
				throw new ArgumentOutOfRangeException("row", "Row and column indices must be between 0 and 2.");
			}
			fixed (float* _flatsharp__M_ = &__flatsharp__M_0)
			{
				(_flatsharp__M_ + row * 3)[column] = value;
			}
		}
	}

	public unsafe float this[int index]
	{
		get
		{
			if ((index < 0 || index > 8) ? true : false)
			{
				throw new ArgumentOutOfRangeException("index", "Index must be between 0 and 8.");
			}
			fixed (float* _flatsharp__M_ = &__flatsharp__M_0)
			{
				return _flatsharp__M_[index];
			}
		}
		set
		{
			if ((index < 0 || index > 8) ? true : false)
			{
				throw new ArgumentOutOfRangeException("index", "Index must be between 0 and 8.");
			}
			fixed (float* _flatsharp__M_ = &__flatsharp__M_0)
			{
				_flatsharp__M_[index] = value;
			}
		}
	}

	public static Matrix3x3 Zero { get; }

	public int M_Length => 9;

	public static Matrix3x3 operator *(Matrix3x3 left, Matrix3x3 right)
	{
		Matrix3x3 result = default;
		for (int i = 0; i < 3; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				result[i, j] = left[i, 0] * right[0, j] + left[i, 1] * right[1, j] + left[i, 2] * right[2, j];
			}
		}
		return result;
	}

	public unsafe Vector3 GetRow(int row)
	{
		switch (row)
		{
		case 0:
			fixed (float* _flatsharp__M_ = &__flatsharp__M_0)
			{
				return *(Vector3*)_flatsharp__M_;
			}
		case 1:
			fixed (float* _flatsharp__M_ = &__flatsharp__M_3)
			{
				return *(Vector3*)_flatsharp__M_;
			}
		case 2:
			fixed (float* _flatsharp__M_ = &__flatsharp__M_6)
			{
				return *(Vector3*)_flatsharp__M_;
			}
		default:
			throw new ArgumentOutOfRangeException("row", "Row index must be between 0 and 2.");
		}
	}

	public IEnumerator<float> GetEnumerator()
	{
		for (int i = 0; i < 9; i++)
		{
			yield return this[i];
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public static ref float M_Item(ref Matrix3x3 item, int index)
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
		default:
			FSThrow.IndexOutOfRange();
			goto case 0;
		}
	}
}
