using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N1087C7BBE897D60D5114078C7FF778BA37BC612673B0664E09465992350BF286;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.ScriptValidate")]
public class ScriptValidate : IFlatBufferSerializable<ScriptValidate>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? Name { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Content { get; set; }

	public static ISerializer<ScriptValidate> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ScriptValidate>)this).Serializer;

	ISerializer<ScriptValidate> IFlatBufferSerializable<ScriptValidate>.Serializer => Serializer;

	private static readonly ISerializer<ScriptValidate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptValidate_003E_002ELazySerializer;

	static ISerializer<ScriptValidate> IFlatBufferSerializable<ScriptValidate>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptValidate_003E_002ELazySerializer;

	private static readonly ISerializer<ScriptValidate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptValidate_003E_002EGreedySerializer;

	static ISerializer<ScriptValidate> IFlatBufferSerializable<ScriptValidate>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptValidate_003E_002EGreedySerializer;

	private static readonly ISerializer<ScriptValidate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptValidate_003E_002EGreedyMutableSerializer;

	static ISerializer<ScriptValidate> IFlatBufferSerializable<ScriptValidate>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptValidate_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ScriptValidate> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptValidate_003E_002EProgressiveSerializer;

	static ISerializer<ScriptValidate> IFlatBufferSerializable<ScriptValidate>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptValidate_003E_002EProgressiveSerializer;

	static ScriptValidate()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptValidate_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptValidate_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptValidate_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptValidate_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ScriptValidate()
	{
		Name = null;
	}

	protected ScriptValidate(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ScriptValidate(ScriptValidate source)
	{
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Content = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Content);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
