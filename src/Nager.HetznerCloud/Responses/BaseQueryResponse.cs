using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Responses
{
    public abstract class BaseQueryResponse : BaseResponse
    {
        public Meta Meta { get; set; }
    }
}
