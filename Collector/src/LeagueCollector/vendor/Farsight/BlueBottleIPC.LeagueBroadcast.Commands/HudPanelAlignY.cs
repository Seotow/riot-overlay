using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferEnum(typeof(byte))]
public enum HudPanelAlignY : byte
{
	top,
	middle,
	bottom
}
