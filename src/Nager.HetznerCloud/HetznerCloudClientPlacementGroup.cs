using Nager.HetznerCloud.Helpers;
using Nager.HetznerCloud.Responses;
using System.Net.Http.Json;

namespace Nager.HetznerCloud
{
    public partial class HetznerCloudClient
    {
        public async Task<PlacementGroupQueryResponse?> PlacementGroupsQueryAsync(
            int page = 1,
            int perPage = 25,
            CancellationToken cancellationToken = default)
        {
            var query = new Dictionary<string, string>
            {
                { "page", $"{page}" },
                { "per_page", $"{perPage}" }
            };

            var requestQuery = QueryStringHelper.BuildUrlWithQueryStringUsingStringConcat("/v1/placement_groups", query);

            using var responseMessage = await this._httpClient.GetAsync(requestQuery, cancellationToken);
            this.CheckRateLimiting(responseMessage);

            if (!responseMessage.IsSuccessStatusCode)
            {
                var errorResponse = await responseMessage.Content.ReadFromJsonAsync<ErrorResponse>(cancellationToken);
                return new PlacementGroupQueryResponse
                {
                    Error = errorResponse?.Error
                };
            }

            return await responseMessage.Content.ReadFromJsonAsync<PlacementGroupQueryResponse>(this._jsonSerializerOptions, cancellationToken);
        }
    }
}
