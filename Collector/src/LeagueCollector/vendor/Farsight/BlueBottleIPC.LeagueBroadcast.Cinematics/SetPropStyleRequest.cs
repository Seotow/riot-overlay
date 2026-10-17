using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.ND04D4537E2853BEBA113257552626A4E72962436D35A21894684376F824EEB71;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Cinematics.SetPropStyleRequest")]
public class SetPropStyleRequest : IFlatBufferSerializable<SetPropStyleRequest>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual string? CinematicId { get; set; }

	[FlatBufferItem(1)]
	public virtual string? PropId { get; set; }

	[FlatBufferItem(2)]
	public virtual PropStyle? Style { get; set; }

	public static ISerializer<SetPropStyleRequest> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetPropStyleRequest>)this).Serializer;

	ISerializer<SetPropStyleRequest> IFlatBufferSerializable<SetPropStyleRequest>.Serializer => Serializer;

	private static readonly ISerializer<SetPropStyleRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetPropStyleRequest_003E_002ELazySerializer;

	static ISerializer<SetPropStyleRequest> IFlatBufferSerializable<SetPropStyleRequest>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetPropStyleRequest_003E_002ELazySerializer;

	private static readonly ISerializer<SetPropStyleRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetPropStyleRequest_003E_002EGreedySerializer;

	static ISerializer<SetPropStyleRequest> IFlatBufferSerializable<SetPropStyleRequest>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetPropStyleRequest_003E_002EGreedySerializer;

	private static readonly ISerializer<SetPropStyleRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetPropStyleRequest_003E_002EGreedyMutableSerializer;

	static ISerializer<SetPropStyleRequest> IFlatBufferSerializable<SetPropStyleRequest>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetPropStyleRequest_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetPropStyleRequest> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetPropStyleRequest_003E_002EProgressiveSerializer;

	static ISerializer<SetPropStyleRequest> IFlatBufferSerializable<SetPropStyleRequest>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetPropStyleRequest_003E_002EProgressiveSerializer;

	static SetPropStyleRequest()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetPropStyleRequest_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetPropStyleRequest_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetPropStyleRequest_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECinematics_002ESetPropStyleRequest_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetPropStyleRequest()
	{
		CinematicId = null;
		PropId = null;
		Style = null;
	}

	protected SetPropStyleRequest(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetPropStyleRequest(SetPropStyleRequest source)
	{
		CinematicId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CinematicId);
		PropId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PropId);
		Style = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Style);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
