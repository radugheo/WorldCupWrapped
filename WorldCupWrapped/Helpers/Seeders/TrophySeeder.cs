using WorldCupWrapped.Data;
using WorldCupWrapped.Models;

namespace WorldCupWrapped.Helpers.Seeders
{
    public class TrophySeeder
    {
        public readonly ProjectContext _projectContext;

        public TrophySeeder(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public void SeedInitialTrophies(string token)
        {
            System.Diagnostics.Debug.WriteLine("a ajuns la token: " + token);
            if (!_projectContext.Trophies.Any())
            {
                var uefaEuro = new Trophy
                {
                    Name = "UEFA Euro",
                    Picture = "https://world-cup-wrapped.s3.amazonaws.com/trophies/euro.jpg",
                };
                var fifaWorldCup = new Trophy
                {
                    Name = "FIFA World Cup",
                    Picture = "https://world-cup-wrapped.s3.amazonaws.com/trophies/worldcup.jpg"
                };
                var copaAmerica = new Trophy
                {
                    Name = "Copa America",
                    Picture = "https://world-cup-wrapped.s3.amazonaws.com/trophies/copaamerica.jpg"
                };
                _projectContext.Trophies.Add(uefaEuro);
                _projectContext.Trophies.Add(fifaWorldCup);
                _projectContext.Trophies.Add(copaAmerica);
                _projectContext.SaveChanges();
            }
        }
    }
}
