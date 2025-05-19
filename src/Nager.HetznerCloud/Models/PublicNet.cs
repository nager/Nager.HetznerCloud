namespace Nager.HetznerCloud.Models
{
    public class PublicNet
    {
        public bool EnableIpv4 { get; set; }
        public bool EnableIpv6 { get; set; }
        public string Ipv4 { get; set; }
        public string Ipv6 { get; set; }
    }
}
