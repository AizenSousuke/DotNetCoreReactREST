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
        IEnumerable<Post[]> GetPostByCategory(string category);
        Post GetPostByIdAndCategory(int postId, string category);
        void CreatePost(Post post);
        void UpdatePost(Post post);
        void DeletePost(int postId);
        void Save();
    }
}
