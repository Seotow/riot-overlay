using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NECA310474EFE10AB83E0714327849C76F302474567AE823F7286B38542B22F71;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneSnapshot")]
public class SceneSnapshot : IFlatBufferSerializable<SceneSnapshot>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required SceneDescriptor Scene { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<EntitySnapshot>? Entities { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<ScriptAssetSnapshot>? Scripts { get; set; }

	public static ISerializer<SceneSnapshot> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneSnapshot>)this).Serializer;

	ISerializer<SceneSnapshot> IFlatBufferSerializable<SceneSnapshot>.Serializer => Serializer;

	private static readonly ISerializer<SceneSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSnapshot_003E_002ELazySerializer;

	static ISerializer<SceneSnapshot> IFlatBufferSerializable<SceneSnapshot>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSnapshot_003E_002ELazySerializer;

	private static readonly ISerializer<SceneSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSnapshot_003E_002EGreedySerializer;

	static ISerializer<SceneSnapshot> IFlatBufferSerializable<SceneSnapshot>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSnapshot_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSnapshot_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneSnapshot> IFlatBufferSerializable<SceneSnapshot>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSnapshot_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSnapshot_003E_002EProgressiveSerializer;

	static ISerializer<SceneSnapshot> IFlatBufferSerializable<SceneSnapshot>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSnapshot_003E_002EProgressiveSerializer;

	static SceneSnapshot()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSnapshot_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSnapshot_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSnapshot_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSnapshot_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneSnapshot()
	{
		Entities = null;
		Scripts = null;
	}

	protected SceneSnapshot(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneSnapshot(SceneSnapshot source)
	{
		Scene = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Scene);
		Entities = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Entities);
		Scripts = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Scripts);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
