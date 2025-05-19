namespace Nager.HetznerCloud.Models
{
    public class PlacementGroups
    {
        public DateTime Created { get; set; }
        public int Id { get; set; }
        public Labels2 Labels { get; set; }
        public string Name { get; set; }
        public int[] Servers { get; set; }
        public string Type { get; set; }
    }
}
