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
        [HttpGet]
        [Route("UpdateTeams")]
        public async Task<IActionResult> UpdateTeams()
        {
            await _teamService.UpdateTeams();
            return Ok();
        }
    }
}
