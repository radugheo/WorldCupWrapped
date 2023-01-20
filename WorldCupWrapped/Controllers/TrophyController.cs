using Microsoft.AspNetCore.Mvc;
using WorldCupWrapped.Services.TrophyService;

namespace WorldCupWrapped.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrophyController : ControllerBase
    {
        public readonly ITrophyService _trophyService;
        public TrophyController(ITrophyService trophyService)
        {
            _trophyService = trophyService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTrophies()
        {
            var trophies = await _trophyService.GetAllTrophies();
            return Ok(trophies);
        }
    }
}
