using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            if(comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }
            _context.Comments.Add(comment);
        }

        public bool CommentExists(int commentId)
        {
            if(String.IsNullOrEmpty(commentId.ToString()))
            {
                throw new ArgumentNullException(nameof(commentId));
            }
            return _context.Comments.Any(c => c.Id == commentId);
        }

        public void DeleteComment(Comment comment)
        {
            if(comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }
            _context.Comments.Remove(comment);
        }

        public IEnumerable<Author> GetAuthors(AuthorsResourceParameters authorsResourceParameters)
        {
            if (authorsResourceParameters == null)
            {
                throw new ArgumentNullException(nameof(authorsResourceParameters));
            }

            if (string.IsNullOrWhiteSpace(authorsResourceParameters.MainCategory)
                 && string.IsNullOrWhiteSpace(authorsResourceParameters.SearchQuery))
            {
                return GetAuthors();
            }

            var collection = _context.Authors as IQueryable<Author>;

            if (!string.IsNullOrWhiteSpace(authorsResourceParameters.MainCategory))
            {
                var mainCategory = authorsResourceParameters.MainCategory.Trim();
                collection = collection.Where(a => a.MainCategory == mainCategory);
            }

            if (!string.IsNullOrWhiteSpace(authorsResourceParameters.SearchQuery))
            {

                var searchQuery = authorsResourceParameters.SearchQuery.Trim();
                collection = collection.Where(a => a.MainCategory.Contains(searchQuery)
                    || a.FirstName.Contains(searchQuery)
                    || a.LastName.Contains(searchQuery));
            }

            return collection.ToList();
        }

        public Comment GetCommentById(int commentId)
        {
            if(String.IsNullOrWhiteSpace(commentId.ToString()))
            {
                throw new ArgumentNullException(nameof(commentId));
            }
            return _context.Comments.FirstOrDefault(c => c.Id == commentId);
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateComment(Comment comment)
        {
            if(comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }
            _context.Comments.Update(comment);
        }
    }
}
