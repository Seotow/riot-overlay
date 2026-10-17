using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(uint))]
public enum Feature : uint
{
	BasicTier,
	ProTier,
	EnterpriseTier,
	Decals,
	Models,
	Strokes,
	Strokes_Cloud,
	Coaching,
	Coaching_Cloud,
	Develop,
	Cinematics,
	HostedWorkspaces,
	Strokes_Remote,
	Strokes_Sync,
	Mirror_Sync
}
