using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NA2C9FCAFE1C080311BDA16CCA3940BC4157C7F9C96557BE8E0770E3C0CB18562;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneSetZOrder")]
public class SceneSetZOrder : IFlatBufferSerializable<SceneSetZOrder>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual int ZOrder { get; set; }

	public static ISerializer<SceneSetZOrder> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneSetZOrder>)this).Serializer;

	ISerializer<SceneSetZOrder> IFlatBufferSerializable<SceneSetZOrder>.Serializer => Serializer;

	private static readonly ISerializer<SceneSetZOrder> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetZOrder_003E_002ELazySerializer;

	static ISerializer<SceneSetZOrder> IFlatBufferSerializable<SceneSetZOrder>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetZOrder_003E_002ELazySerializer;

	private static readonly ISerializer<SceneSetZOrder> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetZOrder_003E_002EGreedySerializer;

	static ISerializer<SceneSetZOrder> IFlatBufferSerializable<SceneSetZOrder>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetZOrder_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneSetZOrder> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetZOrder_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneSetZOrder> IFlatBufferSerializable<SceneSetZOrder>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetZOrder_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneSetZOrder> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetZOrder_003E_002EProgressiveSerializer;

	static ISerializer<SceneSetZOrder> IFlatBufferSerializable<SceneSetZOrder>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetZOrder_003E_002EProgressiveSerializer;

	static SceneSetZOrder()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetZOrder_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetZOrder_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetZOrder_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetZOrder_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneSetZOrder()
	{
		SceneId = 0u;
		ZOrder = 0;
	}

	protected SceneSetZOrder(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneSetZOrder(SceneSetZOrder source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		ZOrder = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ZOrder);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
