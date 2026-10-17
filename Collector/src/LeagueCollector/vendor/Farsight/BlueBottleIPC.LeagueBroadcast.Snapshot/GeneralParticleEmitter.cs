using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[JsonConverter(typeof(GeneralParticleEmitterJsonConverter))]
[FlatBufferTable(BuildSerializer = false)]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.GeneralParticleEmitter")]
public class GeneralParticleEmitter
{
	[FlatBufferItem(0, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required ObjectInfo Info { get; set; }

	[FlatBufferItem(1)]
	public virtual uint AttachmentIndex { get; set; }

	[FlatBufferItem(2)]
	public virtual uint TargetIndex { get; set; }

	[FlatBufferItem(3, Required = true)]
	[FlatBufferMetadata(FlatBufferMetadataKind.FbsAttribute, "required", "0")]
	public virtual required Matrix3x3 WorldRotation { get; set; }

	static GeneralParticleEmitter()
	{
	}

	public GeneralParticleEmitter()
	{
		AttachmentIndex = 0u;
		TargetIndex = 0u;
	}

	protected GeneralParticleEmitter(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public GeneralParticleEmitter(GeneralParticleEmitter source)
	{
		Info = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.Info);
		AttachmentIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.AttachmentIndex);
		TargetIndex = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.TargetIndex);
		WorldRotation = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.WorldRotation);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
