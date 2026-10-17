using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[FlatBufferEnum(typeof(byte))]
public enum AnimationTransitionCondition : byte
{
	Trigger,
	AnimationComplete,
	ElapsedTime
}
