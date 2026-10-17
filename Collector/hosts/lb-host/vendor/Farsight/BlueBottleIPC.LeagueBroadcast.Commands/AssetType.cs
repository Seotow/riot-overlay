using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum AssetType : byte
{
	texture,
	model,
	streamTexture,
	font
}
