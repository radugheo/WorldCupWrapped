using WorldCupWrapped.Models.DTOs.Stadium;

namespace WorldCupWrapped.Models.DTOs.City
{
    public class CityDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public ICollection<StadiumDto>? Stadiums { get; set; }
    }
}
