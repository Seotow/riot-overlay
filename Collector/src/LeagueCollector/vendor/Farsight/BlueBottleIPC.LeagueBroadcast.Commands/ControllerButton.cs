using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum ControllerButton : byte
{
	FaceSouth,
	FaceEast,
	FaceWest,
	FaceNorth,
	DPadUp,
	DPadDown,
	DPadLeft,
	DPadRight,
	LeftShoulder,
	RightShoulder,
	LeftStick,
	RightStick,
	Menu,
	View
}
