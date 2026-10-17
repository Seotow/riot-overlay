using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N1C46CB7C0B7D4C7E9C3BE0EEFC4E6A608780F614410AEA00290E28A86ED2450A;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.ScriptCreate")]
public class ScriptCreate : IFlatBufferSerializable<ScriptCreate>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Name { get; set; }

	[FlatBufferItem(2)]
	public virtual string? Content { get; set; }

	public static ISerializer<ScriptCreate> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ScriptCreate>)this).Serializer;

	ISerializer<ScriptCreate> IFlatBufferSerializable<ScriptCreate>.Serializer => Serializer;

	private static readonly ISerializer<ScriptCreate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptCreate_003E_002ELazySerializer;

	static ISerializer<ScriptCreate> IFlatBufferSerializable<ScriptCreate>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptCreate_003E_002ELazySerializer;

	private static readonly ISerializer<ScriptCreate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptCreate_003E_002EGreedySerializer;

	static ISerializer<ScriptCreate> IFlatBufferSerializable<ScriptCreate>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptCreate_003E_002EGreedySerializer;

	private static readonly ISerializer<ScriptCreate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptCreate_003E_002EGreedyMutableSerializer;

	static ISerializer<ScriptCreate> IFlatBufferSerializable<ScriptCreate>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptCreate_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ScriptCreate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptCreate_003E_002EProgressiveSerializer;

	static ISerializer<ScriptCreate> IFlatBufferSerializable<ScriptCreate>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptCreate_003E_002EProgressiveSerializer;

	static ScriptCreate()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptCreate_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptCreate_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptCreate_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptCreate_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ScriptCreate()
	{
		SceneId = 0u;
		Name = null;
		Content = null;
	}

	protected ScriptCreate(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ScriptCreate(ScriptCreate source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Content = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Content);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
