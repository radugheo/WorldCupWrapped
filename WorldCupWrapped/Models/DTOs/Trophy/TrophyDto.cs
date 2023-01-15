using WorldCupWrapped.Models.DTOs.Team;

namespace WorldCupWrapped.Models.DTOs.Trophy
{
    public class TrophyDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public ICollection<TeamDto>? Teams { get; set; }
    }
}
