using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N405CCDF1EC5A3D244FABF790E241DD351BBA7686D1907F197BB89423321DCBF5;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Scene.EntityAssignment")]
public class EntityAssignment : IFlatBufferSerializable<EntityAssignment>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint ClientIndex { get; set; }

	[FlatBufferItem(1)]
	public virtual ulong RequestedId { get; set; }

	[FlatBufferItem(2)]
	public virtual ulong AssignedId { get; set; }

	[FlatBufferItem(3)]
	public virtual string? SourcePath { get; set; }

	public static ISerializer<EntityAssignment> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<EntityAssignment>)this).Serializer;

	ISerializer<EntityAssignment> IFlatBufferSerializable<EntityAssignment>.Serializer => Serializer;

	private static readonly ISerializer<EntityAssignment> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityAssignment_003E_002ELazySerializer;

	static ISerializer<EntityAssignment> IFlatBufferSerializable<EntityAssignment>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityAssignment_003E_002ELazySerializer;

	private static readonly ISerializer<EntityAssignment> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityAssignment_003E_002EGreedySerializer;

	static ISerializer<EntityAssignment> IFlatBufferSerializable<EntityAssignment>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityAssignment_003E_002EGreedySerializer;

	private static readonly ISerializer<EntityAssignment> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityAssignment_003E_002EGreedyMutableSerializer;

	static ISerializer<EntityAssignment> IFlatBufferSerializable<EntityAssignment>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityAssignment_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<EntityAssignment> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityAssignment_003E_002EProgressiveSerializer;

	static ISerializer<EntityAssignment> IFlatBufferSerializable<EntityAssignment>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityAssignment_003E_002EProgressiveSerializer;

	static EntityAssignment()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityAssignment_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityAssignment_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityAssignment_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EScene_002EEntityAssignment_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public EntityAssignment()
	{
		ClientIndex = 0u;
		RequestedId = 0uL;
		AssignedId = 0uL;
		SourcePath = null;
	}

	protected EntityAssignment(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public EntityAssignment(EntityAssignment source)
	{
		ClientIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ClientIndex);
		RequestedId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RequestedId);
		AssignedId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AssignedId);
		SourcePath = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SourcePath);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
