using WorldCupWrapped.Helpers.JwtUtilsHelpers;
using WorldCupWrapped.Models;
using WorldCupWrapped.Models.DTOs.User;
using WorldCupWrapped.Repositories.UserRepository;
using BCryptNet = BCrypt.Net.BCrypt;

namespace WorldCupWrapped.Services.UserService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        private readonly IJwtUtils _jwtUtils;

        public UserService(IUserRepository userRepository, IJwtUtils jwtUtils)
        {
            _userRepository = userRepository;
            _jwtUtils = jwtUtils;
        }
        public UserResponseDto Authenticate(UserRequestDto model)
        {
            var user = _userRepository.FindByUsername(model.Username);
            if (user == null || !BCryptNet.Verify(model.Password, user.PasswordHash))
            {
                return null; 
            }
            var jwtToken = _jwtUtils.GenerateJwtToken(user);
            return new UserResponseDto(user, jwtToken);
        }
        public async Task Create(User newUser)
        {
            await _userRepository.CreateAsync(newUser);
            await _userRepository.SaveAsync();
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAll();
        }

        public User GetById(Guid id)
        {
            return _userRepository.FindById(id);
        }
        public async Task UploadProfilePictureToS3(User newUser)
        {
            await _userRepository.UploadProfilePictureToS3(newUser);
        }
    }
}
