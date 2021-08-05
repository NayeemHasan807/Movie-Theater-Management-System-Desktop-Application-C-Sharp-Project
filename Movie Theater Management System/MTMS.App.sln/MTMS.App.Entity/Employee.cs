using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTMS.App.Entity
{
    public class Employee
    {
        public int Id { set; get; }
        public string EmployeeId { set; get; }
        public string EmployeeName { set; get; }
        public string JobCategory { set; get; }
        public double Salary { set; get; }
        public DateTime JoiningDate { set; get; }
        public string EmployeePhoneNo { set; get; }
        public string EmployeeEmail { set; get; }

    }
}
