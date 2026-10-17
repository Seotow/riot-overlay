using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using Farsight.IPC2;
using Microsoft.Extensions.Logging;

namespace Farsight.BBObject;

public sealed class AssetConnector
{
	private static readonly HashSet<string> _registeredAssets;

	private static readonly SemaphoreSlim _assetLock;

	private static ILogger? Logger;

	internal static FarsightSocketClient? FarsightSocket => LeagueConnector._farsightSocket;

	static AssetConnector()
	{
		_registeredAssets = new HashSet<string>();
		_assetLock = new SemaphoreSlim(1, 1);
		LeagueConnector.GameWindowClosed += (object? sender, GameWindowClosedEventArgs e) =>
		{
			Logger?.LogDebug("Game window closed - clearing AssetConnector cached state.");
			_registeredAssets.Clear();
		};
	}

	public static void ClearCache()
	{
		Logger?.LogDebug("AssetConnector cache cleared (connection reset).");
		_registeredAssets.Clear();
	}

	public static void MarkAssetsRegistered(IEnumerable<string> assetNames)
	{
		foreach (string assetName in assetNames)
		{
			_registeredAssets.Add(assetName);
		}
		Logger?.LogDebug("Pre-registered {Count} assets in cache (reconnect).", _registeredAssets.Count);
	}

	public static void EnableLogging(ILoggerFactory loggerFactory)
	{
		Logger = loggerFactory.CreateLogger("AssetConnector");
	}

	public static async Task<string?> CreateAsync(AssetType type, string path, string? name = null)
	{
		if (name == null)
		{
			name = Path.GetFileNameWithoutExtension(path);
		}
		if (!LeagueConnector.IsReady)
		{
			Logger?.LogDebug("Cannot create asset '{Name}': lblib is not ready.", name);
			return null;
		}
		if (_registeredAssets.Contains(name))
		{
			Logger?.LogTrace("Asset '{Name}' already registered, skipping create.", name);
			return name;
		}
		await _assetLock.WaitAsync();
		try
		{
			if (_registeredAssets.Contains(name))
			{
				return name;
			}
			if (await SendRequestAsync(new Request
			{
				Data = new RequestKind(new AssetCreate
				{
					Type = type,
					Path = path,
					Name = name
				})
			}, $"create {type} asset '{name}'"))
			{
				_registeredAssets.Add(name);
				Logger?.LogDebug("Asset '{Name}' ({Type}) created successfully from {Path}.", name, type, path);
				return name;
			}
			Logger?.LogWarning("Asset '{Name}' ({Type}) creation failed.", name, type);
			return null;
		}
		finally
		{
			_assetLock.Release();
		}
	}

	public static async Task<HashSet<string>?> CreateBatchAsync(IList<(AssetType Type, string Path, string? Name)> assets)
	{
		if (!LeagueConnector.IsReady || FarsightSocket == null)
		{
			Logger?.LogDebug("Cannot create assets: lblib is not ready.");
			return null;
		}
		List<AssetCreate> toUpload = new List<AssetCreate>();
		List<string> uploadNames = new List<string>();
		HashSet<string> result = new HashSet<string>();
		await _assetLock.WaitAsync();
		try
		{
			foreach (var asset in assets)
			{
				AssetType item = asset.Type;
				string item2 = asset.Path;
				string text = asset.Name ?? Path.GetFileNameWithoutExtension(item2);
				if (_registeredAssets.Contains(text))
				{
					result.Add(text);
					continue;
				}
				toUpload.Add(new AssetCreate
				{
					Type = item,
					Path = item2,
					Name = text
				});
				uploadNames.Add(text);
			}
			if (toUpload.Count == 0)
			{
				return result;
			}
			Request r = new Request
			{
				Data = new RequestKind(new AssetCreateBatch
				{
					Reqs = toUpload
				})
			};
			Response response = await FarsightSocket.SendAndWaitForResponse(r);
			if (response == null)
			{
				Logger?.LogError("Failed to create asset batch - null response.");
				return null;
			}
			if (response.Data.Kind != ResponseKind.ItemKind.BlueBottleIPC_LeagueBroadcast_Commands_AssetCreateBatchResult || response.Data.BlueBottleIPC_LeagueBroadcast_Commands_AssetCreateBatchResult == null)
			{
				Logger?.LogError("Failed to create asset batch - unexpected response type: {Type}.", response.Data.Kind);
				return null;
			}
			AssetCreateBatchResult blueBottleIPC_LeagueBroadcast_Commands_AssetCreateBatchResult = response.Data.BlueBottleIPC_LeagueBroadcast_Commands_AssetCreateBatchResult;
			if (blueBottleIPC_LeagueBroadcast_Commands_AssetCreateBatchResult.Success == null || blueBottleIPC_LeagueBroadcast_Commands_AssetCreateBatchResult.Success.Count != toUpload.Count)
			{
				Logger?.LogError("Asset batch response count mismatch.");
				return null;
			}
			for (int i = 0; i < uploadNames.Count; i++)
			{
				if (blueBottleIPC_LeagueBroadcast_Commands_AssetCreateBatchResult.Success[i])
				{
					_registeredAssets.Add(uploadNames[i]);
					result.Add(uploadNames[i]);
				}
				else
				{
					Logger?.LogWarning("Asset '{Name}' (index {Index}) failed to load.", uploadNames[i], i);
				}
			}
			return result;
		}
		finally
		{
			_assetLock.Release();
		}
	}

	public static async Task<bool> DeleteByNameAsync(string name)
	{
		bool flag = await SendRequestAsync(new Request
		{
			Data = new RequestKind(new AssetDelete
			{
				Ident = new AssetIdentifier(name)
			})
		}, "delete asset '" + name + "'");
		if (flag)
		{
			_registeredAssets.Remove(name);
		}
		return flag;
	}

	public static bool IsRegistered(string name)
	{
		return _registeredAssets.Contains(name);
	}

	public static AssetIdentifier ByName(string name)
	{
		return new AssetIdentifier(name);
	}

	private static async Task<bool> SendRequestAsync(Request request, string description)
	{
		if (!LeagueConnector.IsReady || FarsightSocket == null)
		{
			Logger?.LogDebug("Cannot {Description}: lblib is not ready.", description);
			return false;
		}
		Response response = await FarsightSocket.SendAndWaitForResponse(request);
		if (response == null)
		{
			Logger?.LogWarning("Failed to {Description}: null response.", description);
			return false;
		}
		if (response.Data.Kind == ResponseKind.ItemKind.SimpleResponse)
		{
			SimpleResponse simpleResponse = response.Data.SimpleResponse;
			bool flag = simpleResponse != null && simpleResponse.Kind == SimpleResponseKind.GenericSuccess;
			if (!flag)
			{
				Logger?.LogWarning("Failed to {Description}: server returned {Kind}.", description, response.Data.SimpleResponse?.Kind);
			}
			return flag;
		}
		return true;
	}
}
