using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NAEE366ACB44060E7B82B884516A8345C2E4FEA4F970D9330E2D9631A71A065BC;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.ScriptAsset")]
public class ScriptAsset : IFlatBufferSerializable<ScriptAsset>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Id { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required string Name { get; set; }

	[FlatBufferItem(2)]
	public virtual string? Content { get; set; }

	[FlatBufferItem(3)]
	public virtual IList<ScriptVariable>? Variables { get; set; }

	public static ISerializer<ScriptAsset> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ScriptAsset>)this).Serializer;

	ISerializer<ScriptAsset> IFlatBufferSerializable<ScriptAsset>.Serializer => Serializer;

	private static readonly ISerializer<ScriptAsset> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAsset_003E_002ELazySerializer;

	static ISerializer<ScriptAsset> IFlatBufferSerializable<ScriptAsset>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAsset_003E_002ELazySerializer;

	private static readonly ISerializer<ScriptAsset> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAsset_003E_002EGreedySerializer;

	static ISerializer<ScriptAsset> IFlatBufferSerializable<ScriptAsset>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAsset_003E_002EGreedySerializer;

	private static readonly ISerializer<ScriptAsset> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAsset_003E_002EGreedyMutableSerializer;

	static ISerializer<ScriptAsset> IFlatBufferSerializable<ScriptAsset>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAsset_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ScriptAsset> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAsset_003E_002EProgressiveSerializer;

	static ISerializer<ScriptAsset> IFlatBufferSerializable<ScriptAsset>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAsset_003E_002EProgressiveSerializer;

	static ScriptAsset()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAsset_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAsset_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAsset_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptAsset_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ScriptAsset()
	{
		Content = null;
		Variables = null;
	}

	protected ScriptAsset(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ScriptAsset(ScriptAsset source)
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
