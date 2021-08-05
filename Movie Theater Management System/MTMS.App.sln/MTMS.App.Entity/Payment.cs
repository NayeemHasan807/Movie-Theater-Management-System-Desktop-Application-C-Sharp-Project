using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTMS.App.Entity
{
    public class Payment
    {
        public int Id { set; get; }
        public string PaymentId { set; get; }
        public string TicketId { set; get; }
        public string MemberOrCustomerId { set; get; }
        public string MemberOrCustomerName { set; get; }
        public double Amount { set; get; }
        public DateTime PaymentDate { set; get; }
        public string PaymentTime { set; get; }
    }
}
