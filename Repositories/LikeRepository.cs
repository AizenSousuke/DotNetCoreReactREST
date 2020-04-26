using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Serilog;

namespace DotNetCoreReactREST.Repositories
{
    public class LikeRepository : ILikeRepository
    {
        private readonly AppDbContext _context;

        public LikeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Like> GetLikeById(int likeId)
        {
            if (string.IsNullOrWhiteSpace(likeId.ToString()))
            {
                throw new ArgumentNullException(nameof(likeId));
            }

            return await _context.Likes.FirstOrDefaultAsync(like => like.Id == likeId);
        }

        public async Task<IEnumerable<Like>> GetLikesForComment(int commentId)
        {
            if (string.IsNullOrWhiteSpace(commentId.ToString()))
            {
                throw new ArgumentNullException(nameof(commentId));
            }

            return await _context.Likes.Where(l => l.CommentId == commentId).OrderByDescending(l => l.Id).ToListAsync();
        }

        public async Task<Like> LikeComment(Like like)
        {
            if (like == null)
            {
                throw new ArgumentNullException(nameof(like));
            }

            await _context.Likes.AddAsync(like);
            bool results = await SaveAsync();
            if (results)
            {
                return await _context.Likes.FirstOrDefaultAsync(l => l.ApplicationUserId == like.ApplicationUserId);
            }

            return null;
        }

        public async Task<Like> LikeExists(int commentId, string userId)
        {
            Log.Information("CommentId: {@CommentId}, UserId: {@UserId}", commentId, userId);
            Like result = await _context.Likes
                .FirstOrDefaultAsync(like =>
                like.ApplicationUserId == userId
                && like.CommentId == commentId);
            Log.Information("CommentLikeExists: {@CommentLikeExists}", result);
            if (result != null)
            {
                return result;
            }

            return null;
        }

        public Like UnlikeComment(Like like)
        {
            if (like == null)
            {
                throw new ArgumentNullException(nameof(like));
            }

            like.IsLiked = false;
            return like;
        }

        public async Task<bool> SaveAsync()
        {
            int result = await _context.SaveChangesAsync();
            return result >= 0;
        }
    }
}