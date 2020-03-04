using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Models;

namespace DotNetCoreReactREST.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDto>();
        }
    }
}
