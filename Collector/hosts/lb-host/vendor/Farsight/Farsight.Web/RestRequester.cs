using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace Farsight.Web;

public class RestRequester : IDisposable
{
	private static readonly TimeSpan DefaultTimeout = TimeSpan.FromMilliseconds(5000L);

	private static RestRequester? _instance;

	protected bool _isDisposed;

	private HttpClient HttpClient { get; }

	public static RestRequester Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new RestRequester();
			}
			return _instance;
		}
	}

	private RestRequester()
		: this(DefaultTimeout)
	{
	}

	private RestRequester(TimeSpan requestTimeout, HttpClientHandler? clientHandler = null)
	{
		HttpClient = new HttpClient(clientHandler ?? new HttpClientHandler())
		{
			Timeout = requestTimeout
		};
		HttpClient.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
		HttpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Farsight", "1.0"));
	}

	public static async Task<TResultType?> GetAsync<TResultType>(string? url)
	{
		_ = 1;
		try
		{
			HttpResponseMessage httpResponseMessage = await Instance.HttpClient.GetAsync(url);
			if (!httpResponseMessage.IsSuccessStatusCode)
			{
				throw new HttpRequestException(httpResponseMessage.StatusCode.ToString() ?? "");
			}
			return JsonSerializer.Deserialize<TResultType>(await httpResponseMessage.Content.ReadAsStringAsync());
		}
		catch (TaskCanceledException)
		{
			return default;
		}
	}

	public static async Task<string> GetRaw(string? url)
	{
		_ = 1;
		try
		{
			HttpResponseMessage httpResponseMessage = await Instance.HttpClient.GetAsync(url).ConfigureAwait(continueOnCapturedContext: false);
			if (!httpResponseMessage.IsSuccessStatusCode)
			{
				throw new HttpRequestException(httpResponseMessage.StatusCode.ToString() ?? "");
			}
			return await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (TaskCanceledException)
		{
			return null;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	~RestRequester()
	{
		Dispose(disposing: false);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_isDisposed)
		{
			_isDisposed = true;
			if (disposing)
			{
				HttpClient.Dispose();
			}
		}
	}
}
