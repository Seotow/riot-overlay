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
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationContribution")]
public class AnimationContribution
{
	[FlatBufferItem(0)]
	public virtual ulong InstanceId { get; set; }

	[FlatBufferItem(1)]
	public virtual uint NameHash { get; set; }

	[FlatBufferItem(2)]
	public virtual float Time { get; set; }

	[FlatBufferItem(3)]
	public virtual float Duration { get; set; }

	[FlatBufferItem(4)]
	public virtual float Weight { get; set; }

	[FlatBufferItem(5)]
	public virtual uint Track { get; set; }

	[FlatBufferItem(6)]
	public virtual AnimationBlendMode BlendMode { get; set; }

	[FlatBufferItem(7)]
	public virtual IList<AnimationJointWeight>? JointWeights { get; set; }

	static AnimationContribution()
	{
	}

	public AnimationContribution()
	{
		InstanceId = 0uL;
		NameHash = 0u;
		Time = 0f;
		Duration = 0f;
		Weight = 0f;
		Track = 0u;
		BlendMode = AnimationBlendMode.Normal;
		JointWeights = null;
	}

	protected AnimationContribution(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AnimationContribution(AnimationContribution source)
	{
		InstanceId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.InstanceId);
		NameHash = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.NameHash);
		Time = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Time);
		Duration = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Duration);
		Weight = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Weight);
		Track = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Track);
		BlendMode = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BlendMode);
		JointWeights = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.JointWeights);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
