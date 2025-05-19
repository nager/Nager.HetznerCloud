namespace Nager.HetznerCloud.Models
{
    public class Firewall
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public FirewallRule[] Rules { get; set; }
        public FirewallApplyTo[] AppliedTo { get; set; }
    }
}
