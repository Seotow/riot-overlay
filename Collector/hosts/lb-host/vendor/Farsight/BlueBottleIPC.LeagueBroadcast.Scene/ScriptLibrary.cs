using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N23C2CEF26C0097F5F439C74DCB1B18DD01DB9B6CE9A819213364551F87D40BBF;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.ScriptLibrary")]
public class ScriptLibrary : IFlatBufferSerializable<ScriptLibrary>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<ScriptAssetSnapshot>? Assets { get; set; }

	public static ISerializer<ScriptLibrary> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ScriptLibrary>)this).Serializer;

	ISerializer<ScriptLibrary> IFlatBufferSerializable<ScriptLibrary>.Serializer => Serializer;

	private static readonly ISerializer<ScriptLibrary> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptLibrary_003E_002ELazySerializer;

	static ISerializer<ScriptLibrary> IFlatBufferSerializable<ScriptLibrary>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptLibrary_003E_002ELazySerializer;

	private static readonly ISerializer<ScriptLibrary> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptLibrary_003E_002EGreedySerializer;

	static ISerializer<ScriptLibrary> IFlatBufferSerializable<ScriptLibrary>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptLibrary_003E_002EGreedySerializer;

	private static readonly ISerializer<ScriptLibrary> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptLibrary_003E_002EGreedyMutableSerializer;

	static ISerializer<ScriptLibrary> IFlatBufferSerializable<ScriptLibrary>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptLibrary_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ScriptLibrary> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptLibrary_003E_002EProgressiveSerializer;

	static ISerializer<ScriptLibrary> IFlatBufferSerializable<ScriptLibrary>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptLibrary_003E_002EProgressiveSerializer;

	static ScriptLibrary()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptLibrary_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptLibrary_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptLibrary_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EScriptLibrary_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ScriptLibrary()
	{
		SceneId = 0u;
		Assets = null;
	}

	protected ScriptLibrary(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ScriptLibrary(ScriptLibrary source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		Assets = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Assets);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
