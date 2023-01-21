using Microsoft.AspNetCore.Mvc;
using WorldCupWrapped.Services.RefereeService;

namespace WorldCupWrapped.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefereeController : ControllerBase
    {
        public readonly IRefereeService _RefereeService;
        public RefereeController(IRefereeService trophyService)
        {
            _RefereeService = trophyService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllReferees()
        {
            var trophies = await _RefereeService.GetAllReferees();
            return Ok(trophies);
        }
    }
}
