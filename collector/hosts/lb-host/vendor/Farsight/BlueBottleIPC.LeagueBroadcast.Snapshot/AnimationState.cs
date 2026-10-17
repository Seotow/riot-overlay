using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationState")]
public class AnimationState
{
	[FlatBufferItem(0, DefaultValue = 1)]
	public virtual ushort Version { get; set; }

	[FlatBufferItem(1)]
	public virtual AnimationStateStatus Status { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<AnimationContribution>? Contributions { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<AnimationPoseNode>? Poses { get; set; }

	[FlatBufferItem(4)]
	public virtual IList<AnimationTrackState>? Tracks { get; set; }

	static AnimationState()
	{
	}

	public AnimationState()
	{
		Version = 1;
		Status = AnimationStateStatus.Unavailable;
		Contributions = null;
		Poses = null;
		Tracks = null;
	}

	protected AnimationState(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AnimationState(AnimationState source)
	{
		Version = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Version);
		Status = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Status);
		Contributions = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Contributions);
		Poses = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Poses);
		Tracks = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Tracks);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
