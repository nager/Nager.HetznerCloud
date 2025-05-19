namespace Nager.HetznerCloud.Models
{
    public class ServerType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cores { get; set; }
        public float Memory { get; set; }
        public int Disk { get; set; }
        public bool Deprecated { get; set; }
        public Price[] Prices { get; set; }
        public string StorageType { get; set; }
        public string CpuType { get; set; }
        public string Architecture { get; set; }
        public long IncludedTraffic { get; set; }
        public object Deprecation { get; set; }
    }
}
