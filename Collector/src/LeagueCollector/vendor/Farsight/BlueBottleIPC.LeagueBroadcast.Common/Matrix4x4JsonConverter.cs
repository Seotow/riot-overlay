using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlueBottleIPC.LeagueBroadcast.Common;

internal class Matrix4x4JsonConverter : JsonConverter<Matrix4x4>
{
	public override Matrix4x4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		Matrix4x4 result = default;
		if (reader.TokenType != JsonTokenType.StartArray)
		{
			throw new JsonException();
		}
		int num = 0;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
		{
			if (reader.TokenType != JsonTokenType.Number)
			{
				throw new JsonException();
			}
			if (num >= 16)
			{
				throw new JsonException("Matrix4x4 must have 16 elements.");
			}
			float single = reader.GetSingle();
			result[num++] = single;
		}
		return result;
	}

	public override void Write(Utf8JsonWriter writer, Matrix4x4 value, JsonSerializerOptions options)
	{
		writer.WriteStartArray();
		foreach (float item in value)
		{
			writer.WriteNumberValue(item);
		}
		writer.WriteEndArray();
	}
}
