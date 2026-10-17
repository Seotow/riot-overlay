using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.Building")]
public class Building
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required ObjectInfo Info { get; set; }

	[FlatBufferItem(1)]
	public virtual float Health { get; set; }

	[FlatBufferItem(2)]
	public virtual float MaxHealth { get; set; }

	[FlatBufferItem(3)]
	public virtual sbyte Status { get; set; }

	static Building()
	{
	}

	public Building()
	{
		Health = 0f;
		MaxHealth = 0f;
		Status = 0;
	}

	protected Building(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public Building(Building source)
	{
		Info = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Info);
		Health = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Health);
		MaxHealth = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MaxHealth);
		Status = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Status);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
