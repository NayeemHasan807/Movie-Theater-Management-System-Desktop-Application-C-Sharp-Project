using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTMS.App.Entity
{
    public class Customer
    {
        public int Id { set; get; }
        public string CustomerId { set; get; }
        public string CustomerName { set; get; }
        public string CustomerPhoneNo { set; get; }
    }
}
