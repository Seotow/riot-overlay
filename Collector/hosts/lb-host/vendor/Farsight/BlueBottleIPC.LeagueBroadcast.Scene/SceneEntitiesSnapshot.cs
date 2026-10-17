using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NE943CA05B67B2DAB66293C7C88464A33A3531EABE2DE1A7255EB54F337E4F62E;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntitiesSnapshot")]
public class SceneEntitiesSnapshot : IFlatBufferSerializable<SceneEntitiesSnapshot>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<EntitySnapshot>? Entities { get; set; }

	public static ISerializer<SceneEntitiesSnapshot> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneEntitiesSnapshot>)this).Serializer;

	ISerializer<SceneEntitiesSnapshot> IFlatBufferSerializable<SceneEntitiesSnapshot>.Serializer => Serializer;

	private static readonly ISerializer<SceneEntitiesSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesSnapshot_003E_002ELazySerializer;

	static ISerializer<SceneEntitiesSnapshot> IFlatBufferSerializable<SceneEntitiesSnapshot>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesSnapshot_003E_002ELazySerializer;

	private static readonly ISerializer<SceneEntitiesSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesSnapshot_003E_002EGreedySerializer;

	static ISerializer<SceneEntitiesSnapshot> IFlatBufferSerializable<SceneEntitiesSnapshot>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesSnapshot_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneEntitiesSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesSnapshot_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneEntitiesSnapshot> IFlatBufferSerializable<SceneEntitiesSnapshot>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesSnapshot_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneEntitiesSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesSnapshot_003E_002EProgressiveSerializer;

	static ISerializer<SceneEntitiesSnapshot> IFlatBufferSerializable<SceneEntitiesSnapshot>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesSnapshot_003E_002EProgressiveSerializer;

	static SceneEntitiesSnapshot()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesSnapshot_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesSnapshot_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesSnapshot_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesSnapshot_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneEntitiesSnapshot()
	{
		SceneId = 0u;
		Entities = null;
	}

	protected SceneEntitiesSnapshot(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneEntitiesSnapshot(SceneEntitiesSnapshot source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		Entities = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Entities);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
