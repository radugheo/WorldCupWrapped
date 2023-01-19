using Microsoft.AspNetCore.Mvc;
using WorldCupWrapped.Services.PlayerService;
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
        public IActionResult GetAllTrophies()
        {
            return Ok(_trophyService.GetAllTrophies());
        }
    }
}
