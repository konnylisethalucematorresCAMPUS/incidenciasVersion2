using Dominio;
using AutoMapper;
using Entities;
using InsidenceAPI.Dtos;
using Api.Dtos;




namespace InsidenceAPI.Profiles;

public class MappingPofiles : Profile
    {
      public MappingPofiles(){
        CreateMap<Pais, PaisDto>().ReverseMap().ForMember(o => o.Regiones,d => d.Ignore());
        CreateMap<Region, RegionDto>().ReverseMap().ForMember(i => i.Ciudades,d => d.Ignore());
        CreateMap<Ciudad, CiudadDto>().ReverseMap();
        CreateMap<Persona, PersonDto>().ReverseMap();
        CreateMap<Incidencia, IncidenciaDto>().ReverseMap();
        CreateMap<Area, AreaDto>().ReverseMap();
        



        CreateMap<Persona, PersonaxIncidencia>().ReverseMap();
        CreateMap<Region, RegionxCiudadDto>().ReverseMap();
        CreateMap<Pais, PaisxRegion>().ReverseMap();
      }
    }
