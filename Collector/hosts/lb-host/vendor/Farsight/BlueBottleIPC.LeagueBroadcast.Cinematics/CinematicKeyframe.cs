using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NC4F249BA6A15887322A63793EF41E20A9C30529B83B1963F79FB2EF873740884;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicKeyframe")]
public class CinematicKeyframe : IFlatBufferSerializable<CinematicKeyframe>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual float Time { get; set; }

	[FlatBufferItem(1)]
	public virtual float X { get; set; }

	[FlatBufferItem(2)]
	public virtual float Y { get; set; }

	[FlatBufferItem(3)]
	public virtual float Z { get; set; }

	[FlatBufferItem(4)]
	public virtual float FloatValue { get; set; }

	[FlatBufferItem(5)]
	public virtual bool BoolValue { get; set; }

	[FlatBufferItem(6)]
	public virtual BlendEasing Easing { get; set; }

	public static ISerializer<CinematicKeyframe> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CinematicKeyframe>)this).Serializer;

	ISerializer<CinematicKeyframe> IFlatBufferSerializable<CinematicKeyframe>.Serializer => Serializer;

	private static readonly ISerializer<CinematicKeyframe> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicKeyframe_003E_002ELazySerializer;

	static ISerializer<CinematicKeyframe> IFlatBufferSerializable<CinematicKeyframe>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicKeyframe_003E_002ELazySerializer;

	private static readonly ISerializer<CinematicKeyframe> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicKeyframe_003E_002EGreedySerializer;

	static ISerializer<CinematicKeyframe> IFlatBufferSerializable<CinematicKeyframe>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicKeyframe_003E_002EGreedySerializer;

	private static readonly ISerializer<CinematicKeyframe> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicKeyframe_003E_002EGreedyMutableSerializer;

	static ISerializer<CinematicKeyframe> IFlatBufferSerializable<CinematicKeyframe>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicKeyframe_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CinematicKeyframe> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicKeyframe_003E_002EProgressiveSerializer;

	static ISerializer<CinematicKeyframe> IFlatBufferSerializable<CinematicKeyframe>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicKeyframe_003E_002EProgressiveSerializer;

	static CinematicKeyframe()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicKeyframe_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicKeyframe_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicKeyframe_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicKeyframe_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CinematicKeyframe()
	{
		Time = 0f;
		X = 0f;
		Y = 0f;
		Z = 0f;
		FloatValue = 0f;
		BoolValue = false;
		Easing = BlendEasing.Linear;
	}

	protected CinematicKeyframe(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CinematicKeyframe(CinematicKeyframe source)
	{
		Time = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Time);
		X = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.X);
		Y = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Y);
		Z = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Z);
		FloatValue = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FloatValue);
		BoolValue = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BoolValue);
		Easing = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Easing);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
