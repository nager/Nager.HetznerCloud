namespace Nager.HetznerCloud.Models
{
    public class Pricing
    {
        public string Currency { get; set; }
        public string VatRate { get; set; }
        public PriceImage Image { get; set; }
        public PriceFloatingIp FloatingIp { get; set; }
        //public FloatingIp[] FloatingIps { get; set; }
        public PricePrimaryIps[] PrimaryIps { get; set; }
        public PriceTraffic Traffic { get; set; }
        /// <summary>
        /// Will increase base Server costs by specific percentage
        /// </summary>
        public PriceServerBackup ServerBackup { get; set; }
        public PriceVolume Volume { get; set; }
        public PriceServerType[] ServerTypes { get; set; }
        public PriceLoadBalancerType[] LoadBalancerTypes { get; set; }
    }
}
