using AutoMapper;
using ZiekenFonds.API.Dto.Activiteit;
using ZiekenFonds.API.Models;

namespace ZiekenFonds.API.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            //Hier de mappings met CreateMap<>()
            CreateMap<Activiteit, ActiviteitOphalenDto>();
            CreateMap<ActiviteitMakenDto, Activiteit>();
        }
    }
}
