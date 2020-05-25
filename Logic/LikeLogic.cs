using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;

namespace DotNetCoreReactREST.Logic
{
    public class LikeLogic : ILikeLogic
    {
        private readonly ILikeRepository _likeRepository;
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepository;

        public LikeLogic(IMapper mapper, ILikeRepository likeRepository, ICommentRepository commentRepository)
        {
            _likeRepository = likeRepository;
            _mapper = mapper;
            _commentRepository = commentRepository;
        }

        public async Task<IEnumerable<LikeDto>> GetLikesForCommentAsync(int commentId)
        {
            bool exists = await _commentRepository.CommentExistsAsync(commentId);

            if (!exists)
            {
                return null;
            }

            IEnumerable<Like> likes = await _likeRepository.GetLikesForCommentAsync(commentId);

            return _mapper.Map<List<LikeDto>>(likes);
        }

        public async Task<LikeDto> LikeCommentAsync(int commentId, string userId)
        {
            // Check comment exists
            bool commentExists = await _commentRepository.CommentExistsAsync(commentId);
            if (!commentExists)
            {
                return null;
            }

            // Like is unique to user, so none should exist
            Like existingLike = await _likeRepository.LikeExistsAsync(commentId, userId);
            if (existingLike != null)
            {
                // Change the isLiked property by toggling
                existingLike.IsLiked = false;

                bool isSaved = await _likeRepository.SaveAsync();
                if (!isSaved)
                {
                    return null;
                }

                return _mapper.Map<LikeDto>(existingLike);
            }

            // If Like doesn't exists, create new one
            Like like = await _likeRepository.LikeCommentAsync(new Like { CommentId = commentId, ApplicationUserId = userId, IsLiked = true });
            if (like == null)
            {
                return null;
            }

            return _mapper.Map<LikeDto>(like);
        }
         
        public async Task<LikeDto> UnlikeCommentAsync(int likeId)
        {
            Like like = await _likeRepository.GetLikeByIdAsync(likeId);
            if (like == null)
            {
                return null;
            }

            _likeRepository.UnlikeComment(like);

            bool isSaved = await _likeRepository.SaveAsync();

            if (!isSaved)
            {
                return null;
            }

            return _mapper.Map<LikeDto>(like);
        }
    }
}
