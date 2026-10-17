using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NA5223763E8C9713992E0FDC851839AA7C7F15A6F2DF823F7B38C1A0FB0AB4040;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.ScriptAssetDeleted")]
public class ScriptAssetDeleted : IFlatBufferSerializable<ScriptAssetDeleted>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string ScriptId { get; set; }

	public static ISerializer<ScriptAssetDeleted> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ScriptAssetDeleted>)this).Serializer;

	ISerializer<ScriptAssetDeleted> IFlatBufferSerializable<ScriptAssetDeleted>.Serializer => Serializer;

	private static readonly ISerializer<ScriptAssetDeleted> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetDeleted_003E_002ELazySerializer;

	static ISerializer<ScriptAssetDeleted> IFlatBufferSerializable<ScriptAssetDeleted>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetDeleted_003E_002ELazySerializer;

	private static readonly ISerializer<ScriptAssetDeleted> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetDeleted_003E_002EGreedySerializer;

	static ISerializer<ScriptAssetDeleted> IFlatBufferSerializable<ScriptAssetDeleted>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetDeleted_003E_002EGreedySerializer;

	private static readonly ISerializer<ScriptAssetDeleted> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetDeleted_003E_002EGreedyMutableSerializer;

	static ISerializer<ScriptAssetDeleted> IFlatBufferSerializable<ScriptAssetDeleted>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetDeleted_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ScriptAssetDeleted> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetDeleted_003E_002EProgressiveSerializer;

	static ISerializer<ScriptAssetDeleted> IFlatBufferSerializable<ScriptAssetDeleted>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetDeleted_003E_002EProgressiveSerializer;

	static ScriptAssetDeleted()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetDeleted_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetDeleted_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetDeleted_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetDeleted_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ScriptAssetDeleted()
	{
		SceneId = 0u;
	}

	protected ScriptAssetDeleted(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ScriptAssetDeleted(ScriptAssetDeleted source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		ScriptId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ScriptId);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
