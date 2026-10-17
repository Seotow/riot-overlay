using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlueBottleIPC.LeagueBroadcast.Common;

internal class SnapshotQuaternionJsonConverter : JsonConverter<Quaternion>
{
	public override Quaternion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType == JsonTokenType.StartArray)
		{
			float[] array = new float[4];
			int num = 0;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
			{
				if (reader.TokenType != JsonTokenType.Number)
				{
					throw new JsonException();
				}
				if (num >= 4)
				{
					throw new JsonException("Quaternion array must have 4 elements.");
				}
				array[num++] = reader.GetSingle();
			}
			return new Quaternion
			{
				X = array[0],
				Y = array[1],
				Z = array[2],
				W = array[3]
			};
		}
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException();
		}
		float x = 0f;
		float y = 0f;
		float z = 0f;
		float w = 1f;
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
		return new Quaternion
		{
			X = x,
			Y = y,
			Z = z,
			W = w
		};
	}

	public override void Write(Utf8JsonWriter writer, Quaternion value, JsonSerializerOptions options)
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
			writer.WriteNumber("w", 1);
		}
		else
		{
			writer.WriteNumber("w", value.W);
		}
		writer.WriteEndObject();
	}
}
