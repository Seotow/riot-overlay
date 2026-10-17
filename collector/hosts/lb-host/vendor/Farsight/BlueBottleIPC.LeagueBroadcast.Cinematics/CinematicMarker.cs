using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NBA4F4FBA921636BE8B488F2A6F351EA6AB9A48D9AE55A369F1DAE27BD38ACC1F;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicMarker")]
public class CinematicMarker : IFlatBufferSerializable<CinematicMarker>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual float Time { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Name { get; set; }

	[FlatBufferItem(2, DefaultValue = true)]
	public virtual bool EmitOnce { get; set; }

	public static ISerializer<CinematicMarker> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CinematicMarker>)this).Serializer;

	ISerializer<CinematicMarker> IFlatBufferSerializable<CinematicMarker>.Serializer => Serializer;

	private static readonly ISerializer<CinematicMarker> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicMarker_003E_002ELazySerializer;

	static ISerializer<CinematicMarker> IFlatBufferSerializable<CinematicMarker>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicMarker_003E_002ELazySerializer;

	private static readonly ISerializer<CinematicMarker> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicMarker_003E_002EGreedySerializer;

	static ISerializer<CinematicMarker> IFlatBufferSerializable<CinematicMarker>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicMarker_003E_002EGreedySerializer;

	private static readonly ISerializer<CinematicMarker> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicMarker_003E_002EGreedyMutableSerializer;

	static ISerializer<CinematicMarker> IFlatBufferSerializable<CinematicMarker>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicMarker_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CinematicMarker> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicMarker_003E_002EProgressiveSerializer;

	static ISerializer<CinematicMarker> IFlatBufferSerializable<CinematicMarker>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicMarker_003E_002EProgressiveSerializer;

	static CinematicMarker()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicMarker_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicMarker_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicMarker_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ECinematicMarker_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CinematicMarker()
	{
		Time = 0f;
		Name = null;
		EmitOnce = true;
	}

	protected CinematicMarker(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CinematicMarker(CinematicMarker source)
	{
		Time = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Time);
		Name = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Name);
		EmitOnce = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EmitOnce);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
