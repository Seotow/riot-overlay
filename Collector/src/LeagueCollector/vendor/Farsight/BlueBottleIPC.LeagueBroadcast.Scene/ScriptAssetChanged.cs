using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NDB64B3D55210AE4EB049160D71FC052CE79A97A0BEF60D42CB5A46DD21E12985;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.ScriptAssetChanged")]
public class ScriptAssetChanged : IFlatBufferSerializable<ScriptAssetChanged>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required ScriptAssetSnapshot Asset { get; set; }

	public static ISerializer<ScriptAssetChanged> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ScriptAssetChanged>)this).Serializer;

	ISerializer<ScriptAssetChanged> IFlatBufferSerializable<ScriptAssetChanged>.Serializer => Serializer;

	private static readonly ISerializer<ScriptAssetChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetChanged_003E_002ELazySerializer;

	static ISerializer<ScriptAssetChanged> IFlatBufferSerializable<ScriptAssetChanged>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetChanged_003E_002ELazySerializer;

	private static readonly ISerializer<ScriptAssetChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetChanged_003E_002EGreedySerializer;

	static ISerializer<ScriptAssetChanged> IFlatBufferSerializable<ScriptAssetChanged>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetChanged_003E_002EGreedySerializer;

	private static readonly ISerializer<ScriptAssetChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetChanged_003E_002EGreedyMutableSerializer;

	static ISerializer<ScriptAssetChanged> IFlatBufferSerializable<ScriptAssetChanged>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetChanged_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ScriptAssetChanged> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetChanged_003E_002EProgressiveSerializer;

	static ISerializer<ScriptAssetChanged> IFlatBufferSerializable<ScriptAssetChanged>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetChanged_003E_002EProgressiveSerializer;

	static ScriptAssetChanged()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetChanged_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetChanged_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetChanged_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetChanged_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ScriptAssetChanged()
	{
		SceneId = 0u;
	}

	protected ScriptAssetChanged(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ScriptAssetChanged(ScriptAssetChanged source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		Asset = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Asset);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
