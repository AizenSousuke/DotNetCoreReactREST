using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _appDbContext;
        public PostRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Post> CreatePostAsync(Post post)
        {
            post.DateTime = DateTime.Now;
            await _appDbContext.Posts.AddAsync(post);
            await Save();
            List<Post> newPost = await GetPostsAsync();
            return newPost.FirstOrDefault(p => p.Id == post.Id);
        }

        public async Task<List<Post>> GetPostsAsync()
        {
            List<Post> Posts = await _appDbContext.Posts
                .OrderByDescending(p => p.Id).ToListAsync();
            return Posts;
        }

        public async Task<PaginationResourceParameter<Post>> GetPostsAsync(PaginationResourceParameter<Post> paginationResourceParameter)
        {
            if (paginationResourceParameter == null)
            {
                throw new ArgumentNullException(nameof(paginationResourceParameter));
            }
            if (string.IsNullOrWhiteSpace(paginationResourceParameter.Category)
                && string.IsNullOrWhiteSpace(paginationResourceParameter.SearchQuery)
                && string.IsNullOrWhiteSpace(paginationResourceParameter.UserQuery)
                && paginationResourceParameter.PageNumber <= 1
                && paginationResourceParameter.PageSize < 1
            )
            {
                Log.Information("Getting all posts! ================================");
                return await this.GetPostsPaginationAsync(new PaginationResourceParameter<Post>()
                {
                    // Assuming that nothing is set
                    PageNumber = 1,
                    PageSize = 999,
                    totalNumberOfPostsPerPage = 999
                });
            }

            // Deferred Execution
            var collection = _appDbContext.Posts as IQueryable<Post>;

            if (!string.IsNullOrWhiteSpace(paginationResourceParameter.Category))
            {
                var category = paginationResourceParameter.Category.Trim();
                collection = collection.Where(post => post.Category.Name.Contains(category));
            }

            if (!string.IsNullOrWhiteSpace(paginationResourceParameter.SearchQuery))
            {
                var searchQuery = paginationResourceParameter.SearchQuery.Trim();
                collection = collection.Where(post =>
                    post.Title.Contains(searchQuery) ||
                    post.Description.Contains(searchQuery) ||
                    post.Content.Contains(searchQuery));
            }

            if (!string.IsNullOrWhiteSpace(paginationResourceParameter.UserQuery))
            {
                var userQuery = paginationResourceParameter.UserQuery.Trim();
                collection = collection.Where(post => post.ApplicationUserId.Contains(userQuery));
            }

            // Temporarily disabled because it does not work
            if (paginationResourceParameter.PostId > 0)
            {
                int postId = paginationResourceParameter.PostId;
                collection = collection.Where(post => post.Id == postId);
            }

            // Pagination
            return await this.GetPostsPaginationAsync(new PaginationResourceParameter<Post>()
            {
                // Assuming that nothing is set
                currentPage = paginationResourceParameter.PageNumber,
                PageSize = paginationResourceParameter.PageSize,
                totalNumberOfPostsPerPage = paginationResourceParameter.PageSize
            }, collection);
        }

        public async Task<PaginationResourceParameter<Post>> GetPostsPaginationAsync(PaginationResourceParameter<Post> paginationResourceParameter, IQueryable<Post> collection = null)
        {
            // Get all posts if it doesn't exist 
            if (collection == null)
            {
                // Deferred execution
                collection = _appDbContext.Posts as IQueryable<Post>;
            }

            // Get pagination data and fill up the object as required
            paginationResourceParameter.totalNumberOfPosts = collection.Count();
            Log.Information("paginationResourceParameter.totalNumberOfPosts: " + paginationResourceParameter.totalNumberOfPosts.ToString());
            // Get total number of pages
            double pageNeeded = (double)paginationResourceParameter.totalNumberOfPosts / (double)paginationResourceParameter.totalNumberOfPostsPerPage;
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
            if (paginationResourceParameter.currentPage < 1)
            {
                paginationResourceParameter.currentPage = 1;
            }
            Log.Information("pageNeeded: " + pageNeeded.ToString());
            // For every page, add the number and url
            for (int i = 1; i <= pageNeeded; i++)
            {
                paginationResourceParameter.pages.Add(i);
                paginationResourceParameter.pagesURL.Add("/api/posts?PageNumber=" + i.ToString());
            }

            Log.Information("Post Pagination Object before calculations: \n {@0} \n", paginationResourceParameter);

            // Do calculations
            paginationResourceParameter.firstPage = 1;
            paginationResourceParameter.firstPageURL = paginationResourceParameter.pagesURL[0];
            paginationResourceParameter.lastPage = paginationResourceParameter.pages.Last();
            paginationResourceParameter.lastPageURL = paginationResourceParameter.pagesURL.Last();
            paginationResourceParameter.currentPage = paginationResourceParameter.currentPage < paginationResourceParameter.lastPage ? paginationResourceParameter.currentPage : paginationResourceParameter.lastPage;
            paginationResourceParameter.currentPageURL = paginationResourceParameter.pagesURL[paginationResourceParameter.currentPage - 1];
            paginationResourceParameter.prevPage = paginationResourceParameter.currentPage > paginationResourceParameter.firstPage ? paginationResourceParameter.currentPage - 1 : paginationResourceParameter.firstPage;
            paginationResourceParameter.prevPageURL = paginationResourceParameter.pagesURL[paginationResourceParameter.prevPage - 1];
            paginationResourceParameter.nextPage = paginationResourceParameter.currentPage < paginationResourceParameter.lastPage ? paginationResourceParameter.currentPage + 1 : paginationResourceParameter.lastPage;
            paginationResourceParameter.nextPageURL = paginationResourceParameter.pagesURL[paginationResourceParameter.nextPage - 1];

            // Get the posts on this page only
            paginationResourceParameter.objList = await collection
                .Skip((paginationResourceParameter.currentPage - 1) * paginationResourceParameter.totalNumberOfPostsPerPage)
                .Take(paginationResourceParameter.totalNumberOfPostsPerPage).ToListAsync();
            Log.Information("Post Pagination Object: \n {@0}", paginationResourceParameter);

            return paginationResourceParameter;
        }

        public async Task<Post> GetPostByIdAsync(int postId)
        {
            return await _appDbContext.Posts.Where(p => p.Id == postId).FirstOrDefaultAsync();
        }

        public async Task<Post> UpdatePostAsync(int postId, JsonPatchDocument post)
        {
            Post oldPost = await GetPostByIdAsync(postId);

            await Save();
            return await GetPostByIdAsync(postId);
        }

        public async Task<bool> DeletePostAsync(int postId)
        {
            Post post = await GetPostByIdAsync(postId);
            if (post != null)
            {
                _appDbContext.Posts.Remove(post);
                return await Save();
            }
            return false;
        }

        public async Task<bool> Save()
        {
            int result = await _appDbContext.SaveChangesAsync();
            return (result >= 0);
        }
    }
}
