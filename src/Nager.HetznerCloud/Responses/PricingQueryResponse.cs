using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Responses
{
    public class PricingQueryResponse : BaseResponse
    {
        public Pricing Pricing { get; set; }
    }
}
