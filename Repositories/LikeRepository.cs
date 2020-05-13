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
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Like> GetLikeByIdAsync(int likeId)
        {
            return await _context.Likes.FirstOrDefaultAsync(like => like.Id == likeId);
        }

        public async Task<IEnumerable<Like>> GetLikesForCommentAsync(int commentId)
        {
            return await _context.Likes
                .Where(l => l.CommentId == commentId)
                .OrderByDescending(l => l.Id)
                .ToListAsync();
        }

        public async Task<Like> LikeCommentAsync(Like like)
        {
            if (like == null)
            {
                throw new ArgumentNullException(nameof(like));
            }

            await _context.Likes.AddAsync(like);
            bool isSaved = await SaveAsync();
            if (!isSaved)
            {
                return null;
            }

            return like;
        }

        public async Task<Like> LikeExistsAsync(int commentId, string userId)
        {
            Log.Information("CommentId: {@CommentId}, UserId: {@UserId}", commentId, userId);
            Like like = await _context.Likes
                .FirstOrDefaultAsync(like =>
                    like.ApplicationUserId == userId
                    && like.CommentId == commentId);
            Log.Information("CommentLikeExists: {@CommentLikeExists}", like);
            if (like == null)
            {
                return null;
            }

            return like;
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
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
    }
}