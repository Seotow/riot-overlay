using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N04FB7D6A142D759287EBB1AE8B0EE2F74E4289DD6A6B520678DEDF23BC1327E6;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneFile")]
public class SceneFile : IFlatBufferSerializable<SceneFile>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Name { get; set; }

	[FlatBufferItem(1)]
	public virtual bool IsActive { get; set; }

	[FlatBufferItem(2)]
	public virtual IList<ScriptAsset>? ScriptLibrary { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<EntityRecord>? Entities { get; set; }

	public static ISerializer<SceneFile> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneFile>)this).Serializer;

	ISerializer<SceneFile> IFlatBufferSerializable<SceneFile>.Serializer => Serializer;

	private static readonly ISerializer<SceneFile> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneFile_003E_002ELazySerializer;

	static ISerializer<SceneFile> IFlatBufferSerializable<SceneFile>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneFile_003E_002ELazySerializer;

	private static readonly ISerializer<SceneFile> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneFile_003E_002EGreedySerializer;

	static ISerializer<SceneFile> IFlatBufferSerializable<SceneFile>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneFile_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneFile> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneFile_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneFile> IFlatBufferSerializable<SceneFile>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneFile_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneFile> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneFile_003E_002EProgressiveSerializer;

	static ISerializer<SceneFile> IFlatBufferSerializable<SceneFile>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneFile_003E_002EProgressiveSerializer;

	static SceneFile()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneFile_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneFile_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneFile_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneFile_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneFile()
	{
		IsActive = false;
		ScriptLibrary = null;
		Entities = null;
	}

	protected SceneFile(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneFile(SceneFile source)
	{
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		IsActive = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.IsActive);
		ScriptLibrary = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ScriptLibrary);
		Entities = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Entities);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
