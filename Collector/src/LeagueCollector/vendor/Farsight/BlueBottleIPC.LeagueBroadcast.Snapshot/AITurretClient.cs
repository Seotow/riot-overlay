using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient")]
public class AITurretClient
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required ObjectInfo Info { get; set; }

	[FlatBufferItem(1, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required AIClient Common { get; set; }

	[FlatBufferItem(2)]
	public virtual sbyte PlateCount { get; set; }

	[FlatBufferItem(3)]
	public virtual sbyte MaxPlateCount { get; set; }

	static AITurretClient()
	{
	}

	public AITurretClient()
	{
		PlateCount = 0;
		MaxPlateCount = 0;
	}

	protected AITurretClient(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public AITurretClient(AITurretClient source)
	{
		Info = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Info);
		Common = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Common);
		PlateCount = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.PlateCount);
		MaxPlateCount = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.MaxPlateCount);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
