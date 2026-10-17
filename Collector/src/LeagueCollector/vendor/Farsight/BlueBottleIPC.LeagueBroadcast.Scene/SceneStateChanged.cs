using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N59C2F58A4BF25EA13737D104B507C6F626F4C62B90930D9573C2A8D0767984F9;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneStateChanged")]
public class SceneStateChanged : IFlatBufferSerializable<SceneStateChanged>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required SceneDescriptor Scene { get; set; }

	public static ISerializer<SceneStateChanged> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneStateChanged>)this).Serializer;

	ISerializer<SceneStateChanged> IFlatBufferSerializable<SceneStateChanged>.Serializer => Serializer;

	private static readonly ISerializer<SceneStateChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneStateChanged_003E_002ELazySerializer;

	static ISerializer<SceneStateChanged> IFlatBufferSerializable<SceneStateChanged>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneStateChanged_003E_002ELazySerializer;

	private static readonly ISerializer<SceneStateChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneStateChanged_003E_002EGreedySerializer;

	static ISerializer<SceneStateChanged> IFlatBufferSerializable<SceneStateChanged>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneStateChanged_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneStateChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneStateChanged_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneStateChanged> IFlatBufferSerializable<SceneStateChanged>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneStateChanged_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneStateChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneStateChanged_003E_002EProgressiveSerializer;

	static ISerializer<SceneStateChanged> IFlatBufferSerializable<SceneStateChanged>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneStateChanged_003E_002EProgressiveSerializer;

	static SceneStateChanged()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneStateChanged_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneStateChanged_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneStateChanged_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneStateChanged_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneStateChanged()
	{
	}

	protected SceneStateChanged(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneStateChanged(SceneStateChanged source)
	{
		Scene = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Scene);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
