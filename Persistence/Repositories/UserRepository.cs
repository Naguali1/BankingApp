using Persistence.Models;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private const string TableName = "users";
        private readonly ISqlClient _sqlClient;

        public UserRepository(ISqlClient sqlClient)
        {
            _sqlClient = sqlClient;
        }

        public Task<UserReadModel> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<UserReadModel> GetAsync(string firebaseId)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> SaveOrUpdateAsync(UserReadModel userModel)
        {
            var sql = $"INSERT INTO {TableName} (UserId, FirebaseId, UserName, Email, DateCreated) " +
                $"VALUES (@User_Id, @Firebase_Id, @User_Name, @Email, @Date_Created)";
        }
    }
}