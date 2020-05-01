using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Serilog;

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
            try
            {
                post.DateTime = DateTime.Now;
                Log.Information("Setting Post DateTime: {@DateTime}", post.DateTime.ToString());
                await _appDbContext.Posts.AddAsync(post);

                bool result = await SaveAsync();
                if (result)
                {
                    List<Post> newPost = await GetPostsAsync();
                    Log.Information("Finding Post DateTime: {@DateTime}", newPost.FirstOrDefault(p => p.DateTime == post.DateTime).DateTime.ToString());
                    return newPost.FirstOrDefault(p => p.DateTime == post.DateTime);
                }

                return null;
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                throw;
            }
        }

        public async Task<Post> DeletePostAsync(int postId)
        {
            Post post = await GetPostByIdAsync(postId);
            if (post != null)
            {
                post.IsDeleted = !post.IsDeleted;
                await SaveAsync();
                Post deletedPost = await GetPostByIdAsync(postId);
                if (deletedPost != null)
                {
                    return deletedPost;
                }

                return null;
            }

            return null;
        }

        public async Task<Post> GetPostByIdAsync(int postId)
        {
            return await _appDbContext.Posts.Where(p => p.Id == postId).FirstOrDefaultAsync();
        }

        public async Task<List<Post>> GetPostsAsync()
        {
            List<Post> posts = await _appDbContext.Posts
                .OrderByDescending(p => p.Id).ToListAsync();
            return posts;
        }

        public async Task<PaginationResourceParameter<Post>> GetPostsAsync(PaginationResourceParameter<Post> paginationResourceParameter)
        {
            PaginationResourceParameter<Post> result = new PaginationResourceParameter<Post>(_appDbContext);
            return await result.InitAsync(paginationResourceParameter);
        }

        public async Task<bool> SaveAsync()
        {
            int result = await _appDbContext.SaveChangesAsync();
            return result >= 0;
        }

        public async Task<Post> UpdatePostAsync(int postId, JsonPatchDocument post)
        {
            // Post oldPost = await GetPostByIdAsync(postId);
            bool saved = await SaveAsync();
            if (saved)
            {
                return await GetPostByIdAsync(postId);
            }

            return null;
        }
    }
}