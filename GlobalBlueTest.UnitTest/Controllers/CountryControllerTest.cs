using GlobalBlueTest.Common.DTO;
using GlobalBlueTest.Service.Contracts;
using GlobalBlueTest.UnitTest.Services;
using System.Collections.Generic;
using Xunit;

namespace GlobalBlueTest.UnitTest.Controllers
{
    public class CountryControllerTest
    {
        private readonly ICountryService _countryService;

        public CountryControllerTest()
        {
            _countryService = new CountryServiceTest();
        }

        [Fact]
        public async void GetCountryVatRates()
        {
            // Arrange
            var data = await _countryService.GetCountryVatRates();

            // Act
            var countryVatRates = new List<CountryVatRateDto>((IEnumerable<CountryVatRateDto>)data.Result);

            // Assert
            Assert.Equal(4, countryVatRates.Count);
        }
    }
}
