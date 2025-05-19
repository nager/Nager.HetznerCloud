namespace Nager.HetznerCloud.Models
{
    public class PriceLoadBalancerType
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Price[] Prices { get; set; }
    }
}
