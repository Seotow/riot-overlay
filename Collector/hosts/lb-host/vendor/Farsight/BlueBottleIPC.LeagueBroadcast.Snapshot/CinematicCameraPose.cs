using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N993E8B2AB124F4242D40F3827448F71C32B2D4A22A0EC4BB39E9926CE3404BAF;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.CinematicCameraPose")]
public class CinematicCameraPose : IFlatBufferSerializable<CinematicCameraPose>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual bool Available { get; set; }

	[FlatBufferItem(1)]
	public virtual bool IsFreeCamera { get; set; }

	[FlatBufferItem(2)]
	public virtual Vector3? Position { get; set; }

	[FlatBufferItem(3)]
	public virtual Vector3? Rotation { get; set; }

	[FlatBufferItem(4)]
	public virtual float Zoom { get; set; }

	[FlatBufferItem(5)]
	public virtual float Fov { get; set; }

	[FlatBufferItem(6)]
	public virtual byte Channels { get; set; }

	public static ISerializer<CinematicCameraPose> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CinematicCameraPose>)this).Serializer;

	ISerializer<CinematicCameraPose> IFlatBufferSerializable<CinematicCameraPose>.Serializer => Serializer;

	private static readonly ISerializer<CinematicCameraPose> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraPose_003E_002ELazySerializer;

	static ISerializer<CinematicCameraPose> IFlatBufferSerializable<CinematicCameraPose>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraPose_003E_002ELazySerializer;

	private static readonly ISerializer<CinematicCameraPose> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraPose_003E_002EGreedySerializer;

	static ISerializer<CinematicCameraPose> IFlatBufferSerializable<CinematicCameraPose>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraPose_003E_002EGreedySerializer;

	private static readonly ISerializer<CinematicCameraPose> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraPose_003E_002EGreedyMutableSerializer;

	static ISerializer<CinematicCameraPose> IFlatBufferSerializable<CinematicCameraPose>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraPose_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CinematicCameraPose> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraPose_003E_002EProgressiveSerializer;

	static ISerializer<CinematicCameraPose> IFlatBufferSerializable<CinematicCameraPose>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraPose_003E_002EProgressiveSerializer;

	static CinematicCameraPose()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraPose_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraPose_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraPose_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECinematicCameraPose_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CinematicCameraPose()
	{
		Available = false;
		IsFreeCamera = false;
		Position = null;
		Rotation = null;
		Zoom = 0f;
		Fov = 0f;
		Channels = 0;
	}

	protected CinematicCameraPose(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CinematicCameraPose(CinematicCameraPose source)
	{
		Available = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Available);
		IsFreeCamera = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.IsFreeCamera);
		Position = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Position);
		Rotation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Rotation);
		Zoom = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Zoom);
		Fov = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Fov);
		Channels = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Channels);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
