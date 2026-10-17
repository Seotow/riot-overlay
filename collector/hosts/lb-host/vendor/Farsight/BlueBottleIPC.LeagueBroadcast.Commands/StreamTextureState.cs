using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum StreamTextureState : byte
{
	Idle,
	Connecting,
	Connected,
	Disconnected,
	Failed
}
