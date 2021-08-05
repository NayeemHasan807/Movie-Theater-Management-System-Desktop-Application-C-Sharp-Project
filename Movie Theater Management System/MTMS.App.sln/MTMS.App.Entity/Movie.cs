using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTMS.App.Entity
{
    public class Movie
    {
        public int Id { set; get; }
        public string MovieId { set; get; }
        public string MovieName { set; get; }
        public string MovieLanguage { set; get; }
        public string MovieHour { set; get; }
        public string MovieType { set; get; }
        public DateTime MovieDate { set; get; }
    }
}
