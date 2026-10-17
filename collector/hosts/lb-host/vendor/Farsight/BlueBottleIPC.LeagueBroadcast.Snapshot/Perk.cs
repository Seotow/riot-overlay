using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferStruct]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.Perk")]
public class Perk
{
	[FlatBufferItem(0)]
	public virtual uint Id { get; set; }

	[FlatBufferItem(1)]
	public virtual double Value { get; set; }

	[FlatBufferItem(2)]
	public virtual double StatModValue { get; set; }

	static Perk()
	{
	}

	public Perk()
	{
	}

	protected Perk(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Perk(Perk source)
	{
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
		Value = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Value);
		StatModValue = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.StatModValue);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
