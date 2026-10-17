using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N62CD60CBC0356FDE30260B80C0BAE4F23F41A6FE12582434DC1DA3C65CB1F169;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicPlayback")]
public class CinematicPlayback : IFlatBufferSerializable<CinematicPlayback>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? CinematicId { get; set; }

	[FlatBufferItem(1)]
	public virtual float Time { get; set; }

	[FlatBufferItem(2)]
	public virtual float Length { get; set; }

	[FlatBufferItem(3)]
	public virtual string? State { get; set; }

	[FlatBufferItem(4)]
	public virtual bool Playing { get; set; }

	public static ISerializer<CinematicPlayback> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CinematicPlayback>)this).Serializer;

	ISerializer<CinematicPlayback> IFlatBufferSerializable<CinematicPlayback>.Serializer => Serializer;

	private static readonly ISerializer<CinematicPlayback> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicPlayback_003E_002ELazySerializer;

	static ISerializer<CinematicPlayback> IFlatBufferSerializable<CinematicPlayback>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicPlayback_003E_002ELazySerializer;

	private static readonly ISerializer<CinematicPlayback> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicPlayback_003E_002EGreedySerializer;

	static ISerializer<CinematicPlayback> IFlatBufferSerializable<CinematicPlayback>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicPlayback_003E_002EGreedySerializer;

	private static readonly ISerializer<CinematicPlayback> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicPlayback_003E_002EGreedyMutableSerializer;

	static ISerializer<CinematicPlayback> IFlatBufferSerializable<CinematicPlayback>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicPlayback_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CinematicPlayback> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicPlayback_003E_002EProgressiveSerializer;

	static ISerializer<CinematicPlayback> IFlatBufferSerializable<CinematicPlayback>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicPlayback_003E_002EProgressiveSerializer;

	static CinematicPlayback()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicPlayback_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicPlayback_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicPlayback_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicPlayback_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CinematicPlayback()
	{
		CinematicId = null;
		Time = 0f;
		Length = 0f;
		State = null;
		Playing = false;
	}

	protected CinematicPlayback(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CinematicPlayback(CinematicPlayback source)
	{
		CinematicId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CinematicId);
		Time = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Time);
		Length = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Length);
		State = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.State);
		Playing = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Playing);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
