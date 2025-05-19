namespace Nager.HetznerCloud.Models
{
    public class PriceServerType
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public PriceInfoLocation[] Prices { get; set; }
    }
}
