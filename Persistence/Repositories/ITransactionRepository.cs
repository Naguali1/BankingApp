using Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public interface ITransactionRepository
    {
        Task<int> SaveOrUpdateAsync(TransactionReadModel transactionModel);
        Task<IEnumerable<TransactionReadModel>> GetAllAsync(Guid transactionId, Guid userId);
        Task<TransactionReadModel> GetAsync(Guid accountId);
    }
}
