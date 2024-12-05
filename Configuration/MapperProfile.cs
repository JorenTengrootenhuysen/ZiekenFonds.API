using AutoMapper;
using ZiekenFonds.API.Dto.Activiteit;
using ZiekenFonds.API.Dto.Onkosten;
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
            CreateMap<ActiviteitUpdateDto, Activiteit>();

            //Onkosten 
            CreateMap<Onkosten, GetOnkostenDto>();
            CreateMap<CreateOnkostenDto, Onkosten>();
            CreateMap<UpdateOnkostenDto, Onkosten>();
        }
    }
}
