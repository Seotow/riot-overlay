using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[FlatBufferEnum(typeof(byte))]
public enum ScriptLogLevel : byte
{
	Debug,
	Info,
	Warning,
	Error
}
