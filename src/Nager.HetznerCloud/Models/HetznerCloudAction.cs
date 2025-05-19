namespace Nager.HetznerCloud.Models
{
    public class HetznerCloudAction
    {
        public long Id { get; set; }
        public string Command { get; set; }
        public string Status { get; set; }

        /// <summary>
        /// Progress of the Action in percent
        /// </summary>
        public int Progress { get; set; }

        public DateTime Started { get; set; }

        public DateTime? Finished { get; set; }

        public Resource[] Resources { get; set; }

        public object Error { get; set; }
    }
}
