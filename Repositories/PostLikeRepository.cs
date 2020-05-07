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
    public class PostLikeRepository : IPostLikeRepository
    {
        private readonly AppDbContext _appDbContext;

        public PostLikeRepository(AppDbContext context)
        {
            _appDbContext = context;
        }

        public async Task<List<PostLike>> GetLikesForPost(int postId)
        {
            if (string.IsNullOrWhiteSpace(postId.ToString()))
            {
                throw new ArgumentNullException(nameof(postId));
            }

            return await _appDbContext.PostLikes.Where(pl => pl.PostId == postId).OrderByDescending(pl => pl.Id).ToListAsync();
        }

        public async Task<PostLike> GetPostLikeById(int postLikeId)
        {
            if (string.IsNullOrWhiteSpace(postLikeId.ToString()))
            {
                throw new ArgumentNullException(nameof(postLikeId));
            }

            return await _appDbContext.PostLikes.FirstOrDefaultAsync(l => l.Id == postLikeId);
        }

        public async Task<PostLike> LikePostAsync(PostLike postLike)
        {
            if (postLike == null)
            {
                throw new ArgumentNullException(nameof(postLike));
            }

            await _appDbContext.PostLikes.AddAsync(postLike);
            bool isSaved = await SaveAsync();
            if (!isSaved)
            {
                return null;
            }

            return await GetPostLikeById(postLike.PostId);
        }

        public async Task<PostLike> PostLikeExists(int postId, string userId)
        {
            Log.Information("PostId: {@PostId}, UserId: {@UserId}", postId, userId);
            PostLike result = await _appDbContext.PostLikes
                .FirstOrDefaultAsync(l =>
                l.ApplicationUserId == userId
                && l.PostId == postId);
            Log.Information("PostLikeExists: {@PostLikeExists}", result);
            if (result == null)
            {
                return null;
            }

            return result;
        }

        public PostLike UnlikePost(PostLike postLike)
        {
            if (postLike == null)
            {
                throw new ArgumentNullException(nameof(postLike));
            }

            postLike.IsLiked = false;
            return postLike;
        }

        public async Task<bool> SaveAsync()
        {
            return await _appDbContext.SaveChangesAsync() > 0;
        }
    }
}