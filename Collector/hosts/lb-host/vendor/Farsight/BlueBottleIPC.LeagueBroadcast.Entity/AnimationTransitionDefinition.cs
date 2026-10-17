using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NE45C68FE420A1FC00D9860CDCA64CC850967C67FB72ECD5608223354D5C85C4B;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Entity.AnimationTransitionDefinition")]
public class AnimationTransitionDefinition : IFlatBufferSerializable<AnimationTransitionDefinition>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string FromState { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string ToState { get; set; }

	[FlatBufferItem(2)]
	public virtual AnimationTransitionCondition Condition { get; set; }

	[FlatBufferItem(3)]
	public virtual string? Trigger { get; set; }

	[FlatBufferItem(4)]
	public virtual float AfterTime { get; set; }

	[FlatBufferItem(5)]
	public virtual float BlendDuration { get; set; }

	[FlatBufferItem(6)]
	public virtual int Priority { get; set; }

	public static ISerializer<AnimationTransitionDefinition> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<AnimationTransitionDefinition>)this).Serializer;

	ISerializer<AnimationTransitionDefinition> IFlatBufferSerializable<AnimationTransitionDefinition>.Serializer => Serializer;

	private static readonly ISerializer<AnimationTransitionDefinition> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationTransitionDefinition_003E_002ELazySerializer;

	static ISerializer<AnimationTransitionDefinition> IFlatBufferSerializable<AnimationTransitionDefinition>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationTransitionDefinition_003E_002ELazySerializer;

	private static readonly ISerializer<AnimationTransitionDefinition> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationTransitionDefinition_003E_002EGreedySerializer;

	static ISerializer<AnimationTransitionDefinition> IFlatBufferSerializable<AnimationTransitionDefinition>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationTransitionDefinition_003E_002EGreedySerializer;

	private static readonly ISerializer<AnimationTransitionDefinition> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationTransitionDefinition_003E_002EGreedyMutableSerializer;

	static ISerializer<AnimationTransitionDefinition> IFlatBufferSerializable<AnimationTransitionDefinition>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationTransitionDefinition_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<AnimationTransitionDefinition> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationTransitionDefinition_003E_002EProgressiveSerializer;

	static ISerializer<AnimationTransitionDefinition> IFlatBufferSerializable<AnimationTransitionDefinition>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationTransitionDefinition_003E_002EProgressiveSerializer;

	static AnimationTransitionDefinition()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationTransitionDefinition_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationTransitionDefinition_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationTransitionDefinition_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationTransitionDefinition_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public AnimationTransitionDefinition()
	{
		Condition = AnimationTransitionCondition.Trigger;
		Trigger = null;
		AfterTime = 0f;
		BlendDuration = 0f;
		Priority = 0;
	}

	protected AnimationTransitionDefinition(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AnimationTransitionDefinition(AnimationTransitionDefinition source)
	{
		FromState = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FromState);
		ToState = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ToState);
		Condition = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Condition);
		Trigger = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Trigger);
		AfterTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AfterTime);
		BlendDuration = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BlendDuration);
		Priority = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Priority);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
