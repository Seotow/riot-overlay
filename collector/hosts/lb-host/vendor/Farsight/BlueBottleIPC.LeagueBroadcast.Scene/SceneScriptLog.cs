using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N99CE9F67480DAA96B92F550FCCCFF6BFCA59B3319800D16CBB985150A108BCC2;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneScriptLog")]
public class SceneScriptLog : IFlatBufferSerializable<SceneScriptLog>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual ulong EntityId { get; set; }

	[FlatBufferItem(2)]
	public virtual string? ScriptName { get; set; }

	[FlatBufferItem(3)]
	public virtual string? Message { get; set; }

	[FlatBufferItem(4, DefaultValue = ScriptLogLevel.Info)]
	public virtual ScriptLogLevel Level { get; set; }

	public static ISerializer<SceneScriptLog> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneScriptLog>)this).Serializer;

	ISerializer<SceneScriptLog> IFlatBufferSerializable<SceneScriptLog>.Serializer => Serializer;

	private static readonly ISerializer<SceneScriptLog> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptLog_003E_002ELazySerializer;

	static ISerializer<SceneScriptLog> IFlatBufferSerializable<SceneScriptLog>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptLog_003E_002ELazySerializer;

	private static readonly ISerializer<SceneScriptLog> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptLog_003E_002EGreedySerializer;

	static ISerializer<SceneScriptLog> IFlatBufferSerializable<SceneScriptLog>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptLog_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneScriptLog> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptLog_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneScriptLog> IFlatBufferSerializable<SceneScriptLog>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptLog_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneScriptLog> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptLog_003E_002EProgressiveSerializer;

	static ISerializer<SceneScriptLog> IFlatBufferSerializable<SceneScriptLog>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptLog_003E_002EProgressiveSerializer;

	static SceneScriptLog()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptLog_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptLog_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptLog_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneScriptLog_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneScriptLog()
	{
		SceneId = 0u;
		EntityId = 0uL;
		ScriptName = null;
		Message = null;
		Level = ScriptLogLevel.Info;
	}

	protected SceneScriptLog(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneScriptLog(SceneScriptLog source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		EntityId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EntityId);
		ScriptName = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ScriptName);
		Message = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Message);
		Level = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Level);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
