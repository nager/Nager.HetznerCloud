namespace Nager.HetznerCloud.Models
{
    public class ErrorSummary
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public ErrorDetail Details { get; set; }
    }
}
