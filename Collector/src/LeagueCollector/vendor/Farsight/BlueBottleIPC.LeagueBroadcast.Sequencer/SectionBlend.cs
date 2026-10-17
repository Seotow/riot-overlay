using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferEnum(typeof(byte))]
public enum SectionBlend : byte
{
	Replace,
	Add,
	Multiply,
	Combine
}
