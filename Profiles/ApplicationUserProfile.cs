using AutoMapper;
using DotNetCoreReactREST.Dtos.User;
using DotNetCoreReactREST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Profiles
{
    public class ApplicationUserProfile: Profile
    {
        public ApplicationUserProfile()
        {
            CreateMap<ApplicationUser, UserDto>();
            CreateMap<UserForCreationDto, ApplicationUser>();
            CreateMap<UserForUpdateDto, ApplicationUser>().ReverseMap();
        }
    }
}
