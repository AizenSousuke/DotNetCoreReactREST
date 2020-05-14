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
            await SaveAsync();
            return await _context.Likes.FirstOrDefaultAsync(l => l.ApplicationUserId == like.ApplicationUserId);
        }

        public async Task<bool> LikeExists(int commentId, string userId)
        {
            Log.Information("CommentId: {@CommentId}, UserId: {@UserId}", commentId, userId);
            bool result = await _context.Likes
                .AnyAsync(like =>
                like.ApplicationUserId == userId
                && like.CommentId == commentId);
            Log.Information("CommentLikeExists: {@CommentLikeExists}", result);
            if (result)
            {
                return result;
            }

            return false;
        }

        public void UnlikeComment(Like like)
        {
            if (like == null)
            {
                throw new ArgumentNullException(nameof(like));
            }

            _context.Likes.Remove(like);
        }

        public async Task<bool> SaveAsync()
        {
            int result = await _context.SaveChangesAsync();
            return result >= 0;
        }
    }
}