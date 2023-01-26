using WorldCupWrapped.Data;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repositories.ManagerRepository;

namespace WorldCupWrapped.Helpers.Seeders
{
    public class ManagerSeeder
    {
        public readonly ProjectContext _projectContext;

        public ManagerSeeder(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public void SeedInitialManagers()
        {
            if (!_projectContext.Managers.Any())
            {
                List<Manager> managers = new List<Manager>();
                System.Diagnostics.Debug.WriteLine("seeder manager");

                var managerEcuador = new Manager
                {
                    Name = "Gustavo Alfaro",
                    Nationality = "Argentina",
                    Age = 60,
                    DateCreated = DateTime.Now,
                };

                var managerMexico = new Manager
                {
                    Name = "Gerardo Martino",
                    Nationality = "Argentina",
                    Age = 60,
                    DateCreated = DateTime.Now,
                };

                var managerArgentina = new Manager
                {
                    Name = "Lionel Scaloni",
                    Nationality = "Argentina",
                    Age = 44,
                    DateCreated = DateTime.Now,
                };

                var managerAustralia = new Manager
                {
                    Name = "Graham Arnold",
                    Nationality = "Australia",
                    Age = 59,
                    DateCreated = DateTime.Now,
                };

                var managerBrazilia = new Manager
                {
                    Name = "Tite",
                    Nationality = "Brazil",
                    Age = 61,
                    DateCreated = DateTime.Now,
                };

                var managerCamerun = new Manager
                {
                    Name = "Rigobert Bahanag",
                    Nationality = "Cameroon",
                    Age = 46,
                    DateCreated = DateTime.Now,
                };

                var managerSUA = new Manager
                {
                    Name = "Gregg Berhalter",
                    Nationality = "United States of America",
                    Age = 49,
                    DateCreated = DateTime.Now,
                };

                var managerCostaRica = new Manager
                {
                    Name = "Luis Suarez Guzman",
                    Nationality = "Colombia",
                    Age = 63,
                    DateCreated = DateTime.Now,
                };

                var managerCroatia = new Manager
                {
                    Name = "Zlatko Dalic",
                    Nationality = "Croatia",
                    Age = 56,
                    DateCreated = DateTime.Now,
                };

                var managerDanemarca = new Manager
                {
                    Name = "Kasper Hjulmand",
                    Nationality = "Denmark",
                    Age = 50,
                    DateCreated = DateTime.Now,
                };

                var managerCanada = new Manager
                {
                    Name = "John Herdman",
                    Nationality = "England",
                    Age = 47,
                    DateCreated = DateTime.Now,
                };

                var managerAnglia = new Manager
                {
                    Name = "Gareth Southgate",
                    Nationality = "England",
                    Age = 52,
                    DateCreated = DateTime.Now,
                };

                var managerFranta = new Manager
                {
                    Name = "Didier Deschamps",
                    Nationality = "France",
                    Age = 54,
                    DateCreated = DateTime.Now,
                };

                var managerArabiaSaudita = new Manager
                {
                    Name = "Herve Renard",
                    Nationality = "France",
                    Age = 54,
                    DateCreated = DateTime.Now,
                };

                var managerGermania = new Manager
                {
                    Name = "Hansi Flick",
                    Nationality = "Germany",
                    Age = 57,
                    DateCreated = DateTime.Now,
                };

                var managerGhana = new Manager
                {
                    Name = "Nana Otto Addo",
                    Nationality = "Ghana",
                    Age = 47,
                    DateCreated = DateTime.Now,
                };

                var managerJaponia = new Manager
                {
                    Name = "Hajime Moriyasu",
                    Nationality = "Japan",
                    Age = 54,
                    DateCreated = DateTime.Now,
                };

                var managerMaroc = new Manager
                {
                    Name = "Walid Regragui",
                    Nationality = "Morocco",
                    Age = 47,
                    DateCreated = DateTime.Now,
                };

                var managerOlanda = new Manager
                {
                    Name = "Louis van Gaal",
                    Nationality = "Netherlands",
                    Age = 71,
                    DateCreated = DateTime.Now,
                };

                var managerPolonia = new Manager
                {
                    Name = "Czeslaw Michniewicz",
                    Nationality = "Poland",
                    Age = 52,
                    DateCreated = DateTime.Now,
                };

                var managerKorea = new Manager
                {
                    Name = "Paulo Bento",
                    Nationality = "Portugal",
                    Age = 53,
                    DateCreated = DateTime.Now,
                };

                var managerIran = new Manager
                {
                    Name = "Carlos de Queiroz",
                    Nationality = "Portugal",
                    Age = 69,
                    DateCreated = DateTime.Now,
                };

                var managerPortugalia = new Manager
                {
                    Name = "Fernando da Santos",
                    Nationality = "Portugal",
                    Age = 68,
                    DateCreated = DateTime.Now,
                };

                var managerSenegal = new Manager
                {
                    Name = "Aliou Cisse",
                    Nationality = "Senegal",
                    Age = 46,
                    DateCreated = DateTime.Now,
                };

                var managerSerbia = new Manager
                {
                    Name = "Dragan Stojkovic",
                    Nationality = "Serbia",
                    Age = 57,
                    DateCreated = DateTime.Now,
                };

                var managerSpania = new Manager
                {
                    Name = "Luis Enrique",
                    Nationality = "Spain",
                    Age = 52,
                    DateCreated = DateTime.Now,
                };

                var managerBelgia = new Manager
                {
                    Name = "Roberto Martinez",
                    Nationality = "Spain",
                    Age = 49,
                    DateCreated = DateTime.Now,
                };

                var managerQatar = new Manager
                {
                    Name = "Felix Sanchez",
                    Nationality = "Spain",
                    Age = 47,
                    DateCreated = DateTime.Now,
                };

                var managerElvetia = new Manager
                {
                    Name = "Murat Yakin",
                    Nationality = "Switzerland",
                    Age = 48,
                    DateCreated = DateTime.Now,
                };

                var managerTunisia = new Manager
                {
                    Name = "Jalel Kadri",
                    Nationality = "Tunisia",
                    Age = 51,
                    DateCreated = DateTime.Now,
                };

                var managerUruguay = new Manager
                {
                    Name = "Diego Alonso",
                    Nationality = "Uruguay",
                    Age = 49,
                    DateCreated = DateTime.Now,
                };

                var managerWales = new Manager
                {
                    Name = "Robert Page",
                    Nationality = "Wales",
                    Age = 48,
                    DateCreated = DateTime.Now,
                };

                managers.Add(new Manager { Name = "", Nationality = "", Age = 0, DateCreated = DateTime.Now, });
                managers.Add(managerQatar);
                managers.Add(managerEcuador);
                managers.Add(managerSenegal);
                managers.Add(managerOlanda);

                managers.Add(managerAnglia);
                managers.Add(managerIran);
                managers.Add(managerSUA);
                managers.Add(managerWales);

                managers.Add(managerArgentina);
                managers.Add(managerArabiaSaudita);
                managers.Add(managerDanemarca);
                managers.Add(managerTunisia);

                managers.Add(managerMexico);
                managers.Add(managerPolonia);
                managers.Add(managerFranta);
                managers.Add(managerAustralia);

                managers.Add(managerMaroc);
                managers.Add(managerCroatia);
                managers.Add(managerGermania);
                managers.Add(managerJaponia);

                managers.Add(managerSpania);
                managers.Add(managerCostaRica);
                managers.Add(managerBelgia);
                managers.Add(managerCanada);

                managers.Add(managerBrazilia);
                managers.Add(managerSerbia);
                managers.Add(managerPortugalia);
                managers.Add(managerGhana);

                managers.Add(managerUruguay);
                managers.Add(managerKorea);
                managers.Add(managerElvetia);
                managers.Add(managerCamerun);

                System.Diagnostics.Debug.WriteLine("INFO!!!!!!!! a adaugat managerii in array");
                for (int i = 1; i <= 32; i++)
                {
                    _projectContext.Managers.Add(managers[i]);
                }
                System.Diagnostics.Debug.WriteLine("INFO!!!!!!!! a adaugat managerii in arrayul de context");
                _projectContext.SaveChanges();
                System.Diagnostics.Debug.WriteLine("ALERT!!!!!!!!!!! a bagat in BD");
            }
        }
    }
}
