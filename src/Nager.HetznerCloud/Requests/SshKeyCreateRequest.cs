namespace Nager.HetznerCloud.Requests
{
    public class SshKeyCreateRequest
    {
        public required string Name { get; set; }
        public required string PublicKey { get; set; }

        public Dictionary<string, string>? Labels { get; set; }
    }
}
