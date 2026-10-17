using System;
using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[Flags]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "bit_flags", "0")]
[FlatBufferEnum(typeof(byte))]
public enum AIMinionClientTypeInfo : byte
{
	IsClone = 1,
	IsLaneMinion = 2,
	IsEliteMinion = 4,
	IsEpicMinion = 8,
	IsJungleMinion = 0x10,
	IsWardOrPlant = 0x20
}
