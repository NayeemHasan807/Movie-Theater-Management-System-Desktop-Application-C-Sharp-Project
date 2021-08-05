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
    public class PaymentRepo
    {
        public string appId;

        public string AppId
        {
            get { return appId; }
            set { this.appId = "P-" + value; }
        }

        public int AutoIDValue()
        {
            var dt = DataAccess.GetDataTable("select * from Payment;");
            if (dt == null || dt.Rows.Count == 0)
            {
                int number = 100;
                return number;
            }
            else
            {
                string value = dt.Rows[dt.Rows.Count - 1]["paymentId"].ToString();

                string[] id = value.Split('-');
                int number = Convert.ToInt32(id[1]);
                return number;
            }
        }

        public List<Payment> GetAll(string query)
        {
            var paymentList = new List<Payment>();
            if (query == null)
            {
                query = "select * from Payment;";
            }

            var dt = DataAccess.GetDataTable(query);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Payment payment = ConvertToEntity(dt.Rows[index]);
                paymentList.Add(payment);
            }
            return paymentList;
        }

        private Payment ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var payment = new Payment();

            payment.Id = Convert.ToInt32(row["id"].ToString());
            payment.PaymentId = row["paymentId"].ToString();
            payment.TicketId = row["ticketId"].ToString();
            payment.MemberOrCustomerId = row["memberOrCustomerId"].ToString();
            payment.MemberOrCustomerName = row["memberOrCustomerName"].ToString();
            payment.Amount = Double.Parse(row["amount"].ToString());
            payment.PaymentDate = Convert.ToDateTime(row["paymentDate"].ToString());
            payment.PaymentTime = row["paymentTime"].ToString();

            return payment;
        }

        public bool Delete(string paymentid)
        {
            try
            {
                string query = "select * from Payment where paymentId = '" + paymentid + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    return false;
                }

                query = "delete from Payment where paymentId = '" + paymentid + "'";
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

        public bool Save(Payment payment)
        {
            try
            {
                string query = "select * from Payment where paymentId = '" + payment.PaymentId + "'";
                var dtt = DataAccess.GetDataTable(query);

                if (dtt == null || dtt.Rows.Count == 0)
                {
                    query = "Insert into Payment values ('" + payment.PaymentId + "','" + payment.TicketId + "','" + payment.MemberOrCustomerId + "','" + payment.MemberOrCustomerName + "','" + payment.Amount + "','" + payment.PaymentDate.ToString() + "','" + payment.PaymentTime + "');";

                }
                else
                {
                    query = "Update Payment set ticketId = '" + payment.TicketId + "', memberOrCustomerId = '" + payment.MemberOrCustomerId + "', memberOrCustomerName = '" + payment.MemberOrCustomerName + "', amount = '" + payment.Amount + "' , paymentDate = '" + payment.PaymentDate.ToString() + "' , paymentTime = '" + payment.PaymentTime + "'  where paymentId = '" + payment.PaymentId + "';";
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
    }
}
