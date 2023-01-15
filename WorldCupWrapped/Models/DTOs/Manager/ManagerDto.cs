using WorldCupWrapped.Models.DTOs.Team;

namespace WorldCupWrapped.Models.DTOs.Manager
{
    public class ManagerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public int Age { get; set; }
        public TeamDto? Team { get; set; }
    }
}
