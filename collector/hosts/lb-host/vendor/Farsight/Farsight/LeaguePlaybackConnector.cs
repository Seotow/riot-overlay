using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using Farsight.IPC2;
using Microsoft.Extensions.Logging;

namespace Farsight;

public static class LeaguePlaybackConnector
{
	internal static FarsightSocketClient? FarsightSocket => LeagueConnector._farsightSocket;

	internal static ILogger? Logger { get; private set; }

	internal static void EnableLogging(ILoggerFactory loggerFactory)
	{
		Logger = loggerFactory.CreateLogger("LeaguePlaybackConnector");
	}

	internal static void DisableLogging()
	{
		Logger = null;
	}

	public static async Task<bool> SetPlaybackSpeed(float playbackSpeed, CancellationTokenSource? cts = null)
	{
		if (FarsightSocket == null || !FarsightSocket.IsConnected)
		{
			return false;
		}
		string item = playbackSpeed.ToString("00.00", CultureInfo.InvariantCulture);
		EphemeralAction value = new EphemeralAction
		{
			RequestId = EphemeralType.SetPlaybackSpeed,
			Params = new List<string>(1) { item }
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
		Logger?.LogDebug("Sending playback speed request");
		Response response = await FarsightSocket.SendAndWaitForResponse(r, cts);
		Logger?.LogDebug("Received playback speed response");
		if (response == null)
		{
			Logger?.LogWarning("Failed to update playback speed");
			return false;
		}
		if (response.Data.Kind != ResponseKind.ItemKind.SimpleResponse || response.Data.SimpleResponse == null || response.Data.SimpleResponse.Kind != SimpleResponseKind.PlaybackSpeedChangeSuccess)
		{
			Logger?.LogWarning("Failed to update playback speed");
			return false;
		}
		Logger?.LogInformation("Playback speed updated to {playbackSpeed}", playbackSpeed);
		return true;
	}

	public static async Task<bool> SetReplayTime(float gameTimeSeconds, CancellationTokenSource? cts = null)
	{
		if (FarsightSocket == null || !FarsightSocket.IsConnected || !float.IsFinite(gameTimeSeconds))
		{
			return false;
		}
		SetReplayTime command = new SetReplayTime
		{
			Time = Math.Max(0f, gameTimeSeconds)
		};
		Request r = new Request
		{
			Data = new RequestKind(command)
		};
		Logger?.LogDebug("Sending native replay seek to {GameTimeSeconds}", command.Time);
		Response response = await FarsightSocket.SendAndWaitForResponse(r, cts);
		int num;
		if (response != null && response.Data.Kind == ResponseKind.ItemKind.SimpleResponse)
		{
			SimpleResponse simpleResponse = response.Data.SimpleResponse;
			num = ((simpleResponse != null && simpleResponse.Kind == SimpleResponseKind.GenericSuccess) ? 1 : 0);
		}
		else
		{
			num = 0;
		}
		if (num == 0)
		{
			Logger?.LogWarning("Native replay seek to {GameTimeSeconds} failed", command.Time);
			return false;
		}
		Logger?.LogInformation("Replay time updated to {GameTimeSeconds}", command.Time);
		return true;
	}
}
