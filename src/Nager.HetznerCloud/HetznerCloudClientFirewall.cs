using Nager.HetznerCloud.Helpers;
using Nager.HetznerCloud.Requests;
using Nager.HetznerCloud.Responses;
using System.Net.Http.Json;

namespace Nager.HetznerCloud
{
    public partial class HetznerCloudClient
    {
        public async Task<FirewallQueryResponse?> FirewallsQueryAsync(
            int page = 1,
            int perPage = 25,
            CancellationToken cancellationToken = default)
        {
            var query = new Dictionary<string, string>
            {
                { "page", $"{page}" },
                { "per_page", $"{perPage}" }
            };

            var requestQuery = QueryStringHelper.BuildUrlWithQueryStringUsingStringConcat("/v1/firewalls", query);

            using var responseMessage = await this._httpClient.GetAsync(requestQuery, cancellationToken);
            this.CheckRateLimiting(responseMessage);

            if (!responseMessage.IsSuccessStatusCode)
            {
                var errorResponse = await responseMessage.Content.ReadFromJsonAsync<ErrorResponse>(cancellationToken);
                return new FirewallQueryResponse
                {
                    Error = errorResponse?.Error
                };
            }

            return await responseMessage.Content.ReadFromJsonAsync<FirewallQueryResponse>(this._jsonSerializerOptions, cancellationToken);
        }

        public async Task<FirewallCreateResponse?> FirewallCreateAsync(
            FirewallCreateRequest createRequest,
            CancellationToken cancellationToken = default)
        {
            using var responseMessage = await this._httpClient.PostAsJsonAsync("/v1/firewalls", createRequest, this._jsonSerializerOptions, cancellationToken);
            this.CheckRateLimiting(responseMessage);

            if (!responseMessage.IsSuccessStatusCode)
            {
                var errorResponse = await responseMessage.Content.ReadFromJsonAsync<ErrorResponse>(cancellationToken);
                return new FirewallCreateResponse
                {
                    Error = errorResponse?.Error
                };
            }

            return await responseMessage.Content.ReadFromJsonAsync<FirewallCreateResponse>(this._jsonSerializerOptions, cancellationToken);
        }

        public async Task<bool> FirewallDeleteAsync(
            long firewallId,
            CancellationToken cancellationToken = default)
        {
            using var responseMessage = await this._httpClient.DeleteAsync($"/v1/firewalls/{firewallId}", cancellationToken);
            this.CheckRateLimiting(responseMessage);

            if (!responseMessage.IsSuccessStatusCode)
            {
                return false;
            }

            return true;
        }
    }
}
