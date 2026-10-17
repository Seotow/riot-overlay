using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(int))]
public enum ServiceType
{
	ZenosLiveSnapshot,
	ZenosFile,
	LeagueBroadcastLiveSnapshot,
	StrokeSync,
	MirrorSync,
	CameraSync
}
