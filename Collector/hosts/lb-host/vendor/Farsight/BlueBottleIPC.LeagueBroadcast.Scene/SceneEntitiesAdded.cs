using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N0B14296B19AF182C1B2C8F8044D07E7F174FF991333AA347012E787D92AB2046;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntitiesAdded")]
public class SceneEntitiesAdded : IFlatBufferSerializable<SceneEntitiesAdded>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<EntityAssignment>? Assignments { get; set; }

	public static ISerializer<SceneEntitiesAdded> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneEntitiesAdded>)this).Serializer;

	ISerializer<SceneEntitiesAdded> IFlatBufferSerializable<SceneEntitiesAdded>.Serializer => Serializer;

	private static readonly ISerializer<SceneEntitiesAdded> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesAdded_003E_002ELazySerializer;

	static ISerializer<SceneEntitiesAdded> IFlatBufferSerializable<SceneEntitiesAdded>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesAdded_003E_002ELazySerializer;

	private static readonly ISerializer<SceneEntitiesAdded> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesAdded_003E_002EGreedySerializer;

	static ISerializer<SceneEntitiesAdded> IFlatBufferSerializable<SceneEntitiesAdded>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesAdded_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneEntitiesAdded> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesAdded_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneEntitiesAdded> IFlatBufferSerializable<SceneEntitiesAdded>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesAdded_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneEntitiesAdded> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesAdded_003E_002EProgressiveSerializer;

	static ISerializer<SceneEntitiesAdded> IFlatBufferSerializable<SceneEntitiesAdded>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesAdded_003E_002EProgressiveSerializer;

	static SceneEntitiesAdded()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesAdded_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesAdded_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesAdded_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesAdded_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneEntitiesAdded()
	{
		SceneId = 0u;
		Assignments = null;
	}

	protected SceneEntitiesAdded(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneEntitiesAdded(SceneEntitiesAdded source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		Assignments = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Assignments);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
