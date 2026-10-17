using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N723B83EBF9F923C095BAC53C6D757C39546F7BEA4A60F67CD2820C84BB0A9AF4;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Entity.ComponentStreamSource")]
public class ComponentStreamSource : IFlatBufferSerializable<ComponentStreamSource>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? StreamName { get; set; }

	[FlatBufferItem(1)]
	public virtual byte Format { get; set; }

	[FlatBufferItem(2)]
	public virtual bool AutoStart { get; set; }

	public static ISerializer<ComponentStreamSource> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ComponentStreamSource>)this).Serializer;

	ISerializer<ComponentStreamSource> IFlatBufferSerializable<ComponentStreamSource>.Serializer => Serializer;

	private static readonly ISerializer<ComponentStreamSource> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentStreamSource_003E_002ELazySerializer;

	static ISerializer<ComponentStreamSource> IFlatBufferSerializable<ComponentStreamSource>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentStreamSource_003E_002ELazySerializer;

	private static readonly ISerializer<ComponentStreamSource> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentStreamSource_003E_002EGreedySerializer;

	static ISerializer<ComponentStreamSource> IFlatBufferSerializable<ComponentStreamSource>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentStreamSource_003E_002EGreedySerializer;

	private static readonly ISerializer<ComponentStreamSource> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentStreamSource_003E_002EGreedyMutableSerializer;

	static ISerializer<ComponentStreamSource> IFlatBufferSerializable<ComponentStreamSource>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentStreamSource_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ComponentStreamSource> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentStreamSource_003E_002EProgressiveSerializer;

	static ISerializer<ComponentStreamSource> IFlatBufferSerializable<ComponentStreamSource>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentStreamSource_003E_002EProgressiveSerializer;

	static ComponentStreamSource()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentStreamSource_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentStreamSource_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentStreamSource_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentStreamSource_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ComponentStreamSource()
	{
		StreamName = null;
		Format = 0;
		AutoStart = false;
	}

	protected ComponentStreamSource(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ComponentStreamSource(ComponentStreamSource source)
	{
		StreamName = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.StreamName);
		Format = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Format);
		AutoStart = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AutoStart);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
