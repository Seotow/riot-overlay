using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N6172649086EC14C6089E03C944425DF3B8E9DB51F14F283B17C21EE5988F2658;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntityIdChanged")]
public class SceneEntityIdChanged : IFlatBufferSerializable<SceneEntityIdChanged>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual ulong OldEntityId { get; set; }

	[FlatBufferItem(2)]
	public virtual ulong NewEntityId { get; set; }

	public static ISerializer<SceneEntityIdChanged> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneEntityIdChanged>)this).Serializer;

	ISerializer<SceneEntityIdChanged> IFlatBufferSerializable<SceneEntityIdChanged>.Serializer => Serializer;

	private static readonly ISerializer<SceneEntityIdChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityIdChanged_003E_002ELazySerializer;

	static ISerializer<SceneEntityIdChanged> IFlatBufferSerializable<SceneEntityIdChanged>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityIdChanged_003E_002ELazySerializer;

	private static readonly ISerializer<SceneEntityIdChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityIdChanged_003E_002EGreedySerializer;

	static ISerializer<SceneEntityIdChanged> IFlatBufferSerializable<SceneEntityIdChanged>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityIdChanged_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneEntityIdChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityIdChanged_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneEntityIdChanged> IFlatBufferSerializable<SceneEntityIdChanged>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityIdChanged_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneEntityIdChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityIdChanged_003E_002EProgressiveSerializer;

	static ISerializer<SceneEntityIdChanged> IFlatBufferSerializable<SceneEntityIdChanged>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityIdChanged_003E_002EProgressiveSerializer;

	static SceneEntityIdChanged()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityIdChanged_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityIdChanged_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityIdChanged_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityIdChanged_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneEntityIdChanged()
	{
		SceneId = 0u;
		OldEntityId = 0uL;
		NewEntityId = 0uL;
	}

	protected SceneEntityIdChanged(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneEntityIdChanged(SceneEntityIdChanged source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		OldEntityId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.OldEntityId);
		NewEntityId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.NewEntityId);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
