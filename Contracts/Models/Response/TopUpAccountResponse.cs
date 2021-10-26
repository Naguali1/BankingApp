using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models.Response
{
    public class TopUpAccountResponse
    {
        public decimal Money { get; set; }
        public string Account { get; set; }
    }
}
