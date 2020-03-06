using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
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
            IEnumerable<Post> Posts = _appDbContext.Posts.OrderBy(p => p.Id);
            return Posts;
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

        public Post[] GetPostByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public async Task<Post> GetPostByIdAsync(int postId)
        {
            return await _appDbContext.Posts.Where(p => p.Id == postId).FirstOrDefaultAsync();
        }

        public Post GetPostByIdAndCategory(int postId, string category)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Save()
        {
            int result = await _appDbContext.SaveChangesAsync();
            return (result >= 0);
        }
    }
}
