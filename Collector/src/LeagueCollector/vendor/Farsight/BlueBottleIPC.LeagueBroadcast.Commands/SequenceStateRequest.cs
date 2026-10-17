using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.SequenceStateRequest")]
public class SequenceStateRequest
{
	static SequenceStateRequest()
	{
	}

	public SequenceStateRequest()
	{
	}

	protected SequenceStateRequest(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SequenceStateRequest(SequenceStateRequest source)
	{
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
