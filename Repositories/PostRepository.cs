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
            if (post == null)
            {
                throw new ArgumentNullException(nameof(post));
            }

            post.DateTime = DateTime.Now;
            Log.Information("Setting Post DateTime: {@DateTime}", post.DateTime.ToString());
            await _appDbContext.Posts.AddAsync(post);

            bool isSaved = await SaveAsync();
            if (isSaved)
            {
                List<Post> newPost = await GetPostsAsync();
                Log.Information("Finding Post DateTime: {@DateTime}", newPost.FirstOrDefault(p => p.DateTime == post.DateTime).DateTime.ToString());
                return newPost.FirstOrDefault(p => p.DateTime == post.DateTime);
            }

            return null;
        }

        public async Task<Post> DeletePostAsync(int postId)
        {
            if (postId == null)
            {
                throw new ArgumentNullException(nameof(postId));
            }

            Post post = await GetPostByIdAsync(postId);
            if (post == null)
            {
                return null;
            }

            post.IsDeleted = !post.IsDeleted;
            bool isSaved = await SaveAsync();
            if (!isSaved)
            {
                return null;
            }

            Post deletedPost = await GetPostByIdAsync(postId);
            if (deletedPost == null)
            {
                return null;
            }

            return deletedPost;
        }

        public async Task<Post> GetPostByIdAsync(int postId)
        {
            if (postId == null)
            {
                throw new ArgumentNullException(nameof(postId));
            }

            return await _appDbContext.Posts.Where(p => p.Id == postId).FirstOrDefaultAsync();
        }

        public async Task<List<Post>> GetPostsAsync()
        {
            List<Post> posts = await _appDbContext.Posts
                .OrderByDescending(p => p.Id).ToListAsync();
            if (posts == null)
            {
                return null;
            }

            return posts;
        }

        public async Task<PaginationResourceParameter<Post>> GetPostsAsync(PaginationResourceParameter<Post> paginationResourceParameter)
        {
            PaginationResourceParameter<Post> result = new PaginationResourceParameter<Post>(_appDbContext);
            return await result.InitAsync(paginationResourceParameter);
        }

        public async Task<bool> SaveAsync()
        {
            return await _appDbContext.SaveChangesAsync() > 0;
        }

        public async Task<Post> UpdatePostAsync(int postId, JsonPatchDocument post)
        {
            if (postId == null || post == null)
            {
                throw new ArgumentNullException();
            }

            bool isSaved = await SaveAsync();
            if (!isSaved)
            {
                return null;
            }

            return await GetPostByIdAsync(postId);
        }
    }
}