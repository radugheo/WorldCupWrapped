using System.ComponentModel.DataAnnotations;

namespace WorldCupWrapped.Models.DTOs.User
{
    public class UserRequestDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Picture { get; set; }
    }
}
