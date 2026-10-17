using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Compiler.Generated.N8389B71093DA595F54CDF287A95581EC158B1361A47E55164E60006610B738C0;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = true)]
[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "fs_serializer", "0")]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig")]
public class SetControllerCameraConfig : IFlatBufferSerializable<SetControllerCameraConfig>, IFlatBufferSerializable
{
	[FlatBufferItem(0)]
	public virtual bool Enabled { get; set; }

	[FlatBufferItem(1)]
	public virtual bool DollyEnabled { get; set; }

	[FlatBufferItem(2)]
	public virtual int Slot { get; set; }

	[FlatBufferItem(3)]
	public virtual float StickDeadzone { get; set; }

	[FlatBufferItem(4)]
	public virtual float LookDeadzone { get; set; }

	[FlatBufferItem(5)]
	public virtual float LookSpeed { get; set; }

	[FlatBufferItem(6)]
	public virtual float FreeMoveSpeed { get; set; }

	[FlatBufferItem(7, DefaultValue = ControllerButton.LeftShoulder)]
	public virtual ControllerButton BlueTeamButton { get; set; }

	[FlatBufferItem(8, DefaultValue = ControllerButton.RightShoulder)]
	public virtual ControllerButton RedTeamButton { get; set; }

	[FlatBufferItem(9, DefaultValue = ControllerButton.DPadUp)]
	public virtual ControllerButton ChampionSlot1Button { get; set; }

	[FlatBufferItem(10, DefaultValue = ControllerButton.DPadLeft)]
	public virtual ControllerButton ChampionSlot2Button { get; set; }

	[FlatBufferItem(11, DefaultValue = ControllerButton.DPadRight)]
	public virtual ControllerButton ChampionSlot3Button { get; set; }

	[FlatBufferItem(12, DefaultValue = ControllerButton.DPadDown)]
	public virtual ControllerButton ChampionSlot4Button { get; set; }

	[FlatBufferItem(13)]
	public virtual ControllerButton ChampionSlot5Button { get; set; }

	[FlatBufferItem(14)]
	public virtual bool MoveSmoothing { get; set; }

	[FlatBufferItem(15, DefaultValue = 1f)]
	public virtual float BuildupSeconds { get; set; }

	[FlatBufferItem(16, DefaultValue = 2f)]
	public virtual float FalloffSeconds { get; set; }

	[FlatBufferItem(17, DefaultValue = 1f)]
	public virtual float DirectedMoveSpeed { get; set; }

	[FlatBufferItem(18)]
	public virtual IList<float>? FalloffCurveX { get; set; }

	[FlatBufferItem(19)]
	public virtual IList<float>? FalloffCurveY { get; set; }

	[FlatBufferItem(20)]
	public virtual IList<float>? BuildupCurveX { get; set; }

	[FlatBufferItem(21)]
	public virtual IList<float>? BuildupCurveY { get; set; }

	[FlatBufferItem(22)]
	public virtual bool ChordMoveHold { get; set; }

	[FlatBufferItem(23)]
	public virtual ControllerButton CaptureButton { get; set; }

	[FlatBufferItem(24, DefaultValue = ControllerButton.Menu)]
	public virtual ControllerButton PreviewToggleButton { get; set; }

	[FlatBufferItem(25, DefaultValue = ControllerButton.FaceEast)]
	public virtual ControllerButton PreviewStopButton { get; set; }

	[FlatBufferItem(26, DefaultValue = ControllerButton.DPadLeft)]
	public virtual ControllerButton PlayheadBackButton { get; set; }

	[FlatBufferItem(27, DefaultValue = ControllerButton.DPadRight)]
	public virtual ControllerButton PlayheadForwardButton { get; set; }

	[FlatBufferItem(28, DefaultValue = ControllerButton.DPadUp)]
	public virtual ControllerButton SpeedFasterButton { get; set; }

	[FlatBufferItem(29, DefaultValue = ControllerButton.DPadDown)]
	public virtual ControllerButton SpeedSlowerButton { get; set; }

	[FlatBufferItem(30)]
	public virtual ControllerStick MoveStick { get; set; }

	[FlatBufferItem(31, DefaultValue = ControllerStick.RightStick)]
	public virtual ControllerStick LookStick { get; set; }

	[FlatBufferItem(32)]
	public virtual bool InvertMoveX { get; set; }

	[FlatBufferItem(33)]
	public virtual bool InvertMoveY { get; set; }

	[FlatBufferItem(34)]
	public virtual bool InvertLookX { get; set; }

	[FlatBufferItem(35)]
	public virtual bool InvertLookY { get; set; }

	[FlatBufferItem(36)]
	public virtual bool SwapTriggers { get; set; }

	[FlatBufferItem(37, DefaultValue = 1f)]
	public virtual float ZoomSpeed { get; set; }

	[FlatBufferItem(38, DefaultValue = ControllerButton.FaceWest)]
	public virtual ControllerButton JumpNearestButton { get; set; }

	[FlatBufferItem(39, DefaultValue = ControllerButton.FaceNorth)]
	public virtual ControllerButton JumpNearestDirectionButton { get; set; }

	[FlatBufferItem(40, DefaultValue = ControllerButton.LeftShoulder)]
	public virtual ControllerButton RollLeftButton { get; set; }

	[FlatBufferItem(41, DefaultValue = ControllerButton.RightShoulder)]
	public virtual ControllerButton RollRightButton { get; set; }

	[FlatBufferItem(42)]
	public virtual bool RelativeFreeMovement { get; set; }

	public static ISerializer<SetControllerCameraConfig> Serializer { get; }

	ISerializer IFlatBufferSerializable.Serializer => (ISerializer)((IFlatBufferSerializable<SetControllerCameraConfig>)this).Serializer;

	ISerializer<SetControllerCameraConfig> IFlatBufferSerializable<SetControllerCameraConfig>.Serializer => Serializer;

	private static readonly ISerializer<SetControllerCameraConfig> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetControllerCameraConfig_003E_002ELazySerializer;

	static ISerializer<SetControllerCameraConfig> IFlatBufferSerializable<SetControllerCameraConfig>.LazySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetControllerCameraConfig_003E_002ELazySerializer;

	private static readonly ISerializer<SetControllerCameraConfig> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetControllerCameraConfig_003E_002EGreedySerializer;

	static ISerializer<SetControllerCameraConfig> IFlatBufferSerializable<SetControllerCameraConfig>.GreedySerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetControllerCameraConfig_003E_002EGreedySerializer;

	private static readonly ISerializer<SetControllerCameraConfig> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetControllerCameraConfig_003E_002EGreedyMutableSerializer;

	static ISerializer<SetControllerCameraConfig> IFlatBufferSerializable<SetControllerCameraConfig>.GreedyMutableSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetControllerCameraConfig_003E_002EGreedyMutableSerializer;

	private static readonly ISerializer<SetControllerCameraConfig> FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetControllerCameraConfig_003E_002EProgressiveSerializer;

	static ISerializer<SetControllerCameraConfig> IFlatBufferSerializable<SetControllerCameraConfig>.ProgressiveSerializer => FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetControllerCameraConfig_003E_002EProgressiveSerializer;

	static SetControllerCameraConfig()
	{
		Serializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetControllerCameraConfig_003E_002ELazySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Lazy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetControllerCameraConfig_003E_002EGreedySerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Greedy);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetControllerCameraConfig_003E_002EGreedyMutableSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.GreedyMutable);
		FlatSharp_002EIFlatBufferSerializable_003CBlueBottleIPC_002ELeagueBroadcast_002ECommands_002ESetControllerCameraConfig_003E_002EProgressiveSerializer = new Serializer().AsISerializer(FlatBufferDeserializationOption.Progressive);
	}

	public SetControllerCameraConfig()
	{
		Enabled = false;
		DollyEnabled = false;
		Slot = 0;
		StickDeadzone = 0f;
		LookDeadzone = 0f;
		LookSpeed = 0f;
		FreeMoveSpeed = 0f;
		BlueTeamButton = ControllerButton.LeftShoulder;
		RedTeamButton = ControllerButton.RightShoulder;
		ChampionSlot1Button = ControllerButton.DPadUp;
		ChampionSlot2Button = ControllerButton.DPadLeft;
		ChampionSlot3Button = ControllerButton.DPadRight;
		ChampionSlot4Button = ControllerButton.DPadDown;
		ChampionSlot5Button = ControllerButton.FaceSouth;
		MoveSmoothing = false;
		BuildupSeconds = 1f;
		FalloffSeconds = 2f;
		DirectedMoveSpeed = 1f;
		FalloffCurveX = null;
		FalloffCurveY = null;
		BuildupCurveX = null;
		BuildupCurveY = null;
		ChordMoveHold = false;
		CaptureButton = ControllerButton.FaceSouth;
		PreviewToggleButton = ControllerButton.Menu;
		PreviewStopButton = ControllerButton.FaceEast;
		PlayheadBackButton = ControllerButton.DPadLeft;
		PlayheadForwardButton = ControllerButton.DPadRight;
		SpeedFasterButton = ControllerButton.DPadUp;
		SpeedSlowerButton = ControllerButton.DPadDown;
		MoveStick = ControllerStick.LeftStick;
		LookStick = ControllerStick.RightStick;
		InvertMoveX = false;
		InvertMoveY = false;
		InvertLookX = false;
		InvertLookY = false;
		SwapTriggers = false;
		ZoomSpeed = 1f;
		JumpNearestButton = ControllerButton.FaceWest;
		JumpNearestDirectionButton = ControllerButton.FaceNorth;
		RollLeftButton = ControllerButton.LeftShoulder;
		RollRightButton = ControllerButton.RightShoulder;
		RelativeFreeMovement = false;
	}

	protected SetControllerCameraConfig(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SetControllerCameraConfig(SetControllerCameraConfig source)
	{
		Enabled = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Enabled);
		DollyEnabled = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.DollyEnabled);
		Slot = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Slot);
		StickDeadzone = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.StickDeadzone);
		LookDeadzone = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LookDeadzone);
		LookSpeed = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LookSpeed);
		FreeMoveSpeed = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FreeMoveSpeed);
		BlueTeamButton = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BlueTeamButton);
		RedTeamButton = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RedTeamButton);
		ChampionSlot1Button = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ChampionSlot1Button);
		ChampionSlot2Button = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ChampionSlot2Button);
		ChampionSlot3Button = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ChampionSlot3Button);
		ChampionSlot4Button = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ChampionSlot4Button);
		ChampionSlot5Button = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ChampionSlot5Button);
		MoveSmoothing = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MoveSmoothing);
		BuildupSeconds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BuildupSeconds);
		FalloffSeconds = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FalloffSeconds);
		DirectedMoveSpeed = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.DirectedMoveSpeed);
		FalloffCurveX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FalloffCurveX);
		FalloffCurveY = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FalloffCurveY);
		BuildupCurveX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BuildupCurveX);
		BuildupCurveY = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.BuildupCurveY);
		ChordMoveHold = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ChordMoveHold);
		CaptureButton = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CaptureButton);
		PreviewToggleButton = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PreviewToggleButton);
		PreviewStopButton = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PreviewStopButton);
		PlayheadBackButton = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PlayheadBackButton);
		PlayheadForwardButton = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PlayheadForwardButton);
		SpeedFasterButton = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SpeedFasterButton);
		SpeedSlowerButton = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SpeedSlowerButton);
		MoveStick = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MoveStick);
		LookStick = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.LookStick);
		InvertMoveX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.InvertMoveX);
		InvertMoveY = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.InvertMoveY);
		InvertLookX = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.InvertLookX);
		InvertLookY = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.InvertLookY);
		SwapTriggers = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SwapTriggers);
		ZoomSpeed = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ZoomSpeed);
		JumpNearestButton = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.JumpNearestButton);
		JumpNearestDirectionButton = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.JumpNearestDirectionButton);
		RollLeftButton = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RollLeftButton);
		RollRightButton = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RollRightButton);
		RelativeFreeMovement = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.RelativeFreeMovement);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
