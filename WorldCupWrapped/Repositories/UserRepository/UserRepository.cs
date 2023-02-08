using WorldCupWrapped.Data;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;
using Amazon.S3;
using Amazon.S3.Transfer;
using Amazon.Runtime;
using Amazon.S3.Model;

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
        public async Task UploadProfilePictureToS3(User newUser)
        {
            var credentials = new EnvironmentVariablesAWSCredentials();
            var s3Client = new AmazonS3Client(credentials);
            int startIndex = newUser.Picture.IndexOf(',') + 1;
            string base64String = newUser.Picture.Substring(startIndex);
            System.Diagnostics.Debug.WriteLine("POZA: poza este: " + base64String);
            var request = new PutObjectRequest
            {
                BucketName = "world-cup-wrapped",
                Key = "profile-pictures/" + newUser.Username + ".png",
                ContentType = "image/png",
                InputStream = new MemoryStream(Convert.FromBase64String(base64String))
            };
            await s3Client.PutObjectAsync(request);
        }
    }
}
