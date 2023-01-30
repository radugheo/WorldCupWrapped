using Microsoft.AspNetCore.Mvc;
using WorldCupWrapped.Helpers.Seeders;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repositories.CityRepository;
using WorldCupWrapped.Services.CityService;

namespace WorldCupWrapped.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        public readonly ICityService _cityService;
        public readonly ICityRepository _cityRepository;
        //

        public CityController(ICityService cityService, ICityRepository cityRepository)
        {
            _cityService = cityService;
            _cityRepository = cityRepository;
        }

        [HttpGet("get-all-cities")]
        public async Task<IActionResult> GetAllCities()
        {
            var cities = await _cityRepository.GetAllCities();
            System.Diagnostics.Debug.WriteLine("controller city");
            return Ok(cities);
        }

        [HttpDelete("delete-all-cities")]
        public async Task<IActionResult> DeleteAllCities()
        {
            _cityService.DeleteAll();
            return Ok();
        }

    }
}
