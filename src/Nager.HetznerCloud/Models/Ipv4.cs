namespace Nager.HetznerCloud.Models
{
    public class Ipv4
    {
        public long Id { get; set; }
        public string Ip { get; set; }
        public bool Blocked { get; set; }
        public string DnsPtr { get; set; }
    }
}
