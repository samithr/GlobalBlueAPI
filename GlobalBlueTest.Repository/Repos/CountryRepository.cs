using GlobalBlueTest.Common.DTO;
using GlobalBlueTest.Repository.Contracts;

namespace GlobalBlueTest.Repository.Repos
{
    public class CountryRepository : ICountryRepository
    {

        public async Task<IEnumerable<CountryVatRateDto>> GetCountryVatRates()
        {
            var response = new List<CountryVatRateDto>();
            var austriaVatRates = new List<int>() { 5, 10, 15 };
            var austria = new CountryVatRateDto("Austria");
            austria.VatRates = austriaVatRates;
            response.Add(austria);

            var unitedKingdomVatRates = new List<int>() { 5, 20 };
            var unitedKingdom = new CountryVatRateDto("United Kingdom");
            unitedKingdom.VatRates = unitedKingdomVatRates;
            response.Add(unitedKingdom);

            var portugalVatRates = new List<int>() { 6, 13, 23 };
            var portugal = new CountryVatRateDto("Portugal");
            portugal.VatRates = portugalVatRates;
            response.Add(portugal);

            var singaporeVatRates = new List<int>() { 7 };
            var singapore = new CountryVatRateDto("Singapore");
            singapore.VatRates = singaporeVatRates;
            response.Add(singapore);
            return await Task.FromResult(response);
        }
    }
}
