using Microsoft.AspNetCore.Mvc;
using Service.Services.Interfaces;

namespace App_API.Controllers.UI
{
    public class CountryController : BaseController
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _countryService.GetAllAsync());
        }
    }
}
