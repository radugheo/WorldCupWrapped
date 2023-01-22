using Microsoft.AspNetCore.Mvc;
using WorldCupWrapped.Helpers.Attributes;
using WorldCupWrapped.Models.DTOs.User;
using WorldCupWrapped.Models.Enums;
using WorldCupWrapped.Models;
using BCryptNet = BCrypt.Net.BCrypt;
using WorldCupWrapped.Services.UserService;

namespace WorldCupWrapped.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("create-user")]
        public async Task<IActionResult> CreateUser(UserRequestDto user)
        {
            var userToCreate = new User
            {
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Role = Role.User,
                Email = user.Email,
                Picture = user.Picture,
                PasswordHash = BCryptNet.HashPassword(user.Password)
            };

            await _userService.Create(userToCreate);
            return Ok();
        }

        [HttpPost("create-admin")]
        public async Task<IActionResult> CreateAdmin(UserRequestDto user)
        {
            var userToCreate = new User
            {
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Role = Role.Admin,
                Email = user.Email,
                Picture = user.Picture,
                PasswordHash = BCryptNet.HashPassword(user.Password)
            };

            await _userService.Create(userToCreate);
            return Ok();
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(UserRequestDto user)
        {
            var response = _userService.Authenticate(user);
            if (response == null)
            {
                return BadRequest("Username or password is invalid!");
            }
            return Ok();
        }

        [Authorization(Role.Admin)]
        [HttpGet("admin")]
        public IActionResult GetAllAdmin()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        [Authorization(Role.User)]
        [HttpGet("user")]
        public IActionResult GetAllUser()
        {
            return Ok("User");
        }
    }
}
