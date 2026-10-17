using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.GameStateMetaData")]
public class GameStateMetaData
{
	[FlatBufferItem(0)]
	public virtual string? GameVersion { get; set; }

	[FlatBufferItem(1)]
	public virtual byte GameState { get; set; }

	[FlatBufferItem(2)]
	public virtual string? GameId { get; set; }

	static GameStateMetaData()
	{
	}

	public GameStateMetaData()
	{
		GameVersion = null;
		GameState = 0;
		GameId = null;
	}

	protected GameStateMetaData(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public GameStateMetaData(GameStateMetaData source)
	{
		GameVersion = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.GameVersion);
		GameState = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.GameState);
		GameId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.GameId);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
