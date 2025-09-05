using Nager.HetznerCloud.Helpers;
using Nager.HetznerCloud.Requests;
using Nager.HetznerCloud.Responses;
using System.Net.Http.Json;

namespace Nager.HetznerCloud
{
    public partial class HetznerCloudClient
    {
        public async Task<ServerQueryResponse?> ServersQueryAsync(
            int page = 1,
            int perPage = 25,
            CancellationToken cancellationToken = default)
        {
            var query = new Dictionary<string, string>
            {
                { "page", $"{page}" },
                { "per_page", $"{perPage}" }
            };

            var requestQuery = QueryStringHelper.BuildUrlWithQueryStringUsingStringConcat("/v1/servers", query);

            using var responseMessage = await this._httpClient.GetAsync(requestQuery, cancellationToken);
            this.CheckRateLimiting(responseMessage);

            if (!responseMessage.IsSuccessStatusCode)
            {
                var errorResponse = await responseMessage.Content.ReadFromJsonAsync<ErrorResponse>();
                return new ServerQueryResponse
                {
                    Error = errorResponse?.Error
                };
            }

            return await responseMessage.Content.ReadFromJsonAsync<ServerQueryResponse>(this._jsonSerializerOptions, cancellationToken);
        }

        public async Task<ServerCreateResponse?> ServerCreateAsync(
            ServerCreateRequest createRequest,
            CancellationToken cancellationToken = default)
        {
            using var responseMessage = await this._httpClient.PostAsJsonAsync("/v1/servers", createRequest, this._jsonSerializerOptions, cancellationToken);
            this.CheckRateLimiting(responseMessage);

            if (!responseMessage.IsSuccessStatusCode)
            {
                var errorResponse = await responseMessage.Content.ReadFromJsonAsync<ErrorResponse>(cancellationToken);
                return new ServerCreateResponse
                {
                    Error = errorResponse?.Error
                };
            }

            return await responseMessage.Content.ReadFromJsonAsync<ServerCreateResponse>(cancellationToken);
        }

        public async Task<bool> ServerDeleteAsync(
            long serverId,
            CancellationToken cancellationToken = default)
        {
            using var responseMessage = await this._httpClient.DeleteAsync($"/v1/servers/{serverId}", cancellationToken);
            this.CheckRateLimiting(responseMessage);

            if (!responseMessage.IsSuccessStatusCode)
            {
                return false;
            }

            return true;
        }
    }
}
