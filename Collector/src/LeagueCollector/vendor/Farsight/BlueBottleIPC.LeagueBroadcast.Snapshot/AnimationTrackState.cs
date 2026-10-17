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
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationTrackState")]
public class AnimationTrackState
{
	[FlatBufferItem(0)]
	public virtual uint Track { get; set; }

	[FlatBufferItem(1)]
	public virtual int Root { get; set; }

	[FlatBufferItem(2)]
	public virtual float Weight { get; set; }

	[FlatBufferItem(3)]
	public virtual AnimationBlendMode BlendMode { get; set; }

	[FlatBufferItem(4)]
	public virtual IList<AnimationJointWeight>? JointWeights { get; set; }

	static AnimationTrackState()
	{
	}

	public AnimationTrackState()
	{
		Track = 0u;
		Root = 0;
		Weight = 0f;
		BlendMode = AnimationBlendMode.Normal;
		JointWeights = null;
	}

	protected AnimationTrackState(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AnimationTrackState(AnimationTrackState source)
	{
		Track = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Track);
		Root = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Root);
		Weight = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Weight);
		BlendMode = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BlendMode);
		JointWeights = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.JointWeights);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
