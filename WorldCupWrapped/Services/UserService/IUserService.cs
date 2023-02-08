using WorldCupWrapped.Models;
using WorldCupWrapped.Models.DTOs.User;

namespace WorldCupWrapped.Services.UserService
{
    public interface IUserService
    {
        UserResponseDto Authenticate(UserRequestDto model);
        Task<List<User>> GetAllUsers();
        User GetById(Guid id);
        Task Create(User newUser);
        Task UploadProfilePictureToS3(User newUser);
    }
}
