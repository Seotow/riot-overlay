using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NF688861FB2AFD76432ACA42547B1899571F0EBA88BC62C54D54FFD56FA8D0EBE;

namespace BlueBottleIPC.LeagueBroadcast.Sequencer;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Sequencer.Binding")]
public class Binding : IFlatBufferSerializable<Binding>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual uint Id { get; set; }

	[FlatBufferItem(1)]
	public virtual TargetKind Target { get; set; }

	[FlatBufferItem(2)]
	public virtual string? EntityName { get; set; }

	[FlatBufferItem(3)]
	public virtual ulong EntityId { get; set; }

	[FlatBufferItem(4)]
	public virtual string? PropId { get; set; }

	[FlatBufferItem(5)]
	public virtual string? Label { get; set; }

	[FlatBufferItem(6)]
	public virtual string? SceneName { get; set; }

	public static ISerializer<Binding> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<Binding>)this).Serializer;

	ISerializer<Binding> IFlatBufferSerializable<Binding>.Serializer => Serializer;

	private static readonly ISerializer<Binding> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EBinding_003E_002ELazySerializer;

	static ISerializer<Binding> IFlatBufferSerializable<Binding>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EBinding_003E_002ELazySerializer;

	private static readonly ISerializer<Binding> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EBinding_003E_002EGreedySerializer;

	static ISerializer<Binding> IFlatBufferSerializable<Binding>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EBinding_003E_002EGreedySerializer;

	private static readonly ISerializer<Binding> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EBinding_003E_002EGreedyMutableSerializer;

	static ISerializer<Binding> IFlatBufferSerializable<Binding>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EBinding_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<Binding> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EBinding_003E_002EProgressiveSerializer;

	static ISerializer<Binding> IFlatBufferSerializable<Binding>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EBinding_003E_002EProgressiveSerializer;

	static Binding()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EBinding_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EBinding_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EBinding_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ESequencer_002EBinding_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public Binding()
	{
		Id = 0u;
		Target = TargetKind.Entity;
		EntityName = null;
		EntityId = 0uL;
		PropId = null;
		Label = null;
		SceneName = null;
	}

	protected Binding(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Binding(Binding source)
	{
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
		Target = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Target);
		EntityName = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EntityName);
		EntityId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.EntityId);
		PropId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PropId);
		Label = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Label);
		SceneName = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SceneName);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
