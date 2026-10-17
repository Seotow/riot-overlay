using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N461C25481BE10137F2E8E51623BDE0B9934B11B6AF2D5F09BA9C1C880C83EECF;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneSetSelection")]
public class SceneSetSelection : IFlatBufferSerializable<SceneSetSelection>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<ulong>? SelectedIds { get; set; }

	public static ISerializer<SceneSetSelection> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneSetSelection>)this).Serializer;

	ISerializer<SceneSetSelection> IFlatBufferSerializable<SceneSetSelection>.Serializer => Serializer;

	private static readonly ISerializer<SceneSetSelection> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetSelection_003E_002ELazySerializer;

	static ISerializer<SceneSetSelection> IFlatBufferSerializable<SceneSetSelection>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetSelection_003E_002ELazySerializer;

	private static readonly ISerializer<SceneSetSelection> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetSelection_003E_002EGreedySerializer;

	static ISerializer<SceneSetSelection> IFlatBufferSerializable<SceneSetSelection>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetSelection_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneSetSelection> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetSelection_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneSetSelection> IFlatBufferSerializable<SceneSetSelection>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetSelection_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneSetSelection> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetSelection_003E_002EProgressiveSerializer;

	static ISerializer<SceneSetSelection> IFlatBufferSerializable<SceneSetSelection>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetSelection_003E_002EProgressiveSerializer;

	static SceneSetSelection()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetSelection_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetSelection_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetSelection_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetSelection_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneSetSelection()
	{
		SceneId = 0u;
		SelectedIds = null;
	}

	protected SceneSetSelection(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneSetSelection(SceneSetSelection source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		SelectedIds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SelectedIds);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
