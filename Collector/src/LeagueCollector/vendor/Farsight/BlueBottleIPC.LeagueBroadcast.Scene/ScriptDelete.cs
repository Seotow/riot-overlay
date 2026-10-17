using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NF887C5836C47DB7F02BE4F66B963E4A233A863D39741BB34C28D444FD080F679;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.ScriptDelete")]
public class ScriptDelete : IFlatBufferSerializable<ScriptDelete>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string ScriptId { get; set; }

	public static ISerializer<ScriptDelete> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ScriptDelete>)this).Serializer;

	ISerializer<ScriptDelete> IFlatBufferSerializable<ScriptDelete>.Serializer => Serializer;

	private static readonly ISerializer<ScriptDelete> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptDelete_003E_002ELazySerializer;

	static ISerializer<ScriptDelete> IFlatBufferSerializable<ScriptDelete>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptDelete_003E_002ELazySerializer;

	private static readonly ISerializer<ScriptDelete> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptDelete_003E_002EGreedySerializer;

	static ISerializer<ScriptDelete> IFlatBufferSerializable<ScriptDelete>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptDelete_003E_002EGreedySerializer;

	private static readonly ISerializer<ScriptDelete> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptDelete_003E_002EGreedyMutableSerializer;

	static ISerializer<ScriptDelete> IFlatBufferSerializable<ScriptDelete>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptDelete_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ScriptDelete> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptDelete_003E_002EProgressiveSerializer;

	static ISerializer<ScriptDelete> IFlatBufferSerializable<ScriptDelete>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptDelete_003E_002EProgressiveSerializer;

	static ScriptDelete()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptDelete_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptDelete_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptDelete_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptDelete_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ScriptDelete()
	{
		SceneId = 0u;
	}

	protected ScriptDelete(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ScriptDelete(ScriptDelete source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		ScriptId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ScriptId);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
