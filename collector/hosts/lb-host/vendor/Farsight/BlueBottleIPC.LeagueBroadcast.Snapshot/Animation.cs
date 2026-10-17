using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferStruct]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.Animation")]
public class Animation
{
	[FlatBufferItem(0)]
	public virtual uint NameHash { get; set; }

	[FlatBufferItem(1)]
	public virtual float AnimationProgress { get; set; }

	static Animation()
	{
	}

	public Animation()
	{
	}

	protected Animation(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Animation(Animation source)
	{
		NameHash = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.NameHash);
		AnimationProgress = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnimationProgress);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
