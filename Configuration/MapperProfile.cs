
﻿using AutoMapper;
using ZiekenFonds.API.Dto.Monitor;
using Monitor = ZiekenFonds.API.Models.Monitor;
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


            //Monitor mappings
            CreateMap<Monitor, GetMonitorDto>()
                .ForMember(dest => dest.Naam, x => x.MapFrom(src => src.Persoon.Naam))
                .ForMember(dest => dest.Voornaam, x => x.MapFrom(src => src.Persoon.Voornaam))
                .ForMember(dest => dest.Email, x => x.MapFrom(src => src.Persoon.Email))
                .ForMember(dest => dest.Telefoonnummer, x => x.MapFrom(src => src.Persoon.TelefoonNummer));

            CreateMap<OpleidingenPersoonDto, Opleiding>()
                .ForMember(dest => dest.Naam, opt => opt.MapFrom(src => src.Opleiding.Naam));

            CreateMap<Monitor, GetMonitorDetailsDto>()
                .ForMember(dest => dest.Naam, opt => opt.MapFrom(src => $"{src.Persoon.Naam} {src.Persoon.Voornaam}"))
                .ForMember(dest => dest.Bestemmingen, opt => opt.MapFrom(src => new List<string> { src.Groepsreis.Bestemming.Naam }))
                .ForMember(dest => dest.Opleidingen, opt => opt.MapFrom(src => src.Persoon.OpleidingenPersonen.Select(o => o.Opleiding.Naam).ToList()));

            CreateMap<CreateMonitorDto, Monitor>();

            CreateMap<Activiteit, ActiviteitOphalenDto>();
            CreateMap<ActiviteitMakenDto, Activiteit>();
            CreateMap<ActiviteitUpdateDto, Activiteit>();

        }
    }
}