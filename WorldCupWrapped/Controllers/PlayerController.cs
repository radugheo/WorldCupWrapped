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
        public IActionResult GetAllPlayers()
        {
            return Ok(_playerService.GetAllPlayers());
        }
    }
}
