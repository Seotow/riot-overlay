using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlueBottleIPC.LeagueBroadcast.Common;

internal class SnapshotMatrix3x3JsonConverter : JsonConverter<Matrix3x3>
{
	public override Matrix3x3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartArray)
		{
			throw new JsonException();
		}
		Matrix3x3 result = default;
		int num = 0;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
		{
			if (reader.TokenType != JsonTokenType.Number)
			{
				throw new JsonException();
			}
			if (num >= 9)
			{
				throw new JsonException("Matrix3x3 must have 9 elements.");
			}
			result[num++] = reader.GetSingle();
		}
		return result;
	}

	public override void Write(Utf8JsonWriter writer, Matrix3x3 value, JsonSerializerOptions options)
	{
		writer.WriteStartArray();
		for (int i = 0; i < 9; i++)
		{
			if (float.IsNaN(value[i]))
			{
				writer.WriteNumberValue(0);
			}
			else
			{
				writer.WriteNumberValue(value[i]);
			}
		}
		writer.WriteEndArray();
	}
}
