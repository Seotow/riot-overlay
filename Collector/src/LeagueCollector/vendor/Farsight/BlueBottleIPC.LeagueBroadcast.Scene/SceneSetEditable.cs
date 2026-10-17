using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N10B9A7CE752DAFBF3AEC3FD70F796B1D45F41F8328A0CADB1BFAC19B7E6BCD08;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneSetEditable")]
public class SceneSetEditable : IFlatBufferSerializable<SceneSetEditable>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual bool Editable { get; set; }

	public static ISerializer<SceneSetEditable> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneSetEditable>)this).Serializer;

	ISerializer<SceneSetEditable> IFlatBufferSerializable<SceneSetEditable>.Serializer => Serializer;

	private static readonly ISerializer<SceneSetEditable> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetEditable_003E_002ELazySerializer;

	static ISerializer<SceneSetEditable> IFlatBufferSerializable<SceneSetEditable>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetEditable_003E_002ELazySerializer;

	private static readonly ISerializer<SceneSetEditable> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetEditable_003E_002EGreedySerializer;

	static ISerializer<SceneSetEditable> IFlatBufferSerializable<SceneSetEditable>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetEditable_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneSetEditable> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetEditable_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneSetEditable> IFlatBufferSerializable<SceneSetEditable>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetEditable_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneSetEditable> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetEditable_003E_002EProgressiveSerializer;

	static ISerializer<SceneSetEditable> IFlatBufferSerializable<SceneSetEditable>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetEditable_003E_002EProgressiveSerializer;

	static SceneSetEditable()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetEditable_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetEditable_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetEditable_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneSetEditable_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneSetEditable()
	{
		SceneId = 0u;
		Editable = false;
	}

	protected SceneSetEditable(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneSetEditable(SceneSetEditable source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		Editable = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Editable);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
