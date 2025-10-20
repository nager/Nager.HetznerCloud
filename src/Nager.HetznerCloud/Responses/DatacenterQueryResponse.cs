using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Responses
{
    public class DatacenterQueryResponse : BaseQueryResponse
    {
        public Datacenter[] Datacenters { get; set; }

        /// <summary>
        /// Recommended Datacenter ID for new Resources
        /// </summary>
        public long Recommendation { get; set; }
    }
}
