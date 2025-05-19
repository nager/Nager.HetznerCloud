using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Responses
{
    public class FirewallQueryResponse : BaseQueryResponse
    {
        public Firewall[] Firewalls { get; set; }
    }
}
