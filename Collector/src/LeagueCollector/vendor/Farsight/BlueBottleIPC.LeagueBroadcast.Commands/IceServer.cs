using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.IceServer")]
public class IceServer
{
	[FlatBufferItem(0)]
	public virtual IList<string>? Urls { get; set; }

	[FlatBufferItem(1)]
	public virtual string? Username { get; set; }

	[FlatBufferItem(2)]
	public virtual string? Credential { get; set; }

	static IceServer()
	{
	}

	public IceServer()
	{
		Urls = null;
		Username = null;
		Credential = null;
	}

	protected IceServer(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public IceServer(IceServer source)
	{
		Urls = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Urls);
		Username = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Username);
		Credential = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Credential);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
