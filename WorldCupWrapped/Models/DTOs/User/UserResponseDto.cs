namespace WorldCupWrapped.Models.DTOs.User
{
    using WorldCupWrapped.Models;
    public class UserResponseDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Picture { get; set; }
        public string Token { get; set; }
        public UserResponseDto(User user, string token)
        {
            Id = user.Id;
            Username = user.Username;
            Email = user.Email;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Picture = user.Picture;
            Token = token;
        }
    }
}
