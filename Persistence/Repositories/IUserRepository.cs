using Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public interface IUserRepository
    {
        Task<int> SaveOrUpdateAsync(UserReadModel userModel);
        Task<UserReadModel> GetAsync(string firebaseId);
        Task<UserReadModel> GetAllAsync();
    }
}
