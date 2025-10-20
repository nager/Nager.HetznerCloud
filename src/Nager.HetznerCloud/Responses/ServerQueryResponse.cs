using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Responses
{
    public class ServerQueryResponse : BaseQueryResponse
    {
        public Server[] Servers { get; set; }
    }
}
