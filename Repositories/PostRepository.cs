using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Models;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<Post> UpdatePost(int postId, Post post)
        {
            Post updatedPost = GetPostById(postId);
            updatedPost.Title = post.Title;
            updatedPost.Content = post.Content;
            updatedPost.DateTime = DateTime.Now;
            await Save();
            return GetPostById(postId);
        }

        public Task<bool> DeletePost(int postId)
        {
            Post post = GetPostById(postId);
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

        public Post GetPostById(int postId)
        {
            Post post = _appDbContext.Posts.Where(p => p.Id == postId).FirstOrDefault();
            return post;
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
