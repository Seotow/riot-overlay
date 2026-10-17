using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferStruct]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationJointWeight")]
public class AnimationJointWeight
{
	[FlatBufferItem(0)]
	public virtual uint NameHash { get; set; }

	[FlatBufferItem(1)]
	public virtual float Weight { get; set; }

	static AnimationJointWeight()
	{
	}

	public AnimationJointWeight()
	{
	}

	protected AnimationJointWeight(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AnimationJointWeight(AnimationJointWeight source)
	{
		NameHash = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.NameHash);
		Weight = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Weight);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
