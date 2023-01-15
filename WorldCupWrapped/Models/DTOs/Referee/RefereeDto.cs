using WorldCupWrapped.Models.DTOs.Match;

namespace WorldCupWrapped.Models.DTOs.Referee
{
    public class RefereeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public ICollection<MatchDto> Matches { get; set; }
    }
}
