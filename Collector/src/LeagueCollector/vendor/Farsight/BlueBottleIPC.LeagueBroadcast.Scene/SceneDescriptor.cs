using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.SceneDescriptor")]
public class SceneDescriptor : IFlatBufferSerializable<SceneDescriptor>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint SceneId { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Name { get; set; }

	[FlatBufferItem(2, DefaultValue = true)]
	public virtual bool Visible { get; set; }

	[FlatBufferItem(3)]
	public virtual bool Editable { get; set; }

	[FlatBufferItem(4)]
	public virtual int ZOrder { get; set; }

	[FlatBufferItem(5)]
	public virtual uint EntityCount { get; set; }

	[FlatBufferItem(6)]
	public virtual ulong Fingerprint { get; set; }

	public static ISerializer<SceneDescriptor> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SceneDescriptor>)this).Serializer;

	ISerializer<SceneDescriptor> IFlatBufferSerializable<SceneDescriptor>.Serializer => Serializer;

	private static readonly ISerializer<SceneDescriptor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneDescriptor_003E_002ELazySerializer;

	static ISerializer<SceneDescriptor> IFlatBufferSerializable<SceneDescriptor>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneDescriptor_003E_002ELazySerializer;

	private static readonly ISerializer<SceneDescriptor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneDescriptor_003E_002EGreedySerializer;

	static ISerializer<SceneDescriptor> IFlatBufferSerializable<SceneDescriptor>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneDescriptor_003E_002EGreedySerializer;

	private static readonly ISerializer<SceneDescriptor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneDescriptor_003E_002EGreedyMutableSerializer;

	static ISerializer<SceneDescriptor> IFlatBufferSerializable<SceneDescriptor>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneDescriptor_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SceneDescriptor> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneDescriptor_003E_002EProgressiveSerializer;

	static ISerializer<SceneDescriptor> IFlatBufferSerializable<SceneDescriptor>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneDescriptor_003E_002EProgressiveSerializer;

	static SceneDescriptor()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneDescriptor_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneDescriptor_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneDescriptor_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002ESceneDescriptor_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SceneDescriptor()
	{
		SceneId = 0u;
		Name = null;
		Visible = true;
		Editable = false;
		ZOrder = 0;
		EntityCount = 0u;
		Fingerprint = 0uL;
	}

	protected SceneDescriptor(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SceneDescriptor(SceneDescriptor source)
	{
		SceneId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneId);
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		Visible = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Visible);
		Editable = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Editable);
		ZOrder = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ZOrder);
		EntityCount = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EntityCount);
		Fingerprint = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Fingerprint);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
