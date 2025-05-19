using Nager.HetznerCloud.Models;

namespace Nager.HetznerCloud.Responses
{
    public class SshKeyQueryResponse : BaseQueryResponse
    {
        public SshKey[] SshKeys { get; set; }
    }
}
