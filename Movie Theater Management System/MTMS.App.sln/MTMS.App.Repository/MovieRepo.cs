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
    public class MovieRepo
    {
        public string appId;

        public string AppId
        {
            get { return appId; }
            set { this.appId = "M-" + value; }
        }

        public int AutoIDValue()
        {
            var dt = DataAccess.GetDataTable("select * from Movie;");
            if (dt == null || dt.Rows.Count == 0)
            {
                int number = 100;
                return number;
            }
            else
            {
                string value = dt.Rows[dt.Rows.Count - 1]["movieId"].ToString();

                string[] id = value.Split('-');
                int number = Convert.ToInt32(id[1]);
                return number;
            }
        }

        public List<Movie> GetAll(string query)
        {
            var movieList = new List<Movie>();
            if (query == null)
            {
                query = "select * from Movie;";
            }
            
            var dt = DataAccess.GetDataTable(query);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Movie movie = ConvertToEntity(dt.Rows[index]);
                movieList.Add(movie);
            }
            return movieList;
        }

        public bool Save(Movie movie)
        {
            try
            {

                string queryy = "select * from Movie where movieId = '" + movie.MovieId + "'";
                var dtt = DataAccess.GetDataTable(queryy);

                if (dtt == null || dtt.Rows.Count == 0)
                {
                    queryy = "Insert into Movie values ('" + movie.MovieId + "','" + movie.MovieName + "','" + movie.MovieLanguage + "','" + movie.MovieHour + "','" + movie.MovieType + "','" + movie.MovieDate.ToString() + "');";

                }
                else
                {
                    queryy = "Update Movie set movieName = '" + movie.MovieName + "',movieLanguage= '" + movie.MovieLanguage + "',movieHour= '" + movie.MovieHour + "',movieType= '" + movie.MovieType + "',movieDate= '" + movie.MovieDate.ToString() + "' where movieId = '" + movie.MovieId + "';";
                }

                int countt = DataAccess.ExecuteUpdateQuery(queryy);

                if (countt >= 1)
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
                string query = "select * from Movie where movieId = '" + movieid + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    return false;
                }

                query = "delete from Movie where movieId = '" + movieid + "'";
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

        private Movie ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var movie = new Movie();

            movie.Id = Convert.ToInt32(row["id"].ToString());
            movie.MovieId = row["movieId"].ToString();
            movie.MovieName = row["movieName"].ToString();
            movie.MovieLanguage = row["movieLanguage"].ToString();
            movie.MovieHour = row["movieHour"].ToString();
            movie.MovieType = row["movieType"].ToString();
            movie.MovieDate = Convert.ToDateTime(row["movieDate"].ToString());


            return movie;
        }

    }
}
