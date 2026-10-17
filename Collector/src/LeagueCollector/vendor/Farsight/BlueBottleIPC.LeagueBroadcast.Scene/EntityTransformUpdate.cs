using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NC5CBA9F46D32D05766F60D0B099A849A6DF84F2017E84177AF17E73CA658E441;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.EntityTransformUpdate")]
public class EntityTransformUpdate : IFlatBufferSerializable<EntityTransformUpdate>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ulong EntityId { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required ComponentTransform Transform { get; set; }

	public static ISerializer<EntityTransformUpdate> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<EntityTransformUpdate>)this).Serializer;

	ISerializer<EntityTransformUpdate> IFlatBufferSerializable<EntityTransformUpdate>.Serializer => Serializer;

	private static readonly ISerializer<EntityTransformUpdate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityTransformUpdate_003E_002ELazySerializer;

	static ISerializer<EntityTransformUpdate> IFlatBufferSerializable<EntityTransformUpdate>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityTransformUpdate_003E_002ELazySerializer;

	private static readonly ISerializer<EntityTransformUpdate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityTransformUpdate_003E_002EGreedySerializer;

	static ISerializer<EntityTransformUpdate> IFlatBufferSerializable<EntityTransformUpdate>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityTransformUpdate_003E_002EGreedySerializer;

	private static readonly ISerializer<EntityTransformUpdate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityTransformUpdate_003E_002EGreedyMutableSerializer;

	static ISerializer<EntityTransformUpdate> IFlatBufferSerializable<EntityTransformUpdate>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityTransformUpdate_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<EntityTransformUpdate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityTransformUpdate_003E_002EProgressiveSerializer;

	static ISerializer<EntityTransformUpdate> IFlatBufferSerializable<EntityTransformUpdate>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityTransformUpdate_003E_002EProgressiveSerializer;

	static EntityTransformUpdate()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityTransformUpdate_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityTransformUpdate_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityTransformUpdate_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityTransformUpdate_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public EntityTransformUpdate()
	{
		EntityId = 0uL;
	}

	protected EntityTransformUpdate(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public EntityTransformUpdate(EntityTransformUpdate source)
	{
		EntityId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EntityId);
		Transform = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Transform);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
