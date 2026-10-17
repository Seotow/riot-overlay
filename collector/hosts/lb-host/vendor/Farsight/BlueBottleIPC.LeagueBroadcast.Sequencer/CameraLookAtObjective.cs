using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferEnum(typeof(byte))]
public enum CameraLookAtObjective : byte
{
	Grubs,
	RiftHerald,
	Dragon,
	Baron
}
