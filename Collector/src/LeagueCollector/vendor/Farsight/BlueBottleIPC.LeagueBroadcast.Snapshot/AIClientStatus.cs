using System;
using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[Flags]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "bit_flags", "0")]
[FlatBufferEnum(typeof(byte))]
public enum AIClientStatus : byte
{
	IsAlive = 1,
	IsZombie = 2,
	IsRecalling = 4,
	IsTargetable = 8
}
