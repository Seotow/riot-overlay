using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N0588F3A69073E87EB926FDD5201F55DB33F601848099958C6B593ED0B9B7B2E8;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.TouchPanSettings")]
public class TouchPanSettings : IFlatBufferSerializable<TouchPanSettings>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual bool Enabled { get; set; }

	[FlatBufferItem(1)]
	public virtual bool WhileDrawingOff { get; set; }

	public static ISerializer<TouchPanSettings> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<TouchPanSettings>)this).Serializer;

	ISerializer<TouchPanSettings> IFlatBufferSerializable<TouchPanSettings>.Serializer => Serializer;

	private static readonly ISerializer<TouchPanSettings> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETouchPanSettings_003E_002ELazySerializer;

	static ISerializer<TouchPanSettings> IFlatBufferSerializable<TouchPanSettings>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETouchPanSettings_003E_002ELazySerializer;

	private static readonly ISerializer<TouchPanSettings> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETouchPanSettings_003E_002EGreedySerializer;

	static ISerializer<TouchPanSettings> IFlatBufferSerializable<TouchPanSettings>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETouchPanSettings_003E_002EGreedySerializer;

	private static readonly ISerializer<TouchPanSettings> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETouchPanSettings_003E_002EGreedyMutableSerializer;

	static ISerializer<TouchPanSettings> IFlatBufferSerializable<TouchPanSettings>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETouchPanSettings_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<TouchPanSettings> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETouchPanSettings_003E_002EProgressiveSerializer;

	static ISerializer<TouchPanSettings> IFlatBufferSerializable<TouchPanSettings>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETouchPanSettings_003E_002EProgressiveSerializer;

	static TouchPanSettings()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETouchPanSettings_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETouchPanSettings_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETouchPanSettings_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ETouchPanSettings_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public TouchPanSettings()
	{
		Enabled = false;
		WhileDrawingOff = false;
	}

	protected TouchPanSettings(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public TouchPanSettings(TouchPanSettings source)
	{
		Enabled = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Enabled);
		WhileDrawingOff = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.WhileDrawingOff);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
