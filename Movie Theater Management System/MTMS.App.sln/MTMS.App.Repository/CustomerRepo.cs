using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTMS.App.Entity;
using MTMS.App.Data;
using System.Data;

namespace MTMS.App.Repository
{
    public class CustomerRepo
    {
        public string appId;

        public string AppId
        {
            get { return appId; }
            set { this.appId = "C-" + value; }
        }

        public int AutoIDValue()
        {
            var dt = DataAccess.GetDataTable("select * from Customer;");
            if (dt == null || dt.Rows.Count == 0)
            {
                int number = 100;
                return number;
            }
            else
            {
                string value = dt.Rows[dt.Rows.Count - 1]["customerId"].ToString();

                string[] id = value.Split('-');
                int number = Convert.ToInt32(id[1]);
                return number;
            }
            
        }

        public List<Customer> GetAll(string query)
        {
            var customerList = new List<Customer>();
            if (query == null)
            {
                query = "select * from Customer;";
            }

            var dt = DataAccess.GetDataTable(query);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Customer customer = ConvertToEntity(dt.Rows[index]);
                customerList.Add(customer);
            }
            return customerList;
        }

        private Customer ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var customer = new Customer();

            customer.Id = Convert.ToInt32(row["id"].ToString());
            customer.CustomerId = row["customerId"].ToString();
            customer.CustomerName = row["customerName"].ToString();
            customer.CustomerPhoneNo = row["customerPhoneNo"].ToString();

            return customer;
        }

        public bool Save(Customer customer)
        {
            try
            {

                string query = "select * from Customer where customerId = '" + customer.CustomerId + "'";
                var dtt = DataAccess.GetDataTable(query);

                if (dtt == null || dtt.Rows.Count == 0)
                {
                    query = "Insert into Customer values ('" + customer.CustomerId + "','" + customer.CustomerName + "','" + customer.CustomerPhoneNo + "');";

                }
                else
                {
                    query = "Update Customer set customerName = '" + customer.CustomerName + "',customerPhoneNo= '" + customer.CustomerPhoneNo + "' where customerId = '" + customer.CustomerId + "';";
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

        public bool Delete(string customerid)
        {
            try
            {
                string query = "select * from Customer where CustomerId = '" + customerid + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    return false;
                }

                query = "delete from Customer where customerId = '" + customerid + "'";
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

        public Customer GetCustomer(string customerId)
        {
            var sql = "select * from Customer where customerId='" + customerId + "'";
            var dt = DataAccess.GetDataTable(sql);
            var customer = ConvertToEntity(dt.Rows[0]);
            return customer;
        }
    }
}
