using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Farsight.Utils.Json;

public class NullableUInt64JsonConverter : JsonConverter<ulong?>
{
	public override ulong? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType == JsonTokenType.Null)
		{
			return null;
		}
		if (reader.TokenType != JsonTokenType.String)
		{
			throw new JsonException();
		}
		if (ulong.TryParse(reader.GetString(), out var result))
		{
			return result;
		}
		throw new JsonException();
	}

	public override void Write(Utf8JsonWriter writer, ulong? value, JsonSerializerOptions options)
	{
		if (value.HasValue)
		{
			writer.WriteStringValue($"0x{value.Value:X}");
		}
		else
		{
			writer.WriteNullValue();
		}
	}
}
