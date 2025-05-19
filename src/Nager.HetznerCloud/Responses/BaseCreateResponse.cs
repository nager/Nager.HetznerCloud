using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Responses
{
    public abstract class BaseCreateResponse : BaseResponse
    {
        public HetznerCloudAction[] Actions { get; set; }
    }
}
