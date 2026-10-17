using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlueBottleIPC.LeagueBroadcast.Common;

internal class SnapshotVector4JsonConverter : JsonConverter<Vector4>
{
	public override Vector4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException();
		}
		float x = 0f;
		float y = 0f;
		float z = 0f;
		float w = 0f;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			string text = reader.GetString();
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
			case "w":
				w = reader.GetSingle();
				break;
			default:
				throw new JsonException("Unexpected property: " + text);
			}
		}
		return new Vector4
		{
			X = x,
			Y = y,
			Z = z,
			W = w
		};
	}

	public override void Write(Utf8JsonWriter writer, Vector4 value, JsonSerializerOptions options)
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
		if (float.IsNaN(value.W))
		{
			writer.WriteNumber("w", 0);
		}
		else
		{
			writer.WriteNumber("w", value.W);
		}
		writer.WriteEndObject();
	}
}
