using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N11BDFB110B0C663C92CA2111B8AEDA2B3D491ED4C86D2C48EBD45BA9F3487431;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer")]
public class ComponentMeshRenderer : IFlatBufferSerializable<ComponentMeshRenderer>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual AssetIdentifier? Model { get; set; }

	[FlatBufferItem(2)]
	public virtual AssetIdentifier? OverrideTexture { get; set; }

	[FlatBufferItem(4)]
	public virtual string? AnimationName { get; set; }

	[FlatBufferItem(5)]
	public virtual float AnimationTime { get; set; }

	[FlatBufferItem(6, DefaultValue = 1f)]
	public virtual float AnimationSpeed { get; set; }

	[FlatBufferItem(7, DefaultValue = true)]
	public virtual bool AnimationLoop { get; set; }

	[FlatBufferItem(8, DefaultValue = true)]
	public virtual bool AnimationPlaying { get; set; }

	[FlatBufferItem(9)]
	public virtual bool StateMachineEnabled { get; set; }

	[FlatBufferItem(10)]
	public virtual string? EntryState { get; set; }

	[FlatBufferItem(11)]
	public virtual IList<AnimationStateDefinition>? AnimationStates { get; set; }

	[FlatBufferItem(12)]
	public virtual IList<AnimationTransitionDefinition>? AnimationTransitions { get; set; }

	public static ISerializer<ComponentMeshRenderer> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ComponentMeshRenderer>)this).Serializer;

	ISerializer<ComponentMeshRenderer> IFlatBufferSerializable<ComponentMeshRenderer>.Serializer => Serializer;

	private static readonly ISerializer<ComponentMeshRenderer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentMeshRenderer_003E_002ELazySerializer;

	static ISerializer<ComponentMeshRenderer> IFlatBufferSerializable<ComponentMeshRenderer>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentMeshRenderer_003E_002ELazySerializer;

	private static readonly ISerializer<ComponentMeshRenderer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentMeshRenderer_003E_002EGreedySerializer;

	static ISerializer<ComponentMeshRenderer> IFlatBufferSerializable<ComponentMeshRenderer>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentMeshRenderer_003E_002EGreedySerializer;

	private static readonly ISerializer<ComponentMeshRenderer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentMeshRenderer_003E_002EGreedyMutableSerializer;

	static ISerializer<ComponentMeshRenderer> IFlatBufferSerializable<ComponentMeshRenderer>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentMeshRenderer_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ComponentMeshRenderer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentMeshRenderer_003E_002EProgressiveSerializer;

	static ISerializer<ComponentMeshRenderer> IFlatBufferSerializable<ComponentMeshRenderer>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentMeshRenderer_003E_002EProgressiveSerializer;

	static ComponentMeshRenderer()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentMeshRenderer_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentMeshRenderer_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentMeshRenderer_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentMeshRenderer_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ComponentMeshRenderer()
	{
		Model = null;
		OverrideTexture = null;
		AnimationName = null;
		AnimationTime = 0f;
		AnimationSpeed = 1f;
		AnimationLoop = true;
		AnimationPlaying = true;
		StateMachineEnabled = false;
		EntryState = null;
		AnimationStates = null;
		AnimationTransitions = null;
	}

	protected ComponentMeshRenderer(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ComponentMeshRenderer(ComponentMeshRenderer source)
	{
		Model = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Model);
		OverrideTexture = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.OverrideTexture);
		AnimationName = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnimationName);
		AnimationTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnimationTime);
		AnimationSpeed = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnimationSpeed);
		AnimationLoop = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnimationLoop);
		AnimationPlaying = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnimationPlaying);
		StateMachineEnabled = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.StateMachineEnabled);
		EntryState = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EntryState);
		AnimationStates = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnimationStates);
		AnimationTransitions = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AnimationTransitions);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
