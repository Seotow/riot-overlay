using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N9C50E52676E12AF39C5F09F4F14CC8C9BA1FD37D63DA6789B6464A0A1A3465E6;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.SetSequence")]
public class SetSequence : IFlatBufferSerializable<SetSequence>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual Memory<byte>? Document { get; set; }

	public static ISerializer<SetSequence> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetSequence>)this).Serializer;

	ISerializer<SetSequence> IFlatBufferSerializable<SetSequence>.Serializer => Serializer;

	private static readonly ISerializer<SetSequence> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSequence_003E_002ELazySerializer;

	static ISerializer<SetSequence> IFlatBufferSerializable<SetSequence>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSequence_003E_002ELazySerializer;

	private static readonly ISerializer<SetSequence> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSequence_003E_002EGreedySerializer;

	static ISerializer<SetSequence> IFlatBufferSerializable<SetSequence>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSequence_003E_002EGreedySerializer;

	private static readonly ISerializer<SetSequence> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSequence_003E_002EGreedyMutableSerializer;

	static ISerializer<SetSequence> IFlatBufferSerializable<SetSequence>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSequence_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetSequence> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSequence_003E_002EProgressiveSerializer;

	static ISerializer<SetSequence> IFlatBufferSerializable<SetSequence>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSequence_003E_002EProgressiveSerializer;

	static SetSequence()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSequence_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSequence_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSequence_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSequence_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetSequence()
	{
		Document = null;
	}

	protected SetSequence(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetSequence(SetSequence source)
	{
		Document = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Document);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
