using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NB499B3F57D752590B2A9034FB81E41DF2056924F65285E1A97138023B952867D;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneSetVisibility")]
public class SceneSetVisibility : IFlatBufferSerializable<SceneSetVisibility>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual bool Visible { get; set; }

	public static ISerializer<SceneSetVisibility> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneSetVisibility>)this).Serializer;

	ISerializer<SceneSetVisibility> IFlatBufferSerializable<SceneSetVisibility>.Serializer => Serializer;

	private static readonly ISerializer<SceneSetVisibility> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetVisibility_003E_002ELazySerializer;

	static ISerializer<SceneSetVisibility> IFlatBufferSerializable<SceneSetVisibility>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetVisibility_003E_002ELazySerializer;

	private static readonly ISerializer<SceneSetVisibility> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetVisibility_003E_002EGreedySerializer;

	static ISerializer<SceneSetVisibility> IFlatBufferSerializable<SceneSetVisibility>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetVisibility_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneSetVisibility> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetVisibility_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneSetVisibility> IFlatBufferSerializable<SceneSetVisibility>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetVisibility_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneSetVisibility> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetVisibility_003E_002EProgressiveSerializer;

	static ISerializer<SceneSetVisibility> IFlatBufferSerializable<SceneSetVisibility>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetVisibility_003E_002EProgressiveSerializer;

	static SceneSetVisibility()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetVisibility_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetVisibility_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetVisibility_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetVisibility_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneSetVisibility()
	{
		SceneId = 0u;
		Visible = false;
	}

	protected SceneSetVisibility(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneSetVisibility(SceneSetVisibility source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		Visible = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Visible);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
