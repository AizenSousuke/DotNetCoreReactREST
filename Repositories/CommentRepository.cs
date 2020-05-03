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

        public async Task<Comment> AddCommentAsync(Comment comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }

            comment.DateTime = DateTime.Now;
            await _context.Comments.AddAsync(comment);
            await SaveAsync();
            Comment newComment = await _context.Comments.FirstOrDefaultAsync(c => c.DateTime == comment.DateTime);
            return await GetCommentByIdAsync(newComment.Id);
        }

        public async Task<bool> CommentExistsAsync(int commentId)
        {
            if (string.IsNullOrEmpty(commentId.ToString()))
            {
                throw new ArgumentNullException(nameof(commentId));
            }

            return await _context.Comments.AnyAsync(c => c.Id == commentId);
        }

        public async Task<Comment> DeleteCommentAsync(Comment comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }

            comment.IsDeleted = !comment.IsDeleted;
            await SaveAsync();
            return await GetCommentByIdAsync(comment.Id);
        }

        public async Task<Comment> GetCommentByIdAsync(int commentId)
        {
            if (string.IsNullOrWhiteSpace(commentId.ToString()))
            {
                throw new ArgumentNullException(nameof(commentId));
            }

            return await _context.Comments.FirstOrDefaultAsync(c => c.Id == commentId);
        }

        public async Task<IEnumerable<Comment>> GetCommentsForPostAsync(int postId)
        {
            return await _context.Comments
                .Where(c => c.PostId == postId)
                .OrderByDescending(c => c.DateTime)
                .ToListAsync();
        }

        public async Task<IEnumerable<Comment>> GetCommentsForUserAsync(string userId)
        {
            return await _context.Comments
                .Where(c => c.ApplicationUserId == userId)
                .OrderByDescending(c => c.DateTime)
                .ToListAsync();
        }

        public async Task<bool> SaveAsync()
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