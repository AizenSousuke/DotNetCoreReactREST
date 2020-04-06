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

        public async Task<PostPagination> GetPostsAsync(PostResourceParameter postResourceParameters)
        {
            if (postResourceParameters == null)
            {
                throw new ArgumentNullException(nameof(postResourceParameters));
            }
            if (string.IsNullOrWhiteSpace(postResourceParameters.Category)
                && string.IsNullOrWhiteSpace(postResourceParameters.SearchQuery)
                && string.IsNullOrWhiteSpace(postResourceParameters.UserQuery)
                && postResourceParameters.PageNumber <= 1
                && postResourceParameters.PageSize < 1
            )
            {
                Log.Information("Getting all posts! ================================");
                return await this.GetPostsPaginationAsync(new PostPagination()
                {
                    // Assuming that nothing is set
                });
                // return await GetPostsAsync();
            }

            // Deferred Execution
            var collection = _appDbContext.Posts as IQueryable<Post>;

            if (!string.IsNullOrWhiteSpace(postResourceParameters.Category))
            {
                var category = postResourceParameters.Category.Trim();
                collection = collection.Where(post => post.Category.Name.Contains(category));
            }

            if (!string.IsNullOrWhiteSpace(postResourceParameters.SearchQuery))
            {
                var searchQuery = postResourceParameters.SearchQuery.Trim();
                collection = collection.Where(post =>
                    post.Title.Contains(searchQuery) ||
                    post.Description.Contains(searchQuery) ||
                    post.Content.Contains(searchQuery));
            }

            if (!string.IsNullOrWhiteSpace(postResourceParameters.UserQuery))
            {
                var userQuery = postResourceParameters.UserQuery.Trim();
                collection = collection.Where(post => post.ApplicationUserId.Contains(userQuery));
            }

            // Temporarily disabled because it does not work
            //if (postResourceParameters.PostId != 0)
            //{
            //    int postId = postResourceParameters.PostId;
            //    collection = collection.Where(post => post.Id == postId);
            //}

            // Pagination
            //if (postResourceParameters.PageNumber >= 1)
            //{
            //    collection = collection.Skip(postResourceParameters.SkipOffset + (postResourceParameters.PageNumber - 1) * postResourceParameters.PageSize)
            //        .Take(postResourceParameters.PageSize);
            //}
            // var jsonPagination = 
            return await this.GetPostsPaginationAsync(new PostPagination() 
            { 
                // Assuming that nothing is set
                currentPage = postResourceParameters.PageNumber,
                totalNumberOfPostsPerPage = postResourceParameters.PageSize
            }, collection);

            // return await collection.OrderByDescending(p => p.Id).ToListAsync();
        }

        public async Task<PostPagination> GetPostsPaginationAsync(PostPagination postPagination, IQueryable<Post> collection = null) {
            // Get all posts if it doesn't exist 
            if (collection == null)
            {
                // Deferred execution
                collection = _appDbContext.Posts as IQueryable<Post>;
            }

            // Get pagination data and fill up the object as required
            postPagination.totalNumberOfPosts = collection.Count();
            Log.Information("postPagination.totalNumberOfPosts: " + postPagination.totalNumberOfPosts.ToString());
            // Get total number of pages
            double pageNeeded = (double)postPagination.totalNumberOfPosts / (double)postPagination.totalNumberOfPostsPerPage;
            Log.Information("pageNeeded before ceil: " + pageNeeded.ToString());
            // Round up to nearest int
            pageNeeded = Convert.ToInt32(Math.Ceiling((decimal)pageNeeded));
            Log.Information("pageNeeded before min: " + pageNeeded.ToString());
            // Min of 1 page
            if (pageNeeded < 1)
            {
                pageNeeded = 1;
            }
            Log.Information("pageNeeded: " + pageNeeded.ToString());
            // For every page, add the number and url
            for (int i = 1; i <= pageNeeded; i++)
            {
                postPagination.pages.Add(i);
                postPagination.pagesURL.Add("/api/posts?PageNumber=" + i.ToString());
            }

            Log.Information("Post Pagination Object before calculations: \n {@0} \n", postPagination);
            
            // Do calculations
            postPagination.firstPage = 1;
            postPagination.firstPageURL = postPagination.pagesURL[0];
            postPagination.lastPage = postPagination.pages.Last();
            postPagination.lastPageURL = postPagination.pagesURL.Last();
            postPagination.currentPage = postPagination.currentPage < postPagination.lastPage ? postPagination.currentPage : postPagination.lastPage;
            postPagination.currentPageURL = postPagination.pagesURL[postPagination.currentPage - 1];
            postPagination.prevPage = postPagination.currentPage > postPagination.firstPage ? postPagination.currentPage - 1 : postPagination.firstPage;
            postPagination.prevPageURL = postPagination.pagesURL[postPagination.prevPage - 1];
            postPagination.nextPage = postPagination.currentPage < postPagination.lastPage ? postPagination.currentPage + 1 : postPagination.lastPage;
            postPagination.nextPageURL = postPagination.pagesURL[postPagination.nextPage - 1];

            // Get the posts on this page only
            postPagination.posts = await collection
                .Skip((postPagination.currentPage - 1) * postPagination.totalNumberOfPostsPerPage)
                .Take(postPagination.totalNumberOfPostsPerPage).ToListAsync();
            Log.Information("Post Pagination Object: \n {@0}", postPagination);

            return postPagination;
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
