using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlueBottleIPC.LeagueBroadcast.Common;

internal class SnapshotVector3JsonConverter : JsonConverter<Vector3>
{
	public override Vector3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException();
		}
		float x = 0f;
		float y = 0f;
		float z = 0f;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			string text = reader.GetString()?.ToLowerInvariant();
			reader.Read();
			switch (text)
			{
			case "x":
				x = reader.GetSingle();
				break;
			case "y":
				y = reader.GetSingle();
				break;
			case "z":
				z = reader.GetSingle();
				break;
			default:
				throw new JsonException("Unexpected property: " + text);
			}
		}
		return new Vector3
		{
			X = x,
			Y = y,
			Z = z
		};
	}

	public override void Write(Utf8JsonWriter writer, Vector3 value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (float.IsNaN(value.X))
		{
			writer.WriteNumber("x", 0);
		}
		else
		{
			writer.WriteNumber("x", value.X);
		}
		if (float.IsNaN(value.Y))
		{
			writer.WriteNumber("y", 0);
		}
		else
		{
			writer.WriteNumber("y", value.Y);
		}
		if (float.IsNaN(value.Z))
		{
			writer.WriteNumber("z", 0);
		}
		else
		{
			writer.WriteNumber("z", value.Z);
		}
		writer.WriteEndObject();
	}
}
