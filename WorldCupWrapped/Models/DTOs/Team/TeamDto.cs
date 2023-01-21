using WorldCupWrapped.Models.DTOs.Manager;
using WorldCupWrapped.Models.DTOs.Player;
using WorldCupWrapped.Models.DTOs.Trophy;

namespace WorldCupWrapped.Models.DTOs.Team
{
    public class TeamDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FifaName { get; set; }
        public string Flag { get; set; }
        public string Group { get; set; }
        public string GroupRanking { get; set; }
        public string KnockoutRanking { get; set; }
        public string TopScorer { get; set; }
        public Guid ManagerId { get; set; }
        public ICollection<PlayerDto> Players { get; set; }
        public ICollection<TrophyDto> Trophies { get; set; }

    }
}
