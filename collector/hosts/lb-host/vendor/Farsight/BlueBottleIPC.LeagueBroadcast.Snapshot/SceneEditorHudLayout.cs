using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.ND2ED2E42252B34D21BB5F5789F1B8937BCD17FFB818A2EE218491ECC5DAB9EDD;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.SceneEditorHudLayout")]
public class SceneEditorHudLayout : IFlatBufferSerializable<SceneEditorHudLayout>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual bool Available { get; set; }

	[FlatBufferItem(1)]
	public virtual float MinimapX { get; set; }

	[FlatBufferItem(2)]
	public virtual float MinimapY { get; set; }

	[FlatBufferItem(3)]
	public virtual float MinimapWidth { get; set; }

	[FlatBufferItem(4)]
	public virtual float MinimapHeight { get; set; }

	public static ISerializer<SceneEditorHudLayout> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneEditorHudLayout>)this).Serializer;

	ISerializer<SceneEditorHudLayout> IFlatBufferSerializable<SceneEditorHudLayout>.Serializer => Serializer;

	private static readonly ISerializer<SceneEditorHudLayout> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ESceneEditorHudLayout_003E_002ELazySerializer;

	static ISerializer<SceneEditorHudLayout> IFlatBufferSerializable<SceneEditorHudLayout>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ESceneEditorHudLayout_003E_002ELazySerializer;

	private static readonly ISerializer<SceneEditorHudLayout> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ESceneEditorHudLayout_003E_002EGreedySerializer;

	static ISerializer<SceneEditorHudLayout> IFlatBufferSerializable<SceneEditorHudLayout>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ESceneEditorHudLayout_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneEditorHudLayout> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ESceneEditorHudLayout_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneEditorHudLayout> IFlatBufferSerializable<SceneEditorHudLayout>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ESceneEditorHudLayout_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneEditorHudLayout> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ESceneEditorHudLayout_003E_002EProgressiveSerializer;

	static ISerializer<SceneEditorHudLayout> IFlatBufferSerializable<SceneEditorHudLayout>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ESceneEditorHudLayout_003E_002EProgressiveSerializer;

	static SceneEditorHudLayout()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ESceneEditorHudLayout_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ESceneEditorHudLayout_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ESceneEditorHudLayout_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ESceneEditorHudLayout_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneEditorHudLayout()
	{
		Available = false;
		MinimapX = 0f;
		MinimapY = 0f;
		MinimapWidth = 0f;
		MinimapHeight = 0f;
	}

	protected SceneEditorHudLayout(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneEditorHudLayout(SceneEditorHudLayout source)
	{
		Available = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Available);
		MinimapX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MinimapX);
		MinimapY = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MinimapY);
		MinimapWidth = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MinimapWidth);
		MinimapHeight = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MinimapHeight);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
