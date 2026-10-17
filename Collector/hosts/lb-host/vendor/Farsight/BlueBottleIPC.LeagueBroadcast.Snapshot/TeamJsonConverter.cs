using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

public class TeamJsonConverter : JsonConverter<Team>
{
	public override Team Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		Team result = Team.None;
		if (reader.TokenType == JsonTokenType.Number)
		{
			result = (Team)reader.GetByte();
		}
		else if (reader.TokenType == JsonTokenType.String)
		{
			Team team;
			switch ((reader.GetString() ?? "None").ToLower())
			{
			case "order":
			case "blue":
			case "left":
				team = Team.Order;
				break;
			case "chaos":
			case "right":
			case "red":
				team = Team.Chaos;
				break;
			case "neutral":
				team = Team.Neutral;
				break;
			default:
				team = Team.None;
				break;
			}
			result = team;
		}
		return result;
	}

	public override void Write(Utf8JsonWriter writer, Team value, JsonSerializerOptions options)
	{
		writer.WriteNumberValue((int)value);
	}

	public override void WriteAsPropertyName(Utf8JsonWriter writer, Team value, JsonSerializerOptions options)
	{
		byte b = (byte)value;
		writer.WritePropertyName(b.ToString());
	}

	public override Team ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string text = reader.GetString();
		if (byte.TryParse(text, out var result))
		{
			return (Team)result;
		}
		switch (text?.ToLower())
		{
		case "order":
		case "blue":
		case "left":
			return Team.Order;
		case "chaos":
		case "right":
		case "red":
			return Team.Chaos;
		case "neutral":
			return Team.Neutral;
		default:
			return Team.None;
		}
	}
}
