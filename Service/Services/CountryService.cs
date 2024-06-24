using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interfaces;
using Service.DTOs.Countries;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public CountryService(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(CountryCreateDto request)
        {
            if(request is null) throw new ArgumentException();
            await _countryRepository.CreateAsync(_mapper.Map<Country>(request));
        }

        public async Task DeleteAsync(int id)
        {
            var country = await _countryRepository.GetByIdAsync(id);
            await _countryRepository.DeleteAsync(country);
        }

        public async Task EditAsync(Country country,CountryEditDto request)
        {
            _mapper.Map(request, country);
            await _countryRepository.UpdateAsync(country);
        }

        public async Task<IEnumerable<CountryDto>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<CountryDto>>(await _countryRepository.GetAllAsync());
        }

        public async Task<Country> GetById(int id)
        {
            return await _countryRepository.GetByIdAsync(id);
        }
    }
}
