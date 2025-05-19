using System.Globalization;

namespace Nager.HetznerCloud.Models
{
    public class PriceDetail
    {
        public string Net { get; set; }

        public decimal ParsedPriceNet
        {
            get
            {
                decimal.TryParse(this.Net, CultureInfo.InvariantCulture, out var netPrice);
                return netPrice;
            }
        }

        public string Gross { get; set; }

        public override string ToString()
        {
            decimal.TryParse(this.Net, CultureInfo.InvariantCulture, out var netPrice);

            return $"Net:{netPrice:0.0000}";
        }
    }
}
