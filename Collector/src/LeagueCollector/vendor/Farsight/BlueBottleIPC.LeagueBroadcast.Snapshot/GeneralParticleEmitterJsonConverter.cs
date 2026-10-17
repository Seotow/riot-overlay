using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

internal class GeneralParticleEmitterJsonConverter : JsonConverter<GeneralParticleEmitter>
{
	public override GeneralParticleEmitter? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		throw new NotImplementedException();
	}

	public override void Write(Utf8JsonWriter writer, GeneralParticleEmitter value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("index");
		writer.WriteNumberValue(value.Info.Index);
		writer.WritePropertyName("networkId");
		writer.WriteNumberValue(value.Info.NetworkId);
		writer.WritePropertyName("name");
		writer.WriteStringValue(value.Info.Name);
		writer.WritePropertyName("position");
		JsonSerializer.Serialize(writer, value.Info.Position, options);
		writer.WritePropertyName("rotation");
		JsonSerializer.Serialize(writer, value.WorldRotation, options);
		if (value.AttachmentIndex != 0)
		{
			writer.WritePropertyName("attachmentIndex");
			writer.WriteNumberValue(value.AttachmentIndex);
		}
		if (value.TargetIndex != 0)
		{
			writer.WritePropertyName("targetIndex");
			writer.WriteNumberValue(value.TargetIndex);
		}
		writer.WriteEndObject();
	}
}
