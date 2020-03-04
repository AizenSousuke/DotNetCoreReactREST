using AutoMapper;
using DotNetCoreReactREST.Models;

namespace DotNetCoreReactREST.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostDto>();
        }
    }
}
