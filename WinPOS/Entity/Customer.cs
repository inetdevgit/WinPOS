using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPOS.Entity
{
    public partial class Customer
    {
        public string CustId { get; set; }
        public string? CustName { get; set; }
        public string? Address { get; set; }
    }
}
