using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User FindByUsername(string username);
        public void UploadProfilePictureToS3(User newUser);
    }
}
