using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[CompilerGenerated]
public struct ResponseKind : IFlatBufferUnion<GameInfo, GameStateMetaData, SimpleResponse, StrokeProperties, AuthenticationChallenge, CameraProperties, StrokeSyncEvent, StrokeSyncEvents, StrokeSyncCurrent, SpellObjectList, SceneEventWrapper, AssetCreateBatchResult, StreamTextureSDPAnswer, MirrorState, OffsetDump, ObjectAddressDump, CameraState, HudPanelRowClicked, HudPanelRowsReordered, StrokeAnchorTargetChanged, StrokeCameraLockChanged, PenEraserStateChanged, StreamTextureSDPResult, StreamTextureStatus, SceneEditorHudLayout, RenderSettings, SequenceStateResponse, CinematicCameraPose, CinematicCameraEditEvent, CinematicPropEditEvent, CinematicAuthoringActionEvent, CameraPreviewStatus, CrashReportChannel>, IFlatBufferUnion
{
	public enum ItemKind : byte
	{
		GameInfo = 1,
		GameStateMetaData = 2,
		SimpleResponse = 3,
		StrokeProperties = 4,
		AuthenticationChallenge = 5,
		CameraProperties = 6,
		StrokeSyncEvent = 7,
		StrokeSyncEvents = 8,
		BlueBottleIPC_LeagueBroadcast_Commands_StrokeSyncCurrent = 9,
		SpellObjectList = 10,
		BlueBottleIPC_LeagueBroadcast_Scene_SceneEventWrapper = 11,
		BlueBottleIPC_LeagueBroadcast_Commands_AssetCreateBatchResult = 12,
		BlueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPAnswer = 13,
		MirrorState = 14,
		OffsetDump = 15,
		ObjectAddressDump = 16,
		CameraState = 17,
		HudPanelRowClicked = 18,
		HudPanelRowsReordered = 19,
		StrokeAnchorTargetChanged = 20,
		StrokeCameraLockChanged = 21,
		PenEraserStateChanged = 22,
		BlueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPResult = 23,
		BlueBottleIPC_LeagueBroadcast_Commands_StreamTextureStatus = 24,
		SceneEditorHudLayout = 25,
		RenderSettings = 26,
		SequenceStateResponse = 27,
		CinematicCameraPose = 28,
		CinematicCameraEditEvent = 29,
		CinematicPropEditEvent = 30,
		CinematicAuthoringActionEvent = 31,
		BlueBottleIPC_LeagueBroadcast_Commands_CameraPreviewStatus = 32,
		CrashReportChannel = 33,
		NONE = 0
	}

	public interface Visitor<TReturn> : IFlatBufferUnionVisitor<TReturn, GameInfo, GameStateMetaData, SimpleResponse, StrokeProperties, AuthenticationChallenge, CameraProperties, StrokeSyncEvent, StrokeSyncEvents, StrokeSyncCurrent, SpellObjectList, SceneEventWrapper, AssetCreateBatchResult, StreamTextureSDPAnswer, MirrorState, OffsetDump, ObjectAddressDump, CameraState, HudPanelRowClicked, HudPanelRowsReordered, StrokeAnchorTargetChanged, StrokeCameraLockChanged, PenEraserStateChanged, StreamTextureSDPResult, StreamTextureStatus, SceneEditorHudLayout, RenderSettings, SequenceStateResponse, CinematicCameraPose, CinematicCameraEditEvent, CinematicPropEditEvent, CinematicAuthoringActionEvent, CameraPreviewStatus, CrashReportChannel>
	{
	}

	private readonly object value;

	public ItemKind Kind => (ItemKind)Discriminator;

	public byte Discriminator { get; }

	public GameInfo GameInfo => Item1;

	public GameInfo Item1
	{
		get
		{
			if (Discriminator != 1)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem1();
		}
	}

	public GameStateMetaData GameStateMetaData => Item2;

	public GameStateMetaData Item2
	{
		get
		{
			if (Discriminator != 2)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem2();
		}
	}

	public SimpleResponse SimpleResponse => Item3;

	public SimpleResponse Item3
	{
		get
		{
			if (Discriminator != 3)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem3();
		}
	}

	public StrokeProperties StrokeProperties => Item4;

	public StrokeProperties Item4
	{
		get
		{
			if (Discriminator != 4)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem4();
		}
	}

	public AuthenticationChallenge AuthenticationChallenge => Item5;

	public AuthenticationChallenge Item5
	{
		get
		{
			if (Discriminator != 5)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem5();
		}
	}

	public CameraProperties CameraProperties => Item6;

	public CameraProperties Item6
	{
		get
		{
			if (Discriminator != 6)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem6();
		}
	}

	public StrokeSyncEvent StrokeSyncEvent => Item7;

	public StrokeSyncEvent Item7
	{
		get
		{
			if (Discriminator != 7)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem7();
		}
	}

	public StrokeSyncEvents StrokeSyncEvents => Item8;

	public StrokeSyncEvents Item8
	{
		get
		{
			if (Discriminator != 8)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem8();
		}
	}

	public StrokeSyncCurrent BlueBottleIPC_LeagueBroadcast_Commands_StrokeSyncCurrent => Item9;

	public StrokeSyncCurrent Item9
	{
		get
		{
			if (Discriminator != 9)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem9();
		}
	}

	public SpellObjectList SpellObjectList => Item10;

	public SpellObjectList Item10
	{
		get
		{
			if (Discriminator != 10)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem10();
		}
	}

	public SceneEventWrapper BlueBottleIPC_LeagueBroadcast_Scene_SceneEventWrapper => Item11;

	public SceneEventWrapper Item11
	{
		get
		{
			if (Discriminator != 11)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem11();
		}
	}

	public AssetCreateBatchResult BlueBottleIPC_LeagueBroadcast_Commands_AssetCreateBatchResult => Item12;

	public AssetCreateBatchResult Item12
	{
		get
		{
			if (Discriminator != 12)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem12();
		}
	}

	public StreamTextureSDPAnswer BlueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPAnswer => Item13;

	public StreamTextureSDPAnswer Item13
	{
		get
		{
			if (Discriminator != 13)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem13();
		}
	}

	public MirrorState MirrorState => Item14;

	public MirrorState Item14
	{
		get
		{
			if (Discriminator != 14)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem14();
		}
	}

	public OffsetDump OffsetDump => Item15;

	public OffsetDump Item15
	{
		get
		{
			if (Discriminator != 15)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem15();
		}
	}

	public ObjectAddressDump ObjectAddressDump => Item16;

	public ObjectAddressDump Item16
	{
		get
		{
			if (Discriminator != 16)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem16();
		}
	}

	public CameraState CameraState => Item17;

	public CameraState Item17
	{
		get
		{
			if (Discriminator != 17)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem17();
		}
	}

	public HudPanelRowClicked HudPanelRowClicked => Item18;

	public HudPanelRowClicked Item18
	{
		get
		{
			if (Discriminator != 18)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem18();
		}
	}

	public HudPanelRowsReordered HudPanelRowsReordered => Item19;

	public HudPanelRowsReordered Item19
	{
		get
		{
			if (Discriminator != 19)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem19();
		}
	}

	public StrokeAnchorTargetChanged StrokeAnchorTargetChanged => Item20;

	public StrokeAnchorTargetChanged Item20
	{
		get
		{
			if (Discriminator != 20)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem20();
		}
	}

	public StrokeCameraLockChanged StrokeCameraLockChanged => Item21;

	public StrokeCameraLockChanged Item21
	{
		get
		{
			if (Discriminator != 21)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem21();
		}
	}

	public PenEraserStateChanged PenEraserStateChanged => Item22;

	public PenEraserStateChanged Item22
	{
		get
		{
			if (Discriminator != 22)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem22();
		}
	}

	public StreamTextureSDPResult BlueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPResult => Item23;

	public StreamTextureSDPResult Item23
	{
		get
		{
			if (Discriminator != 23)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem23();
		}
	}

	public StreamTextureStatus BlueBottleIPC_LeagueBroadcast_Commands_StreamTextureStatus => Item24;

	public StreamTextureStatus Item24
	{
		get
		{
			if (Discriminator != 24)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem24();
		}
	}

	public SceneEditorHudLayout SceneEditorHudLayout => Item25;

	public SceneEditorHudLayout Item25
	{
		get
		{
			if (Discriminator != 25)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem25();
		}
	}

	public RenderSettings RenderSettings => Item26;

	public RenderSettings Item26
	{
		get
		{
			if (Discriminator != 26)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem26();
		}
	}

	public SequenceStateResponse SequenceStateResponse => Item27;

	public SequenceStateResponse Item27
	{
		get
		{
			if (Discriminator != 27)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem27();
		}
	}

	public CinematicCameraPose CinematicCameraPose => Item28;

	public CinematicCameraPose Item28
	{
		get
		{
			if (Discriminator != 28)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem28();
		}
	}

	public CinematicCameraEditEvent CinematicCameraEditEvent => Item29;

	public CinematicCameraEditEvent Item29
	{
		get
		{
			if (Discriminator != 29)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem29();
		}
	}

	public CinematicPropEditEvent CinematicPropEditEvent => Item30;

	public CinematicPropEditEvent Item30
	{
		get
		{
			if (Discriminator != 30)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem30();
		}
	}

	public CinematicAuthoringActionEvent CinematicAuthoringActionEvent => Item31;

	public CinematicAuthoringActionEvent Item31
	{
		get
		{
			if (Discriminator != 31)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem31();
		}
	}

	public CameraPreviewStatus BlueBottleIPC_LeagueBroadcast_Commands_CameraPreviewStatus => Item32;

	public CameraPreviewStatus Item32
	{
		get
		{
			if (Discriminator != 32)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem32();
		}
	}

	public CrashReportChannel CrashReportChannel => Item33;

	public CrashReportChannel Item33
	{
		get
		{
			if (Discriminator != 33)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem33();
		}
	}

	public ResponseKind(GameInfo value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 1;
		this.value = value;
	}

	public static implicit operator ResponseKind(GameInfo value)
	{
		return new ResponseKind(value);
	}

	private GameInfo UncheckedGetItem1()
	{
		return (GameInfo)value;
	}

	public bool TryGet([NotNullWhen(true)] out GameInfo? value)
	{
		if (Discriminator != 1)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem1();
		return true;
	}

	public ResponseKind(GameStateMetaData value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 2;
		this.value = value;
	}

	public static implicit operator ResponseKind(GameStateMetaData value)
	{
		return new ResponseKind(value);
	}

	private GameStateMetaData UncheckedGetItem2()
	{
		return (GameStateMetaData)value;
	}

	public bool TryGet([NotNullWhen(true)] out GameStateMetaData? value)
	{
		if (Discriminator != 2)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem2();
		return true;
	}

	public ResponseKind(SimpleResponse value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 3;
		this.value = value;
	}

	public static implicit operator ResponseKind(SimpleResponse value)
	{
		return new ResponseKind(value);
	}

	private SimpleResponse UncheckedGetItem3()
	{
		return (SimpleResponse)value;
	}

	public bool TryGet([NotNullWhen(true)] out SimpleResponse? value)
	{
		if (Discriminator != 3)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem3();
		return true;
	}

	public ResponseKind(StrokeProperties value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 4;
		this.value = value;
	}

	public static implicit operator ResponseKind(StrokeProperties value)
	{
		return new ResponseKind(value);
	}

	private StrokeProperties UncheckedGetItem4()
	{
		return (StrokeProperties)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeProperties? value)
	{
		if (Discriminator != 4)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem4();
		return true;
	}

	public ResponseKind(AuthenticationChallenge value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 5;
		this.value = value;
	}

	public static implicit operator ResponseKind(AuthenticationChallenge value)
	{
		return new ResponseKind(value);
	}

	private AuthenticationChallenge UncheckedGetItem5()
	{
		return (AuthenticationChallenge)value;
	}

	public bool TryGet([NotNullWhen(true)] out AuthenticationChallenge? value)
	{
		if (Discriminator != 5)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem5();
		return true;
	}

	public ResponseKind(CameraProperties value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 6;
		this.value = value;
	}

	public static implicit operator ResponseKind(CameraProperties value)
	{
		return new ResponseKind(value);
	}

	private CameraProperties UncheckedGetItem6()
	{
		return (CameraProperties)value;
	}

	public bool TryGet([NotNullWhen(true)] out CameraProperties? value)
	{
		if (Discriminator != 6)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem6();
		return true;
	}

	public ResponseKind(StrokeSyncEvent value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 7;
		this.value = value;
	}

	public static implicit operator ResponseKind(StrokeSyncEvent value)
	{
		return new ResponseKind(value);
	}

	private StrokeSyncEvent UncheckedGetItem7()
	{
		return (StrokeSyncEvent)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSyncEvent? value)
	{
		if (Discriminator != 7)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem7();
		return true;
	}

	public ResponseKind(StrokeSyncEvents value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 8;
		this.value = value;
	}

	public static implicit operator ResponseKind(StrokeSyncEvents value)
	{
		return new ResponseKind(value);
	}

	private StrokeSyncEvents UncheckedGetItem8()
	{
		return (StrokeSyncEvents)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSyncEvents? value)
	{
		if (Discriminator != 8)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem8();
		return true;
	}

	public ResponseKind(StrokeSyncCurrent value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 9;
		this.value = value;
	}

	public static implicit operator ResponseKind(StrokeSyncCurrent value)
	{
		return new ResponseKind(value);
	}

	private StrokeSyncCurrent UncheckedGetItem9()
	{
		return (StrokeSyncCurrent)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSyncCurrent? value)
	{
		if (Discriminator != 9)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem9();
		return true;
	}

	public ResponseKind(SpellObjectList value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 10;
		this.value = value;
	}

	public static implicit operator ResponseKind(SpellObjectList value)
	{
		return new ResponseKind(value);
	}

	private SpellObjectList UncheckedGetItem10()
	{
		return (SpellObjectList)value;
	}

	public bool TryGet([NotNullWhen(true)] out SpellObjectList? value)
	{
		if (Discriminator != 10)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem10();
		return true;
	}

	public ResponseKind(SceneEventWrapper value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 11;
		this.value = value;
	}

	public static implicit operator ResponseKind(SceneEventWrapper value)
	{
		return new ResponseKind(value);
	}

	private SceneEventWrapper UncheckedGetItem11()
	{
		return (SceneEventWrapper)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneEventWrapper? value)
	{
		if (Discriminator != 11)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem11();
		return true;
	}

	public ResponseKind(AssetCreateBatchResult value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 12;
		this.value = value;
	}

	public static implicit operator ResponseKind(AssetCreateBatchResult value)
	{
		return new ResponseKind(value);
	}

	private AssetCreateBatchResult UncheckedGetItem12()
	{
		return (AssetCreateBatchResult)value;
	}

	public bool TryGet([NotNullWhen(true)] out AssetCreateBatchResult? value)
	{
		if (Discriminator != 12)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem12();
		return true;
	}

	public ResponseKind(StreamTextureSDPAnswer value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 13;
		this.value = value;
	}

	public static implicit operator ResponseKind(StreamTextureSDPAnswer value)
	{
		return new ResponseKind(value);
	}

	private StreamTextureSDPAnswer UncheckedGetItem13()
	{
		return (StreamTextureSDPAnswer)value;
	}

	public bool TryGet([NotNullWhen(true)] out StreamTextureSDPAnswer? value)
	{
		if (Discriminator != 13)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem13();
		return true;
	}

	public ResponseKind(MirrorState value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 14;
		this.value = value;
	}

	public static implicit operator ResponseKind(MirrorState value)
	{
		return new ResponseKind(value);
	}

	private MirrorState UncheckedGetItem14()
	{
		return (MirrorState)value;
	}

	public bool TryGet([NotNullWhen(true)] out MirrorState? value)
	{
		if (Discriminator != 14)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem14();
		return true;
	}

	public ResponseKind(OffsetDump value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 15;
		this.value = value;
	}

	public static implicit operator ResponseKind(OffsetDump value)
	{
		return new ResponseKind(value);
	}

	private OffsetDump UncheckedGetItem15()
	{
		return (OffsetDump)value;
	}

	public bool TryGet([NotNullWhen(true)] out OffsetDump? value)
	{
		if (Discriminator != 15)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem15();
		return true;
	}

	public ResponseKind(ObjectAddressDump value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 16;
		this.value = value;
	}

	public static implicit operator ResponseKind(ObjectAddressDump value)
	{
		return new ResponseKind(value);
	}

	private ObjectAddressDump UncheckedGetItem16()
	{
		return (ObjectAddressDump)value;
	}

	public bool TryGet([NotNullWhen(true)] out ObjectAddressDump? value)
	{
		if (Discriminator != 16)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem16();
		return true;
	}

	public ResponseKind(CameraState value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 17;
		this.value = value;
	}

	public static implicit operator ResponseKind(CameraState value)
	{
		return new ResponseKind(value);
	}

	private CameraState UncheckedGetItem17()
	{
		return (CameraState)value;
	}

	public bool TryGet([NotNullWhen(true)] out CameraState? value)
	{
		if (Discriminator != 17)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem17();
		return true;
	}

	public ResponseKind(HudPanelRowClicked value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 18;
		this.value = value;
	}

	public static implicit operator ResponseKind(HudPanelRowClicked value)
	{
		return new ResponseKind(value);
	}

	private HudPanelRowClicked UncheckedGetItem18()
	{
		return (HudPanelRowClicked)value;
	}

	public bool TryGet([NotNullWhen(true)] out HudPanelRowClicked? value)
	{
		if (Discriminator != 18)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem18();
		return true;
	}

	public ResponseKind(HudPanelRowsReordered value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 19;
		this.value = value;
	}

	public static implicit operator ResponseKind(HudPanelRowsReordered value)
	{
		return new ResponseKind(value);
	}

	private HudPanelRowsReordered UncheckedGetItem19()
	{
		return (HudPanelRowsReordered)value;
	}

	public bool TryGet([NotNullWhen(true)] out HudPanelRowsReordered? value)
	{
		if (Discriminator != 19)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem19();
		return true;
	}

	public ResponseKind(StrokeAnchorTargetChanged value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 20;
		this.value = value;
	}

	public static implicit operator ResponseKind(StrokeAnchorTargetChanged value)
	{
		return new ResponseKind(value);
	}

	private StrokeAnchorTargetChanged UncheckedGetItem20()
	{
		return (StrokeAnchorTargetChanged)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeAnchorTargetChanged? value)
	{
		if (Discriminator != 20)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem20();
		return true;
	}

	public ResponseKind(StrokeCameraLockChanged value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 21;
		this.value = value;
	}

	public static implicit operator ResponseKind(StrokeCameraLockChanged value)
	{
		return new ResponseKind(value);
	}

	private StrokeCameraLockChanged UncheckedGetItem21()
	{
		return (StrokeCameraLockChanged)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeCameraLockChanged? value)
	{
		if (Discriminator != 21)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem21();
		return true;
	}

	public ResponseKind(PenEraserStateChanged value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 22;
		this.value = value;
	}

	public static implicit operator ResponseKind(PenEraserStateChanged value)
	{
		return new ResponseKind(value);
	}

	private PenEraserStateChanged UncheckedGetItem22()
	{
		return (PenEraserStateChanged)value;
	}

	public bool TryGet([NotNullWhen(true)] out PenEraserStateChanged? value)
	{
		if (Discriminator != 22)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem22();
		return true;
	}

	public ResponseKind(StreamTextureSDPResult value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 23;
		this.value = value;
	}

	public static implicit operator ResponseKind(StreamTextureSDPResult value)
	{
		return new ResponseKind(value);
	}

	private StreamTextureSDPResult UncheckedGetItem23()
	{
		return (StreamTextureSDPResult)value;
	}

	public bool TryGet([NotNullWhen(true)] out StreamTextureSDPResult? value)
	{
		if (Discriminator != 23)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem23();
		return true;
	}

	public ResponseKind(StreamTextureStatus value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 24;
		this.value = value;
	}

	public static implicit operator ResponseKind(StreamTextureStatus value)
	{
		return new ResponseKind(value);
	}

	private StreamTextureStatus UncheckedGetItem24()
	{
		return (StreamTextureStatus)value;
	}

	public bool TryGet([NotNullWhen(true)] out StreamTextureStatus? value)
	{
		if (Discriminator != 24)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem24();
		return true;
	}

	public ResponseKind(SceneEditorHudLayout value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 25;
		this.value = value;
	}

	public static implicit operator ResponseKind(SceneEditorHudLayout value)
	{
		return new ResponseKind(value);
	}

	private SceneEditorHudLayout UncheckedGetItem25()
	{
		return (SceneEditorHudLayout)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneEditorHudLayout? value)
	{
		if (Discriminator != 25)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem25();
		return true;
	}

	public ResponseKind(RenderSettings value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 26;
		this.value = value;
	}

	public static implicit operator ResponseKind(RenderSettings value)
	{
		return new ResponseKind(value);
	}

	private RenderSettings UncheckedGetItem26()
	{
		return (RenderSettings)value;
	}

	public bool TryGet([NotNullWhen(true)] out RenderSettings? value)
	{
		if (Discriminator != 26)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem26();
		return true;
	}

	public ResponseKind(SequenceStateResponse value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 27;
		this.value = value;
	}

	public static implicit operator ResponseKind(SequenceStateResponse value)
	{
		return new ResponseKind(value);
	}

	private SequenceStateResponse UncheckedGetItem27()
	{
		return (SequenceStateResponse)value;
	}

	public bool TryGet([NotNullWhen(true)] out SequenceStateResponse? value)
	{
		if (Discriminator != 27)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem27();
		return true;
	}

	public ResponseKind(CinematicCameraPose value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 28;
		this.value = value;
	}

	public static implicit operator ResponseKind(CinematicCameraPose value)
	{
		return new ResponseKind(value);
	}

	private CinematicCameraPose UncheckedGetItem28()
	{
		return (CinematicCameraPose)value;
	}

	public bool TryGet([NotNullWhen(true)] out CinematicCameraPose? value)
	{
		if (Discriminator != 28)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem28();
		return true;
	}

	public ResponseKind(CinematicCameraEditEvent value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 29;
		this.value = value;
	}

	public static implicit operator ResponseKind(CinematicCameraEditEvent value)
	{
		return new ResponseKind(value);
	}

	private CinematicCameraEditEvent UncheckedGetItem29()
	{
		return (CinematicCameraEditEvent)value;
	}

	public bool TryGet([NotNullWhen(true)] out CinematicCameraEditEvent? value)
	{
		if (Discriminator != 29)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem29();
		return true;
	}

	public ResponseKind(CinematicPropEditEvent value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 30;
		this.value = value;
	}

	public static implicit operator ResponseKind(CinematicPropEditEvent value)
	{
		return new ResponseKind(value);
	}

	private CinematicPropEditEvent UncheckedGetItem30()
	{
		return (CinematicPropEditEvent)value;
	}

	public bool TryGet([NotNullWhen(true)] out CinematicPropEditEvent? value)
	{
		if (Discriminator != 30)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem30();
		return true;
	}

	public ResponseKind(CinematicAuthoringActionEvent value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 31;
		this.value = value;
	}

	public static implicit operator ResponseKind(CinematicAuthoringActionEvent value)
	{
		return new ResponseKind(value);
	}

	private CinematicAuthoringActionEvent UncheckedGetItem31()
	{
		return (CinematicAuthoringActionEvent)value;
	}

	public bool TryGet([NotNullWhen(true)] out CinematicAuthoringActionEvent? value)
	{
		if (Discriminator != 31)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem31();
		return true;
	}

	public ResponseKind(CameraPreviewStatus value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 32;
		this.value = value;
	}

	public static implicit operator ResponseKind(CameraPreviewStatus value)
	{
		return new ResponseKind(value);
	}

	private CameraPreviewStatus UncheckedGetItem32()
	{
		return (CameraPreviewStatus)value;
	}

	public bool TryGet([NotNullWhen(true)] out CameraPreviewStatus? value)
	{
		if (Discriminator != 32)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem32();
		return true;
	}

	public ResponseKind(CrashReportChannel value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 33;
		this.value = value;
	}

	public static implicit operator ResponseKind(CrashReportChannel value)
	{
		return new ResponseKind(value);
	}

	private CrashReportChannel UncheckedGetItem33()
	{
		return (CrashReportChannel)value;
	}

	public bool TryGet([NotNullWhen(true)] out CrashReportChannel? value)
	{
		if (Discriminator != 33)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem33();
		return true;
	}

	public TReturn Accept<TVisitor, TReturn>(TVisitor visitor) where TVisitor : IFlatBufferUnionVisitor<TReturn, GameInfo, GameStateMetaData, SimpleResponse, StrokeProperties, AuthenticationChallenge, CameraProperties, StrokeSyncEvent, StrokeSyncEvents, StrokeSyncCurrent, SpellObjectList, SceneEventWrapper, AssetCreateBatchResult, StreamTextureSDPAnswer, MirrorState, OffsetDump, ObjectAddressDump, CameraState, HudPanelRowClicked, HudPanelRowsReordered, StrokeAnchorTargetChanged, StrokeCameraLockChanged, PenEraserStateChanged, StreamTextureSDPResult, StreamTextureStatus, SceneEditorHudLayout, RenderSettings, SequenceStateResponse, CinematicCameraPose, CinematicCameraEditEvent, CinematicPropEditEvent, CinematicAuthoringActionEvent, CameraPreviewStatus, CrashReportChannel>
	{
		byte discriminator = Discriminator;
		TVisitor val;
		switch (discriminator)
		{
		case 1:
		{
			ref TVisitor reference15 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference15;
				reference15 = ref val;
			}
			GameInfo item15 = UncheckedGetItem1();
			return reference15.Visit(item15);
		}
		case 2:
		{
			ref TVisitor reference18 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference18;
				reference18 = ref val;
			}
			GameStateMetaData item18 = UncheckedGetItem2();
			return reference18.Visit(item18);
		}
		case 3:
		{
			ref TVisitor reference6 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference6;
				reference6 = ref val;
			}
			SimpleResponse item6 = UncheckedGetItem3();
			return reference6.Visit(item6);
		}
		case 4:
		{
			ref TVisitor reference29 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference29;
				reference29 = ref val;
			}
			StrokeProperties item29 = UncheckedGetItem4();
			return reference29.Visit(item29);
		}
		case 5:
		{
			ref TVisitor reference20 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference20;
				reference20 = ref val;
			}
			AuthenticationChallenge item20 = UncheckedGetItem5();
			return reference20.Visit(item20);
		}
		case 6:
		{
			ref TVisitor reference17 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference17;
				reference17 = ref val;
			}
			CameraProperties item17 = UncheckedGetItem6();
			return reference17.Visit(item17);
		}
		case 7:
		{
			ref TVisitor reference33 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference33;
				reference33 = ref val;
			}
			StrokeSyncEvent item33 = UncheckedGetItem7();
			return reference33.Visit(item33);
		}
		case 8:
		{
			ref TVisitor reference26 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference26;
				reference26 = ref val;
			}
			StrokeSyncEvents item26 = UncheckedGetItem8();
			return reference26.Visit(item26);
		}
		case 9:
		{
			ref TVisitor reference9 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference9;
				reference9 = ref val;
			}
			StrokeSyncCurrent item9 = UncheckedGetItem9();
			return reference9.Visit(item9);
		}
		case 10:
		{
			ref TVisitor reference2 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference2;
				reference2 = ref val;
			}
			SpellObjectList item2 = UncheckedGetItem10();
			return reference2.Visit(item2);
		}
		case 11:
		{
			ref TVisitor reference27 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference27;
				reference27 = ref val;
			}
			SceneEventWrapper item27 = UncheckedGetItem11();
			return reference27.Visit(item27);
		}
		case 12:
		{
			ref TVisitor reference24 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference24;
				reference24 = ref val;
			}
			AssetCreateBatchResult item24 = UncheckedGetItem12();
			return reference24.Visit(item24);
		}
		case 13:
		{
			ref TVisitor reference11 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference11;
				reference11 = ref val;
			}
			StreamTextureSDPAnswer item11 = UncheckedGetItem13();
			return reference11.Visit(item11);
		}
		case 14:
		{
			ref TVisitor reference8 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference8;
				reference8 = ref val;
			}
			MirrorState item8 = UncheckedGetItem14();
			return reference8.Visit(item8);
		}
		case 15:
		{
			ref TVisitor reference32 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference32;
				reference32 = ref val;
			}
			OffsetDump item32 = UncheckedGetItem15();
			return reference32.Visit(item32);
		}
		case 16:
		{
			ref TVisitor reference30 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference30;
				reference30 = ref val;
			}
			ObjectAddressDump item30 = UncheckedGetItem16();
			return reference30.Visit(item30);
		}
		case 17:
		{
			ref TVisitor reference23 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference23;
				reference23 = ref val;
			}
			CameraState item23 = UncheckedGetItem17();
			return reference23.Visit(item23);
		}
		case 18:
		{
			ref TVisitor reference21 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference21;
				reference21 = ref val;
			}
			HudPanelRowClicked item21 = UncheckedGetItem18();
			return reference21.Visit(item21);
		}
		case 19:
		{
			ref TVisitor reference14 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference14;
				reference14 = ref val;
			}
			HudPanelRowsReordered item14 = UncheckedGetItem19();
			return reference14.Visit(item14);
		}
		case 20:
		{
			ref TVisitor reference12 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference12;
				reference12 = ref val;
			}
			StrokeAnchorTargetChanged item12 = UncheckedGetItem20();
			return reference12.Visit(item12);
		}
		case 21:
		{
			ref TVisitor reference5 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference5;
				reference5 = ref val;
			}
			StrokeCameraLockChanged item5 = UncheckedGetItem21();
			return reference5.Visit(item5);
		}
		case 22:
		{
			ref TVisitor reference3 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference3;
				reference3 = ref val;
			}
			PenEraserStateChanged item3 = UncheckedGetItem22();
			return reference3.Visit(item3);
		}
		case 23:
		{
			ref TVisitor reference31 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference31;
				reference31 = ref val;
			}
			StreamTextureSDPResult item31 = UncheckedGetItem23();
			return reference31.Visit(item31);
		}
		case 24:
		{
			ref TVisitor reference28 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference28;
				reference28 = ref val;
			}
			StreamTextureStatus item28 = UncheckedGetItem24();
			return reference28.Visit(item28);
		}
		case 25:
		{
			ref TVisitor reference25 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference25;
				reference25 = ref val;
			}
			SceneEditorHudLayout item25 = UncheckedGetItem25();
			return reference25.Visit(item25);
		}
		case 26:
		{
			ref TVisitor reference22 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference22;
				reference22 = ref val;
			}
			RenderSettings item22 = UncheckedGetItem26();
			return reference22.Visit(item22);
		}
		case 27:
		{
			ref TVisitor reference19 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference19;
				reference19 = ref val;
			}
			SequenceStateResponse item19 = UncheckedGetItem27();
			return reference19.Visit(item19);
		}
		case 28:
		{
			ref TVisitor reference16 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference16;
				reference16 = ref val;
			}
			CinematicCameraPose item16 = UncheckedGetItem28();
			return reference16.Visit(item16);
		}
		case 29:
		{
			ref TVisitor reference13 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference13;
				reference13 = ref val;
			}
			CinematicCameraEditEvent item13 = UncheckedGetItem29();
			return reference13.Visit(item13);
		}
		case 30:
		{
			ref TVisitor reference10 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference10;
				reference10 = ref val;
			}
			CinematicPropEditEvent item10 = UncheckedGetItem30();
			return reference10.Visit(item10);
		}
		case 31:
		{
			ref TVisitor reference7 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference7;
				reference7 = ref val;
			}
			CinematicAuthoringActionEvent item7 = UncheckedGetItem31();
			return reference7.Visit(item7);
		}
		case 32:
		{
			ref TVisitor reference4 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference4;
				reference4 = ref val;
			}
			CameraPreviewStatus item4 = UncheckedGetItem32();
			return reference4.Visit(item4);
		}
		case 33:
		{
			ref TVisitor reference = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference;
				reference = ref val;
			}
			CrashReportChannel item = UncheckedGetItem33();
			return reference.Visit(item);
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<ResponseKind>(discriminator);
			return default;
		}
	}

	public TReturn Match<TReturn>(Func<GameInfo, TReturn> caseGameInfo, Func<GameStateMetaData, TReturn> caseGameStateMetaData, Func<SimpleResponse, TReturn> caseSimpleResponse, Func<StrokeProperties, TReturn> caseStrokeProperties, Func<AuthenticationChallenge, TReturn> caseAuthenticationChallenge, Func<CameraProperties, TReturn> caseCameraProperties, Func<StrokeSyncEvent, TReturn> caseStrokeSyncEvent, Func<StrokeSyncEvents, TReturn> caseStrokeSyncEvents, Func<StrokeSyncCurrent, TReturn> caseBlueBottleIPC_LeagueBroadcast_Commands_StrokeSyncCurrent, Func<SpellObjectList, TReturn> caseSpellObjectList, Func<SceneEventWrapper, TReturn> caseBlueBottleIPC_LeagueBroadcast_Scene_SceneEventWrapper, Func<AssetCreateBatchResult, TReturn> caseBlueBottleIPC_LeagueBroadcast_Commands_AssetCreateBatchResult, Func<StreamTextureSDPAnswer, TReturn> caseBlueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPAnswer, Func<MirrorState, TReturn> caseMirrorState, Func<OffsetDump, TReturn> caseOffsetDump, Func<ObjectAddressDump, TReturn> caseObjectAddressDump, Func<CameraState, TReturn> caseCameraState, Func<HudPanelRowClicked, TReturn> caseHudPanelRowClicked, Func<HudPanelRowsReordered, TReturn> caseHudPanelRowsReordered, Func<StrokeAnchorTargetChanged, TReturn> caseStrokeAnchorTargetChanged, Func<StrokeCameraLockChanged, TReturn> caseStrokeCameraLockChanged, Func<PenEraserStateChanged, TReturn> casePenEraserStateChanged, Func<StreamTextureSDPResult, TReturn> caseBlueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPResult, Func<StreamTextureStatus, TReturn> caseBlueBottleIPC_LeagueBroadcast_Commands_StreamTextureStatus, Func<SceneEditorHudLayout, TReturn> caseSceneEditorHudLayout, Func<RenderSettings, TReturn> caseRenderSettings, Func<SequenceStateResponse, TReturn> caseSequenceStateResponse, Func<CinematicCameraPose, TReturn> caseCinematicCameraPose, Func<CinematicCameraEditEvent, TReturn> caseCinematicCameraEditEvent, Func<CinematicPropEditEvent, TReturn> caseCinematicPropEditEvent, Func<CinematicAuthoringActionEvent, TReturn> caseCinematicAuthoringActionEvent, Func<CameraPreviewStatus, TReturn> caseBlueBottleIPC_LeagueBroadcast_Commands_CameraPreviewStatus, Func<CrashReportChannel, TReturn> caseCrashReportChannel)
	{
		byte discriminator = Discriminator;
		switch (discriminator)
		{
		case 1:
			return caseGameInfo(UncheckedGetItem1());
		case 2:
			return caseGameStateMetaData(UncheckedGetItem2());
		case 3:
			return caseSimpleResponse(UncheckedGetItem3());
		case 4:
			return caseStrokeProperties(UncheckedGetItem4());
		case 5:
			return caseAuthenticationChallenge(UncheckedGetItem5());
		case 6:
			return caseCameraProperties(UncheckedGetItem6());
		case 7:
			return caseStrokeSyncEvent(UncheckedGetItem7());
		case 8:
			return caseStrokeSyncEvents(UncheckedGetItem8());
		case 9:
			return caseBlueBottleIPC_LeagueBroadcast_Commands_StrokeSyncCurrent(UncheckedGetItem9());
		case 10:
			return caseSpellObjectList(UncheckedGetItem10());
		case 11:
			return caseBlueBottleIPC_LeagueBroadcast_Scene_SceneEventWrapper(UncheckedGetItem11());
		case 12:
			return caseBlueBottleIPC_LeagueBroadcast_Commands_AssetCreateBatchResult(UncheckedGetItem12());
		case 13:
			return caseBlueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPAnswer(UncheckedGetItem13());
		case 14:
			return caseMirrorState(UncheckedGetItem14());
		case 15:
			return caseOffsetDump(UncheckedGetItem15());
		case 16:
			return caseObjectAddressDump(UncheckedGetItem16());
		case 17:
			return caseCameraState(UncheckedGetItem17());
		case 18:
			return caseHudPanelRowClicked(UncheckedGetItem18());
		case 19:
			return caseHudPanelRowsReordered(UncheckedGetItem19());
		case 20:
			return caseStrokeAnchorTargetChanged(UncheckedGetItem20());
		case 21:
			return caseStrokeCameraLockChanged(UncheckedGetItem21());
		case 22:
			return casePenEraserStateChanged(UncheckedGetItem22());
		case 23:
			return caseBlueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPResult(UncheckedGetItem23());
		case 24:
			return caseBlueBottleIPC_LeagueBroadcast_Commands_StreamTextureStatus(UncheckedGetItem24());
		case 25:
			return caseSceneEditorHudLayout(UncheckedGetItem25());
		case 26:
			return caseRenderSettings(UncheckedGetItem26());
		case 27:
			return caseSequenceStateResponse(UncheckedGetItem27());
		case 28:
			return caseCinematicCameraPose(UncheckedGetItem28());
		case 29:
			return caseCinematicCameraEditEvent(UncheckedGetItem29());
		case 30:
			return caseCinematicPropEditEvent(UncheckedGetItem30());
		case 31:
			return caseCinematicAuthoringActionEvent(UncheckedGetItem31());
		case 32:
			return caseBlueBottleIPC_LeagueBroadcast_Commands_CameraPreviewStatus(UncheckedGetItem32());
		case 33:
			return caseCrashReportChannel(UncheckedGetItem33());
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<ResponseKind>(discriminator);
			return default;
		}
	}
}
