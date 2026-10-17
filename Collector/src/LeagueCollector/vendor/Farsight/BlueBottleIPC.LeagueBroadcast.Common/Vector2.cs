using System.Numerics;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Common;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[JsonConverter(typeof(SnapshotVector2JsonConverter))]
[FlatBufferStruct]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_valueStruct", "0")]
public struct Vector2
{
	[FieldOffset(0)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "X")]
	public float X;

	[FieldOffset(4)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Y")]
	public float Y;

	public static Vector2 Zero { get; } = new Vector2(0f, 0f);

	public unsafe System.Numerics.Vector2 ToVector2()
	{
		fixed (float* x = &X)
		{
			return *(System.Numerics.Vector2*)x;
		}
	}

	public Vector2(float x, float y)
	{
		X = x;
		Y = y;
	}

	public Vector2(Vector2 other)
	{
		X = other.X;
		Y = other.Y;
	}
}
