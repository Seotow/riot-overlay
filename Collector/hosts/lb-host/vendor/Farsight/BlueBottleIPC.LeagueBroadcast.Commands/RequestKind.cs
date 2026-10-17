using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[CompilerGenerated]
public struct RequestKind : IFlatBufferUnion<RegisterService, ConfigService, UnregisterService, EphemeralAction, AuthenticationStart, AuthenticationVerify, DrawingStateAction, SceneAction, AssetCreate, AssetCreateBatch, AssetDelete, StreamTextureSDPOffer, StreamTextureCloseSession, SetCameraTarget, SetCameraFollowEnabled, IdentifyClient, SetCameraPath, SetGizmoState, SetClientCapabilities, HudPanelSet, HudLabelsSet, StreamTextureCreateSDPOffer, StreamTextureApplySDPAnswer, StreamTextureStatusRequest, SetSceneEditorViewport, GetSceneEditorHudLayout, SetDirectedCameraTarget, SetReplayTime, GetRenderSettings, SetRenderSettings, SetSequence, SequenceTransport, SequenceStateRequest, SetCinematicCameraEditor, GetCinematicCameraPose, SetCinematicPropEditor, SetControllerCameraConfig, SetCameraPreviewConfiguration, ClearCameraPreviewConfiguration, GetCameraPreviewStatus, TakeCameraPreviewAux, SetAutoDirectorMainCamera>, IFlatBufferUnion
{
	public enum ItemKind : byte
	{
		RegisterService = 1,
		ConfigService = 2,
		UnregisterService = 3,
		EphemeralAction = 4,
		AuthenticationStart = 5,
		AuthenticationVerify = 6,
		DrawingStateAction = 7,
		BlueBottleIPC_LeagueBroadcast_Scene_SceneAction = 8,
		AssetCreate = 9,
		AssetCreateBatch = 10,
		AssetDelete = 11,
		StreamTextureSDPOffer = 12,
		StreamTextureCloseSession = 13,
		SetCameraTarget = 14,
		SetCameraFollowEnabled = 15,
		IdentifyClient = 16,
		SetCameraPath = 17,
		SetGizmoState = 18,
		SetClientCapabilities = 19,
		HudPanelSet = 20,
		HudLabelsSet = 21,
		StreamTextureCreateSDPOffer = 22,
		StreamTextureApplySDPAnswer = 23,
		StreamTextureStatusRequest = 24,
		SetSceneEditorViewport = 25,
		GetSceneEditorHudLayout = 26,
		SetDirectedCameraTarget = 27,
		SetReplayTime = 28,
		GetRenderSettings = 29,
		SetRenderSettings = 30,
		SetSequence = 31,
		SequenceTransport = 32,
		SequenceStateRequest = 33,
		SetCinematicCameraEditor = 34,
		GetCinematicCameraPose = 35,
		SetCinematicPropEditor = 36,
		SetControllerCameraConfig = 37,
		SetCameraPreviewConfiguration = 38,
		ClearCameraPreviewConfiguration = 39,
		GetCameraPreviewStatus = 40,
		TakeCameraPreviewAux = 41,
		SetAutoDirectorMainCamera = 42,
		NONE = 0
	}

	public interface Visitor<TReturn> : IFlatBufferUnionVisitor<TReturn, RegisterService, ConfigService, UnregisterService, EphemeralAction, AuthenticationStart, AuthenticationVerify, DrawingStateAction, SceneAction, AssetCreate, AssetCreateBatch, AssetDelete, StreamTextureSDPOffer, StreamTextureCloseSession, SetCameraTarget, SetCameraFollowEnabled, IdentifyClient, SetCameraPath, SetGizmoState, SetClientCapabilities, HudPanelSet, HudLabelsSet, StreamTextureCreateSDPOffer, StreamTextureApplySDPAnswer, StreamTextureStatusRequest, SetSceneEditorViewport, GetSceneEditorHudLayout, SetDirectedCameraTarget, SetReplayTime, GetRenderSettings, SetRenderSettings, SetSequence, SequenceTransport, SequenceStateRequest, SetCinematicCameraEditor, GetCinematicCameraPose, SetCinematicPropEditor, SetControllerCameraConfig, SetCameraPreviewConfiguration, ClearCameraPreviewConfiguration, GetCameraPreviewStatus, TakeCameraPreviewAux, SetAutoDirectorMainCamera>
	{
	}

	private readonly object value;

	public ItemKind Kind => (ItemKind)Discriminator;

	public byte Discriminator { get; }

	public RegisterService RegisterService => Item1;

	public RegisterService Item1
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

	public ConfigService ConfigService => Item2;

	public ConfigService Item2
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

	public UnregisterService UnregisterService => Item3;

	public UnregisterService Item3
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

	public EphemeralAction EphemeralAction => Item4;

	public EphemeralAction Item4
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

	public AuthenticationStart AuthenticationStart => Item5;

	public AuthenticationStart Item5
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

	public AuthenticationVerify AuthenticationVerify => Item6;

	public AuthenticationVerify Item6
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

	public DrawingStateAction DrawingStateAction => Item7;

	public DrawingStateAction Item7
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

	public SceneAction BlueBottleIPC_LeagueBroadcast_Scene_SceneAction => Item8;

	public SceneAction Item8
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

	public AssetCreate AssetCreate => Item9;

	public AssetCreate Item9
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

	public AssetCreateBatch AssetCreateBatch => Item10;

	public AssetCreateBatch Item10
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

	public AssetDelete AssetDelete => Item11;

	public AssetDelete Item11
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

	public StreamTextureSDPOffer StreamTextureSDPOffer => Item12;

	public StreamTextureSDPOffer Item12
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

	public StreamTextureCloseSession StreamTextureCloseSession => Item13;

	public StreamTextureCloseSession Item13
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

	public SetCameraTarget SetCameraTarget => Item14;

	public SetCameraTarget Item14
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

	public SetCameraFollowEnabled SetCameraFollowEnabled => Item15;

	public SetCameraFollowEnabled Item15
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

	public IdentifyClient IdentifyClient => Item16;

	public IdentifyClient Item16
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

	public SetCameraPath SetCameraPath => Item17;

	public SetCameraPath Item17
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

	public SetGizmoState SetGizmoState => Item18;

	public SetGizmoState Item18
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

	public SetClientCapabilities SetClientCapabilities => Item19;

	public SetClientCapabilities Item19
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

	public HudPanelSet HudPanelSet => Item20;

	public HudPanelSet Item20
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

	public HudLabelsSet HudLabelsSet => Item21;

	public HudLabelsSet Item21
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

	public StreamTextureCreateSDPOffer StreamTextureCreateSDPOffer => Item22;

	public StreamTextureCreateSDPOffer Item22
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

	public StreamTextureApplySDPAnswer StreamTextureApplySDPAnswer => Item23;

	public StreamTextureApplySDPAnswer Item23
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

	public StreamTextureStatusRequest StreamTextureStatusRequest => Item24;

	public StreamTextureStatusRequest Item24
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

	public SetSceneEditorViewport SetSceneEditorViewport => Item25;

	public SetSceneEditorViewport Item25
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

	public GetSceneEditorHudLayout GetSceneEditorHudLayout => Item26;

	public GetSceneEditorHudLayout Item26
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

	public SetDirectedCameraTarget SetDirectedCameraTarget => Item27;

	public SetDirectedCameraTarget Item27
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

	public SetReplayTime SetReplayTime => Item28;

	public SetReplayTime Item28
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

	public GetRenderSettings GetRenderSettings => Item29;

	public GetRenderSettings Item29
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

	public SetRenderSettings SetRenderSettings => Item30;

	public SetRenderSettings Item30
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

	public SetSequence SetSequence => Item31;

	public SetSequence Item31
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

	public SequenceTransport SequenceTransport => Item32;

	public SequenceTransport Item32
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

	public SequenceStateRequest SequenceStateRequest => Item33;

	public SequenceStateRequest Item33
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

	public SetCinematicCameraEditor SetCinematicCameraEditor => Item34;

	public SetCinematicCameraEditor Item34
	{
		get
		{
			if (Discriminator != 34)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem34();
		}
	}

	public GetCinematicCameraPose GetCinematicCameraPose => Item35;

	public GetCinematicCameraPose Item35
	{
		get
		{
			if (Discriminator != 35)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem35();
		}
	}

	public SetCinematicPropEditor SetCinematicPropEditor => Item36;

	public SetCinematicPropEditor Item36
	{
		get
		{
			if (Discriminator != 36)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem36();
		}
	}

	public SetControllerCameraConfig SetControllerCameraConfig => Item37;

	public SetControllerCameraConfig Item37
	{
		get
		{
			if (Discriminator != 37)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem37();
		}
	}

	public SetCameraPreviewConfiguration SetCameraPreviewConfiguration => Item38;

	public SetCameraPreviewConfiguration Item38
	{
		get
		{
			if (Discriminator != 38)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem38();
		}
	}

	public ClearCameraPreviewConfiguration ClearCameraPreviewConfiguration => Item39;

	public ClearCameraPreviewConfiguration Item39
	{
		get
		{
			if (Discriminator != 39)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem39();
		}
	}

	public GetCameraPreviewStatus GetCameraPreviewStatus => Item40;

	public GetCameraPreviewStatus Item40
	{
		get
		{
			if (Discriminator != 40)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem40();
		}
	}

	public TakeCameraPreviewAux TakeCameraPreviewAux => Item41;

	public TakeCameraPreviewAux Item41
	{
		get
		{
			if (Discriminator != 41)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem41();
		}
	}

	public SetAutoDirectorMainCamera SetAutoDirectorMainCamera => Item42;

	public SetAutoDirectorMainCamera Item42
	{
		get
		{
			if (Discriminator != 42)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem42();
		}
	}

	public RequestKind(RegisterService value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 1;
		this.value = value;
	}

	public static implicit operator RequestKind(RegisterService value)
	{
		return new RequestKind(value);
	}

	private RegisterService UncheckedGetItem1()
	{
		return (RegisterService)value;
	}

	public bool TryGet([NotNullWhen(true)] out RegisterService? value)
	{
		if (Discriminator != 1)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem1();
		return true;
	}

	public RequestKind(ConfigService value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 2;
		this.value = value;
	}

	public static implicit operator RequestKind(ConfigService value)
	{
		return new RequestKind(value);
	}

	private ConfigService UncheckedGetItem2()
	{
		return (ConfigService)value;
	}

	public bool TryGet([NotNullWhen(true)] out ConfigService? value)
	{
		if (Discriminator != 2)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem2();
		return true;
	}

	public RequestKind(UnregisterService value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 3;
		this.value = value;
	}

	public static implicit operator RequestKind(UnregisterService value)
	{
		return new RequestKind(value);
	}

	private UnregisterService UncheckedGetItem3()
	{
		return (UnregisterService)value;
	}

	public bool TryGet([NotNullWhen(true)] out UnregisterService? value)
	{
		if (Discriminator != 3)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem3();
		return true;
	}

	public RequestKind(EphemeralAction value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 4;
		this.value = value;
	}

	public static implicit operator RequestKind(EphemeralAction value)
	{
		return new RequestKind(value);
	}

	private EphemeralAction UncheckedGetItem4()
	{
		return (EphemeralAction)value;
	}

	public bool TryGet([NotNullWhen(true)] out EphemeralAction? value)
	{
		if (Discriminator != 4)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem4();
		return true;
	}

	public RequestKind(AuthenticationStart value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 5;
		this.value = value;
	}

	public static implicit operator RequestKind(AuthenticationStart value)
	{
		return new RequestKind(value);
	}

	private AuthenticationStart UncheckedGetItem5()
	{
		return (AuthenticationStart)value;
	}

	public bool TryGet([NotNullWhen(true)] out AuthenticationStart? value)
	{
		if (Discriminator != 5)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem5();
		return true;
	}

	public RequestKind(AuthenticationVerify value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 6;
		this.value = value;
	}

	public static implicit operator RequestKind(AuthenticationVerify value)
	{
		return new RequestKind(value);
	}

	private AuthenticationVerify UncheckedGetItem6()
	{
		return (AuthenticationVerify)value;
	}

	public bool TryGet([NotNullWhen(true)] out AuthenticationVerify? value)
	{
		if (Discriminator != 6)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem6();
		return true;
	}

	public RequestKind(DrawingStateAction value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 7;
		this.value = value;
	}

	public static implicit operator RequestKind(DrawingStateAction value)
	{
		return new RequestKind(value);
	}

	private DrawingStateAction UncheckedGetItem7()
	{
		return (DrawingStateAction)value;
	}

	public bool TryGet([NotNullWhen(true)] out DrawingStateAction? value)
	{
		if (Discriminator != 7)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem7();
		return true;
	}

	public RequestKind(SceneAction value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 8;
		this.value = value;
	}

	public static implicit operator RequestKind(SceneAction value)
	{
		return new RequestKind(value);
	}

	private SceneAction UncheckedGetItem8()
	{
		return (SceneAction)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneAction? value)
	{
		if (Discriminator != 8)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem8();
		return true;
	}

	public RequestKind(AssetCreate value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 9;
		this.value = value;
	}

	public static implicit operator RequestKind(AssetCreate value)
	{
		return new RequestKind(value);
	}

	private AssetCreate UncheckedGetItem9()
	{
		return (AssetCreate)value;
	}

	public bool TryGet([NotNullWhen(true)] out AssetCreate? value)
	{
		if (Discriminator != 9)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem9();
		return true;
	}

	public RequestKind(AssetCreateBatch value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 10;
		this.value = value;
	}

	public static implicit operator RequestKind(AssetCreateBatch value)
	{
		return new RequestKind(value);
	}

	private AssetCreateBatch UncheckedGetItem10()
	{
		return (AssetCreateBatch)value;
	}

	public bool TryGet([NotNullWhen(true)] out AssetCreateBatch? value)
	{
		if (Discriminator != 10)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem10();
		return true;
	}

	public RequestKind(AssetDelete value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 11;
		this.value = value;
	}

	public static implicit operator RequestKind(AssetDelete value)
	{
		return new RequestKind(value);
	}

	private AssetDelete UncheckedGetItem11()
	{
		return (AssetDelete)value;
	}

	public bool TryGet([NotNullWhen(true)] out AssetDelete? value)
	{
		if (Discriminator != 11)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem11();
		return true;
	}

	public RequestKind(StreamTextureSDPOffer value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 12;
		this.value = value;
	}

	public static implicit operator RequestKind(StreamTextureSDPOffer value)
	{
		return new RequestKind(value);
	}

	private StreamTextureSDPOffer UncheckedGetItem12()
	{
		return (StreamTextureSDPOffer)value;
	}

	public bool TryGet([NotNullWhen(true)] out StreamTextureSDPOffer? value)
	{
		if (Discriminator != 12)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem12();
		return true;
	}

	public RequestKind(StreamTextureCloseSession value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 13;
		this.value = value;
	}

	public static implicit operator RequestKind(StreamTextureCloseSession value)
	{
		return new RequestKind(value);
	}

	private StreamTextureCloseSession UncheckedGetItem13()
	{
		return (StreamTextureCloseSession)value;
	}

	public bool TryGet([NotNullWhen(true)] out StreamTextureCloseSession? value)
	{
		if (Discriminator != 13)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem13();
		return true;
	}

	public RequestKind(SetCameraTarget value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 14;
		this.value = value;
	}

	public static implicit operator RequestKind(SetCameraTarget value)
	{
		return new RequestKind(value);
	}

	private SetCameraTarget UncheckedGetItem14()
	{
		return (SetCameraTarget)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetCameraTarget? value)
	{
		if (Discriminator != 14)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem14();
		return true;
	}

	public RequestKind(SetCameraFollowEnabled value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 15;
		this.value = value;
	}

	public static implicit operator RequestKind(SetCameraFollowEnabled value)
	{
		return new RequestKind(value);
	}

	private SetCameraFollowEnabled UncheckedGetItem15()
	{
		return (SetCameraFollowEnabled)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetCameraFollowEnabled? value)
	{
		if (Discriminator != 15)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem15();
		return true;
	}

	public RequestKind(IdentifyClient value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 16;
		this.value = value;
	}

	public static implicit operator RequestKind(IdentifyClient value)
	{
		return new RequestKind(value);
	}

	private IdentifyClient UncheckedGetItem16()
	{
		return (IdentifyClient)value;
	}

	public bool TryGet([NotNullWhen(true)] out IdentifyClient? value)
	{
		if (Discriminator != 16)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem16();
		return true;
	}

	public RequestKind(SetCameraPath value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 17;
		this.value = value;
	}

	public static implicit operator RequestKind(SetCameraPath value)
	{
		return new RequestKind(value);
	}

	private SetCameraPath UncheckedGetItem17()
	{
		return (SetCameraPath)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetCameraPath? value)
	{
		if (Discriminator != 17)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem17();
		return true;
	}

	public RequestKind(SetGizmoState value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 18;
		this.value = value;
	}

	public static implicit operator RequestKind(SetGizmoState value)
	{
		return new RequestKind(value);
	}

	private SetGizmoState UncheckedGetItem18()
	{
		return (SetGizmoState)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetGizmoState? value)
	{
		if (Discriminator != 18)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem18();
		return true;
	}

	public RequestKind(SetClientCapabilities value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 19;
		this.value = value;
	}

	public static implicit operator RequestKind(SetClientCapabilities value)
	{
		return new RequestKind(value);
	}

	private SetClientCapabilities UncheckedGetItem19()
	{
		return (SetClientCapabilities)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetClientCapabilities? value)
	{
		if (Discriminator != 19)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem19();
		return true;
	}

	public RequestKind(HudPanelSet value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 20;
		this.value = value;
	}

	public static implicit operator RequestKind(HudPanelSet value)
	{
		return new RequestKind(value);
	}

	private HudPanelSet UncheckedGetItem20()
	{
		return (HudPanelSet)value;
	}

	public bool TryGet([NotNullWhen(true)] out HudPanelSet? value)
	{
		if (Discriminator != 20)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem20();
		return true;
	}

	public RequestKind(HudLabelsSet value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 21;
		this.value = value;
	}

	public static implicit operator RequestKind(HudLabelsSet value)
	{
		return new RequestKind(value);
	}

	private HudLabelsSet UncheckedGetItem21()
	{
		return (HudLabelsSet)value;
	}

	public bool TryGet([NotNullWhen(true)] out HudLabelsSet? value)
	{
		if (Discriminator != 21)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem21();
		return true;
	}

	public RequestKind(StreamTextureCreateSDPOffer value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 22;
		this.value = value;
	}

	public static implicit operator RequestKind(StreamTextureCreateSDPOffer value)
	{
		return new RequestKind(value);
	}

	private StreamTextureCreateSDPOffer UncheckedGetItem22()
	{
		return (StreamTextureCreateSDPOffer)value;
	}

	public bool TryGet([NotNullWhen(true)] out StreamTextureCreateSDPOffer? value)
	{
		if (Discriminator != 22)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem22();
		return true;
	}

	public RequestKind(StreamTextureApplySDPAnswer value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 23;
		this.value = value;
	}

	public static implicit operator RequestKind(StreamTextureApplySDPAnswer value)
	{
		return new RequestKind(value);
	}

	private StreamTextureApplySDPAnswer UncheckedGetItem23()
	{
		return (StreamTextureApplySDPAnswer)value;
	}

	public bool TryGet([NotNullWhen(true)] out StreamTextureApplySDPAnswer? value)
	{
		if (Discriminator != 23)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem23();
		return true;
	}

	public RequestKind(StreamTextureStatusRequest value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 24;
		this.value = value;
	}

	public static implicit operator RequestKind(StreamTextureStatusRequest value)
	{
		return new RequestKind(value);
	}

	private StreamTextureStatusRequest UncheckedGetItem24()
	{
		return (StreamTextureStatusRequest)value;
	}

	public bool TryGet([NotNullWhen(true)] out StreamTextureStatusRequest? value)
	{
		if (Discriminator != 24)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem24();
		return true;
	}

	public RequestKind(SetSceneEditorViewport value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 25;
		this.value = value;
	}

	public static implicit operator RequestKind(SetSceneEditorViewport value)
	{
		return new RequestKind(value);
	}

	private SetSceneEditorViewport UncheckedGetItem25()
	{
		return (SetSceneEditorViewport)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetSceneEditorViewport? value)
	{
		if (Discriminator != 25)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem25();
		return true;
	}

	public RequestKind(GetSceneEditorHudLayout value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 26;
		this.value = value;
	}

	public static implicit operator RequestKind(GetSceneEditorHudLayout value)
	{
		return new RequestKind(value);
	}

	private GetSceneEditorHudLayout UncheckedGetItem26()
	{
		return (GetSceneEditorHudLayout)value;
	}

	public bool TryGet([NotNullWhen(true)] out GetSceneEditorHudLayout? value)
	{
		if (Discriminator != 26)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem26();
		return true;
	}

	public RequestKind(SetDirectedCameraTarget value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 27;
		this.value = value;
	}

	public static implicit operator RequestKind(SetDirectedCameraTarget value)
	{
		return new RequestKind(value);
	}

	private SetDirectedCameraTarget UncheckedGetItem27()
	{
		return (SetDirectedCameraTarget)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetDirectedCameraTarget? value)
	{
		if (Discriminator != 27)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem27();
		return true;
	}

	public RequestKind(SetReplayTime value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 28;
		this.value = value;
	}

	public static implicit operator RequestKind(SetReplayTime value)
	{
		return new RequestKind(value);
	}

	private SetReplayTime UncheckedGetItem28()
	{
		return (SetReplayTime)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetReplayTime? value)
	{
		if (Discriminator != 28)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem28();
		return true;
	}

	public RequestKind(GetRenderSettings value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 29;
		this.value = value;
	}

	public static implicit operator RequestKind(GetRenderSettings value)
	{
		return new RequestKind(value);
	}

	private GetRenderSettings UncheckedGetItem29()
	{
		return (GetRenderSettings)value;
	}

	public bool TryGet([NotNullWhen(true)] out GetRenderSettings? value)
	{
		if (Discriminator != 29)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem29();
		return true;
	}

	public RequestKind(SetRenderSettings value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 30;
		this.value = value;
	}

	public static implicit operator RequestKind(SetRenderSettings value)
	{
		return new RequestKind(value);
	}

	private SetRenderSettings UncheckedGetItem30()
	{
		return (SetRenderSettings)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetRenderSettings? value)
	{
		if (Discriminator != 30)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem30();
		return true;
	}

	public RequestKind(SetSequence value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 31;
		this.value = value;
	}

	public static implicit operator RequestKind(SetSequence value)
	{
		return new RequestKind(value);
	}

	private SetSequence UncheckedGetItem31()
	{
		return (SetSequence)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetSequence? value)
	{
		if (Discriminator != 31)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem31();
		return true;
	}

	public RequestKind(SequenceTransport value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 32;
		this.value = value;
	}

	public static implicit operator RequestKind(SequenceTransport value)
	{
		return new RequestKind(value);
	}

	private SequenceTransport UncheckedGetItem32()
	{
		return (SequenceTransport)value;
	}

	public bool TryGet([NotNullWhen(true)] out SequenceTransport? value)
	{
		if (Discriminator != 32)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem32();
		return true;
	}

	public RequestKind(SequenceStateRequest value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 33;
		this.value = value;
	}

	public static implicit operator RequestKind(SequenceStateRequest value)
	{
		return new RequestKind(value);
	}

	private SequenceStateRequest UncheckedGetItem33()
	{
		return (SequenceStateRequest)value;
	}

	public bool TryGet([NotNullWhen(true)] out SequenceStateRequest? value)
	{
		if (Discriminator != 33)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem33();
		return true;
	}

	public RequestKind(SetCinematicCameraEditor value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 34;
		this.value = value;
	}

	public static implicit operator RequestKind(SetCinematicCameraEditor value)
	{
		return new RequestKind(value);
	}

	private SetCinematicCameraEditor UncheckedGetItem34()
	{
		return (SetCinematicCameraEditor)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetCinematicCameraEditor? value)
	{
		if (Discriminator != 34)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem34();
		return true;
	}

	public RequestKind(GetCinematicCameraPose value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 35;
		this.value = value;
	}

	public static implicit operator RequestKind(GetCinematicCameraPose value)
	{
		return new RequestKind(value);
	}

	private GetCinematicCameraPose UncheckedGetItem35()
	{
		return (GetCinematicCameraPose)value;
	}

	public bool TryGet([NotNullWhen(true)] out GetCinematicCameraPose? value)
	{
		if (Discriminator != 35)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem35();
		return true;
	}

	public RequestKind(SetCinematicPropEditor value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 36;
		this.value = value;
	}

	public static implicit operator RequestKind(SetCinematicPropEditor value)
	{
		return new RequestKind(value);
	}

	private SetCinematicPropEditor UncheckedGetItem36()
	{
		return (SetCinematicPropEditor)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetCinematicPropEditor? value)
	{
		if (Discriminator != 36)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem36();
		return true;
	}

	public RequestKind(SetControllerCameraConfig value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 37;
		this.value = value;
	}

	public static implicit operator RequestKind(SetControllerCameraConfig value)
	{
		return new RequestKind(value);
	}

	private SetControllerCameraConfig UncheckedGetItem37()
	{
		return (SetControllerCameraConfig)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetControllerCameraConfig? value)
	{
		if (Discriminator != 37)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem37();
		return true;
	}

	public RequestKind(SetCameraPreviewConfiguration value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 38;
		this.value = value;
	}

	public static implicit operator RequestKind(SetCameraPreviewConfiguration value)
	{
		return new RequestKind(value);
	}

	private SetCameraPreviewConfiguration UncheckedGetItem38()
	{
		return (SetCameraPreviewConfiguration)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetCameraPreviewConfiguration? value)
	{
		if (Discriminator != 38)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem38();
		return true;
	}

	public RequestKind(ClearCameraPreviewConfiguration value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 39;
		this.value = value;
	}

	public static implicit operator RequestKind(ClearCameraPreviewConfiguration value)
	{
		return new RequestKind(value);
	}

	private ClearCameraPreviewConfiguration UncheckedGetItem39()
	{
		return (ClearCameraPreviewConfiguration)value;
	}

	public bool TryGet([NotNullWhen(true)] out ClearCameraPreviewConfiguration? value)
	{
		if (Discriminator != 39)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem39();
		return true;
	}

	public RequestKind(GetCameraPreviewStatus value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 40;
		this.value = value;
	}

	public static implicit operator RequestKind(GetCameraPreviewStatus value)
	{
		return new RequestKind(value);
	}

	private GetCameraPreviewStatus UncheckedGetItem40()
	{
		return (GetCameraPreviewStatus)value;
	}

	public bool TryGet([NotNullWhen(true)] out GetCameraPreviewStatus? value)
	{
		if (Discriminator != 40)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem40();
		return true;
	}

	public RequestKind(TakeCameraPreviewAux value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 41;
		this.value = value;
	}

	public static implicit operator RequestKind(TakeCameraPreviewAux value)
	{
		return new RequestKind(value);
	}

	private TakeCameraPreviewAux UncheckedGetItem41()
	{
		return (TakeCameraPreviewAux)value;
	}

	public bool TryGet([NotNullWhen(true)] out TakeCameraPreviewAux? value)
	{
		if (Discriminator != 41)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem41();
		return true;
	}

	public RequestKind(SetAutoDirectorMainCamera value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 42;
		this.value = value;
	}

	public static implicit operator RequestKind(SetAutoDirectorMainCamera value)
	{
		return new RequestKind(value);
	}

	private SetAutoDirectorMainCamera UncheckedGetItem42()
	{
		return (SetAutoDirectorMainCamera)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetAutoDirectorMainCamera? value)
	{
		if (Discriminator != 42)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem42();
		return true;
	}

	public TReturn Accept<TVisitor, TReturn>(TVisitor visitor) where TVisitor : IFlatBufferUnionVisitor<TReturn, RegisterService, ConfigService, UnregisterService, EphemeralAction, AuthenticationStart, AuthenticationVerify, DrawingStateAction, SceneAction, AssetCreate, AssetCreateBatch, AssetDelete, StreamTextureSDPOffer, StreamTextureCloseSession, SetCameraTarget, SetCameraFollowEnabled, IdentifyClient, SetCameraPath, SetGizmoState, SetClientCapabilities, HudPanelSet, HudLabelsSet, StreamTextureCreateSDPOffer, StreamTextureApplySDPAnswer, StreamTextureStatusRequest, SetSceneEditorViewport, GetSceneEditorHudLayout, SetDirectedCameraTarget, SetReplayTime, GetRenderSettings, SetRenderSettings, SetSequence, SequenceTransport, SequenceStateRequest, SetCinematicCameraEditor, GetCinematicCameraPose, SetCinematicPropEditor, SetControllerCameraConfig, SetCameraPreviewConfiguration, ClearCameraPreviewConfiguration, GetCameraPreviewStatus, TakeCameraPreviewAux, SetAutoDirectorMainCamera>
	{
		byte discriminator = Discriminator;
		TVisitor val;
		switch (discriminator)
		{
		case 1:
		{
			ref TVisitor reference42 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference42;
				reference42 = ref val;
			}
			RegisterService item42 = UncheckedGetItem1();
			return reference42.Visit(item42);
		}
		case 2:
		{
			ref TVisitor reference6 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference6;
				reference6 = ref val;
			}
			ConfigService item6 = UncheckedGetItem2();
			return reference6.Visit(item6);
		}
		case 3:
		{
			ref TVisitor reference33 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference33;
				reference33 = ref val;
			}
			UnregisterService item33 = UncheckedGetItem3();
			return reference33.Visit(item33);
		}
		case 4:
		{
			ref TVisitor reference20 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference20;
				reference20 = ref val;
			}
			EphemeralAction item20 = UncheckedGetItem4();
			return reference20.Visit(item20);
		}
		case 5:
		{
			ref TVisitor reference9 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference9;
				reference9 = ref val;
			}
			AuthenticationStart item9 = UncheckedGetItem5();
			return reference9.Visit(item9);
		}
		case 6:
		{
			ref TVisitor reference2 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference2;
				reference2 = ref val;
			}
			AuthenticationVerify item2 = UncheckedGetItem6();
			return reference2.Visit(item2);
		}
		case 7:
		{
			ref TVisitor reference26 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference26;
				reference26 = ref val;
			}
			DrawingStateAction item26 = UncheckedGetItem7();
			return reference26.Visit(item26);
		}
		case 8:
		{
			ref TVisitor reference18 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference18;
				reference18 = ref val;
			}
			SceneAction item18 = UncheckedGetItem8();
			return reference18.Visit(item18);
		}
		case 9:
		{
			ref TVisitor reference36 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference36;
				reference36 = ref val;
			}
			AssetCreate item36 = UncheckedGetItem9();
			return reference36.Visit(item36);
		}
		case 10:
		{
			ref TVisitor reference29 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference29;
				reference29 = ref val;
			}
			AssetCreateBatch item29 = UncheckedGetItem10();
			return reference29.Visit(item29);
		}
		case 11:
		{
			ref TVisitor reference17 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference17;
				reference17 = ref val;
			}
			AssetDelete item17 = UncheckedGetItem11();
			return reference17.Visit(item17);
		}
		case 12:
		{
			ref TVisitor reference15 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference15;
				reference15 = ref val;
			}
			StreamTextureSDPOffer item15 = UncheckedGetItem12();
			return reference15.Visit(item15);
		}
		case 13:
		{
			ref TVisitor reference38 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference38;
				reference38 = ref val;
			}
			StreamTextureCloseSession item38 = UncheckedGetItem13();
			return reference38.Visit(item38);
		}
		case 14:
		{
			ref TVisitor reference35 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference35;
				reference35 = ref val;
			}
			SetCameraTarget item35 = UncheckedGetItem14();
			return reference35.Visit(item35);
		}
		case 15:
		{
			ref TVisitor reference27 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference27;
				reference27 = ref val;
			}
			SetCameraFollowEnabled item27 = UncheckedGetItem15();
			return reference27.Visit(item27);
		}
		case 16:
		{
			ref TVisitor reference24 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference24;
				reference24 = ref val;
			}
			IdentifyClient item24 = UncheckedGetItem16();
			return reference24.Visit(item24);
		}
		case 17:
		{
			ref TVisitor reference11 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference11;
				reference11 = ref val;
			}
			SetCameraPath item11 = UncheckedGetItem17();
			return reference11.Visit(item11);
		}
		case 18:
		{
			ref TVisitor reference8 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference8;
				reference8 = ref val;
			}
			SetGizmoState item8 = UncheckedGetItem18();
			return reference8.Visit(item8);
		}
		case 19:
		{
			ref TVisitor reference41 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference41;
				reference41 = ref val;
			}
			SetClientCapabilities item41 = UncheckedGetItem19();
			return reference41.Visit(item41);
		}
		case 20:
		{
			ref TVisitor reference39 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference39;
				reference39 = ref val;
			}
			HudPanelSet item39 = UncheckedGetItem20();
			return reference39.Visit(item39);
		}
		case 21:
		{
			ref TVisitor reference32 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference32;
				reference32 = ref val;
			}
			HudLabelsSet item32 = UncheckedGetItem21();
			return reference32.Visit(item32);
		}
		case 22:
		{
			ref TVisitor reference30 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference30;
				reference30 = ref val;
			}
			StreamTextureCreateSDPOffer item30 = UncheckedGetItem22();
			return reference30.Visit(item30);
		}
		case 23:
		{
			ref TVisitor reference23 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference23;
				reference23 = ref val;
			}
			StreamTextureApplySDPAnswer item23 = UncheckedGetItem23();
			return reference23.Visit(item23);
		}
		case 24:
		{
			ref TVisitor reference21 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference21;
				reference21 = ref val;
			}
			StreamTextureStatusRequest item21 = UncheckedGetItem24();
			return reference21.Visit(item21);
		}
		case 25:
		{
			ref TVisitor reference14 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference14;
				reference14 = ref val;
			}
			SetSceneEditorViewport item14 = UncheckedGetItem25();
			return reference14.Visit(item14);
		}
		case 26:
		{
			ref TVisitor reference12 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference12;
				reference12 = ref val;
			}
			GetSceneEditorHudLayout item12 = UncheckedGetItem26();
			return reference12.Visit(item12);
		}
		case 27:
		{
			ref TVisitor reference5 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference5;
				reference5 = ref val;
			}
			SetDirectedCameraTarget item5 = UncheckedGetItem27();
			return reference5.Visit(item5);
		}
		case 28:
		{
			ref TVisitor reference3 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference3;
				reference3 = ref val;
			}
			SetReplayTime item3 = UncheckedGetItem28();
			return reference3.Visit(item3);
		}
		case 29:
		{
			ref TVisitor reference40 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference40;
				reference40 = ref val;
			}
			GetRenderSettings item40 = UncheckedGetItem29();
			return reference40.Visit(item40);
		}
		case 30:
		{
			ref TVisitor reference37 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference37;
				reference37 = ref val;
			}
			SetRenderSettings item37 = UncheckedGetItem30();
			return reference37.Visit(item37);
		}
		case 31:
		{
			ref TVisitor reference34 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference34;
				reference34 = ref val;
			}
			SetSequence item34 = UncheckedGetItem31();
			return reference34.Visit(item34);
		}
		case 32:
		{
			ref TVisitor reference31 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference31;
				reference31 = ref val;
			}
			SequenceTransport item31 = UncheckedGetItem32();
			return reference31.Visit(item31);
		}
		case 33:
		{
			ref TVisitor reference28 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference28;
				reference28 = ref val;
			}
			SequenceStateRequest item28 = UncheckedGetItem33();
			return reference28.Visit(item28);
		}
		case 34:
		{
			ref TVisitor reference25 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference25;
				reference25 = ref val;
			}
			SetCinematicCameraEditor item25 = UncheckedGetItem34();
			return reference25.Visit(item25);
		}
		case 35:
		{
			ref TVisitor reference22 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference22;
				reference22 = ref val;
			}
			GetCinematicCameraPose item22 = UncheckedGetItem35();
			return reference22.Visit(item22);
		}
		case 36:
		{
			ref TVisitor reference19 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference19;
				reference19 = ref val;
			}
			SetCinematicPropEditor item19 = UncheckedGetItem36();
			return reference19.Visit(item19);
		}
		case 37:
		{
			ref TVisitor reference16 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference16;
				reference16 = ref val;
			}
			SetControllerCameraConfig item16 = UncheckedGetItem37();
			return reference16.Visit(item16);
		}
		case 38:
		{
			ref TVisitor reference13 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference13;
				reference13 = ref val;
			}
			SetCameraPreviewConfiguration item13 = UncheckedGetItem38();
			return reference13.Visit(item13);
		}
		case 39:
		{
			ref TVisitor reference10 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference10;
				reference10 = ref val;
			}
			ClearCameraPreviewConfiguration item10 = UncheckedGetItem39();
			return reference10.Visit(item10);
		}
		case 40:
		{
			ref TVisitor reference7 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference7;
				reference7 = ref val;
			}
			GetCameraPreviewStatus item7 = UncheckedGetItem40();
			return reference7.Visit(item7);
		}
		case 41:
		{
			ref TVisitor reference4 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference4;
				reference4 = ref val;
			}
			TakeCameraPreviewAux item4 = UncheckedGetItem41();
			return reference4.Visit(item4);
		}
		case 42:
		{
			ref TVisitor reference = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference;
				reference = ref val;
			}
			SetAutoDirectorMainCamera item = UncheckedGetItem42();
			return reference.Visit(item);
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<RequestKind>(discriminator);
			return default;
		}
	}

	public TReturn Match<TReturn>(Func<RegisterService, TReturn> caseRegisterService, Func<ConfigService, TReturn> caseConfigService, Func<UnregisterService, TReturn> caseUnregisterService, Func<EphemeralAction, TReturn> caseEphemeralAction, Func<AuthenticationStart, TReturn> caseAuthenticationStart, Func<AuthenticationVerify, TReturn> caseAuthenticationVerify, Func<DrawingStateAction, TReturn> caseDrawingStateAction, Func<SceneAction, TReturn> caseBlueBottleIPC_LeagueBroadcast_Scene_SceneAction, Func<AssetCreate, TReturn> caseAssetCreate, Func<AssetCreateBatch, TReturn> caseAssetCreateBatch, Func<AssetDelete, TReturn> caseAssetDelete, Func<StreamTextureSDPOffer, TReturn> caseStreamTextureSDPOffer, Func<StreamTextureCloseSession, TReturn> caseStreamTextureCloseSession, Func<SetCameraTarget, TReturn> caseSetCameraTarget, Func<SetCameraFollowEnabled, TReturn> caseSetCameraFollowEnabled, Func<IdentifyClient, TReturn> caseIdentifyClient, Func<SetCameraPath, TReturn> caseSetCameraPath, Func<SetGizmoState, TReturn> caseSetGizmoState, Func<SetClientCapabilities, TReturn> caseSetClientCapabilities, Func<HudPanelSet, TReturn> caseHudPanelSet, Func<HudLabelsSet, TReturn> caseHudLabelsSet, Func<StreamTextureCreateSDPOffer, TReturn> caseStreamTextureCreateSDPOffer, Func<StreamTextureApplySDPAnswer, TReturn> caseStreamTextureApplySDPAnswer, Func<StreamTextureStatusRequest, TReturn> caseStreamTextureStatusRequest, Func<SetSceneEditorViewport, TReturn> caseSetSceneEditorViewport, Func<GetSceneEditorHudLayout, TReturn> caseGetSceneEditorHudLayout, Func<SetDirectedCameraTarget, TReturn> caseSetDirectedCameraTarget, Func<SetReplayTime, TReturn> caseSetReplayTime, Func<GetRenderSettings, TReturn> caseGetRenderSettings, Func<SetRenderSettings, TReturn> caseSetRenderSettings, Func<SetSequence, TReturn> caseSetSequence, Func<SequenceTransport, TReturn> caseSequenceTransport, Func<SequenceStateRequest, TReturn> caseSequenceStateRequest, Func<SetCinematicCameraEditor, TReturn> caseSetCinematicCameraEditor, Func<GetCinematicCameraPose, TReturn> caseGetCinematicCameraPose, Func<SetCinematicPropEditor, TReturn> caseSetCinematicPropEditor, Func<SetControllerCameraConfig, TReturn> caseSetControllerCameraConfig, Func<SetCameraPreviewConfiguration, TReturn> caseSetCameraPreviewConfiguration, Func<ClearCameraPreviewConfiguration, TReturn> caseClearCameraPreviewConfiguration, Func<GetCameraPreviewStatus, TReturn> caseGetCameraPreviewStatus, Func<TakeCameraPreviewAux, TReturn> caseTakeCameraPreviewAux, Func<SetAutoDirectorMainCamera, TReturn> caseSetAutoDirectorMainCamera)
	{
		byte discriminator = Discriminator;
		switch (discriminator)
		{
		case 1:
			return caseRegisterService(UncheckedGetItem1());
		case 2:
			return caseConfigService(UncheckedGetItem2());
		case 3:
			return caseUnregisterService(UncheckedGetItem3());
		case 4:
			return caseEphemeralAction(UncheckedGetItem4());
		case 5:
			return caseAuthenticationStart(UncheckedGetItem5());
		case 6:
			return caseAuthenticationVerify(UncheckedGetItem6());
		case 7:
			return caseDrawingStateAction(UncheckedGetItem7());
		case 8:
			return caseBlueBottleIPC_LeagueBroadcast_Scene_SceneAction(UncheckedGetItem8());
		case 9:
			return caseAssetCreate(UncheckedGetItem9());
		case 10:
			return caseAssetCreateBatch(UncheckedGetItem10());
		case 11:
			return caseAssetDelete(UncheckedGetItem11());
		case 12:
			return caseStreamTextureSDPOffer(UncheckedGetItem12());
		case 13:
			return caseStreamTextureCloseSession(UncheckedGetItem13());
		case 14:
			return caseSetCameraTarget(UncheckedGetItem14());
		case 15:
			return caseSetCameraFollowEnabled(UncheckedGetItem15());
		case 16:
			return caseIdentifyClient(UncheckedGetItem16());
		case 17:
			return caseSetCameraPath(UncheckedGetItem17());
		case 18:
			return caseSetGizmoState(UncheckedGetItem18());
		case 19:
			return caseSetClientCapabilities(UncheckedGetItem19());
		case 20:
			return caseHudPanelSet(UncheckedGetItem20());
		case 21:
			return caseHudLabelsSet(UncheckedGetItem21());
		case 22:
			return caseStreamTextureCreateSDPOffer(UncheckedGetItem22());
		case 23:
			return caseStreamTextureApplySDPAnswer(UncheckedGetItem23());
		case 24:
			return caseStreamTextureStatusRequest(UncheckedGetItem24());
		case 25:
			return caseSetSceneEditorViewport(UncheckedGetItem25());
		case 26:
			return caseGetSceneEditorHudLayout(UncheckedGetItem26());
		case 27:
			return caseSetDirectedCameraTarget(UncheckedGetItem27());
		case 28:
			return caseSetReplayTime(UncheckedGetItem28());
		case 29:
			return caseGetRenderSettings(UncheckedGetItem29());
		case 30:
			return caseSetRenderSettings(UncheckedGetItem30());
		case 31:
			return caseSetSequence(UncheckedGetItem31());
		case 32:
			return caseSequenceTransport(UncheckedGetItem32());
		case 33:
			return caseSequenceStateRequest(UncheckedGetItem33());
		case 34:
			return caseSetCinematicCameraEditor(UncheckedGetItem34());
		case 35:
			return caseGetCinematicCameraPose(UncheckedGetItem35());
		case 36:
			return caseSetCinematicPropEditor(UncheckedGetItem36());
		case 37:
			return caseSetControllerCameraConfig(UncheckedGetItem37());
		case 38:
			return caseSetCameraPreviewConfiguration(UncheckedGetItem38());
		case 39:
			return caseClearCameraPreviewConfiguration(UncheckedGetItem39());
		case 40:
			return caseGetCameraPreviewStatus(UncheckedGetItem40());
		case 41:
			return caseTakeCameraPreviewAux(UncheckedGetItem41());
		case 42:
			return caseSetAutoDirectorMainCamera(UncheckedGetItem42());
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<RequestKind>(discriminator);
			return default;
		}
	}
}
