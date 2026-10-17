using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N0C73FD5470637A15B3E39097E6ED0AC97D723E23875D0E14FFCF88E29A1A78D6;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneAction")]
public class SceneAction : IFlatBufferSerializable<SceneAction>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual SceneCommand? Command { get; set; }

	public static ISerializer<SceneAction> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneAction>)this).Serializer;

	ISerializer<SceneAction> IFlatBufferSerializable<SceneAction>.Serializer => Serializer;

	private static readonly ISerializer<SceneAction> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneAction_003E_002ELazySerializer;

	static ISerializer<SceneAction> IFlatBufferSerializable<SceneAction>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneAction_003E_002ELazySerializer;

	private static readonly ISerializer<SceneAction> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneAction_003E_002EGreedySerializer;

	static ISerializer<SceneAction> IFlatBufferSerializable<SceneAction>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneAction_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneAction> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneAction_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneAction> IFlatBufferSerializable<SceneAction>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneAction_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneAction> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneAction_003E_002EProgressiveSerializer;

	static ISerializer<SceneAction> IFlatBufferSerializable<SceneAction>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneAction_003E_002EProgressiveSerializer;

	static SceneAction()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneAction_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneAction_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneAction_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneAction_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneAction()
	{
		Command = null;
	}

	protected SceneAction(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneAction(SceneAction source)
	{
		Command = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Command);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
