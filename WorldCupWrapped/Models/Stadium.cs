using WorldCupWrapped.Models.Base;

namespace WorldCupWrapped.Models
{
    public class Stadium : BaseEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public City City { get; set; }
        public Guid CityId { get; set; }
        public ICollection<Match>? Matches { get; set; }
        public int FoundationYear { get; set; }
        public string Picture { get; set; }
    }
}
