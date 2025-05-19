namespace Nager.HetznerCloud.Models
{
    public class Server
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public PublicNet1 PublicNet { get; set; }
        public object[] PrivateNet { get; set; }
        public ServerType ServerType { get; set; }
        public Datacenter Datacenter { get; set; }
        public Image? Image { get; set; }
        public object Iso { get; set; }
        public bool RescueEnabled { get; set; }
        public bool Locked { get; set; }
        public string? BackupWindow { get; set; }
        public long? OutgoingTraffic { get; set; }
        public long? IngoingTraffic { get; set; }
        public long IncludedTraffic { get; set; }
        public ServerProtection Protection { get; set; }
        //public Labels1 Labels { get; set; }
        public long[] Volumes { get; set; }
        public long[] LoadBalancers { get; set; }
        public int PrimaryDiskSize { get; set; }
        public object PlacementGroup { get; set; }
    }
}
