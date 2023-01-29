using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorldCupWrapped.Services.PlayerService;

namespace WorldCupWrapped.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        public readonly IPlayerService _playerService;
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPlayers()
        {
            var players = await _playerService.GetAllPlayers();
            return Ok(players);
            
        }

        //delete all players
        [HttpDelete("delete-all-players")]
        public async Task<IActionResult> DeleteAllPlayers()
        {
            _playerService.DeleteAll();
            return Ok();
        }
    }
}
