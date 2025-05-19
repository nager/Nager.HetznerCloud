using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Responses
{
    public abstract class BaseResponse
    {
        public ErrorSummary? Error { get; set; }

        public bool HasErrors => this.Error != null;
    }
}
