using WorldCupWrapped.Data;
using WorldCupWrapped.Models;

namespace WorldCupWrapped.Helpers.Seeders
{
    public class RefereeSeeder
    {
        public readonly ProjectContext _projectContext;

        public RefereeSeeder(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public void SeedInitialReferees()
        {
            if (!_projectContext.Referees.Any())
            {
                List<Referee> arbitri = new List<Referee>
                {
                    new Referee() { Name = "Abdulrahman Al-Jassim", Nationality = "Qatar" },
                    new Referee() {Name = "Chris Beath", Nationality = "Australia"},
                    new Referee() {Name = "Alireza Faghani", Nationality = "Iran"},
                    new Referee() {Name = "Ma Ning", Nationality = "China"},
                    new Referee() {Name = "Mohammed Abdulla Hassan", Nationality = "United Arab Emirates"},
                    new Referee() {Name = "Yoshimi Yamashita", Nationality = "Japan"},
                    new Referee() {Name = "Bakary Gassama", Nationality = "Gambia"},
                    new Referee() {Name = "Mustapha Ghorbal", Nationality = "Algeria"},
                    new Referee() {Name = "Victor Gomes", Nationality = "South Africa"},
                    new Referee() {Name = "Maguette Ndiaye", Nationality = "Senegal"},
                    new Referee() {Name = "Janny Sikazwe", Nationality = "Zambia"},
                    new Referee() {Name = "Salima Mukansanga", Nationality = "Rwanda"},
                    new Referee() {Name = "Ivan Barton", Nationality = "El Salvador"},
                    new Referee() {Name = "Ismail Elfath", Nationality = "United States of America"},
                    new Referee() {Name = "Mario Escobar", Nationality = "Guatemala"},
                    new Referee() {Name = "Said Martinez", Nationality = "Honduras"},
                    new Referee() {Name = "Cesar Arturo Ramos", Nationality = "Mexico"},
                    new Referee() {Name = "Raphael Claus", Nationality = "Brazil"},
                    new Referee() {Name = "Andres Matonte", Nationality = "Uruguay"},
                    new Referee() {Name = "Kevin Ortega", Nationality = "Peru"},
                    new Referee() {Name = "Fernando Rapallini", Nationality = "Argentina"},
                    new Referee() {Name = "Facundo Tello", Nationality = "Argentina"},
                    new Referee() {Name = "Jesus Valenzuela", Nationality = "Venezuela"},
                    new Referee() {Name = "Wilton Sampaio", Nationality = "Brazil"},
                    new Referee() {Name = "Matthew Conger", Nationality = "New Zealand"},
                    new Referee() {Name = "Istvan Kovacs", Nationality = "Romania"},
                    new Referee() {Name = "Danny Makkelie", Nationality = "Netherlands"},
                    new Referee() {Name = "Szymon Marciniak", Nationality = "Poland"},
                    new Referee() {Name = "Antonio Mateu Lahoz", Nationality = "Spain"},
                    new Referee() {Name = "Michael Oliver", Nationality = "England"},
                    new Referee() {Name = "Daniele Orsato", Nationality = "Italy"},
                    new Referee() {Name = "Daniel Siebert", Nationality = "Germany"},
                    new Referee() {Name = "Anthony Taylor", Nationality = "England"},
                    new Referee() {Name = "Clement Turpin", Nationality = "France"},
                    new Referee() {Name = "Slavko Vincic", Nationality = "Slovenia"},
                    new Referee() {Name = "Stéphanie Frappart", Nationality ="France"},
                };

                for(int i = 0; i < arbitri.Count(); i++)
                {
                    _projectContext.Referees.Add(arbitri[i]);
                }
                _projectContext.SaveChanges();
            }
        }
    }
}
