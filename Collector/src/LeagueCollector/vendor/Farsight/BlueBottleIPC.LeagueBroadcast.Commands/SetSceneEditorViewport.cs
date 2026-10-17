using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.NE0F58D42F2BDF9493B701C37CE70EC84503669C3E509C33ABD1FD85902AA109A;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.SetSceneEditorViewport")]
public class SetSceneEditorViewport : IFlatBufferSerializable<SetSceneEditorViewport>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual bool Enabled { get; set; }

	[FlatBufferItem(1)]
	public virtual float Left { get; set; }

	[FlatBufferItem(2)]
	public virtual float Top { get; set; }

	[FlatBufferItem(3)]
	public virtual float Right { get; set; }

	[FlatBufferItem(4)]
	public virtual float Bottom { get; set; }

	[FlatBufferItem(5, DefaultValue = true)]
	public virtual bool VirtualEdgeScroll { get; set; }

	[FlatBufferItem(6, DefaultValue = true)]
	public virtual bool SuppressNativeEdgeScroll { get; set; }

	[FlatBufferItem(7, DefaultValue = true)]
	public virtual bool ReleaseCursor { get; set; }

	public static ISerializer<SetSceneEditorViewport> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetSceneEditorViewport>)this).Serializer;

	ISerializer<SetSceneEditorViewport> IFlatBufferSerializable<SetSceneEditorViewport>.Serializer => Serializer;

	private static readonly ISerializer<SetSceneEditorViewport> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSceneEditorViewport_003E_002ELazySerializer;

	static ISerializer<SetSceneEditorViewport> IFlatBufferSerializable<SetSceneEditorViewport>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSceneEditorViewport_003E_002ELazySerializer;

	private static readonly ISerializer<SetSceneEditorViewport> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSceneEditorViewport_003E_002EGreedySerializer;

	static ISerializer<SetSceneEditorViewport> IFlatBufferSerializable<SetSceneEditorViewport>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSceneEditorViewport_003E_002EGreedySerializer;

	private static readonly ISerializer<SetSceneEditorViewport> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSceneEditorViewport_003E_002EGreedyMutableSerializer;

	static ISerializer<SetSceneEditorViewport> IFlatBufferSerializable<SetSceneEditorViewport>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSceneEditorViewport_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetSceneEditorViewport> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSceneEditorViewport_003E_002EProgressiveSerializer;

	static ISerializer<SetSceneEditorViewport> IFlatBufferSerializable<SetSceneEditorViewport>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSceneEditorViewport_003E_002EProgressiveSerializer;

	static SetSceneEditorViewport()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSceneEditorViewport_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSceneEditorViewport_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSceneEditorViewport_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetSceneEditorViewport_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetSceneEditorViewport()
	{
		Enabled = false;
		Left = 0f;
		Top = 0f;
		Right = 0f;
		Bottom = 0f;
		VirtualEdgeScroll = true;
		SuppressNativeEdgeScroll = true;
		ReleaseCursor = true;
	}

	protected SetSceneEditorViewport(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetSceneEditorViewport(SetSceneEditorViewport source)
	{
		Enabled = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Enabled);
		Left = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Left);
		Top = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Top);
		Right = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Right);
		Bottom = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Bottom);
		VirtualEdgeScroll = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.VirtualEdgeScroll);
		SuppressNativeEdgeScroll = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SuppressNativeEdgeScroll);
		ReleaseCursor = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ReleaseCursor);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
