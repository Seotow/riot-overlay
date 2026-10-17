using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Farsight.Utils;
using Microsoft.Extensions.Logging;

namespace Farsight.Replay;

public static class ReplayConnector
{
	private sealed class PlaybackDto
	{
		public bool Paused { get; set; }

		public bool Seeking { get; set; }

		public float Time { get; set; }

		public float Speed { get; set; }

		public float Length { get; set; }
	}

	public record EnableReplayApiResult(bool IsEnabled, bool WasChanged);

	private const short ReplayPort = 2999;

	private const string PlaybackUrl = "https://127.0.0.1:2999/replay/playback";

	private static readonly HttpClient _http = CreateClient();

	private static readonly JsonSerializerOptions _json = new JsonSerializerOptions
	{
		PropertyNameCaseInsensitive = true
	};

	internal static ILogger? Logger { get; private set; }

	internal static void EnableLogging(ILoggerFactory factory)
	{
		Logger = factory.CreateLogger("ReplayConnector");
	}

	internal static void DisableLogging()
	{
		Logger = null;
	}

	private static HttpClient CreateClient()
	{
		return new HttpClient(new HttpClientHandler
		{
			ClientCertificateOptions = ClientCertificateOption.Manual,
			ServerCertificateCustomValidationCallback = (HttpRequestMessage _, X509Certificate2? _, X509Chain? _, SslPolicyErrors _) => true
		})
		{
			Timeout = TimeSpan.FromSeconds(2L)
		};
	}

	public static bool IsReplayApiAvailable()
	{
		return TcpInfo.IsPortInUse(2999);
	}

	public static async Task<PlaybackState?> GetPlaybackAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		if (!IsReplayApiAvailable())
		{
			Logger?.LogDebug("Replay API not available (port {Port} closed)", (short)2999);
			return null;
		}
		try
		{
			using HttpResponseMessage response = await _http.GetAsync("https://127.0.0.1:2999/replay/playback", cancellationToken);
			if (!response.IsSuccessStatusCode)
			{
				Logger?.LogWarning("Replay playback GET failed: {Status}", response.StatusCode);
				return null;
			}
			PlaybackDto playbackDto = JsonSerializer.Deserialize<PlaybackDto>(await response.Content.ReadAsStringAsync(cancellationToken), _json);
			return (playbackDto == null) ? null : new PlaybackState(playbackDto.Paused, playbackDto.Seeking, playbackDto.Time, playbackDto.Speed, playbackDto.Length);
		}
		catch (Exception exception)
		{
			Logger?.LogWarning(exception, "Replay playback GET error");
			return null;
		}
	}

	public static Task<bool> SetPausedAsync(bool paused, CancellationToken cancellationToken = default(CancellationToken))
	{
		return PostPropertyAsync("paused", paused, cancellationToken);
	}

	public static Task<bool> SetTimeAsync(float seconds, CancellationToken cancellationToken = default(CancellationToken))
	{
		return PostPropertyAsync("time", seconds, cancellationToken);
	}

	public static Task<bool> SetSpeedAsync(float speed, CancellationToken cancellationToken = default(CancellationToken))
	{
		return PostPropertyAsync("speed", speed, cancellationToken);
	}

	private static async Task<bool> PostPropertyAsync(string property, object value, CancellationToken cancellationToken)
	{
		if (!IsReplayApiAvailable())
		{
			Logger?.LogWarning("Cannot set replay {Property}: Replay API not available", property);
			return false;
		}
		try
		{
			string content = JsonSerializer.Serialize(new Dictionary<string, object> { [property] = value });
			using StringContent content2 = new StringContent(content, Encoding.UTF8, "application/json");
			using HttpResponseMessage httpResponseMessage = await _http.PostAsync("https://127.0.0.1:2999/replay/playback", content2, cancellationToken);
			if (!httpResponseMessage.IsSuccessStatusCode)
			{
				Logger?.LogWarning("Replay playback POST {Property} failed: {Status}", property, httpResponseMessage.StatusCode);
				return false;
			}
			Logger?.LogInformation("Replay {Property} set to {Value}", property, value);
			return true;
		}
		catch (Exception exception)
		{
			Logger?.LogWarning(exception, "Replay playback POST {Property} error", property);
			return false;
		}
	}

	public static async Task<EnableReplayApiResult> EnableReplayApi(string clientGameConfigDirectory, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (!Directory.Exists(clientGameConfigDirectory))
		{
			Logger?.LogError("Game config directory does not exist: {Dir}", clientGameConfigDirectory);
			return new EnableReplayApiResult(IsEnabled: false, WasChanged: false);
		}
		string gameCfg = Path.Combine(clientGameConfigDirectory, "game.cfg");
		if (!File.Exists(gameCfg))
		{
			Logger?.LogError("game.cfg not found in {Dir}", clientGameConfigDirectory);
			return new EnableReplayApiResult(IsEnabled: false, WasChanged: false);
		}
		List<string> list = (await File.ReadAllTextAsync(gameCfg, cancellationToken)).Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList();
		int num = list.FindIndex((string l) => l.Trim() == "[General]");
		if (num == -1)
		{
			Logger?.LogWarning("Could not find [General] section in game.cfg; Replay API may not be enabled");
			return new EnableReplayApiResult(IsEnabled: false, WasChanged: false);
		}
		int num2 = list.FindIndex((string l) => l.StartsWith("EnableReplayApi", StringComparison.OrdinalIgnoreCase));
		bool flag = false;
		if (num2 == -1)
		{
			list.Insert(num + 1, "EnableReplayApi=1");
			flag = true;
		}
		else if (list[num2].Contains('0'))
		{
			list[num2] = "EnableReplayApi=1";
			flag = true;
		}
		if (flag)
		{
			await File.WriteAllLinesAsync(gameCfg, list, cancellationToken);
			Logger?.LogWarning("Enabled Replay API in game.cfg. Restart the game for it to take effect.");
			return new EnableReplayApiResult(IsEnabled: false, WasChanged: true);
		}
		Logger?.LogInformation("Replay API already enabled in game.cfg");
		return new EnableReplayApiResult(IsEnabled: true, WasChanged: false);
	}
}
