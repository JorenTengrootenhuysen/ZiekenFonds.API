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

            CreateMap<Kind, GetKind>()
                .ForMember(dest => dest.OuderNaam, opt => opt.MapFrom(src => src.Persoon.Naam))
                .ForMember(dest => dest.OuderVoornaam, opt => opt.MapFrom(src => src.Persoon.Voornaam))
                .ReverseMap();
            CreateMap<CreateKind, Kind>()
                .ForMember(dest => dest.PersoonId, opt => opt.MapFrom(src => src.PersoonId))
                .ReverseMap();
            CreateMap<UpdateKind, Kind>()
                .ReverseMap();
        }
    }
}
