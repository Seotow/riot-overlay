using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NC6030EE145CA2ECA2D995BDC240014B833DFA8755316E552928748427EBB9618;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.EntityRecord")]
public class EntityRecord : IFlatBufferSerializable<EntityRecord>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual ulong Id { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Name { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<Component>? Components { get; set; }

	public static ISerializer<EntityRecord> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<EntityRecord>)this).Serializer;

	ISerializer<EntityRecord> IFlatBufferSerializable<EntityRecord>.Serializer => Serializer;

	private static readonly ISerializer<EntityRecord> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityRecord_003E_002ELazySerializer;

	static ISerializer<EntityRecord> IFlatBufferSerializable<EntityRecord>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityRecord_003E_002ELazySerializer;

	private static readonly ISerializer<EntityRecord> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityRecord_003E_002EGreedySerializer;

	static ISerializer<EntityRecord> IFlatBufferSerializable<EntityRecord>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityRecord_003E_002EGreedySerializer;

	private static readonly ISerializer<EntityRecord> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityRecord_003E_002EGreedyMutableSerializer;

	static ISerializer<EntityRecord> IFlatBufferSerializable<EntityRecord>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityRecord_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<EntityRecord> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityRecord_003E_002EProgressiveSerializer;

	static ISerializer<EntityRecord> IFlatBufferSerializable<EntityRecord>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityRecord_003E_002EProgressiveSerializer;

	static EntityRecord()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityRecord_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityRecord_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityRecord_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityRecord_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public EntityRecord()
	{
		Id = 0uL;
		Name = null;
		Components = null;
	}

	protected EntityRecord(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public EntityRecord(EntityRecord source)
	{
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Components = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Components);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
