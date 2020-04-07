using System.Collections.Generic;

namespace DotNetCoreReactREST.ResourceParameters
{
    public class PaginationResourceParameter<T>
    {
        // Search Type
        public int PostId { get; set; }
        public string Category { get; set; }
        public string SearchQuery { get; set; }
        public string UserQuery { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 999;

        // Parameters
        private int _defaultNumberOfObjectsPerPage = 10;
        // Change the max number here in the code
        private const int _maxNumberOfObjectsPerPage = 999;
        public int totalNumberOfPosts { get; set; }
        public int totalNumberOfPostsPerPage
        {
            get => _defaultNumberOfObjectsPerPage;
            set => _defaultNumberOfObjectsPerPage = (value > _maxNumberOfObjectsPerPage) ? _maxNumberOfObjectsPerPage : value;
        }

        // Pages
        public List<int> pages { get; set; } = new List<int>();
        public List<string> pagesURL { get; set; } = new List<string>();

        // Navigation bar items
        public int firstPage { get; set; } = 1;
        public int prevPage { get; set; } // { get => (currentPage - 1) > 1 ? currentPage - 1 : 1; set => prevPage = (currentPage - 1) > 1 ? currentPage - 1 : 0; }
        public int currentPage { get; set; } = 1;
        public int nextPage { get; set; } // { get => (currentPage + 1) > lastPage ? currentPage + 1 : lastPage; set => nextPage = (currentPage + 1) > lastPage ? currentPage + 1 : lastPage; }
        public int lastPage { get; set; } = 1;
        public string firstPageURL { get; set; }
        public string prevPageURL { get; set; }
        public string currentPageURL { get; set; }
        public string nextPageURL { get; set; }
        public string lastPageURL { get; set; }

        // Objects for this page
        public List<T> objList { get; set; } = new List<T>();

    }
}
