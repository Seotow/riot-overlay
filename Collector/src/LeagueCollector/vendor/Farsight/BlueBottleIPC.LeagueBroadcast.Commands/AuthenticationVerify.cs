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
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Commands.AuthenticationVerify")]
public class AuthenticationVerify
{
	[FlatBufferItem(0)]
	public virtual IList<ulong>? FeatureBits { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required EdDSASig Sig { get; set; }

	static AuthenticationVerify()
	{
	}

	public AuthenticationVerify()
	{
		FeatureBits = null;
	}

	protected AuthenticationVerify(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AuthenticationVerify(AuthenticationVerify source)
	{
		FeatureBits = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.FeatureBits);
		Sig = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Sig);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
