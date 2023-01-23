using System.Text.Json.Serialization;
using WorldCupWrapped.Models.Base;
using WorldCupWrapped.Models.Enums;

namespace WorldCupWrapped.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        [JsonIgnore]
        public string PasswordHash { get; set; }
        public string Picture { get; set; }
        public Role Role { get; set; }
    }
}
