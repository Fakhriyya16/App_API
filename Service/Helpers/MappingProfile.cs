using AutoMapper;
using Domain.Entities;
using Service.DTOs.Countries;


namespace Service.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Country, CountryDto>();
            CreateMap<CountryCreateDto, Country>();
            CreateMap<CountryEditDto, Country>();
            CreateMap<Country, CountryDetailDto>();
        }
    }
}
