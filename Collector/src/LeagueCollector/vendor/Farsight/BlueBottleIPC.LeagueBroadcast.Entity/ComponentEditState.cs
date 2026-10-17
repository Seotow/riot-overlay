using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N0E8BE41C014BEDA7170D52DF6BFF9D47C366F712224B9EE97715CF1BB3FF6DEF;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Entity.ComponentEditState")]
public class ComponentEditState : IFlatBufferSerializable<ComponentEditState>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual bool EditMode { get; set; }

	[FlatBufferItem(1)]
	public virtual bool LinkedToCursor { get; set; }

	[FlatBufferItem(2)]
	public virtual float CursorConstraintX { get; set; }

	[FlatBufferItem(3)]
	public virtual float CursorConstraintZ { get; set; }

	[FlatBufferItem(4)]
	public virtual float CursorConstraintRadius { get; set; }

	public static ISerializer<ComponentEditState> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<ComponentEditState>)this).Serializer;

	ISerializer<ComponentEditState> IFlatBufferSerializable<ComponentEditState>.Serializer => Serializer;

	private static readonly ISerializer<ComponentEditState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentEditState_003E_002ELazySerializer;

	static ISerializer<ComponentEditState> IFlatBufferSerializable<ComponentEditState>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentEditState_003E_002ELazySerializer;

	private static readonly ISerializer<ComponentEditState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentEditState_003E_002EGreedySerializer;

	static ISerializer<ComponentEditState> IFlatBufferSerializable<ComponentEditState>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentEditState_003E_002EGreedySerializer;

	private static readonly ISerializer<ComponentEditState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentEditState_003E_002EGreedyMutableSerializer;

	static ISerializer<ComponentEditState> IFlatBufferSerializable<ComponentEditState>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentEditState_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<ComponentEditState> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentEditState_003E_002EProgressiveSerializer;

	static ISerializer<ComponentEditState> IFlatBufferSerializable<ComponentEditState>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentEditState_003E_002EProgressiveSerializer;

	static ComponentEditState()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentEditState_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentEditState_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentEditState_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002EEntity_002EComponentEditState_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public ComponentEditState()
	{
		EditMode = false;
		LinkedToCursor = false;
		CursorConstraintX = 0f;
		CursorConstraintZ = 0f;
		CursorConstraintRadius = 0f;
	}

	protected ComponentEditState(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public ComponentEditState(ComponentEditState source)
	{
		EditMode = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EditMode);
		LinkedToCursor = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LinkedToCursor);
		CursorConstraintX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CursorConstraintX);
		CursorConstraintZ = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CursorConstraintZ);
		CursorConstraintRadius = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CursorConstraintRadius);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
