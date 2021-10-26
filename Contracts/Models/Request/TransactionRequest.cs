using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models.Request
{
    public class TransactionRequest
    {
        public decimal Money { get; set; }
        public string Account { get; set; }
    }
}
