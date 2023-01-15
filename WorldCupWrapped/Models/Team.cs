using WorldCupWrapped.Models.Base;

namespace WorldCupWrapped.Models
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string FifaName { get; set; }
        public string Flag { get; set; }
        public string Group { get; set; }
        public string GroupRanking { get; set; }
        public string KnockoutRanking { get; set; } 
        public string TopScorer { get; set; }
        public Manager Manager { get; set; }
        public Guid ManagerId { get; set; }
        public ICollection<Player> Players { get; set; }
        public ICollection<TeamTrophy> TeamsTrophies { get; set; }
    }
}
