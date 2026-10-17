using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.AuthenticationChallenge")]
public class AuthenticationChallenge
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required Challenge Challenge { get; set; }

	static AuthenticationChallenge()
	{
	}

	public AuthenticationChallenge()
	{
	}

	protected AuthenticationChallenge(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AuthenticationChallenge(AuthenticationChallenge source)
	{
		Challenge = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Challenge);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
