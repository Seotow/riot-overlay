using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N35274406A01A5411664A08E8CCA14CF897B9B2E5633A5B23E5C90EDC9D951CFC;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.SetMarkersRequest")]
public class SetMarkersRequest : IFlatBufferSerializable<SetMarkersRequest>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? CinematicId { get; set; }

	[FlatBufferItem(1)]
	public virtual IList<CinematicMarker>? Markers { get; set; }

	public static ISerializer<SetMarkersRequest> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetMarkersRequest>)this).Serializer;

	ISerializer<SetMarkersRequest> IFlatBufferSerializable<SetMarkersRequest>.Serializer => Serializer;

	private static readonly ISerializer<SetMarkersRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetMarkersRequest_003E_002ELazySerializer;

	static ISerializer<SetMarkersRequest> IFlatBufferSerializable<SetMarkersRequest>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetMarkersRequest_003E_002ELazySerializer;

	private static readonly ISerializer<SetMarkersRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetMarkersRequest_003E_002EGreedySerializer;

	static ISerializer<SetMarkersRequest> IFlatBufferSerializable<SetMarkersRequest>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetMarkersRequest_003E_002EGreedySerializer;

	private static readonly ISerializer<SetMarkersRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetMarkersRequest_003E_002EGreedyMutableSerializer;

	static ISerializer<SetMarkersRequest> IFlatBufferSerializable<SetMarkersRequest>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetMarkersRequest_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetMarkersRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetMarkersRequest_003E_002EProgressiveSerializer;

	static ISerializer<SetMarkersRequest> IFlatBufferSerializable<SetMarkersRequest>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetMarkersRequest_003E_002EProgressiveSerializer;

	static SetMarkersRequest()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetMarkersRequest_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetMarkersRequest_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetMarkersRequest_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetMarkersRequest_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetMarkersRequest()
	{
		CinematicId = null;
		Markers = null;
	}

	protected SetMarkersRequest(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetMarkersRequest(SetMarkersRequest source)
	{
		CinematicId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CinematicId);
		Markers = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Markers);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
