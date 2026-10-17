using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NC9780113534523AD662A33FF68B919970EF7075D2D9C890E6E92E0B42D1D6857;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.ScriptAssetSnapshot")]
public class ScriptAssetSnapshot : IFlatBufferSerializable<ScriptAssetSnapshot>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Id { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Name { get; set; }

	[FlatBufferItem(2)]
	public virtual string? Content { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<ScriptVariableSnapshot>? Variables { get; set; }

	public static ISerializer<ScriptAssetSnapshot> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ScriptAssetSnapshot>)this).Serializer;

	ISerializer<ScriptAssetSnapshot> IFlatBufferSerializable<ScriptAssetSnapshot>.Serializer => Serializer;

	private static readonly ISerializer<ScriptAssetSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetSnapshot_003E_002ELazySerializer;

	static ISerializer<ScriptAssetSnapshot> IFlatBufferSerializable<ScriptAssetSnapshot>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetSnapshot_003E_002ELazySerializer;

	private static readonly ISerializer<ScriptAssetSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetSnapshot_003E_002EGreedySerializer;

	static ISerializer<ScriptAssetSnapshot> IFlatBufferSerializable<ScriptAssetSnapshot>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetSnapshot_003E_002EGreedySerializer;

	private static readonly ISerializer<ScriptAssetSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetSnapshot_003E_002EGreedyMutableSerializer;

	static ISerializer<ScriptAssetSnapshot> IFlatBufferSerializable<ScriptAssetSnapshot>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetSnapshot_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ScriptAssetSnapshot> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetSnapshot_003E_002EProgressiveSerializer;

	static ISerializer<ScriptAssetSnapshot> IFlatBufferSerializable<ScriptAssetSnapshot>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetSnapshot_003E_002EProgressiveSerializer;

	static ScriptAssetSnapshot()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetSnapshot_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetSnapshot_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetSnapshot_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAssetSnapshot_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ScriptAssetSnapshot()
	{
		Name = null;
		Content = null;
		Variables = null;
	}

	protected ScriptAssetSnapshot(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ScriptAssetSnapshot(ScriptAssetSnapshot source)
	{
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Content = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Content);
		Variables = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Variables);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
