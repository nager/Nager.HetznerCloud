using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Responses
{
    public class PlacementGroupQueryResponse : BaseQueryResponse
    {
        public PlacementGroups[] PlacementGroups { get; set; }
    }
}
