﻿using AutoMapper;
using MagicVilla_Web_new.Models.Dto;

namespace MagicVilla_Web_new
{
    public class MappingConfig: Profile
    {
        public MappingConfig()  
        {

            CreateMap<VillaDTO, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaDTO, VillaUpdateDTO>().ReverseMap();


            CreateMap<VillaNumberDTO, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumberUpdateDTO>().ReverseMap();
        }
    }
}
