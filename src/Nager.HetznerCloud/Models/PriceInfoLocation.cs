namespace Nager.HetznerCloud.Models
{
    public class PriceInfoLocation
    {
        public string Location { get; set; }

        public PriceDetail PriceHourly { get; set; }

        public PriceDetail PriceMonthly { get; set; }

        public override string ToString()
        {
            return $"{this.Location} - Hourly:{this.PriceHourly} Monthly:{this.PriceMonthly}";
        }
    }
}
