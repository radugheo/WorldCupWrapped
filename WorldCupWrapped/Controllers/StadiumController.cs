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
    }
}
