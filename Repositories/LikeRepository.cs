using System;
using System.Collections.Generic;
using System.Linq;
using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;

namespace DotNetCoreReactREST.Repositories
{
    public class LikeRepository : ILikeRepository
    {
        private readonly AppDbContext _context;

        public LikeRepository(AppDbContext context)
        {
            _context = context;
        }

        public Like GetLikeById(int likeId)
        {
            if (string.IsNullOrWhiteSpace(likeId.ToString()))
            {
                throw new ArgumentNullException(nameof(likeId));
            }

            return _context.Likes.FirstOrDefault(like => like.Id == likeId);
        }

        public IEnumerable<Like> GetLikesForComment(int commentId)
        {
            if (string.IsNullOrWhiteSpace(commentId.ToString()))
            {
                throw new ArgumentNullException(nameof(commentId));
            }

            return _context.Likes;
        }

        public void LikeComment(Like like)
        {
            if (like == null)
            {
                throw new ArgumentNullException(nameof(like));
            }

            _context.Likes.Add(like);
        }

        public bool LikeExists(int commentId, string userId)
        {
            return _context.Likes
                .Any(like => like.ApplicationUserId == userId
                            && like.CommentId == commentId);
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UnlikeComment(Like like)
        {
            if (like == null)
            {
                throw new ArgumentNullException(nameof(like));
            }

            _context.Likes.Remove(like);
        }
    }
}