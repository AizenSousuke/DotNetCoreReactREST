using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace DotNetCoreReactREST.Repositories
{
    public class PostLikeRespository : IPostLikeRepository
    {
        private readonly AppDbContext _appDbContext;

        public PostLikeRespository(AppDbContext context)
        {
            _appDbContext = context;
        }

        public async Task<List<PostLike>> GetLikesForPost(int postId)
        {
            if (String.IsNullOrWhiteSpace(postId.ToString()))
            {
                throw new ArgumentNullException(nameof(postId));
            }
            return await _appDbContext.PostLikes.Where(pl => pl.PostId == postId).OrderByDescending(pl => pl.Id).ToListAsync();
        }

        public PostLike GetPostLikeById(int postLikeId)
        {
            if (String.IsNullOrWhiteSpace(postLikeId.ToString()))
            {
                throw new ArgumentNullException(nameof(postLikeId));
            }
            return _appDbContext.PostLikes.FirstOrDefault(l => l.Id == postLikeId);
        }

        public async Task<List<PostLike>> LikePostAsync(PostLike postLike)
        {
            if (postLike == null)
            {
                throw new ArgumentNullException(nameof(postLike));
            }
            await _appDbContext.PostLikes.AddAsync(postLike);
            await SaveAsync();
            return await GetLikesForPost(postLike.PostId);
        }

        public async Task<bool> PostLikeExists(int postId, string userId)
        {
            Log.Information("PostId: {@PostId}, UserId: {@UserId}", postId, userId);
            var result = await _appDbContext.PostLikes
                .AnyAsync(l =>
                l.ApplicationUserId == userId
                && l.PostId == postId);
            Log.Information("PostLikeExists: {@PostLikeExists}", result);
            if (result)
            {
                return (result);
            }
            return false;
        }

        public async Task<bool> SaveAsync()
        {
            int result = await _appDbContext.SaveChangesAsync();
            return (result >= 0);
        }

        public void UnlikePost(PostLike postLike)
        {
            if (postLike == null)
            {
                throw new ArgumentNullException(nameof(postLike));
            }
            _appDbContext.PostLikes.Remove(postLike);
        }
    }
}