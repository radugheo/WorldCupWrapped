using Lab3_14.Models.Base;

namespace WorldCupWrapped.Models
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public ICollection<Stadium> Stadiums { get; set; }
    }
}
