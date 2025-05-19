using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Requests
{
    public class ServerCreateRequest
    {
        public bool Automount { get; set; }
        public string Datacenter { get; set; }
        public FirewallServerMapping[] Firewalls { get; set; }
        public string Image { get; set; }
        public Labels Labels { get; set; }
        public string Location { get; set; }
        public required string Name { get; set; }
        public long[] Networks { get; set; }
        public long? PlacementGroup { get; set; }
        public PublicNet PublicNet { get; set; }
        public required string ServerType { get; set; }
        public string[] SshKeys { get; set; }
        public bool StartAfterCreate { get; set; }
        public string UserData { get; set; }
        public long[] Volumes { get; set; }
    }
}
