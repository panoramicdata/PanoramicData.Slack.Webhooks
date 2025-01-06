using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PanoramicData.Slack.Webhooks;

public class SlackClient : ISlackClient, IDisposable
{
	private readonly HttpClient _httpClient;
	private readonly Uri _webhookUri;
	private const string POST_SUCCESS = "ok";
	private readonly int _timeoutMs = 100;

	private static readonly DefaultContractResolver _resolver = new() { NamingStrategy = new SnakeCaseNamingStrategy() };
	private static readonly JsonSerializerSettings _serializerSettings = new()
	{
		ContractResolver = _resolver,
		NullValueHandling = NullValueHandling.Ignore
	};

	/// <summary>
	/// Returns the current Timeout value.
	/// </summary>
	internal int TimeoutMs => _timeoutMs * 1000;

	public SlackClient(string webhookUrl, int timeoutMs = 100, HttpClient? httpClient = null)
	{
		_httpClient = httpClient ?? new HttpClient();
		if (!Uri.TryCreate(webhookUrl, UriKind.Absolute, out _webhookUri))
			throw new ArgumentException("Please enter a valid webhook url");
		_timeoutMs = timeoutMs;
	}

	public virtual bool Post(SlackMessage slackMessage) => PostAsync(slackMessage, false).Result;

	public bool PostToChannels(SlackMessage message, IEnumerable<string> channels) => channels.DefaultIfEmpty(message.Channel)
				.Select(message.Clone)
				.Select(Post).All(r => r);

	public IEnumerable<Task<bool>> PostToChannelsAsync(SlackMessage message, IEnumerable<string> channels) => channels.DefaultIfEmpty(message.Channel)
							.Select(message.Clone)
							.Select(PostAsync);

	public async Task<bool> PostAsync(SlackMessage slackMessage) => await PostAsync(slackMessage, true);

	public async Task<bool> PostAsync(SlackMessage slackMessage, bool configureAwait = true)
	{
		using var request = new HttpRequestMessage(HttpMethod.Post, _webhookUri);

		request.Content = new StringContent(slackMessage.AsJson(), System.Text.Encoding.UTF8, "application/json");
		var response = await _httpClient.SendAsync(request).ConfigureAwait(configureAwait);
		var content = await response.Content.ReadAsStringAsync();

		return content.Equals(POST_SUCCESS, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Deserialize SlackMessage from a JSON string
	/// </summary>
	/// <param name="json">string containing serialized JSON</param>
	/// <returns>SlackMessage</returns>
	public static SlackMessage? DeserializeObject(string json)
		=> JsonConvert.DeserializeObject<SlackMessage>(json, _serializerSettings);

	/// <summary>
	/// Serialize SlackMessage to a JSON string
	/// </summary>
	/// <param name="json">An instance of SlackMessage</param>
	/// <returns>string containing serialized JSON</returns>
	public static string SerializeObject(object obj)
		=> JsonConvert.SerializeObject(obj, _serializerSettings);

	public void Dispose()
	{
		_httpClient.Dispose();
		GC.SuppressFinalize(this);
	}
}
