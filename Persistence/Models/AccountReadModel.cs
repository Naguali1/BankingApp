using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
   public class AccountReadModel
    {
        public Guid AccountId { get; set; }
        public Guid UserId { get; set; }
        public string AccountName { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal AccountBalance { get; set; }
        public string AccountDescription { get; set; }
        //public Enum AccountType { get; set; }
    }
}
