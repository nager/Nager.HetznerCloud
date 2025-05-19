namespace Nager.HetznerCloud.Models
{
    public class PublicNet1
    {
        public Ipv4 Ipv4 { get; set; }
        public object Ipv6 { get; set; }
        public object[] FloatingIps { get; set; }
        public object[] Firewalls { get; set; }
    }
}
