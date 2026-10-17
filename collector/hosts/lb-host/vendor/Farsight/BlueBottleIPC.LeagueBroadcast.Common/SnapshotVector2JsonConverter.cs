using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlueBottleIPC.LeagueBroadcast.Common;

internal class SnapshotVector2JsonConverter : JsonConverter<Vector2>
{
	public override Vector2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException();
		}
		float x = 0f;
		float y = 0f;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			string text = reader.GetString();
			reader.Read();
			if (!(text == "x"))
			{
				if (!(text == "y"))
				{
					throw new JsonException("Unexpected property: " + text);
				}
				y = reader.GetSingle();
			}
			else
			{
				x = reader.GetSingle();
			}
		}
		return new Vector2
		{
			X = x,
			Y = y
		};
	}

	public override void Write(Utf8JsonWriter writer, Vector2 value, JsonSerializerOptions options)
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
		writer.WriteEndObject();
	}
}
