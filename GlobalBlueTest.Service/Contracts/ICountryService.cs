using GlobalBlueTest.Service.Shared;

namespace GlobalBlueTest.Service.Contracts
{
    public interface ICountryService
    {
        Task<ServiceResponse> GetCountryVatRates();
    }
}
