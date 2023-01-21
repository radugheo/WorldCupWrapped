using WorldCupWrapped.Data;
using WorldCupWrapped.Models;

namespace WorldCupWrapped.Helpers.Seeders
{
    public class CitySeeder
    {
        public readonly ProjectContext _projectContext;

        public CitySeeder(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public void SeedInitialCities()
        {
            if (!_projectContext.Cities.Any())
            {
                var city1 = new City
                {
                    Name = "Al Wakrah",
                    Population = 140000,
                };

                var city2 = new City
                {
                    Name = "Al Rayyan",
                    Population = 826000,
                };

                var city3 = new City
                {
                    Name = "Doha",
                    Population = 2382000,
                };

                var city4 = new City
                {
                    Name = "Al Khor",
                    Population = 193900,
                };

                var city5 = new City
                {
                    Name = "Lusail",
                    Population = 200000,
                };

                _projectContext.Cities.Add(city1);
                _projectContext.Cities.Add(city2);
                _projectContext.Cities.Add(city3);
                _projectContext.Cities.Add(city4);
                _projectContext.Cities.Add(city5);
                _projectContext.SaveChanges();

            }
        }
    }
}
