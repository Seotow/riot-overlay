using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N7A011B6A8B2F3AD3E3AD0D334BE4CB0763646E05D9F53C4379B0B460BA318942;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntityChanged")]
public class SceneEntityChanged : IFlatBufferSerializable<SceneEntityChanged>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual EntityEventKind Kind { get; set; }

	[FlatBufferItem(1)]
	public virtual ulong EntityId { get; set; }

	[FlatBufferItem(2)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<Component>? ChangedComponents { get; set; }

	public static ISerializer<SceneEntityChanged> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneEntityChanged>)this).Serializer;

	ISerializer<SceneEntityChanged> IFlatBufferSerializable<SceneEntityChanged>.Serializer => Serializer;

	private static readonly ISerializer<SceneEntityChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityChanged_003E_002ELazySerializer;

	static ISerializer<SceneEntityChanged> IFlatBufferSerializable<SceneEntityChanged>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityChanged_003E_002ELazySerializer;

	private static readonly ISerializer<SceneEntityChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityChanged_003E_002EGreedySerializer;

	static ISerializer<SceneEntityChanged> IFlatBufferSerializable<SceneEntityChanged>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityChanged_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneEntityChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityChanged_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneEntityChanged> IFlatBufferSerializable<SceneEntityChanged>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityChanged_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneEntityChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityChanged_003E_002EProgressiveSerializer;

	static ISerializer<SceneEntityChanged> IFlatBufferSerializable<SceneEntityChanged>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityChanged_003E_002EProgressiveSerializer;

	static SceneEntityChanged()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityChanged_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityChanged_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityChanged_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneEntityChanged_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneEntityChanged()
	{
		Kind = EntityEventKind.Created;
		EntityId = 0uL;
		SceneId = 0u;
		ChangedComponents = null;
	}

	protected SceneEntityChanged(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneEntityChanged(SceneEntityChanged source)
	{
		Kind = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Kind);
		EntityId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EntityId);
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		ChangedComponents = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ChangedComponents);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
