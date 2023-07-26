using GlobalBlueTest.API.ApiResponses;
using GlobalBlueTest.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace GlobalBlueGlobalBlueTest.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> CountryVatRates()
        {
            var response = await _countryService.GetCountryVatRates();
            if (!response.IsError)
            {
                return Ok(new OkResponse(response.Message, response.Result));
            }
            else
            {
                return BadRequest(new InternalServerErrorResponse(response.Message, response.Result));
            }
        }
    }
}
