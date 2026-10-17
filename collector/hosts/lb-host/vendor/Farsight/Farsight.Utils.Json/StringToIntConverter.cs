using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Farsight.Utils.Json;

public class StringToIntConverter : JsonConverter<int?>
{
	public override int? Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
	{
		if (reader.TokenType == JsonTokenType.String)
		{
			string text = reader.GetString();
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			if (text.Equals("null", StringComparison.OrdinalIgnoreCase))
			{
				return null;
			}
			if (int.TryParse(text, out var result))
			{
				return result;
			}
			return null;
		}
		return reader.GetInt32();
	}

	public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
	{
		if (value.HasValue)
		{
			writer.WriteNumberValue(value.Value);
		}
		else
		{
			writer.WriteNullValue();
		}
	}
}
