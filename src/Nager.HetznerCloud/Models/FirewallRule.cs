namespace Nager.HetznerCloud.Models
{
    public class FirewallRule
    {
        /// <summary>
        /// Description of the Firewall Rule
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Traffic direction (in, out)
        /// </summary>
        public FirewallDirection Direction { get; set; }

        /// <summary>
        /// Port or port range to which traffic will be allowed
        /// </summary>
        public string? Port { get; set; }

        /// <summary>
        /// Protocol
        /// </summary>
        public FirewallProtocol Protocol { get; set; }

        /// <summary>
        /// List of permitted IPv4/IPv6 addresses for incoming traffic
        /// </summary>
        public string[] SourceIps { get; set; }
    }
}
