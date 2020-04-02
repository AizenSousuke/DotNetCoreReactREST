namespace DotNetCoreReactREST.ResourceParameters
{
    public class PostResourceParameter
    {
        public int PostId { get; set; }
        public string Category { get; set; }
        public string SearchQuery { get; set; }
        public string UserQuery { get; set; }

        private int _pageSize = 10;
        const int maxPageSize = 20;
        public int PageNumber { get; set; } = 1;
        public int PageSize
        {
            get => _pageSize;
            //if requested page size is greater than our set max, return max; 
            //otherwise return requested value
            set => _pageSize = (value > maxPageSize) ? maxPageSize : value;
        }
    }
}
