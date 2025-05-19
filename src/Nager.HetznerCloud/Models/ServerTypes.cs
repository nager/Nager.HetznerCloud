namespace Nager.HetznerCloud.Models
{
    public class ServerTypes
    {
        public int[] Available { get; set; }
        public int[] AvailableForMigration { get; set; }
        public int[] Supported { get; set; }
    }
}
