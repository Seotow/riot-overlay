using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum SequenceTransportCommand : byte
{
	Play,
	Pause,
	Stop,
	Seek,
	SetRate,
	FireClip,
	StopClip,
	ClearAll
}
