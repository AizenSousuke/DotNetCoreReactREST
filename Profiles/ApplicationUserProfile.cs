﻿using AutoMapper;
using DotNetCoreReactREST.Dtos.User;
using DotNetCoreReactREST.Entities;

namespace DotNetCoreReactREST.Profiles
{
    public class ApplicationUserProfile : Profile
    {
        public ApplicationUserProfile()
        {
            CreateMap<ApplicationUser, UserDto>();
            CreateMap<UserForCreationDto, ApplicationUser>();
            CreateMap<UserForUpdateDto, ApplicationUser>().ReverseMap();
        }
    }
}
