using AutoMapper;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Dtos
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {

            //CreateMap<Producto, ProductoDto>();

            CreateMap<Producto, ProductoDto>()
                .ForMember(p => p.MarcaNombre, x => x.MapFrom(c => c.Marca.Nombre))
                .ForMember(p => p.CategoriaNombre, x => x.MapFrom(c => c.Categoria.Nombre));
        }
    }
}
