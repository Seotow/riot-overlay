using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N39092260AD9FFB8D55257AC7D9CF6905DE333F049D1E7303E7268EE4048C0F46;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneSelectionChanged")]
public class SceneSelectionChanged : IFlatBufferSerializable<SceneSelectionChanged>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<ulong>? SelectedEntityIds { get; set; }

	public static ISerializer<SceneSelectionChanged> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneSelectionChanged>)this).Serializer;

	ISerializer<SceneSelectionChanged> IFlatBufferSerializable<SceneSelectionChanged>.Serializer => Serializer;

	private static readonly ISerializer<SceneSelectionChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSelectionChanged_003E_002ELazySerializer;

	static ISerializer<SceneSelectionChanged> IFlatBufferSerializable<SceneSelectionChanged>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSelectionChanged_003E_002ELazySerializer;

	private static readonly ISerializer<SceneSelectionChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSelectionChanged_003E_002EGreedySerializer;

	static ISerializer<SceneSelectionChanged> IFlatBufferSerializable<SceneSelectionChanged>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSelectionChanged_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneSelectionChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSelectionChanged_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneSelectionChanged> IFlatBufferSerializable<SceneSelectionChanged>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSelectionChanged_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneSelectionChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSelectionChanged_003E_002EProgressiveSerializer;

	static ISerializer<SceneSelectionChanged> IFlatBufferSerializable<SceneSelectionChanged>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSelectionChanged_003E_002EProgressiveSerializer;

	static SceneSelectionChanged()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSelectionChanged_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSelectionChanged_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSelectionChanged_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSelectionChanged_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneSelectionChanged()
	{
		SceneId = 0u;
		SelectedEntityIds = null;
	}

	protected SceneSelectionChanged(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneSelectionChanged(SceneSelectionChanged source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		SelectedEntityIds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SelectedEntityIds);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
