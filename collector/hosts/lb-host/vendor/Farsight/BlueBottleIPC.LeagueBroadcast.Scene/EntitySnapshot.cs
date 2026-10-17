using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.EntitySnapshot")]
public class EntitySnapshot : IFlatBufferSerializable<EntitySnapshot>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ulong EntityId { get; set; }

	[FlatBufferItem(1)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<Component>? Components { get; set; }

	public static ISerializer<EntitySnapshot> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<EntitySnapshot>)this).Serializer;

	ISerializer<EntitySnapshot> IFlatBufferSerializable<EntitySnapshot>.Serializer => Serializer;

	private static readonly ISerializer<EntitySnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntitySnapshot_003E_002ELazySerializer;

	static ISerializer<EntitySnapshot> IFlatBufferSerializable<EntitySnapshot>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntitySnapshot_003E_002ELazySerializer;

	private static readonly ISerializer<EntitySnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntitySnapshot_003E_002EGreedySerializer;

	static ISerializer<EntitySnapshot> IFlatBufferSerializable<EntitySnapshot>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntitySnapshot_003E_002EGreedySerializer;

	private static readonly ISerializer<EntitySnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntitySnapshot_003E_002EGreedyMutableSerializer;

	static ISerializer<EntitySnapshot> IFlatBufferSerializable<EntitySnapshot>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntitySnapshot_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<EntitySnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntitySnapshot_003E_002EProgressiveSerializer;

	static ISerializer<EntitySnapshot> IFlatBufferSerializable<EntitySnapshot>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntitySnapshot_003E_002EProgressiveSerializer;

	static EntitySnapshot()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntitySnapshot_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntitySnapshot_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntitySnapshot_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntitySnapshot_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public EntitySnapshot()
	{
		EntityId = 0uL;
		SceneId = 0u;
		Components = null;
	}

	protected EntitySnapshot(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public EntitySnapshot(EntitySnapshot source)
	{
		EntityId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EntityId);
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		Components = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Components);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
