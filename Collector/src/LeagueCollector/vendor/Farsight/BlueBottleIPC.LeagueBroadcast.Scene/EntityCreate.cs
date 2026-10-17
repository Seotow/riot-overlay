using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NCAE7D2E61298C73EB9C86E4A28C7DCE1C1488F40CB9167B4CDECD5E1D1E1EED2;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.EntityCreate")]
public class EntityCreate : IFlatBufferSerializable<EntityCreate>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual uint ClientIndex { get; set; }

	[FlatBufferItem(2)]
	public virtual ulong RequestedId { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<Component>? Components { get; set; }

	public static ISerializer<EntityCreate> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<EntityCreate>)this).Serializer;

	ISerializer<EntityCreate> IFlatBufferSerializable<EntityCreate>.Serializer => Serializer;

	private static readonly ISerializer<EntityCreate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreate_003E_002ELazySerializer;

	static ISerializer<EntityCreate> IFlatBufferSerializable<EntityCreate>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreate_003E_002ELazySerializer;

	private static readonly ISerializer<EntityCreate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreate_003E_002EGreedySerializer;

	static ISerializer<EntityCreate> IFlatBufferSerializable<EntityCreate>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreate_003E_002EGreedySerializer;

	private static readonly ISerializer<EntityCreate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreate_003E_002EGreedyMutableSerializer;

	static ISerializer<EntityCreate> IFlatBufferSerializable<EntityCreate>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreate_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<EntityCreate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreate_003E_002EProgressiveSerializer;

	static ISerializer<EntityCreate> IFlatBufferSerializable<EntityCreate>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreate_003E_002EProgressiveSerializer;

	static EntityCreate()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreate_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreate_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreate_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityCreate_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public EntityCreate()
	{
		SceneId = 0u;
		ClientIndex = 0u;
		RequestedId = 0uL;
		Components = null;
	}

	protected EntityCreate(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public EntityCreate(EntityCreate source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		ClientIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ClientIndex);
		RequestedId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RequestedId);
		Components = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Components);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
