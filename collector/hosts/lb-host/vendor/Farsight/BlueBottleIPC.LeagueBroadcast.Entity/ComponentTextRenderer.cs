using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N1CE29980970708520611434CAE77FA847B3634B8909E0FA0EBA980ED85EFB7AA;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Entity.ComponentTextRenderer")]
public class ComponentTextRenderer : IFlatBufferSerializable<ComponentTextRenderer>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? Text { get; set; }

	[FlatBufferItem(1)]
	public virtual string? FontName { get; set; }

	[FlatBufferItem(2, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required ColorRGBA Color { get; set; }

	[FlatBufferItem(3)]
	public virtual bool Billboard { get; set; }

	public static ISerializer<ComponentTextRenderer> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ComponentTextRenderer>)this).Serializer;

	ISerializer<ComponentTextRenderer> IFlatBufferSerializable<ComponentTextRenderer>.Serializer => Serializer;

	private static readonly ISerializer<ComponentTextRenderer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTextRenderer_003E_002ELazySerializer;

	static ISerializer<ComponentTextRenderer> IFlatBufferSerializable<ComponentTextRenderer>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTextRenderer_003E_002ELazySerializer;

	private static readonly ISerializer<ComponentTextRenderer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTextRenderer_003E_002EGreedySerializer;

	static ISerializer<ComponentTextRenderer> IFlatBufferSerializable<ComponentTextRenderer>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTextRenderer_003E_002EGreedySerializer;

	private static readonly ISerializer<ComponentTextRenderer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTextRenderer_003E_002EGreedyMutableSerializer;

	static ISerializer<ComponentTextRenderer> IFlatBufferSerializable<ComponentTextRenderer>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTextRenderer_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ComponentTextRenderer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTextRenderer_003E_002EProgressiveSerializer;

	static ISerializer<ComponentTextRenderer> IFlatBufferSerializable<ComponentTextRenderer>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTextRenderer_003E_002EProgressiveSerializer;

	static ComponentTextRenderer()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTextRenderer_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTextRenderer_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTextRenderer_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentTextRenderer_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ComponentTextRenderer()
	{
		Text = null;
		FontName = null;
		Billboard = false;
	}

	protected ComponentTextRenderer(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ComponentTextRenderer(ComponentTextRenderer source)
	{
		Text = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Text);
		FontName = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FontName);
		Color = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Color);
		Billboard = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Billboard);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
