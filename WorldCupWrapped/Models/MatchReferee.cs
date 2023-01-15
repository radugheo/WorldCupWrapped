namespace WorldCupWrapped.Models
{
    public class MatchReferee
    {
        public Guid MatchId { get; set; }
        public Match Match { get; set; }
        public Guid RefereeId { get; set; }
        public Referee Referee { get; set; }
    }
}
