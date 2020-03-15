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
            Post newPost = GetPosts().FirstOrDefault(p => p.Id == post.Id);
            return newPost;
        }

        public IEnumerable<Post> GetPosts()
        {
            IEnumerable<Post> Posts = _appDbContext.Posts
                .OrderByDescending(p => p.DateTime);
            return Posts;
        }

        public IEnumerable<Post> GetPosts(PostResourceParameter postResourceParameters)
        {
            if (postResourceParameters == null)
            {
                throw new ArgumentNullException(nameof(postResourceParameters));
            }
            if (string.IsNullOrWhiteSpace(postResourceParameters.Category)
                && string.IsNullOrWhiteSpace(postResourceParameters.SearchQuery))
            {
                return GetPosts();
            }
            var collection = _appDbContext.Posts as IQueryable<Post>;

            if (!string.IsNullOrWhiteSpace(postResourceParameters.Category))
            {
                var category = postResourceParameters.Category.Trim();
                collection = collection.Where(post => post.Category.Name == category);
            }

            if (!string.IsNullOrWhiteSpace(postResourceParameters.SearchQuery))
            {

                var searchQuery = postResourceParameters.SearchQuery.Trim();
                collection = collection.Where(a => a.Title.Contains(searchQuery));
            }

            return collection.ToList();
        }

        public async Task<Post> UpdatePost(int postId, JsonPatchDocument post)
        {
            Task<Post> oldPost = GetPostByIdAsync(postId);

            await Save();
            return GetPostByIdAsync(postId).Result;
        }

        public Task<bool> DeletePost(int postId)
        {
            Post post = GetPostByIdAsync(postId).Result;
            if (post != null)
            {
                _appDbContext.Posts.Remove(post);
                return Save();
            }
            return Task.FromResult(false);
        }

        public async Task<Post> GetPostByIdAsync(int postId)
        {
            return await _appDbContext.Posts.Where(p => p.Id == postId).FirstOrDefaultAsync();
        }

        public async Task<bool> Save()
        {
            int result = await _appDbContext.SaveChangesAsync();
            return (result >= 0);
        }
    }
}
