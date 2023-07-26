using GlobalBlueTest.Repository.Repos;
using GlobalBlueTest.Service.Contracts;
using GlobalBlueTest.Service.Shared;
using System.Threading.Tasks;

namespace GlobalBlueTest.UnitTest.Services
{
    internal class CountryServiceTest : ICountryService
    {

        public async Task<ServiceResponse> GetCountryVatRates()
        {
            var countryRepository = new CountryRepository();
            var countryVatRates = await countryRepository.GetCountryVatRates();
            return new ServiceResponse(ApiResponseCodes.Success, false, ApiResponseCodes.Success.ToString(), countryVatRates);
        }
    }
}
