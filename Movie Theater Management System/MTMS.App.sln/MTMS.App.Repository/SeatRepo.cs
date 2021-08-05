using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MTMS.App.Data;
using MTMS.App.Entity;


namespace MTMS.App.Repository
{
    public class SeatRepo
    {
        public List<Seat> GetAll(string query)
        {
            var seatList = new List<Seat>();
            if (query == null)
            {
                query = "select * from Seat;";
            }

            var dt = DataAccess.GetDataTable(query);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Seat seat = ConvertToEntity(dt.Rows[index]);
                seatList.Add(seat);
            }
            return seatList;
        }

        private Seat ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var seat = new Seat();

            seat.Id = Convert.ToInt32(row["id"].ToString());
            seat.MovieId = row["movieId"].ToString();
            seat.S101 = row["s101"].ToString();
            seat.S102 = row["s102"].ToString();
            seat.S103 = row["s103"].ToString();
            seat.S104 = row["s104"].ToString();
            seat.S105 = row["s105"].ToString();
            seat.S106 = row["s106"].ToString();
            seat.S107 = row["s107"].ToString();
            seat.S108 = row["s108"].ToString();
            seat.S109 = row["s109"].ToString();
            seat.S110 = row["s110"].ToString();


            return seat;
        }

        public bool Insert(string movieid)
        {
            try
            {
                string query = "select * from Seat where movieId = '" + movieid + "'";
                var dt = DataAccess.GetDataTable(query);
                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "Insert into Seat values ('" + movieid + "','Available','Available','Available','Available','Available','Available','Available','Available','Available','Available');";

                }

                int count = DataAccess.ExecuteUpdateQuery(query);

                if (count >= 1)
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

        public bool Delete(string movieid)
        {
            try
            {
                string query = "select * from Seat where movieId = '" + movieid + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    return false;
                }

                query = "delete from Seat where movieId = '" + movieid + "'";
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

        public bool Update(Seat seat)
        {
            try
            {
                string query = "select * from Seat where movieId = '" + seat.MovieId + "'";
                var dt = DataAccess.GetDataTable(query);
                if (dt == null || dt.Rows.Count == 0)
                {
                    return false;
                }

                string gg = "Update Seat set s101 = '" + seat.S101 + "',s102 = '" + seat.S102 + "', s103 = '" + seat.S103 + "', s104 = '" + seat.S104 + "', s105 = '" + seat.S105 + "', s106 = '" + seat.S106 + "', s107 = '" + seat.S107 + "', s108 = '" + seat.S108 + "', s109 = '" + seat.S109 + "', s110 = '" + seat.S110 + "' where movieId = '" + seat.MovieId + "';";
                int count = DataAccess.ExecuteUpdateQuery(gg);
                if (count >= 1)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public Seat GetSeatInfo(string movieId)
        {
            var sql = "select * from Seat where movieId='" + movieId + "'";
            var dt = DataAccess.GetDataTable(sql);
            var seat = ConvertToEntity(dt.Rows[0]);
            return seat;
 
        }
    }

   
}
