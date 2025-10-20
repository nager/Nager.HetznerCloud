namespace Nager.HetznerCloud.UnitTest
{
    [TestClass]
    public sealed class LogicTest
    {
        [TestMethod]
        public async Task ServersQueryAsync()
        {
            var client = new HetznerCloudClient(new HttpClient(), HetznerConfig.ApiKey);

            var runningServer = await client.ServersQueryAsync();
        }

        [TestMethod]
        public async Task ServerTypesQueryAsync()
        {
            var client = new HetznerCloudClient(new HttpClient(), HetznerConfig.ApiKey);

            var serverTypes = await client.ServerTypesQueryAsync();
        }
    }
}
