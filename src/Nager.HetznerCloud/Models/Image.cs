namespace Nager.HetznerCloud.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Architecture { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public int? ImageSize { get; set; }
        public int DiskSize { get; set; }
        public DateTime Created { get; set; }
        public object CreatedFrom { get; set; }
        public object BoundTo { get; set; }
        public string OsFlavor { get; set; }
        public string OsVersion { get; set; }
        public bool RapidDeploy { get; set; }
        public ImageProtection Protection { get; set; }
        public object Deprecated { get; set; }
        public Labels Labels { get; set; }
        public object Deleted { get; set; }

    }
}
