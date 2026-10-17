using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferEnum(typeof(uint))]
public enum SimpleResponseKind : uint
{
	RegisterSuccess,
	RegisterError,
	UnregisterSuccess,
	UnregisterError,
	ProveSubTierSuccess,
	ProveSubTierError,
	PlaybackSpeedChangeSuccess,
	PlaybackSpeedChangeError,
	GenericSuccess,
	GenericError,
	Quit
}
