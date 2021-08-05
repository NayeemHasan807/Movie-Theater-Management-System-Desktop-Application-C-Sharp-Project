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
    public class UserRepo
    {
        public User GetUser(User userLogin)
        {
            try
            {
                string query = "select * from Users where userId = '" + userLogin.UserId + "' and userPassword = '"+userLogin.UserPassword+"';";

                var dt = DataAccess.GetDataTable(query);

                int count = dt.Rows.Count;

                if (count == 1)
                {
                    User user = ConvertToEntity(dt.Rows[0]);
                    return user;
                    
                }
                else
                {
                    return null;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }



        private User ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var user = new User();

            user.Id= Convert.ToInt32(row["id"].ToString());
            user.UserId = row["userId"].ToString();
            user.UserPassword = row["userPassword"].ToString();
            user.UserStatus = row["userStatus"].ToString();
            return user;
        }

        public bool Update(User user, string newPassword)
        {
            try
            {
                string query = "Update Users set userPassword = '" + newPassword + "' where userId = '" + user.UserId + "';";
                int count = DataAccess.ExecuteUpdateQuery(query);
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

        public string Insert(string employeeId,string jobCategory)
        {
            Random random = new Random();
            string password = random.Next(100000, 999999).ToString();
            string emptyornot = null;
            try
            {
                string query = "select * from Users where userId = '" + employeeId + "'";
                var dt = DataAccess.GetDataTable(query);
                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "Insert into Users values ('" + employeeId + "','"+ password +"','"+ jobCategory +"');";

                }

                int count = DataAccess.ExecuteUpdateQuery(query);

                if (count >= 1)
                {
                    return password;
                }
                else
                {
                    return emptyornot;
                }
            }
            catch
            {
                return emptyornot;
            }
        }

        public bool Delete(string employeeId)
        {
            try
            {
                string query = "select * from Users where userId = '" + employeeId + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    return false;
                }

                query = "delete from Users where userId = '" + employeeId + "'";
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

        public bool UpdateStatus(string userid, string userstatus)
        {
            try
            {
                string query = "Update Users set userStatus = '" + userstatus + "' where userId = '" + userid + "';";
                int count = DataAccess.ExecuteUpdateQuery(query);
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
    }

}

