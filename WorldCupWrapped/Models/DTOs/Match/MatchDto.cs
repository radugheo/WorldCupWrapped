using WorldCupWrapped.Models.DTOs.Referee;
using WorldCupWrapped.Models.DTOs.Stadium;
using WorldCupWrapped.Models.DTOs.Team;

namespace WorldCupWrapped.Models.DTOs.Match
{
    public class MatchDto
    {
        public Guid Id { get; set; }
        public string HomeTeam { get; set; }
        public Guid HomeTeamId { get; set; }
        public string AwayTeam { get; set; }
        public Guid AwayTeamId { get; set; }
        public string Date { get; set; }
        public StadiumDto? Stadium { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public string Phase { get; set; }
        public ICollection<RefereeDto> Referees { get; set; }
    }
}
