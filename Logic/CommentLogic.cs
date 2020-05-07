using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DotNetCoreReactREST.Logic
{
    public class CommentLogic : ICommentLogic
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentLogic(IMapper mapper, ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public async Task<CommentDto> CreateCommentAsync(CommentForCreationDto comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }

            // Map DTO to Entity
            Comment commentToAdd = _mapper.Map<Comment>(comment);

            // Add comment
            await _commentRepository.AddCommentAsync(commentToAdd);

            // Save
            bool isSaved = await _commentRepository.SaveAsync();

            if (!isSaved)
            {
                return null;
            }

            return _mapper.Map<CommentDto>(commentToAdd);
        }

        public async Task<CommentDto> DeleteCommentAsync(int commentId)
        {
            // Get comment
            Comment commentToDelete = await _commentRepository.GetCommentByIdAsync(commentId);

            if (commentToDelete == null)
            {
                return null;
            }

            // Soft delete
            commentToDelete.IsDeleted = true;

            // Update date time
            commentToDelete.DateTime = DateTime.Now;

            // Save
            bool isSaved = await _commentRepository.SaveAsync();

            if (!isSaved)
            {
                return null;
            }

            return _mapper.Map<CommentDto>(commentToDelete);
        }

        public async Task<CommentDto> EditCommentAsync(int commentId, JsonPatchDocument<Comment> patchDocument, ModelStateDictionary modelState)
        {
            Comment commentFromRepo = await _commentRepository.GetCommentByIdAsync(commentId);

            if (commentFromRepo == null)
            {
                return null;
            }

            // Undelete when deleted comment is edited
            if (commentFromRepo.IsDeleted)
            {
                commentFromRepo.IsDeleted = false;
            }

            // Apply changes
            patchDocument.ApplyTo(commentFromRepo, modelState);

            // Update date time
            commentFromRepo.DateTime = DateTime.Now;

            // Update comment
            _commentRepository.UpdateCommentAsync(commentFromRepo);

            // Save
            bool isSaved = await _commentRepository.SaveAsync();

            if (!isSaved)
            {
                return null;
            }

            return _mapper.Map<CommentDto>(commentFromRepo);
        }

        public async Task<CommentDto> GetCommentAsync(int commentId)
        {
            // Get comment
            Comment commentFromRepo = await _commentRepository.GetCommentByIdAsync(commentId);

            if (commentFromRepo == null || commentFromRepo.IsDeleted)
            {
                return null;
            }

            return _mapper.Map<CommentDto>(commentFromRepo);
        }

        public async Task<IEnumerable<CommentDto>> GetCommentsForPostAsync(int postId)
        {
            // Get comments
            IEnumerable<Comment> commentsFromRepo = await _commentRepository.GetCommentsForPostAsync(postId);

            // Return converted Enumerable Entity to Enumerable Dto comments
            return _mapper.Map<IEnumerable<CommentDto>>(commentsFromRepo);
        }

        public async Task<IEnumerable<CommentDto>> GetCommentsForUserAsync(string userId)
        {
            // Get comments
            IEnumerable<Comment> commentsFromRepo = await _commentRepository.GetCommentsForUserAsync(userId);

            // Return converted Enumerable Entity to Enumerable Dto comments
            return _mapper.Map<IEnumerable<CommentDto>>(commentsFromRepo);
        }
    }
}