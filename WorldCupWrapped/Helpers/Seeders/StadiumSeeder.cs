using WorldCupWrapped.Data;
using WorldCupWrapped.Models;

namespace WorldCupWrapped.Helpers.Seeders
{
    public class StadiumSeeder
    {
        public readonly ProjectContext _projectContext;
 
        public StadiumSeeder(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        public void SeedInitialStadiums()
        {
            if (!_projectContext.Stadiums.Any())
            {
                var stadium1 = new Stadium
                {
                    Name = "Lusail Stadium",
                    Capacity = 80000,
                    CityId = _projectContext.Cities.FirstOrDefault(c => c.Name == "Lusail").Id,
                    FoundationYear = 2022,
                    Picture = "https://www.stadiumguide.com/wp-content/uploads/lusail2022.jpg"
                };

                var stadium2 = new Stadium
                {
                    Name = "Al Bayt Stadium",
                    Capacity = 60000,
                    CityId = _projectContext.Cities.FirstOrDefault(c => c.Name == "Al Khor").Id,
                    FoundationYear = 2021,
                    Picture = "https://www.stadiumguide.com/wp-content/uploads/albayt_top.jpg"
                };

                var stadium3 = new Stadium
                {
                    Name = "Al Janoub Stadium",
                    Capacity = 40000,
                    CityId = _projectContext.Cities.FirstOrDefault(c => c.Name == "Al Wakrah").Id,
                    FoundationYear = 2019,
                    Picture = "https://www.stadiumguide.com/wp-content/uploads/alwakrah_top.jpg"
                };

                var stadium4 = new Stadium
                {
                    Name = "Ahmad Bin Ali Stadium",
                    Capacity = 40000,
                    CityId = _projectContext.Cities.FirstOrDefault(c => c.Name == "Al Rayyan").Id,
                    FoundationYear = 2020,
                    Picture = "https://www.stadiumguide.com/wp-content/uploads/alrayyan_top.jpg"
                };

                var stadium5 = new Stadium
                {
                    Name = "Khalifa International Stadium",
                    Capacity = 40000,
                    CityId = _projectContext.Cities.FirstOrDefault(c => c.Name == "Doha").Id,
                    FoundationYear = 1976,
                    Picture = "https://www.stadiumguide.com/wp-content/uploads/khalifanew_top.jpg"
                };

                var stadium6 = new Stadium
                {
                    Name = "Education City Stadium",
                    Capacity = 40000,
                    CityId = _projectContext.Cities.FirstOrDefault(c => c.Name == "Doha").Id,
                    FoundationYear = 2020,
                    Picture = "https://www.stadiumguide.com/wp-content/uploads/qatarfoundation_top.jpg"
                };

                var stadium7 = new Stadium
                {
                    Name = "Stadium 974",
                    Capacity = 40000,
                    CityId = _projectContext.Cities.FirstOrDefault(c => c.Name == "Doha").Id,
                    FoundationYear = 2021,
                    Picture = "https://www.stadiumguide.com/wp-content/uploads/rasabuaboud2022.jpg"
                };

                var stadium8 = new Stadium
                {
                    Name = "Al Thumama Stadium",
                    Capacity = 40000,
                    CityId = _projectContext.Cities.FirstOrDefault(c => c.Name == "Doha").Id,
                    FoundationYear = 2021,
                    Picture = "https://www.stadiumguide.com/wp-content/uploads/althumama2022.jpg"
                };

                _projectContext.Stadiums.Add(stadium1);
                _projectContext.Stadiums.Add(stadium2);
                _projectContext.Stadiums.Add(stadium3);
                _projectContext.Stadiums.Add(stadium4);
                _projectContext.Stadiums.Add(stadium5);
                _projectContext.Stadiums.Add(stadium6);
                _projectContext.Stadiums.Add(stadium7);
                _projectContext.Stadiums.Add(stadium8);
                _projectContext.SaveChanges();
                
            }
        }
    }
}
