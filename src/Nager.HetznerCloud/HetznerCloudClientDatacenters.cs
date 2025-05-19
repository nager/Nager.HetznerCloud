using Nager.HetznerCloud.Helpers;
using Nager.HetznerCloud.Responses;
using System.Net.Http.Json;

namespace Nager.HetznerCloud
{
    public partial class HetznerCloudClient
    {
        public async Task<DatacenterQueryResponse?> DatacentersQueryAsync(
            int page = 1,
            int perPage = 25,
            CancellationToken cancellationToken = default)
        {
            var query = new Dictionary<string, string>
            {
                { "page", $"{page}" },
                { "per_page", $"{perPage}" }
            };

            var requestQuery = QueryStringHelper.BuildUrlWithQueryStringUsingStringConcat("/v1/datacenters", query);

            var responseMessage = await this._httpClient.GetAsync(requestQuery, cancellationToken);
            this.CheckRateLimiting(responseMessage);

            if (!responseMessage.IsSuccessStatusCode)
            {
                return null;
            }

            return await responseMessage.Content.ReadFromJsonAsync<DatacenterQueryResponse>(this._jsonSerializerOptions, cancellationToken);
        }
    }
}
