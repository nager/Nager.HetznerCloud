using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Requests
{
    public class FirewallCreateRequest
    {
        public FirewallApplyTo[] ApplyTo { get; set; }
        public Labels Labels { get; set; }
        public required string Name { get; set; }
        public FirewallRule[] Rules { get; set; }
    }
}