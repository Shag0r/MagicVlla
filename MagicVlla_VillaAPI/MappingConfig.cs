using AutoMapper;
using MagicVlla_VillaAPI.Models;
using MagicVlla_VillaAPI.Models.Dto;

namespace MagicVlla_VillaAPI
{
    public class MappingConfig: Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa,VillaDTO>();
            CreateMap<VillaDTO, Villa>(); 

            CreateMap<Villa,VillaCreateDTO>().ReverseMap();
            CreateMap<Villa,VillaUpdateDTO>().ReverseMap();
           
        }
    }
}
