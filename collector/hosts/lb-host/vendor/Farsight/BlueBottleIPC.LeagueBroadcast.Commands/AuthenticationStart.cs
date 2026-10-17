using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.AuthenticationStart")]
public class AuthenticationStart
{
	static AuthenticationStart()
	{
	}

	public AuthenticationStart()
	{
	}

	protected AuthenticationStart(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AuthenticationStart(AuthenticationStart source)
	{
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
