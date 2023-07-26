using GlobalBlueTest.Repository.Contracts;
using GlobalBlueTest.Service.Contracts;
using GlobalBlueTest.Service.Shared;

namespace GlobalBlueTest.Service.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<ServiceResponse> GetCountryVatRates()
        {
            var countryVatRates = await _countryRepository.GetCountryVatRates();
            return new ServiceResponse(ApiResponseCodes.Success, false, ApiResponseCodes.Success.ToString(), countryVatRates);
        }
    }
}
