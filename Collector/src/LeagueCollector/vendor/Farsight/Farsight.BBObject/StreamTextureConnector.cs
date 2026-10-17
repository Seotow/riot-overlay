using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using Farsight.IPC2;
using Microsoft.Extensions.Logging;

namespace Farsight.BBObject;

public sealed class StreamTextureConnector
{
	public sealed class IceServerConfig
	{
		public required List<string> Urls { get; init; }

		public string? Username { get; init; }

		public string? Credential { get; init; }
	}

	public sealed class SDPOfferResult
	{
		public bool Success { get; init; }

		public string? SDPAnswer { get; init; }

		public string? Error { get; init; }
	}

	public sealed class StreamStatusResult
	{
		public required string State { get; init; }

		public required string Codec { get; init; }

		public uint Width { get; init; }

		public uint Height { get; init; }

		public ulong LastFrameUnixMs { get; init; }

		public string? Error { get; init; }
	}

	private static ILogger? Logger;

	internal static FarsightSocketClient? FarsightSocket => LeagueConnector._farsightSocket;

	public static void EnableLogging(ILoggerFactory loggerFactory)
	{
		Logger = loggerFactory.CreateLogger("StreamTextureConnector");
	}

	public static async Task<SDPOfferResult?> SendSDPOfferAsync(string assetName, string sdpOffer, IReadOnlyList<IceServerConfig>? iceServers = null, CancellationTokenSource? cts = null)
	{
		if (FarsightSocket == null || !FarsightSocket.IsConnected)
		{
			Logger?.LogWarning("Cannot send SDP offer: not connected.");
			return null;
		}
		Request r = new Request
		{
			Data = new RequestKind(new StreamTextureSDPOffer
			{
				Ident = new AssetIdentifier(assetName),
				SdpOffer = sdpOffer,
				IceServers = ToFlatBufferIceServers(iceServers)
			})
		};
		Response response = await FarsightSocket.SendAndWaitForResponse(r, cts);
		if (response == null)
		{
			Logger?.LogWarning("SDP offer for '{Name}': null response.", assetName);
			return null;
		}
		if (response.Data.Kind == ResponseKind.ItemKind.BlueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPAnswer)
		{
			StreamTextureSDPAnswer blueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPAnswer = response.Data.BlueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPAnswer;
			if (blueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPAnswer == null)
			{
				Logger?.LogWarning("SDP offer for '{Name}': answer payload was null.", assetName);
				return new SDPOfferResult
				{
					Success = false,
					Error = "null answer payload"
				};
			}
			if (!string.IsNullOrEmpty(blueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPAnswer.Error))
			{
				Logger?.LogWarning("SDP offer for '{Name}' failed: {Error}.", assetName, blueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPAnswer.Error);
				return new SDPOfferResult
				{
					Success = false,
					Error = blueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPAnswer.Error
				};
			}
			Logger?.LogDebug("SDP offer for '{Name}' succeeded.", assetName);
			return new SDPOfferResult
			{
				Success = true,
				SDPAnswer = blueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPAnswer.SdpAnswer
			};
		}
		if (response.Data.Kind == ResponseKind.ItemKind.SimpleResponse)
		{
			Logger?.LogWarning("SDP offer for '{Name}': server returned {Kind}.", assetName, response.Data.SimpleResponse?.Kind);
			return new SDPOfferResult
			{
				Success = false,
				Error = response.Data.SimpleResponse?.Kind.ToString()
			};
		}
		Logger?.LogWarning("SDP offer for '{Name}': unexpected response kind {Kind}.", assetName, response.Data.Kind);
		return null;
	}

	public static async Task<SDPOfferResult?> CreateSDPOfferAsync(string assetName, IReadOnlyList<IceServerConfig>? iceServers = null, CancellationTokenSource? cts = null)
	{
		if (FarsightSocket == null || !FarsightSocket.IsConnected)
		{
			return null;
		}
		Request r = new Request
		{
			Data = new RequestKind(new StreamTextureCreateSDPOffer
			{
				Ident = new AssetIdentifier(assetName),
				IceServers = ToFlatBufferIceServers(iceServers)
			})
		};
		Response response = await FarsightSocket.SendAndWaitForResponse(r, cts);
		if (response == null || response.Data.Kind != ResponseKind.ItemKind.BlueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPResult)
		{
			return null;
		}
		StreamTextureSDPResult blueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPResult = response.Data.BlueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPResult;
		if (blueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPResult == null || !string.IsNullOrEmpty(blueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPResult.Error))
		{
			return new SDPOfferResult
			{
				Success = false,
				Error = (blueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPResult?.Error ?? "null offer payload")
			};
		}
		return new SDPOfferResult
		{
			Success = true,
			SDPAnswer = blueBottleIPC_LeagueBroadcast_Commands_StreamTextureSDPResult.Sdp
		};
	}

	public static async Task<bool> ApplySDPAnswerAsync(string assetName, string sdpAnswer, CancellationTokenSource? cts = null)
	{
		if (FarsightSocket == null || !FarsightSocket.IsConnected)
		{
			return false;
		}
		Request r = new Request
		{
			Data = new RequestKind(new StreamTextureApplySDPAnswer
			{
				Ident = new AssetIdentifier(assetName),
				SdpAnswer = sdpAnswer
			})
		};
		Response response = await FarsightSocket.SendAndWaitForResponse(r, cts);
		int result;
		if (response != null && response.Data.Kind == ResponseKind.ItemKind.SimpleResponse)
		{
			SimpleResponse simpleResponse = response.Data.SimpleResponse;
			result = ((simpleResponse != null && simpleResponse.Kind == SimpleResponseKind.GenericSuccess) ? 1 : 0);
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	public static async Task<StreamStatusResult?> GetStatusAsync(string assetName, CancellationTokenSource? cts = null)
	{
		if (FarsightSocket == null || !FarsightSocket.IsConnected)
		{
			return null;
		}
		Request r = new Request
		{
			Data = new RequestKind(new StreamTextureStatusRequest
			{
				Ident = new AssetIdentifier(assetName)
			})
		};
		Response response = await FarsightSocket.SendAndWaitForResponse(r, cts);
		if (response == null || response.Data.Kind != ResponseKind.ItemKind.BlueBottleIPC_LeagueBroadcast_Commands_StreamTextureStatus)
		{
			return null;
		}
		StreamTextureStatus blueBottleIPC_LeagueBroadcast_Commands_StreamTextureStatus = response.Data.BlueBottleIPC_LeagueBroadcast_Commands_StreamTextureStatus;
		if (blueBottleIPC_LeagueBroadcast_Commands_StreamTextureStatus == null)
		{
			return null;
		}
		return new StreamStatusResult
		{
			State = blueBottleIPC_LeagueBroadcast_Commands_StreamTextureStatus.State.ToString(),
			Codec = (blueBottleIPC_LeagueBroadcast_Commands_StreamTextureStatus.Codec ?? ""),
			Width = blueBottleIPC_LeagueBroadcast_Commands_StreamTextureStatus.Width,
			Height = blueBottleIPC_LeagueBroadcast_Commands_StreamTextureStatus.Height,
			LastFrameUnixMs = blueBottleIPC_LeagueBroadcast_Commands_StreamTextureStatus.LastFrameUnixMs,
			Error = blueBottleIPC_LeagueBroadcast_Commands_StreamTextureStatus.Error
		};
	}

	public static async Task<bool> CloseSessionAsync(string assetName, CancellationTokenSource? cts = null)
	{
		if (FarsightSocket == null || !FarsightSocket.IsConnected)
		{
			Logger?.LogWarning("Cannot close stream session: not connected.");
			return false;
		}
		Request r = new Request
		{
			Data = new RequestKind(new StreamTextureCloseSession
			{
				Ident = new AssetIdentifier(assetName)
			})
		};
		Response response = await FarsightSocket.SendAndWaitForResponse(r, cts);
		if (response == null)
		{
			Logger?.LogWarning("Close session for '{Name}': null response.", assetName);
			return false;
		}
		if (response.Data.Kind == ResponseKind.ItemKind.SimpleResponse)
		{
			SimpleResponse simpleResponse = response.Data.SimpleResponse;
			bool flag = simpleResponse != null && simpleResponse.Kind == SimpleResponseKind.GenericSuccess;
			if (!flag)
			{
				Logger?.LogWarning("Close session for '{Name}' failed: {Kind}.", assetName, response.Data.SimpleResponse?.Kind);
			}
			else
			{
				Logger?.LogDebug("Closed WHIP session for '{Name}'.", assetName);
			}
			return flag;
		}
		Logger?.LogWarning("Close session for '{Name}': unexpected response kind {Kind}.", assetName, response.Data.Kind);
		return false;
	}

	private static List<IceServer>? ToFlatBufferIceServers(IReadOnlyList<IceServerConfig>? iceServers)
	{
		if (iceServers == null || iceServers.Count <= 0)
		{
			return null;
		}
		return iceServers.Select((IceServerConfig server) => new IceServer
		{
			Urls = server.Urls,
			Username = server.Username,
			Credential = server.Credential
		}).ToList();
	}
}
