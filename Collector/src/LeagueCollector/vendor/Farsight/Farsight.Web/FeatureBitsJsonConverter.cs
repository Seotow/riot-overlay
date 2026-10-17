using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Farsight.Web;

public sealed class FeatureBitsJsonConverter : JsonConverter<ulong[]?>
{
	public override ulong[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType == JsonTokenType.Null)
		{
			return null;
		}
		JsonTokenType tokenType = reader.TokenType;
		if (tokenType - 7 <= JsonTokenType.StartObject)
		{
			return new ulong[1] { ReadBlock(ref reader) };
		}
		if (reader.TokenType != JsonTokenType.StartArray)
		{
			throw new JsonException($"Unexpected token {reader.TokenType} for FeatureBits.");
		}
		List<ulong> list = new List<ulong>();
		while (reader.Read())
		{
			if (reader.TokenType == JsonTokenType.EndArray)
			{
				return list.ToArray();
			}
			list.Add(ReadBlock(ref reader));
		}
		throw new JsonException("Unterminated FeatureBits array.");
	}

	private static ulong ReadBlock(ref Utf8JsonReader reader)
	{
		switch (reader.TokenType)
		{
		case JsonTokenType.String:
		{
			string text = reader.GetString();
			if (!ulong.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
			{
				throw new JsonException("Invalid uint64 string in FeatureBits: '" + text + "'");
			}
			return result;
		}
		case JsonTokenType.Number:
		{
			if (!reader.TryGetUInt64(out var value))
			{
				throw new JsonException("FeatureBits number does not fit in uint64.");
			}
			return value;
		}
		default:
			throw new JsonException($"Unexpected token {reader.TokenType} in FeatureBits.");
		}
	}

	public override void Write(Utf8JsonWriter writer, ulong[]? value, JsonSerializerOptions options)
	{
		if (value == null)
		{
			writer.WriteNullValue();
			return;
		}
		writer.WriteStartArray();
		foreach (ulong num in value)
		{
			writer.WriteStringValue(num.ToString(CultureInfo.InvariantCulture));
		}
		writer.WriteEndArray();
	}
}
