namespace Nager.HetznerCloud.Models
{
    public class Pagination
    {
        public long LastPage { get; set; }
        public long? NextPage { get; set; }
        public long Page { get; set; }
        public long PerPage { get; set; }
        public long? PreviousPage { get; set; }
        public long TotalEntries { get; set; }
    }
}
