using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N302733F0236A50156BFF02F65E3B48408BBA479896A10F21AB5CD3A57F097C76;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.SequenceTransport")]
public class SequenceTransport : IFlatBufferSerializable<SequenceTransport>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual SequenceTransportCommand Command { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Clip { get; set; }

	[FlatBufferItem(2)]
	public virtual float Time { get; set; }

	[FlatBufferItem(3, DefaultValue = 1f)]
	public virtual float Rate { get; set; }

	[FlatBufferItem(4)]
	public virtual bool Slaved { get; set; }

	[FlatBufferItem(5)]
	public virtual float Anchor { get; set; }

	public static ISerializer<SequenceTransport> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SequenceTransport>)this).Serializer;

	ISerializer<SequenceTransport> IFlatBufferSerializable<SequenceTransport>.Serializer => Serializer;

	private static readonly ISerializer<SequenceTransport> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESequenceTransport_003E_002ELazySerializer;

	static ISerializer<SequenceTransport> IFlatBufferSerializable<SequenceTransport>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESequenceTransport_003E_002ELazySerializer;

	private static readonly ISerializer<SequenceTransport> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESequenceTransport_003E_002EGreedySerializer;

	static ISerializer<SequenceTransport> IFlatBufferSerializable<SequenceTransport>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESequenceTransport_003E_002EGreedySerializer;

	private static readonly ISerializer<SequenceTransport> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESequenceTransport_003E_002EGreedyMutableSerializer;

	static ISerializer<SequenceTransport> IFlatBufferSerializable<SequenceTransport>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESequenceTransport_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SequenceTransport> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESequenceTransport_003E_002EProgressiveSerializer;

	static ISerializer<SequenceTransport> IFlatBufferSerializable<SequenceTransport>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESequenceTransport_003E_002EProgressiveSerializer;

	static SequenceTransport()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESequenceTransport_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESequenceTransport_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESequenceTransport_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESequenceTransport_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SequenceTransport()
	{
		Command = SequenceTransportCommand.Play;
		Clip = null;
		Time = 0f;
		Rate = 1f;
		Slaved = false;
		Anchor = 0f;
	}

	protected SequenceTransport(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SequenceTransport(SequenceTransport source)
	{
		Command = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Command);
		Clip = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Clip);
		Time = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Time);
		Rate = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Rate);
		Slaved = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Slaved);
		Anchor = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Anchor);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
