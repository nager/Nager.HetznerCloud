using Nager.HetznerCloud.Helpers;
using Nager.HetznerCloud.Requests;
using Nager.HetznerCloud.Responses;
using System.Net.Http.Json;

namespace Nager.HetznerCloud
{
    public partial class HetznerCloudClient
    {
        public async Task<SshKeyQueryResponse?> SshKeysQueryAsync(
            int page = 1,
            int perPage = 25,
            CancellationToken cancellationToken = default)
        {
            var query = new Dictionary<string, string>
            {
                { "page", $"{page}" },
                { "per_page", $"{perPage}" }
            };

            var requestQuery = QueryStringHelper.BuildUrlWithQueryStringUsingStringConcat("/v1/ssh_keys", query);

            using var responseMessage = await this._httpClient.GetAsync(requestQuery, cancellationToken);
            this.CheckRateLimiting(responseMessage);

            if (!responseMessage.IsSuccessStatusCode)
            {
                var errorResponse = await responseMessage.Content.ReadFromJsonAsync<ErrorResponse>(cancellationToken);
                return new SshKeyQueryResponse
                {
                    Error = errorResponse?.Error
                };
            }

            return await responseMessage.Content.ReadFromJsonAsync<SshKeyQueryResponse>(this._jsonSerializerOptions, cancellationToken);
        }

        public async Task<SshKeyCreateResponse?> SshKeyCreateAsync(
            SshKeyCreateRequest createRequest,
            CancellationToken cancellationToken = default)
        {
            using var responseMessage = await this._httpClient.PostAsJsonAsync("/v1/ssh_keys", createRequest, this._jsonSerializerOptions, cancellationToken);
            this.CheckRateLimiting(responseMessage);

            if (!responseMessage.IsSuccessStatusCode)
            {
                var errorResponse = await responseMessage.Content.ReadFromJsonAsync<ErrorResponse>(cancellationToken);
                return new SshKeyCreateResponse
                {
                    Error = errorResponse?.Error
                };
            }

            return await responseMessage.Content.ReadFromJsonAsync<SshKeyCreateResponse>(this._jsonSerializerOptions, cancellationToken);
        }

        public async Task<bool> SshKeyDeleteAsync(
            long sshKeyId,
            CancellationToken cancellationToken = default)
        {
            using var responseMessage = await this._httpClient.DeleteAsync($"/v1/ssh_keys/{sshKeyId}", cancellationToken);
            this.CheckRateLimiting(responseMessage);

            if (!responseMessage.IsSuccessStatusCode)
            {
                return false;
            }

            return true;
        }
    }
}
