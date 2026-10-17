using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N559C64490EB42C80A2F10A30999A9652C39CE5656F47946E81274887B3E4825E;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Entity.ComponentSpriteRenderer")]
public class ComponentSpriteRenderer : IFlatBufferSerializable<ComponentSpriteRenderer>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual AssetIdentifier? Texture { get; set; }

	[FlatBufferItem(2)]
	public virtual ColorRGBA? TintColor { get; set; }

	[FlatBufferItem(3, DefaultValue = 1f)]
	public virtual float Width { get; set; }

	[FlatBufferItem(4, DefaultValue = 1f)]
	public virtual float Height { get; set; }

	[FlatBufferItem(5, DefaultValue = true)]
	public virtual bool Billboard { get; set; }

	public static ISerializer<ComponentSpriteRenderer> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ComponentSpriteRenderer>)this).Serializer;

	ISerializer<ComponentSpriteRenderer> IFlatBufferSerializable<ComponentSpriteRenderer>.Serializer => Serializer;

	private static readonly ISerializer<ComponentSpriteRenderer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentSpriteRenderer_003E_002ELazySerializer;

	static ISerializer<ComponentSpriteRenderer> IFlatBufferSerializable<ComponentSpriteRenderer>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentSpriteRenderer_003E_002ELazySerializer;

	private static readonly ISerializer<ComponentSpriteRenderer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentSpriteRenderer_003E_002EGreedySerializer;

	static ISerializer<ComponentSpriteRenderer> IFlatBufferSerializable<ComponentSpriteRenderer>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentSpriteRenderer_003E_002EGreedySerializer;

	private static readonly ISerializer<ComponentSpriteRenderer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentSpriteRenderer_003E_002EGreedyMutableSerializer;

	static ISerializer<ComponentSpriteRenderer> IFlatBufferSerializable<ComponentSpriteRenderer>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentSpriteRenderer_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ComponentSpriteRenderer> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentSpriteRenderer_003E_002EProgressiveSerializer;

	static ISerializer<ComponentSpriteRenderer> IFlatBufferSerializable<ComponentSpriteRenderer>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentSpriteRenderer_003E_002EProgressiveSerializer;

	static ComponentSpriteRenderer()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentSpriteRenderer_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentSpriteRenderer_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentSpriteRenderer_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentSpriteRenderer_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ComponentSpriteRenderer()
	{
		Texture = null;
		TintColor = null;
		Width = 1f;
		Height = 1f;
		Billboard = true;
	}

	protected ComponentSpriteRenderer(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ComponentSpriteRenderer(ComponentSpriteRenderer source)
	{
		Texture = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Texture);
		TintColor = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TintColor);
		Width = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Width);
		Height = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Height);
		Billboard = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Billboard);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
