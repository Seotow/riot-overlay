using System.Numerics;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Common;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[JsonConverter(typeof(SnapshotVector4JsonConverter))]
[FlatBufferStruct]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_valueStruct", "0")]
public struct Vector4
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

	public static Vector4 Zero { get; } = new Vector4(0f, 0f, 0f, 0f);

	public unsafe System.Numerics.Vector4 ToVector4()
	{
		fixed (float* x = &X)
		{
			return *(System.Numerics.Vector4*)x;
		}
	}

	public Vector4(float x, float y, float z, float w)
	{
		X = x;
		Y = y;
		Z = z;
		W = w;
	}

	public Vector4(Vector4 other)
	{
		X = other.X;
		Y = other.Y;
		Z = other.Z;
		W = other.W;
	}
}
