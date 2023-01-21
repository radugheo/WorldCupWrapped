using Microsoft.EntityFrameworkCore;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;
using WorldCupWrapped.Data;

namespace WorldCupWrapped.Repositories.ManagerRepository
{
    public class ManagerRepository : GenericRepository<Manager>, IManagerRepository
    {
        public ManagerRepository(ProjectContext context) : base(context)
        {

        }

        public async Task<List<Manager>> GetAllManagers()
        {
            var managers_unordered = await _table.ToListAsync();

            //make new empty list of 32 managers
            List<Manager> managers = new List<Manager>
            {
                //add the manager with name Felix Sanchez
                new Manager() { Name = "", Nationality = "", Age = 0 },
                managers_unordered.Find(m => m.Name == "Felix Sanchez"),
                managers_unordered.Find(m => m.Name == "Gustavo Alfaro"),
                managers_unordered.Find(m => m.Name == "Aliou Cisse"),
                managers_unordered.Find(m => m.Name == "Louis van Gaal"),
                managers_unordered.Find(m => m.Name == "Gareth Southgate"),
                managers_unordered.Find(m => m.Name == "Carlos de Queiroz"),
                managers_unordered.Find(m => m.Name == "Gregg Berhalter"),
                managers_unordered.Find(m => m.Name == "Robert Page"),
                managers_unordered.Find(m => m.Name == "Lionel Scaloni"),
                managers_unordered.Find(m => m.Name == "Herve Renard"),
                managers_unordered.Find(m => m.Name == "Kasper Hjulmand"),
                managers_unordered.Find(m => m.Name == "Jalel Kadri"),
                managers_unordered.Find(m => m.Name == "Gerardo Martino"),
                managers_unordered.Find(m => m.Name == "Czeslaw Michniewicz"),
                managers_unordered.Find(m => m.Name == "Didier Deschamps"),
                managers_unordered.Find(m => m.Name == "Graham Arnold"),
                managers_unordered.Find(m => m.Name == "Walid Regragui"),
                managers_unordered.Find(m => m.Name == "Zlatko Dalic"),
                managers_unordered.Find(m => m.Name == "Hansi Flick"),
                managers_unordered.Find(m => m.Name == "Hajime Moriyasu"),
                managers_unordered.Find(m => m.Name == "Luis Enrique"),
                managers_unordered.Find(m => m.Name == "Luis Suarez Guzman"),
                managers_unordered.Find(m => m.Name == "Roberto Martinez"),
                managers_unordered.Find(m => m.Name == "John Herdman"),
                managers_unordered.Find(m => m.Name == "Tite"),
                managers_unordered.Find(m => m.Name == "Dragan Stojkovic"),
                managers_unordered.Find(m => m.Name == "Fernando da Santos"),
                managers_unordered.Find(m => m.Name == "Nana Otto Addo"),
                managers_unordered.Find(m => m.Name == "Diego Alonso"),
                managers_unordered.Find(m => m.Name == "Paulo Bento"),
                managers_unordered.Find(m => m.Name == "Murat Yakin"),
                managers_unordered.Find(m => m.Name == "Rigobert Bahanag"),


            };
            return managers;
        }
    }
}