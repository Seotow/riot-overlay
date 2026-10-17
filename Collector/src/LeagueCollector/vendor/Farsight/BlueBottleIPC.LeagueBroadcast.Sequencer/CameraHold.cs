using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferEnum(typeof(byte))]
public enum CameraHold : byte
{
	Idle,
	Driving,
	BlockedByFollower,
	BlockedBySource,
	NoGameCamera
}
