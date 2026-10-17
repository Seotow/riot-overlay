using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.IdWrapper")]
public class IdWrapper
{
	[FlatBufferItem(0)]
	public virtual ulong Id { get; set; }

	static IdWrapper()
	{
	}

	public IdWrapper()
	{
		Id = 0uL;
	}

	protected IdWrapper(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public IdWrapper(IdWrapper source)
	{
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
