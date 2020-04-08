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
        // AppDbContext
        private readonly AppDbContext _context;

        public PaginationResourceParameter()
        {

        }
        public PaginationResourceParameter(AppDbContext context)
        {
            _context = context;
        }

        public string URLName { get; set; }

        // Search Type
        public int Id { get; set; }
        public string Category { get; set; }
        public string SearchQuery { get; set; }
        public string UserQuery { get; set; }
        public int PageNumber { get; set; }
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
        public IEnumerable<T> ObjList { get; set; }

        public async Task<PaginationResourceParameter<T>> InitAsync(PaginationResourceParameter<T> paginationResourceParameter)
        {
            if (paginationResourceParameter == null)
            {
                throw new ArgumentNullException(nameof(paginationResourceParameter));
            }

            // Assuming that nothing is set
            PageNumber = paginationResourceParameter.PageNumber;
            CurrentPage = paginationResourceParameter.PageNumber;
            PageSize = paginationResourceParameter.PageSize;
            TotalNumberOfObjectsPerPage = paginationResourceParameter.PageSize;

            // Deferred Execution
            IQueryable collection;

            Log.Information("Type of T: {@0}", typeof(T).ToString());

            if (typeof(T) == typeof(Post))
            {
                URLName = "posts";

                collection = _context.Posts as IQueryable<Post>;

                if (!string.IsNullOrWhiteSpace(paginationResourceParameter.Category))
                {
                    var category = paginationResourceParameter.Category.Trim();
                    collection = collection.Cast<Post>().Where(post => post.Category.Name.Contains(category));
                    Category = paginationResourceParameter.Category;
                }

                if (!string.IsNullOrWhiteSpace(paginationResourceParameter.SearchQuery))
                {
                    var searchQuery = paginationResourceParameter.SearchQuery.Trim();
                    collection = collection.Cast<Post>().Where(post =>
                        post.Title.Contains(searchQuery) ||
                        post.Description.Contains(searchQuery) ||
                        post.Content.Contains(searchQuery));
                    SearchQuery = paginationResourceParameter.SearchQuery;
                }

                if (!string.IsNullOrWhiteSpace(paginationResourceParameter.UserQuery))
                {
                    var userQuery = paginationResourceParameter.UserQuery.Trim();
                    collection = collection.Cast<Post>().Where(post => post.ApplicationUserId.Contains(userQuery));
                    UserQuery = paginationResourceParameter.UserQuery;
                }

                if (paginationResourceParameter.Id > 0)
                {
                    int objId = paginationResourceParameter.Id;
                    collection = collection.Cast<Post>().Where(obj => obj.Id == objId);
                    Id = paginationResourceParameter.Id;
                }

                // Get pagination data and fill up the object as required
                TotalNumberOfObjects = collection.Cast<Post>().Count();
            }
            else if (typeof(T) == typeof(Category))
            {
                URLName = "categories";

                collection = _context.Categories as IQueryable<Category>;

                // Get pagination data and fill up the object as required
                TotalNumberOfObjects = collection.Cast<Category>().Count();
            }
            else
            {
                Log.Error("Case break in Pagination Resource Parameter class: {@0}", typeof(T).ToString());
                throw new ArgumentNullException();
            }

            Log.Information("paginationResourceParameter.totalNumberOfObjects: " + TotalNumberOfObjects.ToString());

            // Get total number of pages
            double pageNeeded = (double)TotalNumberOfObjects / (double)TotalNumberOfObjectsPerPage;
            // Round up to nearest int
            pageNeeded = Convert.ToInt32(Math.Ceiling((decimal)pageNeeded));
            // Min of 1 page
            if (pageNeeded < 1)
            {
                pageNeeded = 1;
            }
            // Min current page number
            if (CurrentPage < 1)
            {
                CurrentPage = 1;
            }
            Log.Information("pageNeeded: " + pageNeeded.ToString());

            // For every page, add the number and url
            for (int i = 1; i <= pageNeeded; i++)
            {
                Pages.Add(i);
                // Compose the URL
                string fullURL = "/api" + "/" + URLName + "?" + "PageNumber=" + i.ToString();

                if (!string.IsNullOrWhiteSpace(Category))
                {
                    fullURL = fullURL + "&" + "Category=" + Category;
                }

                if (!string.IsNullOrWhiteSpace(SearchQuery))
                {
                    fullURL = fullURL + "&" + "SearchQuery=" + SearchQuery;
                }

                if (!string.IsNullOrWhiteSpace(UserQuery))
                {
                    fullURL = fullURL + "&" + "UserQuery=" + UserQuery;
                }

                PagesURL.Add(fullURL);
            }

            Log.Information("\n\nPagination Object before calculations: \n {@0} \n\n", this);

            // Do calculations
            FirstPage = 1;
            FirstPageURL = PagesURL[0];
            LastPage = Pages.Last();
            LastPageURL = PagesURL.Last();
            CurrentPage = CurrentPage < LastPage ? CurrentPage : LastPage;
            CurrentPageURL = PagesURL[CurrentPage - 1];
            PrevPage = CurrentPage > FirstPage ? CurrentPage - 1 : FirstPage;
            PrevPageURL = PagesURL[PrevPage - 1];
            NextPage = CurrentPage < LastPage ? CurrentPage + 1 : LastPage;
            NextPageURL = PagesURL[NextPage - 1];

            // Calculate Results
            IEnumerable<T> result = null;
            if (typeof(T) == typeof(Post))
            {
                result = (IEnumerable<T>) await collection
                    .Cast<Post>()
                    .Skip((CurrentPage - 1) * TotalNumberOfObjectsPerPage)
                    .Take(TotalNumberOfObjectsPerPage).ToListAsync();
            }
            else if (typeof(T) == typeof(Category))
            {
                result = (IEnumerable<T>)await collection
                    .Cast<Category>()
                    .Skip((CurrentPage - 1) * TotalNumberOfObjectsPerPage)
                    .Take(TotalNumberOfObjectsPerPage).ToListAsync();
            }
            else
            {
                result = null;
                Log.Error("Case break in Pagination Resource Parameter class: {@0}", typeof(T).ToString());
                throw new ArgumentNullException();
            }

            ObjList = result;

            Log.Information("\n\n Pagination Object after calculation: \n {@0} \n\n", this);

            return this;
        }
        public async Task<IEnumerable<T>> UpdateObjList(IQueryable<T> collection)
        {
            return await collection
                   .Skip((CurrentPage - 1) * TotalNumberOfObjectsPerPage)
                   .Take(TotalNumberOfObjectsPerPage).ToListAsync();
        }
    }
}
