using System;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Threading;

namespace Farsight.Web;

internal class WebClient
{
	private static readonly HttpClient _client;

	static WebClient()
	{
		_client = new HttpClient(new HttpClientHandler
		{
			ClientCertificateOptions = ClientCertificateOption.Manual,
			ServerCertificateCustomValidationCallback = (HttpRequestMessage response, X509Certificate2? cert, X509Chain? chain, SslPolicyErrors errors) => true
		});
		_client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
		_client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
		_client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:132.0) Gecko/20100101 Firefox/132.0");
	}

	public static async Task<string> GetStringAsync(string url)
	{
		return await _client.GetStringAsync(url);
	}

	public static Task<string> GetStringAsync(string url, CancellationToken token) => _client.GetStringAsync(url, token);

	public static async Task<T?> GetAsync<T>(string url)
	{
		return JsonSerializer.Deserialize<T>(await (await _client.GetAsync(url)).Content.ReadAsStringAsync());
	}

	public static async Task<JsonNode?> GetJsonAsync(string url)
	{
		string json = await (await _client.GetAsync(url)).Content.ReadAsStringAsync();
		try
		{
			return JsonSerializer.Deserialize<JsonNode>(json);
		}
		catch (Exception)
		{
			return null;
		}
	}
}
