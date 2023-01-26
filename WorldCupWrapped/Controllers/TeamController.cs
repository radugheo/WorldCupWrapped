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
        [HttpGet("{teamName}/trophies")]
        public async Task<IActionResult> GetTeamTrophies(string teamName)
        {
            var trophies = await _teamService.GetTeamTrophies(teamName);
            var result = new 
            {
                TeamName = teamName,
                Trophies = trophies
            };
            return Ok(result);
        }
        [HttpDelete("delete-all-teams")]
        public async Task<IActionResult> DeleteAllTeams()
        {
            _teamService.DeleteAll();
            return Ok();
        }
        [HttpDelete("delete-teams-by-group/{group}")]
        public async Task<IActionResult> DeleteTeamsByGroup(string group)
        {
            _teamService.DeleteTeamsByGroup(group);
            return Ok();
        }
    }
}
