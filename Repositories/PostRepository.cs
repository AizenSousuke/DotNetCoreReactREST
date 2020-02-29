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

        public Post CreatePost(Post post)
        {
            post.DateTime = DateTime.Now;
            _appDbContext.Posts.Add(post);
            Save();
            Post newPost = GetPosts.Last();
            return newPost;
        }

        public IEnumerable<Post> GetPosts
        {
            get
            {
                IEnumerable<Post> Posts = _appDbContext.Posts;
                return Posts;
            }
        }

        public Post UpdatePost(int postId, Post post)
        {
            Post updatedPost = GetPostById(postId);
            updatedPost.Title = post.Title;
            updatedPost.Content = post.Content;
            updatedPost.DateTime = DateTime.Now;
            Save();
            return GetPostById(postId);
        }

        public void DeletePost(int postId)
        {
            throw new NotImplementedException();
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

        public bool Save()
        {
            return (_appDbContext.SaveChanges() >= 0);
        }
    }
}
