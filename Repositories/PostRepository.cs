using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Post>> GetPostsAsync(PostResourceParameter postResourceParameters)
        {
            if (postResourceParameters == null)
            {
                throw new ArgumentNullException(nameof(postResourceParameters));
            }
            if (string.IsNullOrWhiteSpace(postResourceParameters.Category)
                && string.IsNullOrWhiteSpace(postResourceParameters.SearchQuery)
                && string.IsNullOrWhiteSpace(postResourceParameters.UserQuery)
                && (postResourceParameters.PageNumber < 1)
            )
            {
                return await GetPostsAsync();
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
            if (postResourceParameters.PageNumber >= 1)
            {
                collection = collection.Skip(postResourceParameters.SkipOffset + (postResourceParameters.PageNumber - 1) * postResourceParameters.PageSize)
                    .Take(postResourceParameters.PageSize);
            }

            return await collection.OrderByDescending(p => p.Id).ToListAsync();
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
