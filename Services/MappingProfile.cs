using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Common.Dtos;
using Repositories.Entities;
using Common;

namespace Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            CreateMap<Detail, DetailDto>().ReverseMap();
            CreateMap<Child, ChildDto>().ReverseMap();
           
        }
    }
}
