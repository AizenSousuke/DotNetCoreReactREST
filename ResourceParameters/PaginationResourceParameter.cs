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
        public int TotalNumberOfPosts { get; set; }
        public int TotalNumberOfPostsPerPage
        {
            get => _defaultNumberOfObjectsPerPage;
            set => _defaultNumberOfObjectsPerPage = (value > _maxNumberOfObjectsPerPage) ? _maxNumberOfObjectsPerPage : value;
        }

        // Pages
        public List<int> Pages { get; set; } = new List<int>();
        public List<string> PagesURL { get; set; } = new List<string>();

        // Navigation bar items
        public int FirstPage { get; set; } = 1;
        public int PrevPage { get; set; } // { get => (currentPage - 1) > 1 ? currentPage - 1 : 1; set => prevPage = (currentPage - 1) > 1 ? currentPage - 1 : 0; }
        public int CurrentPage { get; set; } = 1;
        public int NextPage { get; set; } // { get => (currentPage + 1) > lastPage ? currentPage + 1 : lastPage; set => nextPage = (currentPage + 1) > lastPage ? currentPage + 1 : lastPage; }
        public int LastPage { get; set; } = 1;
        public string FirstPageURL { get; set; }
        public string PrevPageURL { get; set; }
        public string CurrentPageURL { get; set; }
        public string NextPageURL { get; set; }
        public string LastPageURL { get; set; }

        // Objects for this page
        public List<T> ObjList { get; set; } = new List<T>();

    }
}
