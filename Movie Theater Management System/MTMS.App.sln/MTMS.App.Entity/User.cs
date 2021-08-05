using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTMS.App.Entity
{
    public class User
    {
        public int Id { set; get; }
        public string UserId { set; get; }
        public string UserPassword { set; get; }
        public string UserStatus { set; get; }

    }
}
