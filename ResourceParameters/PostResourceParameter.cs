namespace DotNetCoreReactREST.ResourceParameters
{
    public class PostResourceParameter
    {
        const int maxPageSize = 20;
        public string Category { get; set; }
        public string SearchQuery { get; set; }
        private int _pageSize = 10;
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
