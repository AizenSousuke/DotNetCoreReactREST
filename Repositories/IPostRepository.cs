﻿using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface IPostRepository
    {
        Task<Post> AddPostAsync(Post post);

        Task<Post> DeletePostAsync(int postId);

        Task<Post> GetPostByIdAsync(int postId);

        Task<List<Post>> GetPostsAsync();

        Task<PaginationResourceParameter<Post>> GetPostsAsync(PaginationResourceParameter<Post> paginationResourceParameter);

        Task<bool> SaveAsync();

        Task<Post> UpdatePostAsync(int postId, JsonPatchDocument post);
    }
}