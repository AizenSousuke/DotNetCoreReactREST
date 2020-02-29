using DotNetCoreReactREST.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetPosts { get; }
        Post GetPostById(int postId);
        Post[] GetPostByCategory(string category);
        Post GetPostByIdAndCategory(int postId, string category);
        Post CreatePost(Post post);
        Post UpdatePost(int postId, Post post);
        void DeletePost(int postId);
        bool Save();
    }
}
