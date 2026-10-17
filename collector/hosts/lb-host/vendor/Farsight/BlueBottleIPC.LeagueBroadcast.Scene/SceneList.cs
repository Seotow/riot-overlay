using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N5F011D720117327CF23779F510E3CFEE2353C717C2CC780AF9D76899B0D0E60E;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneList")]
public class SceneList : IFlatBufferSerializable<SceneList>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual IList<SceneDescriptor>? Scenes { get; set; }

	public static ISerializer<SceneList> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneList>)this).Serializer;

	ISerializer<SceneList> IFlatBufferSerializable<SceneList>.Serializer => Serializer;

	private static readonly ISerializer<SceneList> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneList_003E_002ELazySerializer;

	static ISerializer<SceneList> IFlatBufferSerializable<SceneList>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneList_003E_002ELazySerializer;

	private static readonly ISerializer<SceneList> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneList_003E_002EGreedySerializer;

	static ISerializer<SceneList> IFlatBufferSerializable<SceneList>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneList_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneList> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneList_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneList> IFlatBufferSerializable<SceneList>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneList_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneList> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneList_003E_002EProgressiveSerializer;

	static ISerializer<SceneList> IFlatBufferSerializable<SceneList>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneList_003E_002EProgressiveSerializer;

	static SceneList()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneList_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneList_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneList_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneList_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneList()
	{
		Scenes = null;
	}

	protected SceneList(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneList(SceneList source)
	{
		Scenes = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Scenes);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
