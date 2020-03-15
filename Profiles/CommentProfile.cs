using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using System.Linq;

namespace DotNetCoreReactREST.Profiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentDto>()
           .ForMember(
                    dest => dest.LikesCount,
                    opt => opt.MapFrom(src => src.Likes.Count()));

            CreateMap<CommentForCreationDto, Comment>();
            CreateMap<CommentForUpdateDto, Comment>();

        }
    }
}
