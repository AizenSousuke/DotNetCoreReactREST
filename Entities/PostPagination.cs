using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Entities
{
    public class PostPagination
    {
        private int _defaultNumberOfPostsPerPage = 10;
        private const int _maxNumberOfPostsPerPage = 999;
        public int totalNumberOfPosts { get; set; }
        public int totalNumberOfPostsPerPage { 
            get => _defaultNumberOfPostsPerPage; 
            set => _defaultNumberOfPostsPerPage = (value > _maxNumberOfPostsPerPage) ? _maxNumberOfPostsPerPage : value; 
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

        // Posts for this page
        public List<Post> posts { get; set; } = new List<Post>();
    }
}
