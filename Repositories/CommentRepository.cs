using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetCoreReactREST.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private AppDbContext _context;

        public CommentRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }
        public void AddComment(Comment comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }
            _context.Comments.Add(comment);
        }

        public bool CommentExists(int commentId)
        {
            if (String.IsNullOrEmpty(commentId.ToString()))
            {
                throw new ArgumentNullException(nameof(commentId));
            }
            return _context.Comments.Any(c => c.Id == commentId);
        }

        public void DeleteComment(Comment comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }
            _context.Comments.Remove(comment);
        }



        public Comment GetCommentById(int commentId)
        {
            if (String.IsNullOrWhiteSpace(commentId.ToString()))
            {
                throw new ArgumentNullException(nameof(commentId));
            }
            return _context.Comments.FirstOrDefault(c => c.Id == commentId);
        }

        public IEnumerable<Comment> GetAllComments()
        {
            return _context.Comments.OrderBy(c => c.DateTime).ToList();
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
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
