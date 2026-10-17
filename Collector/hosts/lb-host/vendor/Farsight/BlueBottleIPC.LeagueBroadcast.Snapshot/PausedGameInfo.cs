using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.PausedGameInfo")]
public class PausedGameInfo
{
	[FlatBufferItem(0)]
	public virtual ulong UtcTime { get; set; }

	[FlatBufferItem(1)]
	public virtual Camera? Camera { get; set; }

	static PausedGameInfo()
	{
	}

	public PausedGameInfo()
	{
		UtcTime = 0uL;
		Camera = null;
	}

	protected PausedGameInfo(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public PausedGameInfo(PausedGameInfo source)
	{
		UtcTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.UtcTime);
		Camera = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Camera);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
