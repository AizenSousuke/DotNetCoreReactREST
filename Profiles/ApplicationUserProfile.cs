using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;

namespace DotNetCoreReactREST.Profiles
{
    public class ApplicationUserProfile : Profile
    {
        public ApplicationUserProfile()
        {
            CreateMap<ApplicationUser, UserDto>();
            CreateMap<UserDto, ApplicationUser>();
            CreateMap<UserForCreationDto, ApplicationUser>();
            CreateMap<UserForUpdateDto, ApplicationUser>().ReverseMap();
            CreateMap<UserForLoginDto, ApplicationUser>();
        }
    }
}
