using System;
using System.Threading;
using System.Threading.Tasks;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using Farsight.IPC2;
using Microsoft.Extensions.Logging;

namespace Farsight;

public static class LeagueRenderSettingsConnector
{
	internal static FarsightSocketClient? FarsightSocket => LeagueConnector._farsightSocket;

	internal static ILogger? Logger { get; private set; }

	internal static void EnableLogging(ILoggerFactory loggerFactory)
	{
		Logger = loggerFactory.CreateLogger("LeagueRenderSettingsConnector");
	}

	internal static void DisableLogging()
	{
		Logger = null;
	}

	public static async Task<LeagueRenderSettings?> GetRenderSettings(CancellationTokenSource? cts = null)
	{
		if (FarsightSocket == null || !FarsightSocket.IsConnected)
		{
			return null;
		}
		Request r = new Request
		{
			Data = new RequestKind(new GetRenderSettings())
		};
		Response response = await FarsightSocket.SendAndWaitForResponse(r, cts);
		RenderSettings renderSettings = response?.Data.RenderSettings;
		if (response == null || response.Data.Kind != ResponseKind.ItemKind.RenderSettings || renderSettings == null)
		{
			Logger?.LogWarning("Failed to read native render settings");
			return null;
		}
		return new LeagueRenderSettings(renderSettings.FogOfWar);
	}

	public static async Task<bool> SetRenderSettings(LeagueRenderSettingsUpdate update, CancellationTokenSource? cts = null)
	{
		ArgumentNullException.ThrowIfNull(update, "update");
		if (FarsightSocket == null || !FarsightSocket.IsConnected)
		{
			return false;
		}
		SetRenderSettings value = new SetRenderSettings
		{
			FogOfWar = update.FogOfWar
		};
		Request r = new Request
		{
			Data = new RequestKind(value)
		};
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
			Logger?.LogWarning("Failed to update native render settings");
		}
		return (byte)num != 0;
	}

	public static Task<bool> SetFogOfWar(bool enabled, CancellationTokenSource? cts = null)
	{
		return SetRenderSettings(new LeagueRenderSettingsUpdate(enabled), cts);
	}
}
