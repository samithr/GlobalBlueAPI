using GlobalBlueTest.Common.DTO;

namespace GlobalBlueTest.Repository.Contracts
{
    public interface ICountryRepository
    {
        Task<IEnumerable<CountryVatRateDto>> GetCountryVatRates();
    }
}
