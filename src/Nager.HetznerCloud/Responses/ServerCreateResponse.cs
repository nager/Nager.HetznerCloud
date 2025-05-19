using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Responses
{
    public class ServerCreateResponse : BaseCreateResponse
    {
        public HetznerCloudAction Action { get; set; }
        public HetznerCloudAction[] NextAction { get; set; }
        public string RootPassword { get; set; }
        public Server Server { get; set; }
    }
}
