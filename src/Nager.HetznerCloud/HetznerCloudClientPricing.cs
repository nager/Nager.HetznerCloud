using Nager.HetznerCloud.Responses;
using System.Net.Http.Json;

namespace Nager.HetznerCloud
{
    public partial class HetznerCloudClient
    {
        public async Task<PricingQueryResponse?> PricesQueryAsync(
            CancellationToken cancellationToken = default)
        {
            var responseMessage = await this._httpClient.GetAsync("/v1/pricing", cancellationToken);
            this.CheckRateLimiting(responseMessage);

            if (!responseMessage.IsSuccessStatusCode)
            {
                var errorResponse = await responseMessage.Content.ReadFromJsonAsync<ErrorResponse>(cancellationToken);
                return new PricingQueryResponse
                {
                    Error = errorResponse?.Error
                };
            }

            return await responseMessage.Content.ReadFromJsonAsync<PricingQueryResponse>(this._jsonSerializerOptions, cancellationToken);
        }
    }
}
