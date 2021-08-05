using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTMS.App.Entity
{
    public class Booking
    {
        public int Id { set; get; }
        public string TicketId { set; get; }
        public string MemberOrCustomerId { set; get; }
        public string MovieId { set; get; }
        public string MovieName { set; get; }
        public DateTime BookingDate { set; get; }
        public string BookingTime { set; get; }
        public string SeatNumber { set; get; }
    }
}
