using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.Item")]
public class Item
{
	[FlatBufferItem(0)]
	public virtual IList<string>? ItemAssets { get; set; }

	[FlatBufferItem(1)]
	public virtual ItemStats? Stats { get; set; }

	[FlatBufferItem(2)]
	public virtual int CombineCost { get; set; }

	[FlatBufferItem(3)]
	public virtual uint Id { get; set; }

	[FlatBufferItem(4)]
	public virtual sbyte Count { get; set; }

	[FlatBufferItem(5)]
	public virtual ushort Stacks { get; set; }

	[FlatBufferItem(6)]
	public virtual ushort Charges { get; set; }

	[FlatBufferItem(7)]
	public virtual byte Slot { get; set; }

	[FlatBufferItem(8)]
	public virtual IList<ulong>? ItemAssetHashes { get; set; }

	static Item()
	{
	}

	public Item()
	{
		ItemAssets = null;
		Stats = null;
		CombineCost = 0;
		Id = 0u;
		Count = 0;
		Stacks = 0;
		Charges = 0;
		Slot = 0;
		ItemAssetHashes = null;
	}

	protected Item(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Item(Item source)
	{
		ItemAssets = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ItemAssets);
		Stats = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Stats);
		CombineCost = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.CombineCost);
		Id = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Id);
		Count = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Count);
		Stacks = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Stacks);
		Charges = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Charges);
		Slot = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Slot);
		ItemAssetHashes = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.ItemAssetHashes);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
