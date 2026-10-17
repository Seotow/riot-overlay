using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.ND6D8395394E711F9DA22C8A200A94FFA855F4F19C7D507E2D34285B290B7591C;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.CameraState")]
public class CameraState : IFlatBufferSerializable<CameraState>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual Vector3? Pos { get; set; }

	[FlatBufferItem(1)]
	public virtual float RotYaw { get; set; }

	[FlatBufferItem(2)]
	public virtual float RotPitch { get; set; }

	[FlatBufferItem(3)]
	public virtual float RotRoll { get; set; }

	[FlatBufferItem(4)]
	public virtual Vector3? Vel { get; set; }

	[FlatBufferItem(5)]
	public virtual bool IsTeleport { get; set; }

	[FlatBufferItem(6)]
	public virtual ulong UtcTime { get; set; }

	[FlatBufferItem(7)]
	public virtual uint Sequence { get; set; }

	public static ISerializer<CameraState> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<CameraState>)this).Serializer;

	ISerializer<CameraState> IFlatBufferSerializable<CameraState>.Serializer => Serializer;

	private static readonly ISerializer<CameraState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECameraState_003E_002ELazySerializer;

	static ISerializer<CameraState> IFlatBufferSerializable<CameraState>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECameraState_003E_002ELazySerializer;

	private static readonly ISerializer<CameraState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECameraState_003E_002EGreedySerializer;

	static ISerializer<CameraState> IFlatBufferSerializable<CameraState>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECameraState_003E_002EGreedySerializer;

	private static readonly ISerializer<CameraState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECameraState_003E_002EGreedyMutableSerializer;

	static ISerializer<CameraState> IFlatBufferSerializable<CameraState>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECameraState_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<CameraState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECameraState_003E_002EProgressiveSerializer;

	static ISerializer<CameraState> IFlatBufferSerializable<CameraState>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECameraState_003E_002EProgressiveSerializer;

	static CameraState()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECameraState_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECameraState_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECameraState_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESnapshot_002ECameraState_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public CameraState()
	{
		Pos = null;
		RotYaw = 0f;
		RotPitch = 0f;
		RotRoll = 0f;
		Vel = null;
		IsTeleport = false;
		UtcTime = 0uL;
		Sequence = 0u;
	}

	protected CameraState(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public CameraState(CameraState source)
	{
		Pos = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Pos);
		RotYaw = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RotYaw);
		RotPitch = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RotPitch);
		RotRoll = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RotRoll);
		Vel = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Vel);
		IsTeleport = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.IsTeleport);
		UtcTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.UtcTime);
		Sequence = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Sequence);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
