using WorldCupWrapped.Models.DTOs.City;
using WorldCupWrapped.Models.DTOs.Match;

namespace WorldCupWrapped.Models.DTOs.Stadium
{
    public class StadiumDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public Guid CityId { get; set; }
        public ICollection<MatchDto>? Matches { get; set; }
        public int FoundationYear { get; set; }
        public string Picture { get; set; }
    }
}
