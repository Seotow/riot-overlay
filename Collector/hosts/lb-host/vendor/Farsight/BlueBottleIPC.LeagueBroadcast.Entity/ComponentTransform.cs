using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N89C289FBD8995A154A152A7DEE8D4E991E03F6DE0BC52462C0B160C99156A1AB;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Entity.ComponentTransform")]
public class ComponentTransform : IFlatBufferSerializable<ComponentTransform>, IFlatBufferSerializable
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required Vector3 Position { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required Quaternion Rotation { get; set; }

	[FlatBufferItem(2, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required Vector3 Scale { get; set; }

	[FlatBufferItem(3)]
	public virtual ulong ParentId { get; set; }

	public static ISerializer<ComponentTransform> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ComponentTransform>)this).Serializer;

	ISerializer<ComponentTransform> IFlatBufferSerializable<ComponentTransform>.Serializer => Serializer;

	private static readonly ISerializer<ComponentTransform> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTransform_003E_002ELazySerializer;

	static ISerializer<ComponentTransform> IFlatBufferSerializable<ComponentTransform>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTransform_003E_002ELazySerializer;

	private static readonly ISerializer<ComponentTransform> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTransform_003E_002EGreedySerializer;

	static ISerializer<ComponentTransform> IFlatBufferSerializable<ComponentTransform>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTransform_003E_002EGreedySerializer;

	private static readonly ISerializer<ComponentTransform> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTransform_003E_002EGreedyMutableSerializer;

	static ISerializer<ComponentTransform> IFlatBufferSerializable<ComponentTransform>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTransform_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ComponentTransform> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTransform_003E_002EProgressiveSerializer;

	static ISerializer<ComponentTransform> IFlatBufferSerializable<ComponentTransform>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTransform_003E_002EProgressiveSerializer;

	static ComponentTransform()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTransform_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTransform_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTransform_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTransform_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ComponentTransform()
	{
		ParentId = 0uL;
	}

	protected ComponentTransform(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ComponentTransform(ComponentTransform source)
	{
		Position = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Position);
		Rotation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Rotation);
		Scale = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Scale);
		ParentId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ParentId);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
