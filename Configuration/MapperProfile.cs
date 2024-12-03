using AutoMapper;
using ZiekenFonds.API.Dto.Bestemming;
using ZiekenFonds.API.Dto.Activiteit;
using ZiekenFonds.API.Models;

namespace ZiekenFonds.API.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
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
