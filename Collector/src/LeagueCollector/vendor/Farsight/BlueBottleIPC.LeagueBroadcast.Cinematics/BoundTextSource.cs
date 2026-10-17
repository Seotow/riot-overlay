using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Cinematics;

[FlatBufferEnum(typeof(byte))]
public enum BoundTextSource : byte
{
	Team1Name,
	Team2Name,
	ScoreLine,
	Team1Score,
	Team2Score,
	GameClock,
	Team1Kills,
	Team2Kills
}
