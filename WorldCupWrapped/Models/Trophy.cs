using WorldCupWrapped.Models.Base;

namespace WorldCupWrapped.Models
{
    public class Trophy : BaseEntity
    {
        public string Name { get; set; }
        public string Picture { get; set; }
        public ICollection<TeamTrophy>? TeamsTrophies { get; set; }
    }
}
