﻿using Microsoft.AspNetCore.Mvc;
using WorldCupWrapped.Models;
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
            var referees = await _RefereeService.GetAllReferees();
            return Ok(referees);
        }
        [HttpGet("{nationality}")]
        public async Task<IActionResult> GetRefereesByNationality(string nationality)
        {
            var referees = await _RefereeService.GetRefereesByNationality(nationality);
            return Ok(referees);
        }
    }
}
