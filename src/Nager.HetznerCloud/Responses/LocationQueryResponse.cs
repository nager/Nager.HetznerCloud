using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Responses
{
    public class LocationQueryResponse : BaseQueryResponse
    {
        public Location[] Locations { get; set; }
    }
}
