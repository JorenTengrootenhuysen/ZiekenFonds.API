using AutoMapper;
using ZiekenFonds.API.Dto.Opleiding;
using ZiekenFonds.API.Dto.Bestemming;
using ZiekenFonds.API.Dto.Activiteit;
using ZiekenFonds.API.Models;

namespace ZiekenFonds.API.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // Opleiding Mappings
            CreateMap<Opleiding, OpleidingWithPersonenDto>()
                .ForMember(dest => dest.OpleidingenPersonen, opt => opt.MapFrom(src => src.OpleidingenPersonen))
                .ForMember(dest => dest.VereisteOpleidingen, opt => opt.MapFrom(src => src.VereisteOpleidingen));

            CreateMap<OpleidingPersoon, OpleidingPersoonDto>()
                .ForMember(dest => dest.Voornaam, opt => opt.MapFrom(src => $"{src.Persoon.Voornaam} {src.Persoon.Naam}"))
                .ForMember(dest => dest.OpleidingNaam, opt => opt.MapFrom(src => src.Opleiding.Naam));

            CreateMap<CreateOpleidingDto, Opleiding>()
                .ForMember(dest => dest.VereisteOpleidingen, opt => opt.MapFrom(src => src.VereisteOpleidingIds));

            CreateMap<VoorOpleidingDto, Opleiding>()
                .ReverseMap();

            CreateMap<Opleiding, CreateOpleidingDto>()
                .ReverseMap();

            CreateMap<UpdateOpleidingDto, Opleiding>()
                .ForMember(dest => dest.OpleidingenPersonen, opt => opt.MapFrom(src => src.OpleidingenPersonen));

            CreateMap<OpleidingPersoon, UpdateOpleidingPersoonDto>()
                .ReverseMap();

            CreateMap<OpleidingResponseDto, Opleiding>()
                .ReverseMap();
                
            //Bestemming controller
            CreateMap<Bestemming, AllBestemmingenDto>();
            CreateMap<Review, BestemmingWithReviews>();
            CreateMap<Foto, BestemmingWithFoto>();
            CreateMap<Groepsreis, BestemmingWithGroepsreis>();
            
            //Hier de mappings met CreateMap<>()
            CreateMap<Activiteit, ActiviteitOphalenDto>();
            CreateMap<ActiviteitMakenDto, Activiteit>();
            CreateMap<ActiviteitUpdateDto, Activiteit>();

        }
    }
}