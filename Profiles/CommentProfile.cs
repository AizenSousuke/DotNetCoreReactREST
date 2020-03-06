using AutoMapper;
using DotNetCoreReactREST.Dtos.Comment;
using DotNetCoreReactREST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Profiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentDto>();
            CreateMap<CommentForCreationDto, Comment>();
            CreateMap<CommentForUpdateDto, Comment>();

        }
    }
}
