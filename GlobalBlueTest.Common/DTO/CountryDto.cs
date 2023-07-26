namespace GlobalBlueTest.Common.DTO
{
    public class CountryVatRateDto
    {
        public string? Country { get; set; }
        public List<int> VatRates { get; set; }

        public CountryVatRateDto(string country)
        {
            Country = country;
            VatRates = new List<int>();
        }
    }
}
