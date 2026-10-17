using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N3FEF93A7D6A1909E8EF4477ED3592B7F87067320B01952A9CC6C4F60B6B9AE22;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneScriptError")]
public class SceneScriptError : IFlatBufferSerializable<SceneScriptError>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual ulong EntityId { get; set; }

	[FlatBufferItem(2)]
	public virtual string? ScriptName { get; set; }

	[FlatBufferItem(3)]
	public virtual string? ErrorMessage { get; set; }

	[FlatBufferItem(4, DefaultValue = -1)]
	public virtual int LineNumber { get; set; }

	public static ISerializer<SceneScriptError> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneScriptError>)this).Serializer;

	ISerializer<SceneScriptError> IFlatBufferSerializable<SceneScriptError>.Serializer => Serializer;

	private static readonly ISerializer<SceneScriptError> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptError_003E_002ELazySerializer;

	static ISerializer<SceneScriptError> IFlatBufferSerializable<SceneScriptError>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptError_003E_002ELazySerializer;

	private static readonly ISerializer<SceneScriptError> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptError_003E_002EGreedySerializer;

	static ISerializer<SceneScriptError> IFlatBufferSerializable<SceneScriptError>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptError_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneScriptError> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptError_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneScriptError> IFlatBufferSerializable<SceneScriptError>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptError_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneScriptError> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptError_003E_002EProgressiveSerializer;

	static ISerializer<SceneScriptError> IFlatBufferSerializable<SceneScriptError>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptError_003E_002EProgressiveSerializer;

	static SceneScriptError()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptError_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptError_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptError_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptError_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneScriptError()
	{
		SceneId = 0u;
		EntityId = 0uL;
		ScriptName = null;
		ErrorMessage = null;
		LineNumber = -1;
	}

	protected SceneScriptError(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneScriptError(SceneScriptError source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		EntityId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EntityId);
		ScriptName = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ScriptName);
		ErrorMessage = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ErrorMessage);
		LineNumber = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LineNumber);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
