using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;

namespace DotNetCoreReactREST.Profiles
{
    public class PostLikeProfile : Profile
    {
        public PostLikeProfile()
        {
            CreateMap<PostLike, PostLikeDto>();
            CreateMap<PostLike, PostLikeDto>().ReverseMap();
        }
    }
}