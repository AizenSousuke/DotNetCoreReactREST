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
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddPostAsync(Post post)
        {
            if (post == null)
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

            post.DateTime = DateTime.Now;
            Log.Information("Setting Post DateTime: {@DateTime}", post.DateTime.ToString());
            await _context.Posts.AddAsync(post);
        }

        public async Task<Post> DeletePostAsync(int postId)
        {
            if (post == null)
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
            return await _context.Posts.FirstOrDefaultAsync(p => p.Id == postId);
        }

        public async Task<PaginationResourceParameter<Post>> GetPostsAsync(PaginationResourceParameter<Post> paginationResourceParameter)
        {
            PaginationResourceParameter<Post> result = new PaginationResourceParameter<Post>(_context);
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