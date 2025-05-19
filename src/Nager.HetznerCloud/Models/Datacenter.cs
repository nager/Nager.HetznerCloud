namespace Nager.HetznerCloud.Models
{
    public class Datacenter
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; }
        public ServerTypes ServerTypes { get; set; }

        public override string ToString()
        {
            return $"Id:{this.Id} Name:{this.Name} Description:{this.Description}";
        }
    }
}
