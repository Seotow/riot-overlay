using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Common;

[FlatBufferEnum(typeof(byte))]
public enum ScriptVariableValueType : byte
{
	None,
	Bool,
	Int,
	UInt,
	Number,
	String,
	Vec3,
	Color,
	Array
}
