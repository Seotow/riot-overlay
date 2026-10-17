using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N537633F8E7ED7717A7FE82F5305571C9020A071A43F573ED229EA26496D61CD7;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.EntityCreateBatch")]
public class EntityCreateBatch : IFlatBufferSerializable<EntityCreateBatch>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<EntityCreate>? Items { get; set; }

	public static ISerializer<EntityCreateBatch> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<EntityCreateBatch>)this).Serializer;

	ISerializer<EntityCreateBatch> IFlatBufferSerializable<EntityCreateBatch>.Serializer => Serializer;

	private static readonly ISerializer<EntityCreateBatch> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreateBatch_003E_002ELazySerializer;

	static ISerializer<EntityCreateBatch> IFlatBufferSerializable<EntityCreateBatch>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreateBatch_003E_002ELazySerializer;

	private static readonly ISerializer<EntityCreateBatch> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreateBatch_003E_002EGreedySerializer;

	static ISerializer<EntityCreateBatch> IFlatBufferSerializable<EntityCreateBatch>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreateBatch_003E_002EGreedySerializer;

	private static readonly ISerializer<EntityCreateBatch> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreateBatch_003E_002EGreedyMutableSerializer;

	static ISerializer<EntityCreateBatch> IFlatBufferSerializable<EntityCreateBatch>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreateBatch_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<EntityCreateBatch> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreateBatch_003E_002EProgressiveSerializer;

	static ISerializer<EntityCreateBatch> IFlatBufferSerializable<EntityCreateBatch>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreateBatch_003E_002EProgressiveSerializer;

	static EntityCreateBatch()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreateBatch_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreateBatch_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreateBatch_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreateBatch_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public EntityCreateBatch()
	{
		SceneId = 0u;
		Items = null;
	}

	protected EntityCreateBatch(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public EntityCreateBatch(EntityCreateBatch source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		Items = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Items);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
