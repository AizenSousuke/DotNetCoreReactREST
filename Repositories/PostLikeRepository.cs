using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetCoreReactREST.Repositories
{
    public class PostLikeRespository : IPostLikeRepository
    {
        private readonly AppDbContext _appDbContext;

        public PostLikeRespository(AppDbContext context)
        {
            _appDbContext = context;
        }

        public IEnumerable<PostLike> GetLikesForPost(int postId)
        {
            if (String.IsNullOrWhiteSpace(postId.ToString()))
            {
                throw new ArgumentNullException(nameof(postId));
            }
            return _appDbContext.PostLikes;
        }

        public void LikePost(PostLike postLike)
        {
            if (postLike == null)
            {
                throw new ArgumentNullException(nameof(postLike));
            }
            _appDbContext.PostLikes.Add(postLike);

        }

        public void UnlikePost(PostLike postLike)
        {
            if (postLike == null)
            {
                throw new ArgumentNullException(nameof(postLike));
            }
            _appDbContext.PostLikes.Remove(postLike);
        }
        public bool PostLikeExists(int postId, string userId)
        {
            return (_appDbContext.PostLikes
                .Any(l => l.ApplicationUserId == userId
                && l.Id == postId));
        }

        public bool Save()
        {
            return (_appDbContext.SaveChanges() >= 0);
        }

        public PostLike GetPostLikeById(int postLikeId)
        {
            if (String.IsNullOrWhiteSpace(postLikeId.ToString()))
            {
                throw new ArgumentNullException(nameof(postLikeId));
            }
            return _appDbContext.PostLikes.FirstOrDefault(l => l.Id == postLikeId);
        }
    }
}
