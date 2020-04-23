using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreReactREST.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext _context;

        public CommentRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        public async Task AddComment(Comment comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }
            comment.DateCreated = DateTime.Now;
            await _context.Comments.AddAsync(comment);
        }

        public async Task<bool> CommentExists(int commentId)
        {
            if (string.IsNullOrEmpty(commentId.ToString()))
            {
                throw new ArgumentNullException(nameof(commentId));
            }
            return await _context.Comments.AnyAsync(c => c.Id == commentId);
        }

        public void DeleteComment(Comment comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }
            _context.Comments.Remove(comment);
        }

        public async Task<Comment> GetCommentById(int commentId)
        {
            if (string.IsNullOrWhiteSpace(commentId.ToString()))
            {
                throw new ArgumentNullException(nameof(commentId));
            }
            return await _context.Comments
                .Include(c => c.ApplicationUser)
                .Include(c => c.Likes)
                .FirstOrDefaultAsync(c => c.Id == commentId);
        }

        public async Task<IEnumerable<Comment>> GetCommentsForPost(int postId)
        {
            return await _context.Comments
                .Where(c => c.PostId == postId)
                .Include(c => c.ApplicationUser)
                .OrderBy(c => c.Likes.Count())
                .ThenByDescending(c => c.DateCreated)
                .ToListAsync();
        }

        public async Task<IEnumerable<Comment>> GetCommentsForUser(string userId)
        {
            return await _context.Comments
                .Where(c => c.ApplicationUserId == userId)
                .Include(c => c.ApplicationUser)
                .Include(c => c.Likes)
                .OrderByDescending(c => c.DateCreated)
                .ToListAsync();
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() >= 0;
        }

        public void UpdateComment(Comment comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }
            _context.Comments.Update(comment);
        }
    }
}