using Lab3_14.Models.Base;

namespace WorldCupWrapped.Models
{
    public class Match : BaseEntity
    {
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public string Date { get; set; }
        public Stadium Stadium { get; set; }
        public Guid StadiumId { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public string Phase { get; set; }
        
        public ICollection<MatchReferee> MatchesReferees { get; set; }
    }
}
