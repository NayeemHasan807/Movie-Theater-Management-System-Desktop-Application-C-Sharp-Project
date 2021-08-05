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
    public class EmployeeRepo
    {
        public string appId;

        public string AppId
        {
            get { return appId; }
            set { this.appId = "E-" + value; }
        }

        public int AutoIDValue()
        {
            var dt = DataAccess.GetDataTable("select * from Employee;");
            string value = dt.Rows[dt.Rows.Count - 1]["employeeId"].ToString();

            string[] id = value.Split('-');
            int number = Convert.ToInt32(id[1]);
            return number;
        }

        public List<Employee> GetAll(string query)
        {
            var employeeList = new List<Employee>();
            if (query == null)
            {
                query = "select * from Employee;";
            }

            var dt = DataAccess.GetDataTable(query);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Employee employee = ConvertToEntity(dt.Rows[index]);
                employeeList.Add(employee);
            }
            return employeeList;
        }

        public Employee GetEmployee(string employeeId)
        {

            var sql = "select * from Employee where employeeId='" + employeeId + "'";
            var dt = DataAccess.GetDataTable(sql);
            var employee = ConvertToEntity(dt.Rows[0]);
            return employee;


        }

        private Employee ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var employee = new Employee();

            employee.Id = Convert.ToInt32(row["id"].ToString());
            employee.EmployeeId = row["employeeId"].ToString();
            employee.EmployeeName = row["employeeName"].ToString();
            employee.JobCategory = row["jobCategory"].ToString();
            employee.Salary = Double.Parse(row["salary"].ToString());
            employee.JoiningDate = DateTime.Parse(row["joiningDate"].ToString());
            employee.EmployeePhoneNo = row["employeePhoneNo"].ToString();
            employee.EmployeeEmail = row["employeeEmail"].ToString();


            return employee;
        }
        public bool Delete(string employeeid)
        {
            try
            {
                string query = "select * from Employee where employeeId = '" + employeeid + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    return false;
                }

                query = "delete from Employee where employeeId = '" + employeeid + "'";
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
        public bool Save(Employee employee)
        {
            try
            {

                string queryy = "select * from Employee where employeeId = '" + employee.EmployeeId + "'";
                var dtt = DataAccess.GetDataTable(queryy);

                if (dtt == null || dtt.Rows.Count == 0)
                {
                    queryy = "Insert into Employee values ('" + employee.EmployeeId + "','" + employee.EmployeeName + "','" + employee.JobCategory + "','" + employee.Salary + "','" + employee.JoiningDate.ToString() + "','" + employee.EmployeePhoneNo + "','" + employee.EmployeeEmail + "');";

                }
                else
                {
                    queryy = "Update Employee set employeeName = '" + employee.EmployeeName + "', jobCategory='" + employee.JobCategory + "', salary='" + employee.Salary + "', joiningDate = '" + employee.JoiningDate.ToString() + "', employeePhoneNo = '" + employee.EmployeePhoneNo + "', employeeEmail = '" + employee.EmployeeEmail + "' where employeeId = '" + employee.EmployeeId + "';";
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


    }
}
