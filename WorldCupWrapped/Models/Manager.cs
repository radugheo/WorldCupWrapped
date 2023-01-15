using Lab3_14.Models.Base;

namespace WorldCupWrapped.Models
{
    public class Manager : BaseEntity
    {
        public string Name { get; set; }
        public string Nationality { get; set; }
        public int Age { get; set; }
        public Team Team { get; set; }
    }
}
