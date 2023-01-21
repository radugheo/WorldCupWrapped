using Microsoft.AspNetCore.Mvc;
using WorldCupWrapped.Services.MatchService;

namespace WorldCupWrapped.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        public readonly IMatchService _matchService;

        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMatches()
        {
            var matches = await _matchService.GetAllMatches();
            return Ok(matches);
        }

        [HttpGet("{group}")]
        public async Task<IActionResult> GetMatchesByGroup(string group)
        {
            var matches = await _matchService.GetMatchesByGroup(group);
            return Ok(matches);
        }
    }
}
