using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NC833D87BCA5B387661E5B1FAD3359D3BFFA0DA2215E557597D6443DD5D120A46;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntitiesRemoved")]
public class SceneEntitiesRemoved : IFlatBufferSerializable<SceneEntitiesRemoved>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<ulong>? LocalIds { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<ulong>? ReparentedIds { get; set; }

	public static ISerializer<SceneEntitiesRemoved> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneEntitiesRemoved>)this).Serializer;

	ISerializer<SceneEntitiesRemoved> IFlatBufferSerializable<SceneEntitiesRemoved>.Serializer => Serializer;

	private static readonly ISerializer<SceneEntitiesRemoved> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesRemoved_003E_002ELazySerializer;

	static ISerializer<SceneEntitiesRemoved> IFlatBufferSerializable<SceneEntitiesRemoved>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesRemoved_003E_002ELazySerializer;

	private static readonly ISerializer<SceneEntitiesRemoved> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesRemoved_003E_002EGreedySerializer;

	static ISerializer<SceneEntitiesRemoved> IFlatBufferSerializable<SceneEntitiesRemoved>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesRemoved_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneEntitiesRemoved> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesRemoved_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneEntitiesRemoved> IFlatBufferSerializable<SceneEntitiesRemoved>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesRemoved_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneEntitiesRemoved> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesRemoved_003E_002EProgressiveSerializer;

	static ISerializer<SceneEntitiesRemoved> IFlatBufferSerializable<SceneEntitiesRemoved>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesRemoved_003E_002EProgressiveSerializer;

	static SceneEntitiesRemoved()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesRemoved_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesRemoved_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesRemoved_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntitiesRemoved_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneEntitiesRemoved()
	{
		SceneId = 0u;
		LocalIds = null;
		ReparentedIds = null;
	}

	protected SceneEntitiesRemoved(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneEntitiesRemoved(SceneEntitiesRemoved source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		LocalIds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LocalIds);
		ReparentedIds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ReparentedIds);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
