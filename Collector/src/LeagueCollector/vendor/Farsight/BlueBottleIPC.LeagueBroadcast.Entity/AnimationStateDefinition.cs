using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NF1655621F224A077756AD5B696369AACD1355A8756AAAF1E7B1252128D4FD16E;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Entity.AnimationStateDefinition")]
public class AnimationStateDefinition : IFlatBufferSerializable<AnimationStateDefinition>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Name { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Clip { get; set; }

	[FlatBufferItem(2, DefaultValue = 1f)]
	public virtual float Speed { get; set; }

	[FlatBufferItem(3, DefaultValue = true)]
	public virtual bool Loop { get; set; }

	[FlatBufferItem(4)]
	public virtual float PositionX { get; set; }

	[FlatBufferItem(5)]
	public virtual float PositionY { get; set; }

	[FlatBufferItem(6)]
	public virtual string? Group { get; set; }

	public static ISerializer<AnimationStateDefinition> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<AnimationStateDefinition>)this).Serializer;

	ISerializer<AnimationStateDefinition> IFlatBufferSerializable<AnimationStateDefinition>.Serializer => Serializer;

	private static readonly ISerializer<AnimationStateDefinition> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationStateDefinition_003E_002ELazySerializer;

	static ISerializer<AnimationStateDefinition> IFlatBufferSerializable<AnimationStateDefinition>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationStateDefinition_003E_002ELazySerializer;

	private static readonly ISerializer<AnimationStateDefinition> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationStateDefinition_003E_002EGreedySerializer;

	static ISerializer<AnimationStateDefinition> IFlatBufferSerializable<AnimationStateDefinition>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationStateDefinition_003E_002EGreedySerializer;

	private static readonly ISerializer<AnimationStateDefinition> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationStateDefinition_003E_002EGreedyMutableSerializer;

	static ISerializer<AnimationStateDefinition> IFlatBufferSerializable<AnimationStateDefinition>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationStateDefinition_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<AnimationStateDefinition> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationStateDefinition_003E_002EProgressiveSerializer;

	static ISerializer<AnimationStateDefinition> IFlatBufferSerializable<AnimationStateDefinition>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationStateDefinition_003E_002EProgressiveSerializer;

	static AnimationStateDefinition()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationStateDefinition_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationStateDefinition_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationStateDefinition_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EAnimationStateDefinition_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public AnimationStateDefinition()
	{
		Clip = null;
		Speed = 1f;
		Loop = true;
		PositionX = 0f;
		PositionY = 0f;
		Group = null;
	}

	protected AnimationStateDefinition(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AnimationStateDefinition(AnimationStateDefinition source)
	{
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Clip = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Clip);
		Speed = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Speed);
		Loop = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Loop);
		PositionX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PositionX);
		PositionY = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PositionY);
		Group = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Group);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
