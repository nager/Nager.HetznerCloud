namespace Nager.HetznerCloud.Models
{
    public class SshKey
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string Fingerprint { get; set; }
        public string PublicKey { get; set; }
        public Dictionary<string, string>? Labels { get; set; }
    }
}
