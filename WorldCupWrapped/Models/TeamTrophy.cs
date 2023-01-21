namespace WorldCupWrapped.Models
{
    public class TeamTrophy
    {
        public Guid TeamId { get; set; }
        public Team Team { get; set; }
        public Guid TrophyId { get; set; }
        public Trophy Trophy { get; set; }
        public int Count { get; set; }
    }
}
