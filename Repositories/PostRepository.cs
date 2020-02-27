using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Models;
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
            this._appDbContext = appDbContext;
        }

        public IEnumerable<Post> GetPosts
        {
          get
            {
                throw new NotImplementedException();
            }
        }

        public void CreatePost(Post post)
        {
            post.DateTime = DateTime.Now;
            _appDbContext.Posts.Add(post);
            Save();
        }

        public void DeletePost(int postId)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<Post[]> GetPostByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public async Task<Post> GetPostById(int postId)
        {
            return await _appDbContext.Posts.FindAsync(postId);
        }

        public Task<Post> GetPostByIdAndCategory(int postId, string category)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _appDbContext.SaveChangesAsync();
        }

        public Task<Post> UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
