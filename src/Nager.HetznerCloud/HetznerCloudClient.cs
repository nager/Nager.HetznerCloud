using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Nager.HetznerCloud
{
    /// <summary>
    /// Hetzner Cloud Client
    /// </summary>
    /// <remarks>Documentation https://docs.hetzner.cloud</remarks>
    public sealed partial class HetznerCloudClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        private readonly ILogger<HetznerCloudClient> _logger;

        public HetznerCloudClient(
            HttpClient httpClient,
            string apiToken,
            ILogger<HetznerCloudClient>? logger = default)
        {
            this._httpClient = httpClient;
            this._httpClient.BaseAddress = new Uri("https://api.hetzner.cloud");
            this._logger = logger ?? new NullLogger<HetznerCloudClient>();

            this._jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower)
                }
            };

            this._httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
        }

        private void CheckRateLimiting(HttpResponseMessage httpResponseMessage)
        {
            httpResponseMessage.Headers.TryGetValues("ratelimit-limit", out var limitHeaders);
            httpResponseMessage.Headers.TryGetValues("ratelimit-remaining", out var remainingHeaders);
            httpResponseMessage.Headers.TryGetValues("ratelimit-reset", out var resetHeaders);

            var limitHeader = limitHeaders?.FirstOrDefault();
            var remainingHeader = remainingHeaders?.FirstOrDefault();
            var resetHeader = resetHeaders?.FirstOrDefault();

            _ = int.TryParse(limitHeader, out var ratelimitLimit);
            _ = int.TryParse(remainingHeader, out var ratelimitRemaining);
            _ = long.TryParse(resetHeader, out var ratelimitReset);

            this._logger.LogDebug($"{nameof(CheckRateLimiting)} - {ratelimitRemaining}/{ratelimitLimit}");
        }
    }
}
