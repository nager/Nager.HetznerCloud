namespace Nager.HetznerCloud.Models
{
    public class Price
    {
        public string Location { get; set; }
        public PriceDetail PriceHourly { get; set; }
        public PriceDetail PriceMonthly { get; set; }
    }
}
