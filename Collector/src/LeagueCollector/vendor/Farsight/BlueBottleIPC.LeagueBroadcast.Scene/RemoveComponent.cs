using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N4504EA84A6C3AD560466002F55CF08D80B0870998C7D8A71BE9E42602810AB4F;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.RemoveComponent")]
public class RemoveComponent : IFlatBufferSerializable<RemoveComponent>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ulong EntityId { get; set; }

	[FlatBufferItem(1)]
	public virtual ComponentKind Kind { get; set; }

	public static ISerializer<RemoveComponent> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<RemoveComponent>)this).Serializer;

	ISerializer<RemoveComponent> IFlatBufferSerializable<RemoveComponent>.Serializer => Serializer;

	private static readonly ISerializer<RemoveComponent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ERemoveComponent_003E_002ELazySerializer;

	static ISerializer<RemoveComponent> IFlatBufferSerializable<RemoveComponent>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ERemoveComponent_003E_002ELazySerializer;

	private static readonly ISerializer<RemoveComponent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ERemoveComponent_003E_002EGreedySerializer;

	static ISerializer<RemoveComponent> IFlatBufferSerializable<RemoveComponent>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ERemoveComponent_003E_002EGreedySerializer;

	private static readonly ISerializer<RemoveComponent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ERemoveComponent_003E_002EGreedyMutableSerializer;

	static ISerializer<RemoveComponent> IFlatBufferSerializable<RemoveComponent>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ERemoveComponent_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<RemoveComponent> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ERemoveComponent_003E_002EProgressiveSerializer;

	static ISerializer<RemoveComponent> IFlatBufferSerializable<RemoveComponent>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ERemoveComponent_003E_002EProgressiveSerializer;

	static RemoveComponent()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ERemoveComponent_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ERemoveComponent_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ERemoveComponent_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ERemoveComponent_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public RemoveComponent()
	{
		EntityId = 0uL;
		Kind = ComponentKind.Transform;
	}

	protected RemoveComponent(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public RemoveComponent(RemoveComponent source)
	{
		EntityId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EntityId);
		Kind = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Kind);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
