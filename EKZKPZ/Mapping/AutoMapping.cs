using AutoMapper;
using EKZKPZ.DTOs;
using EKZKPZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EKZKPZ.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Clothing, ClothingDTO>();
            CreateMap<ClothingDTO, Clothing>();
        }
    }
}
