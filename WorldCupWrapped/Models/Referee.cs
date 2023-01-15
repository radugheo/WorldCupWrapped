using Lab3_14.Models.Base;

namespace WorldCupWrapped.Models
{
    public class Referee : BaseEntity
    {
        public string Name { get; set; }
        public string Nationality { get; set; }
        public ICollection<MatchReferee> MatchesReferees { get; set; }
    }
}
