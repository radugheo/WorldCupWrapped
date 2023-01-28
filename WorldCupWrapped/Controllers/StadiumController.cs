using Microsoft.AspNetCore.Mvc;
using WorldCupWrapped.Services.StadiumService;

namespace WorldCupWrapped.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiumController : ControllerBase
    {
        public readonly IStadiumService _stadiumService;
        public StadiumController(IStadiumService stadiumService)
        {
            _stadiumService = stadiumService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllStadiums()
        {
            var stadiums = await _stadiumService.GetAllStadiums();
            return Ok(stadiums);
        }
        [HttpGet("{city}")]
        public async Task<IActionResult> GetStadiumsByCity(string city)
        {
            var stadiums = await _stadiumService.GetStadiumsByCity(city);
            return Ok(stadiums);
        }
        [HttpDelete("delete-all-stadiums")]
        public async Task<IActionResult> DeleteAllStadiums()
        {
            _stadiumService.DeleteAll();
            return Ok();
        }
    }
}
