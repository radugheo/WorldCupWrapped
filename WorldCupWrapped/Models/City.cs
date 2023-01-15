using WorldCupWrapped.Models.Base;

namespace WorldCupWrapped.Models
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public ICollection<Stadium>? Stadiums { get; set; }
    }
}
