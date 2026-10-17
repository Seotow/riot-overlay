using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NE65112868DC65E7CD29590129C91123F59F8B054CDBC0C40191A7BB7CDBA3CDE;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneUnloaded")]
public class SceneUnloaded : IFlatBufferSerializable<SceneUnloaded>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Name { get; set; }

	public static ISerializer<SceneUnloaded> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneUnloaded>)this).Serializer;

	ISerializer<SceneUnloaded> IFlatBufferSerializable<SceneUnloaded>.Serializer => Serializer;

	private static readonly ISerializer<SceneUnloaded> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneUnloaded_003E_002ELazySerializer;

	static ISerializer<SceneUnloaded> IFlatBufferSerializable<SceneUnloaded>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneUnloaded_003E_002ELazySerializer;

	private static readonly ISerializer<SceneUnloaded> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneUnloaded_003E_002EGreedySerializer;

	static ISerializer<SceneUnloaded> IFlatBufferSerializable<SceneUnloaded>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneUnloaded_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneUnloaded> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneUnloaded_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneUnloaded> IFlatBufferSerializable<SceneUnloaded>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneUnloaded_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneUnloaded> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneUnloaded_003E_002EProgressiveSerializer;

	static ISerializer<SceneUnloaded> IFlatBufferSerializable<SceneUnloaded>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneUnloaded_003E_002EProgressiveSerializer;

	static SceneUnloaded()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneUnloaded_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneUnloaded_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneUnloaded_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneUnloaded_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneUnloaded()
	{
		SceneId = 0u;
		Name = null;
	}

	protected SceneUnloaded(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneUnloaded(SceneUnloaded source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
