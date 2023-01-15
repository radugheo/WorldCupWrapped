using Lab3_14.Models.Base;

namespace WorldCupWrapped.Models
{
    public class Player : BaseEntity
    {
        public Team Team { get; set; }
        public Guid TeamId { get; set; }
        public string Name { get; set; }
        public int Goals { get; set; }
    }
}
