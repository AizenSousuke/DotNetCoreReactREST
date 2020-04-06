namespace DotNetCoreReactREST.ResourceParameters
{
    public class PostResourceParameter
    {
        public int PostId { get; set; }
        public string Category { get; set; }
        public string SearchQuery { get; set; }
        public string UserQuery { get; set; }

        // Pagination
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 999;

        //private int _PageSize = 10;
        //const int MaxPageSize = 20;
        //public int SkipOffset { get; set; } = 0;
        //public int PageSize
        //{
        //    get => _PageSize;
        //    //if requested page size is greater than our set max, return max; 
        //    //otherwise return requested value
        //    set => _PageSize = (value > MaxPageSize) ? MaxPageSize : value;
        //}
    }
}
