using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Responses
{
    public class FirewallCreateResponse : BaseCreateResponse
    {
        public Firewall Firewall { get; set; }
    }
}
