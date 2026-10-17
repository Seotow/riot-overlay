using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum HudPanelRowState : byte
{
	Normal,
	Highlighted,
	Ranked,
	Confirm,
	Disabled
}
