using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferStruct]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.DamageDealtEvent")]
public class DamageDealtEvent
{
	[FlatBufferItem(0)]
	public virtual float GameTime { get; set; }

	[FlatBufferItem(1)]
	public virtual uint SourceNetworkId { get; set; }

	[FlatBufferItem(2)]
	public virtual uint TargetNetworkId { get; set; }

	[FlatBufferItem(3)]
	public virtual float DamageDealt { get; set; }

	[FlatBufferItem(4)]
	public virtual DamageType DamageType { get; set; }

	[FlatBufferItem(5)]
	public virtual AttackSuccessFlag AttackSuccessFlag { get; set; }

	[FlatBufferItem(6)]
	public virtual sbyte Param4 { get; set; }

	[FlatBufferItem(7)]
	public virtual uint SpellIdentifierELFHash { get; set; }

	[FlatBufferItem(8)]
	public virtual float TargetHealthBefore { get; set; }

	static DamageDealtEvent()
	{
	}

	public DamageDealtEvent()
	{
	}

	protected DamageDealtEvent(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public DamageDealtEvent(DamageDealtEvent source)
	{
		GameTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.GameTime);
		SourceNetworkId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SourceNetworkId);
		TargetNetworkId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TargetNetworkId);
		DamageDealt = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.DamageDealt);
		DamageType = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.DamageType);
		AttackSuccessFlag = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AttackSuccessFlag);
		Param4 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Param4);
		SpellIdentifierELFHash = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.SpellIdentifierELFHash);
		TargetHealthBefore = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TargetHealthBefore);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
