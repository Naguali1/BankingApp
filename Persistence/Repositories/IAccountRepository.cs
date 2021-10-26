using Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public interface IAccountRepository
    {
        Task<int> SaveOrUpdateAsync(AccountReadModel accountModel);

        Task<IEnumerable<AccountReadModel>> GetAllAsync();
        Task<AccountReadModel> GetAsync(Guid id);
        Task<int> DeleteAsync(Guid id);
    }
}
