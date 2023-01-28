using WorldCupWrapped.Data;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;
using Amazon.S3;
using Amazon.S3.Transfer;
using Amazon.Runtime;

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
        public void UploadProfilePictureToS3(User newUser)
        {
            var credentials = new EnvironmentVariablesAWSCredentials();
            var s3Client = new AmazonS3Client(credentials);
            var transferUtility = new TransferUtility(s3Client);
            var filePath = "C:/Users/radu2/Desktop/TESTS3.txt";
            var bucketName = "world-cup-wrapped";
            var key = "profile-pictures/" + newUser.Username + ".jpg";
            transferUtility.Upload(filePath, bucketName, key);
        }
    }
}
