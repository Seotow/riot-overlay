using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.ND0302BF1516C72BECC7F630294FBA2C7C3B8E069F73BF23BFFC5F1DE236D0259;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneCreated")]
public class SceneCreated : IFlatBufferSerializable<SceneCreated>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required SceneDescriptor Scene { get; set; }

	public static ISerializer<SceneCreated> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneCreated>)this).Serializer;

	ISerializer<SceneCreated> IFlatBufferSerializable<SceneCreated>.Serializer => Serializer;

	private static readonly ISerializer<SceneCreated> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneCreated_003E_002ELazySerializer;

	static ISerializer<SceneCreated> IFlatBufferSerializable<SceneCreated>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneCreated_003E_002ELazySerializer;

	private static readonly ISerializer<SceneCreated> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneCreated_003E_002EGreedySerializer;

	static ISerializer<SceneCreated> IFlatBufferSerializable<SceneCreated>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneCreated_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneCreated> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneCreated_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneCreated> IFlatBufferSerializable<SceneCreated>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneCreated_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneCreated> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneCreated_003E_002EProgressiveSerializer;

	static ISerializer<SceneCreated> IFlatBufferSerializable<SceneCreated>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneCreated_003E_002EProgressiveSerializer;

	static SceneCreated()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneCreated_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneCreated_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneCreated_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneCreated_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneCreated()
	{
	}

	protected SceneCreated(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneCreated(SceneCreated source)
	{
		Scene = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Scene);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
