using WorldCupWrapped.Models;

namespace WorldCupWrapped.Helpers.JwtUtilsHelpers
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(User user);
        public Guid ValidateJwtToken(string token);
    }
}
