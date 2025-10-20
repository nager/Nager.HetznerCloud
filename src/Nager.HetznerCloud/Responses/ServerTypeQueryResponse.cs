using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Responses
{
    public class ServerTypeQueryResponse : BaseQueryResponse
    {
        public ServerType[] ServerTypes { get; set; }
    }
}
