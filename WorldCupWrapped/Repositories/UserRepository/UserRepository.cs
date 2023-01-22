using WorldCupWrapped.Data;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ProjectContext context) : base(context)
        {
        }
        public User FindByUsername(string username)
        {
            return _table.FirstOrDefault(x => x.Username == username);
        }
    }
}
