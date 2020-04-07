using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.ResourceParameters
{
    public class PaginationResourceParameter<T>
    {
        public PaginationResourceParameter()
        {

        }
        public PaginationResourceParameter(PaginationResourceParameter<T> paginationResourceParameter, AppDbContext context)
        {
            _context = context;
            if (paginationResourceParameter == null)
            {
                throw new ArgumentNullException(nameof(paginationResourceParameter));
            }
            if (string.IsNullOrWhiteSpace(paginationResourceParameter.Category)
                && string.IsNullOrWhiteSpace(paginationResourceParameter.SearchQuery)
                && string.IsNullOrWhiteSpace(paginationResourceParameter.UserQuery)
                && string.IsNullOrWhiteSpace(paginationResourceParameter.PageNumber.ToString())
                && string.IsNullOrWhiteSpace(paginationResourceParameter.PageSize.ToString())
            )
            {
                Log.Information("Getting all posts! ================================");

                // Assuming that nothing is set
                PageNumber = 1;
                PageSize = 999;
                TotalNumberOfObjectsPerPage = 999;
            }

            // Deferred Execution
            collection = _context.Posts as IQueryable<Post>;

            if (!string.IsNullOrWhiteSpace(paginationResourceParameter.Category))
            {
                var category = paginationResourceParameter.Category.Trim();
                collection = collection.Cast<Post>().Where(post => post.Category.Name.Contains(category));
            }

            if (!string.IsNullOrWhiteSpace(paginationResourceParameter.SearchQuery))
            {
                var searchQuery = paginationResourceParameter.SearchQuery.Trim();
                collection = collection.Cast<Post>().Where(post =>
                    post.Title.Contains(searchQuery) ||
                    post.Description.Contains(searchQuery) ||
                    post.Content.Contains(searchQuery));
            }

            if (!string.IsNullOrWhiteSpace(paginationResourceParameter.UserQuery))
            {
                var userQuery = paginationResourceParameter.UserQuery.Trim();
                collection = collection.Cast<Post>().Where(post => post.ApplicationUserId.Contains(userQuery));
            }

            // Temporarily disabled because it does not work
            if (paginationResourceParameter.Id > 0)
            {
                int postId = paginationResourceParameter.Id;
                collection = collection.Cast<Post>().Where(post => post.Id == postId);
            }

            // Assuming that nothing is set
            CurrentPage = paginationResourceParameter.PageNumber;
            PageSize = paginationResourceParameter.PageSize;
            TotalNumberOfObjectsPerPage = paginationResourceParameter.PageSize;

            // Get pagination data and fill up the object as required
            paginationResourceParameter.TotalNumberOfObjects = collection.Cast<Post>().Count();
            Log.Information("paginationResourceParameter.totalNumberOfPosts: " + paginationResourceParameter.TotalNumberOfObjects.ToString());
            // Get total number of pages
            double pageNeeded = (double)paginationResourceParameter.TotalNumberOfObjects / (double)paginationResourceParameter.TotalNumberOfObjectsPerPage;
            Log.Information("pageNeeded before ceil: " + pageNeeded.ToString());
            // Round up to nearest int
            pageNeeded = Convert.ToInt32(Math.Ceiling((decimal)pageNeeded));
            Log.Information("pageNeeded before min: " + pageNeeded.ToString());
            // Min of 1 page
            if (pageNeeded < 1)
            {
                pageNeeded = 1;
            }
            // Min current page number
            if (paginationResourceParameter.CurrentPage < 1)
            {
                paginationResourceParameter.CurrentPage = 1;
            }
            Log.Information("pageNeeded: " + pageNeeded.ToString());

            // For every page, add the number and url
            for (int i = 1; i <= pageNeeded; i++)
            {
                paginationResourceParameter.Pages.Add(i);
                paginationResourceParameter.PagesURL.Add("/api/posts?PageNumber=" + i.ToString());
            }

            Log.Information("\n\nPost Pagination Object before calculations: \n {@0} \n\n", paginationResourceParameter);

            // Do calculations
            paginationResourceParameter.FirstPage = 1;
            paginationResourceParameter.FirstPageURL = paginationResourceParameter.PagesURL[0];
            paginationResourceParameter.LastPage = paginationResourceParameter.Pages.Last();
            paginationResourceParameter.LastPageURL = paginationResourceParameter.PagesURL.Last();
            paginationResourceParameter.CurrentPage = paginationResourceParameter.CurrentPage < paginationResourceParameter.LastPage ? paginationResourceParameter.CurrentPage : paginationResourceParameter.LastPage;
            paginationResourceParameter.CurrentPageURL = paginationResourceParameter.PagesURL[paginationResourceParameter.CurrentPage - 1];
            paginationResourceParameter.PrevPage = paginationResourceParameter.CurrentPage > paginationResourceParameter.FirstPage ? paginationResourceParameter.CurrentPage - 1 : paginationResourceParameter.FirstPage;
            paginationResourceParameter.PrevPageURL = paginationResourceParameter.PagesURL[paginationResourceParameter.PrevPage - 1];
            paginationResourceParameter.NextPage = paginationResourceParameter.CurrentPage < paginationResourceParameter.LastPage ? paginationResourceParameter.CurrentPage + 1 : paginationResourceParameter.LastPage;
            paginationResourceParameter.NextPageURL = paginationResourceParameter.PagesURL[paginationResourceParameter.NextPage - 1];

            Log.Information("Post Pagination Object after calculation: \n {@0}", paginationResourceParameter);

            Log.Information("Done creating pagination resource");
        }

        // AppDbContext
        private readonly AppDbContext _context;

        // Search Type
        public int Id { get; set; }
        public string Category { get; set; }
        public string SearchQuery { get; set; }
        public string UserQuery { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get => _defaultNumberOfObjectsPerPage; set => _defaultNumberOfObjectsPerPage = value > 0 ? value : 1; }

        // Parameters
        private int _defaultNumberOfObjectsPerPage = 10;
        // Change the max number here in the code
        private const int _maxNumberOfObjectsPerPage = 999;
        public int TotalNumberOfObjects { get; set; }
        public int TotalNumberOfObjectsPerPage
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
        public IQueryable collection { get; set; }
        public IEnumerable<T> ObjList { get; set; } = new List<T>();
        public async Task<IEnumerable<T>> UpdateObjList(IQueryable<T> collection)
        {
            return await collection
                   .Skip((CurrentPage - 1) * TotalNumberOfObjectsPerPage)
                   .Take(TotalNumberOfObjectsPerPage).ToListAsync();
        }
    }
}
