using AutoMapper;
using ZiekenFonds.API.Dto.Activiteit;
using ZiekenFonds.API.Dto.Kind;
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

            CreateMap<Kind, KindOphalenDto>().ForMember(dest => dest.OuderNaam,
                opt => opt.MapFrom(src => $"{src.Persoon.Voornaam} {src.Persoon.Naam}")); ;
            CreateMap<KindMakenDto, Kind>()
                .ForMember(dest => dest.PersoonId, opt => opt.MapFrom(src => src.PersoonId))
                .ReverseMap(); // Koppel PersoonId
            CreateMap<KindUpdateDto, Kind>()
                .ReverseMap();
        }
    }
}
