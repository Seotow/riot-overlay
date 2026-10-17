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
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationPoseNode")]
public class AnimationPoseNode
{
	[FlatBufferItem(0, DefaultValue = -1)]
	public virtual int Contribution { get; set; }

	[FlatBufferItem(1, DefaultValue = -1)]
	public virtual int From { get; set; }

	[FlatBufferItem(2, DefaultValue = -1)]
	public virtual int To { get; set; }

	[FlatBufferItem(3)]
	public virtual float Alpha { get; set; }

	[FlatBufferItem(4)]
	public virtual IList<AnimationJointWeight>? JointAlphas { get; set; }

	[FlatBufferItem(5)]
	public virtual IList<AnimationJointWeight>? SampleWeights { get; set; }

	[FlatBufferItem(6)]
	public virtual bool Spherical { get; set; }

	static AnimationPoseNode()
	{
	}

	public AnimationPoseNode()
	{
		Contribution = -1;
		From = -1;
		To = -1;
		Alpha = 0f;
		JointAlphas = null;
		SampleWeights = null;
		Spherical = false;
	}

	protected AnimationPoseNode(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AnimationPoseNode(AnimationPoseNode source)
	{
		Contribution = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Contribution);
		From = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.From);
		To = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.To);
		Alpha = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Alpha);
		JointAlphas = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.JointAlphas);
		SampleWeights = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SampleWeights);
		Spherical = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Spherical);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
