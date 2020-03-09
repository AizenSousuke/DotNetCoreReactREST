using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Profiles
{
    public class LikeProfile: Profile
    {
        public LikeProfile()
        {
            CreateMap<Like, LikeDto>();
        }
    }
}
