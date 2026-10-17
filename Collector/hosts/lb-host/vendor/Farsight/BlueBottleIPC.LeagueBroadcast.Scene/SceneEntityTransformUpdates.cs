using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.ND1D255C96EB2D5DFB7F8BBD98E8E03B34477EE652138E184E896BA79E92611B0;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntityTransformUpdates")]
public class SceneEntityTransformUpdates : IFlatBufferSerializable<SceneEntityTransformUpdates>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<EntityTransformUpdate>? Updates { get; set; }

	[FlatBufferItem(2)]
	public virtual GizmoManipulationPhase Phase { get; set; }

	public static ISerializer<SceneEntityTransformUpdates> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneEntityTransformUpdates>)this).Serializer;

	ISerializer<SceneEntityTransformUpdates> IFlatBufferSerializable<SceneEntityTransformUpdates>.Serializer => Serializer;

	private static readonly ISerializer<SceneEntityTransformUpdates> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityTransformUpdates_003E_002ELazySerializer;

	static ISerializer<SceneEntityTransformUpdates> IFlatBufferSerializable<SceneEntityTransformUpdates>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityTransformUpdates_003E_002ELazySerializer;

	private static readonly ISerializer<SceneEntityTransformUpdates> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityTransformUpdates_003E_002EGreedySerializer;

	static ISerializer<SceneEntityTransformUpdates> IFlatBufferSerializable<SceneEntityTransformUpdates>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityTransformUpdates_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneEntityTransformUpdates> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityTransformUpdates_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneEntityTransformUpdates> IFlatBufferSerializable<SceneEntityTransformUpdates>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityTransformUpdates_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneEntityTransformUpdates> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityTransformUpdates_003E_002EProgressiveSerializer;

	static ISerializer<SceneEntityTransformUpdates> IFlatBufferSerializable<SceneEntityTransformUpdates>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityTransformUpdates_003E_002EProgressiveSerializer;

	static SceneEntityTransformUpdates()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityTransformUpdates_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityTransformUpdates_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityTransformUpdates_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityTransformUpdates_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneEntityTransformUpdates()
	{
		SceneId = 0u;
		Updates = null;
		Phase = GizmoManipulationPhase.None;
	}

	protected SceneEntityTransformUpdates(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneEntityTransformUpdates(SceneEntityTransformUpdates source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		Updates = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Updates);
		Phase = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Phase);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
