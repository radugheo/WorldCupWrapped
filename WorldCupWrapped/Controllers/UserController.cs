using Microsoft.AspNetCore.Mvc;
using WorldCupWrapped.Helpers.Attributes;
using WorldCupWrapped.Models.DTOs.User;
using WorldCupWrapped.Models.Enums;
using WorldCupWrapped.Models;
using BCryptNet = BCrypt.Net.BCrypt;
using WorldCupWrapped.Services.UserService;
using System.Runtime.CompilerServices;
using WorldCupWrapped.Data;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts;
using Microsoft.EntityFrameworkCore;

namespace WorldCupWrapped.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ProjectContext _context;

        public UsersController(IUserService userService, ProjectContext context)
        {
            _userService = userService;
            _context = context;
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
            if (await _context.Users.AnyAsync(x => x.Username == userToCreate.Username))
            {
                return BadRequest("User with the same username already exists");
            }
            await _userService.UploadProfilePictureToS3(userToCreate);
            userToCreate.Picture = "https://world-cup-wrapped.s3.amazonaws.com/profile-pictures/" + userToCreate.Username + ".png";
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
    }
}
