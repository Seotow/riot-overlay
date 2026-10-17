using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.SimpleResponse")]
public class SimpleResponse
{
	[FlatBufferItem(0)]
	public virtual SimpleResponseKind Kind { get; set; }

	static SimpleResponse()
	{
	}

	public SimpleResponse()
	{
		Kind = SimpleResponseKind.RegisterSuccess;
	}

	protected SimpleResponse(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public SimpleResponse(SimpleResponse source)
	{
		Kind = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Kind);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
