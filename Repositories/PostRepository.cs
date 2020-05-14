using System;
using System.Threading.Tasks;
using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace DotNetCoreReactREST.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _context;

        public PostRepository(AppDbContext context)
        {
            _context = appDbContext;
        }

        public async Task<Post> AddPostAsync(Post post)
        {
            if (post == null)
            {
                throw new ArgumentNullException(nameof(post));
            }

            post.DateTime = DateTime.Now;
            Log.Information("Setting Post DateTime: {@DateTime}", post.DateTime.ToString());
            await _context.Posts.AddAsync(post);

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
            return await _context.Posts.Where(p => p.Id == postId).FirstOrDefaultAsync();
        }

        public async Task<List<Post>> GetPostsAsync()
        {
            List<Post> posts = await _context.Posts
                .OrderByDescending(p => p.Id).ToListAsync();
            if (posts == null)
            {
                return null;
            }

            return posts;
        }

        public async Task<PaginationResourceParameter<Post>> GetPostsAsync(PaginationResourceParameter<Post> paginationResourceParameter)
        {
            PaginationResourceParameter<Post> result = new PaginationResourceParameter<Post>(_context);
            return await result.InitAsync(paginationResourceParameter);
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Post> UpdatePostAsync(int postId, JsonPatchDocument post)
        {
            bool isSaved = await SaveAsync();
            if (!isSaved)
            {
                return null;
            }

            return await GetPostByIdAsync(postId);
        }
    }
}