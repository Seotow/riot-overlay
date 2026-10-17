using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N94184DCDC20856FBE0CFD5BBDD550892414DA09601F69B4B47AFFC8A56F821C0;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.ScriptUpdate")]
public class ScriptUpdate : IFlatBufferSerializable<ScriptUpdate>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string ScriptId { get; set; }

	[FlatBufferItem(2)]
	public virtual string? Name { get; set; }

	[FlatBufferItem(3)]
	public virtual string? Content { get; set; }

	public static ISerializer<ScriptUpdate> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ScriptUpdate>)this).Serializer;

	ISerializer<ScriptUpdate> IFlatBufferSerializable<ScriptUpdate>.Serializer => Serializer;

	private static readonly ISerializer<ScriptUpdate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptUpdate_003E_002ELazySerializer;

	static ISerializer<ScriptUpdate> IFlatBufferSerializable<ScriptUpdate>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptUpdate_003E_002ELazySerializer;

	private static readonly ISerializer<ScriptUpdate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptUpdate_003E_002EGreedySerializer;

	static ISerializer<ScriptUpdate> IFlatBufferSerializable<ScriptUpdate>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptUpdate_003E_002EGreedySerializer;

	private static readonly ISerializer<ScriptUpdate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptUpdate_003E_002EGreedyMutableSerializer;

	static ISerializer<ScriptUpdate> IFlatBufferSerializable<ScriptUpdate>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptUpdate_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ScriptUpdate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptUpdate_003E_002EProgressiveSerializer;

	static ISerializer<ScriptUpdate> IFlatBufferSerializable<ScriptUpdate>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptUpdate_003E_002EProgressiveSerializer;

	static ScriptUpdate()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptUpdate_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptUpdate_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptUpdate_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptUpdate_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ScriptUpdate()
	{
		SceneId = 0u;
		Name = null;
		Content = null;
	}

	protected ScriptUpdate(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ScriptUpdate(ScriptUpdate source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		ScriptId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ScriptId);
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Content = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Content);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
