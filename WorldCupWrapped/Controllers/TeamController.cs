using Microsoft.AspNetCore.Mvc;
using WorldCupWrapped.Services.TeamService;

namespace WorldCupWrapped.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        public readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTeams()
        {
            var teams = await _teamService.GetAllTeams();
            System.Diagnostics.Debug.WriteLine("salutare!!!");
            return Ok(teams);
        }
        [HttpGet("{group}")]
        public async Task<IActionResult> GetTeamsByGroup(string group)
        {
            var teams = await _teamService.GetTeamsByGroup(group);
            return Ok(teams);
        }
        [HttpGet("{group}/{position}")]
        public async Task<IActionResult> GetTeamsByGroupAndPosition(string group, string position)
        {
            var teams = await _teamService.GetTeamsByGroupAndPosition(group, position);
            return Ok(teams);
        }
    }
}
