using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N1E3EF9587AB2AADC68D2E4B7C3F0A89A26D1E41B01A1EF25D2E0032DE5DB3952;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.PropStyle")]
public class PropStyle : IFlatBufferSerializable<PropStyle>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual int FontIndex { get; set; }

	[FlatBufferItem(1, DefaultValue = byte.MaxValue)]
	public virtual byte ColorR { get; set; }

	[FlatBufferItem(2, DefaultValue = byte.MaxValue)]
	public virtual byte ColorG { get; set; }

	[FlatBufferItem(3, DefaultValue = byte.MaxValue)]
	public virtual byte ColorB { get; set; }

	[FlatBufferItem(4, DefaultValue = byte.MaxValue)]
	public virtual byte ColorA { get; set; }

	[FlatBufferItem(5, DefaultValue = 32f)]
	public virtual float FontSize { get; set; }

	[FlatBufferItem(6)]
	public virtual PropOrientation Orientation { get; set; }

	public static ISerializer<PropStyle> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<PropStyle>)this).Serializer;

	ISerializer<PropStyle> IFlatBufferSerializable<PropStyle>.Serializer => Serializer;

	private static readonly ISerializer<PropStyle> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EPropStyle_003E_002ELazySerializer;

	static ISerializer<PropStyle> IFlatBufferSerializable<PropStyle>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EPropStyle_003E_002ELazySerializer;

	private static readonly ISerializer<PropStyle> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EPropStyle_003E_002EGreedySerializer;

	static ISerializer<PropStyle> IFlatBufferSerializable<PropStyle>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EPropStyle_003E_002EGreedySerializer;

	private static readonly ISerializer<PropStyle> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EPropStyle_003E_002EGreedyMutableSerializer;

	static ISerializer<PropStyle> IFlatBufferSerializable<PropStyle>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EPropStyle_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<PropStyle> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EPropStyle_003E_002EProgressiveSerializer;

	static ISerializer<PropStyle> IFlatBufferSerializable<PropStyle>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EPropStyle_003E_002EProgressiveSerializer;

	static PropStyle()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EPropStyle_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EPropStyle_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EPropStyle_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002EPropStyle_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public PropStyle()
	{
		FontIndex = 0;
		ColorR = byte.MaxValue;
		ColorG = byte.MaxValue;
		ColorB = byte.MaxValue;
		ColorA = byte.MaxValue;
		FontSize = 32f;
		Orientation = PropOrientation.FaceCamera;
	}

	protected PropStyle(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public PropStyle(PropStyle source)
	{
		FontIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FontIndex);
		ColorR = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ColorR);
		ColorG = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ColorG);
		ColorB = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ColorB);
		ColorA = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ColorA);
		FontSize = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FontSize);
		Orientation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Orientation);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
