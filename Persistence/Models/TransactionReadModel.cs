using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class TransactionReadModel
    {
        public Guid TransactionId { get; set; }
        public Guid AccountId { get; set; }
        public Guid UserId { get; set; }
        public decimal TransactionAmount { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
