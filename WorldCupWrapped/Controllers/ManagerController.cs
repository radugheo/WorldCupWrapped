using Microsoft.AspNetCore.Mvc;
using WorldCupWrapped.Helpers.Seeders;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repositories.ManagerRepository;
using WorldCupWrapped.Services.ManagerService;

namespace WorldCupWrapped.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        public readonly IManagerService _managerService;
        public readonly IManagerRepository _managerRepository;
        //
        
        public ManagerController(IManagerService managerService, IManagerRepository managerRepository)
        {
            _managerService = managerService;
            _managerRepository = managerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllManagers()
        {
            var managers = await _managerRepository.GetAllManagers();
            System.Diagnostics.Debug.WriteLine("controller manager");
            return Ok(managers);
        }

        //return the list of managers with the function from seeder

    }
}
