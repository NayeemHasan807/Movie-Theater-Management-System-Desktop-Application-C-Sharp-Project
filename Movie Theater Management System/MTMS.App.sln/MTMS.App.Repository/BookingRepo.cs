using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MTMS.App.Entity;
using MTMS.App.Data;


namespace MTMS.App.Repository
{
    public class BookingRepo
    {
        public string appId;

        public string AppId
        {
            get { return appId; }
            set { this.appId = "T-" + value; }
        }

        public int AutoIDValue()
        {
            var dt = DataAccess.GetDataTable("select * from Booking;");
            if (dt == null || dt.Rows.Count == 0)
            {
                int number = 100;
                return number;
            }
            else
            {
                string value = dt.Rows[dt.Rows.Count - 1]["ticketId"].ToString();

                string[] id = value.Split('-');
                int number = Convert.ToInt32(id[1]);
                return number;
            }
        }

        public List<Booking> GetAll(string query)
        {
            var bookingList = new List<Booking>();
            if (query == null)
            {
                query = "select * from Booking;";
            }

            var dt = DataAccess.GetDataTable(query);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Booking booking = ConvertToEntity(dt.Rows[index]);
                bookingList.Add(booking);
            }
            return bookingList;
        }

        private Booking ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var booking = new Booking();

            booking.Id = Convert.ToInt32(row["id"].ToString());
            booking.TicketId = row["ticketId"].ToString();
            booking.MemberOrCustomerId = row["memberOrCustomerId"].ToString();
            booking.MovieId = row["movieId"].ToString();
            booking.MovieName = row["movieName"].ToString();
            booking.BookingDate = DateTime.Parse(row["bookingDate"].ToString());
            booking.BookingTime = row["bookingTime"].ToString();
            booking.SeatNumber = row["seatNumber"].ToString();

            return booking;
        }

        public bool Delete(string ticketid)
        {
            try
            {
                string query = "select * from Booking where ticketId = '" + ticketid + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    return false;
                }

                query = "delete from Booking where ticketId = '" + ticketid + "'";
                int count = DataAccess.ExecuteUpdateQuery(query);
                if (count == 1)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }

        }
        public bool Save(Booking booking)
        {
            try
            {

                string query = "select * from Booking where ticketId = '" + booking.TicketId + "'";
                var dtt = DataAccess.GetDataTable(query);

                if (dtt == null || dtt.Rows.Count == 0)
                {
                    query = "Insert into Booking values ('" + booking.TicketId + "','" + booking.MemberOrCustomerId + "','" + booking.MovieId + "','" + booking.MovieName + "','" + booking.BookingDate.ToString() + "','" + booking.BookingTime + "','" + booking.SeatNumber + "');";

                }
                else
                {
                    query = "Update Booking set memberOrCustomerId = '" + booking.MemberOrCustomerId + "', movieId='" + booking.MovieId + "', movieName='" + booking.MovieName + "', bookingDate = '" + booking.BookingDate.ToString() + "', bookingTime = '" + booking.BookingTime + "', seatNumber = '" + booking.SeatNumber + "' where ticketId = '" + booking.TicketId + "';";
                }

                int count = DataAccess.ExecuteUpdateQuery(query);

                if (count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }
    }
}
