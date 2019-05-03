using BrqWebApi.Dtos;
using BrqWebApi.Models;
using AutoMapper;

namespace BrqWebApi.Infra
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Usuarios, LoginDto>();
            CreateMap<LoginDto, Usuarios>();
        }
    }
}