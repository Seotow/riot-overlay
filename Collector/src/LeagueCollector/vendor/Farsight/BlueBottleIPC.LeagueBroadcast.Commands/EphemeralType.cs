using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(int))]
public enum EphemeralType
{
	Metadata = 0,
	Snapshot = 1,
	Quit = 2,
	ShowDamageFloatingTexts = 3,
	HideDamageFloatingTexts = 4,
	SetPlaybackSpeed = 5,
	SetCameraZoomUnlocked = 6,
	SetCameraZoomLocked = 7,
	GetCameraProperties = 8,
	GetSpellObjectList = 9,
	GetOffsetTable = 10,
	GetObjectAddresses = 11,
	SetCinematicDemo = 12,
	EnableSpectatorGoldFloatingTextFix = 13,
	DisableSpectatorGoldFloatingTextFix = 14,
	GetCrashReportChannel = 15,
	CloseWindowOnGameEnd = 99,
	Debug = 1337
}
