using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NF059AE0810889155C9687D62B2C8E01A8A8A7A6269A2485856784464480E5A42;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.HudLabel")]
public class HudLabel : IFlatBufferSerializable<HudLabel>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual float X { get; set; }

	[FlatBufferItem(1)]
	public virtual float Z { get; set; }

	[FlatBufferItem(2)]
	public virtual string? Text { get; set; }

	[FlatBufferItem(3)]
	public virtual byte Tone { get; set; }

	[FlatBufferItem(4)]
	public virtual bool Inference { get; set; }

	public static ISerializer<HudLabel> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<HudLabel>)this).Serializer;

	ISerializer<HudLabel> IFlatBufferSerializable<HudLabel>.Serializer => Serializer;

	private static readonly ISerializer<HudLabel> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabel_003E_002ELazySerializer;

	static ISerializer<HudLabel> IFlatBufferSerializable<HudLabel>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabel_003E_002ELazySerializer;

	private static readonly ISerializer<HudLabel> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabel_003E_002EGreedySerializer;

	static ISerializer<HudLabel> IFlatBufferSerializable<HudLabel>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabel_003E_002EGreedySerializer;

	private static readonly ISerializer<HudLabel> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabel_003E_002EGreedyMutableSerializer;

	static ISerializer<HudLabel> IFlatBufferSerializable<HudLabel>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabel_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<HudLabel> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabel_003E_002EProgressiveSerializer;

	static ISerializer<HudLabel> IFlatBufferSerializable<HudLabel>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabel_003E_002EProgressiveSerializer;

	static HudLabel()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabel_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabel_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabel_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002EHudLabel_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public HudLabel()
	{
		X = 0f;
		Z = 0f;
		Text = null;
		Tone = 0;
		Inference = false;
	}

	protected HudLabel(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public HudLabel(HudLabel source)
	{
		X = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.X);
		Z = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Z);
		Text = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Text);
		Tone = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Tone);
		Inference = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Inference);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
