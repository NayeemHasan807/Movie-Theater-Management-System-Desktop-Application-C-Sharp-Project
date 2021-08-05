using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MTMS.App.Entity;
using MTMS.App.Repository;
using MTMS.App.FrameWork;


namespace MTMS.App.GUI
{
    public partial class MetroFromPayment : MetroForm
    {
        private Payment payment = new Payment();
        private PaymentRepo repoManage = new PaymentRepo();
        private BookingRepo repoManageBooking = new BookingRepo();
        private Member member = new Member();
        private MemberRepo repoManageMember = new MemberRepo();
        private Customer customer = new Customer();
        private CustomerRepo repoManageCustomer = new CustomerRepo();

        private string userstatus;
        private string userid;

        public MetroFromPayment(string userstatus, string userid)
        {
            InitializeComponent();
            this.userstatus = userstatus;
            this.userid = userid;
            this.metroTextBoxPaymentId.Enabled = false;
            this.metroTextBoxTicketId.Enabled = false;
            this.metroTextBoxMemberOrCustomerId.Enabled = false;

        }

        private void MetroFromPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroButtonLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormLogin().Visible = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormLogin().Visible = true;
        }

        private void metroButtonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormDashboard(userstatus, userid).Visible = true;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormDashboard(userstatus, userid).Visible = true;
        }

        private void MetroFromPayment_Load(object sender, EventArgs e)
        {
            this.LoadAutoAppId();
            string s = null;
            this.PopulateMetroGridPayment(s);
            this.PopulateMetroGridBooking(s);
        }

        private void LoadAutoAppId()
        {
            int serial = repoManage.AutoIDValue();
            repoManage.AppId = (++serial).ToString();
            this.metroTextBoxPaymentId.Text = repoManage.AppId;
        }

        private void PopulateMetroGridPayment(string query)
        {
            this.metroGridPayment.AutoGenerateColumns = false;
            this.metroGridPayment.DataSource = repoManage.GetAll(query).ToList();
            this.metroGridPayment.ClearSelection();
            this.metroGridPayment.Refresh();
        }

        private void PopulateMetroGridBooking(string query)
        {
            this.metroGridBooking.AutoGenerateColumns = false;
            this.metroGridBooking.DataSource = repoManageBooking.GetAll(query).ToList();
            this.metroGridBooking.ClearSelection();
            this.metroGridBooking.Refresh();

        }

        private void metroButtonRefreshPayment_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearchPayment.Text = null;
            string s = null;
            this.PopulateMetroGridPayment(s);
        }

        private void refreshToolStripMenuItemPayment_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearchPayment.Text = null;
            string s = null;
            this.PopulateMetroGridPayment(s);
        }

        private void metroButtonRefreshBooking_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearchBooking.Text = null;
            string s = null;
            this.PopulateMetroGridBooking(s);
        }

        private void refreshToolStripMenuItemBooking_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearchBooking.Text = null;
            string s = null;
            this.PopulateMetroGridBooking(s);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearchPayment.Text = null;
            this.metroTextBoxSearchBooking.Text = null;
            string s = null;
            this.PopulateMetroGridPayment(s);
            this.PopulateMetroGridBooking(s);
        }

        

        private void metroTextBoxSearchBooking_TextChanged(object sender, EventArgs e)
        {
            var query = "select * from Booking where ticketId like '%" + this.metroTextBoxSearchBooking.Text + "%' or memberOrCustomerId like '%" + this.metroTextBoxSearchBooking.Text + "%' ;";
            this.PopulateMetroGridBooking(query);
        }

        private void metroTextBoxSearchPayment_TextChanged(object sender, EventArgs e)
        {
            var query = "select * from Payment where paymentId like '%" + this.metroTextBoxSearchPayment.Text + "%' or ticketId like '%" + this.metroTextBoxSearchPayment.Text + "%' or memberOrCustomerId like '%" + this.metroTextBoxSearchPayment.Text + "%' or memberOrCustomerName like '%" + this.metroTextBoxSearchPayment.Text + "%' or amount like '%" + this.metroTextBoxSearchPayment.Text + "%' or paymentDate like '%" + this.metroTextBoxSearchPayment.Text + "%' or paymentTime like '%" + this.metroTextBoxSearchPayment.Text + "%' ;";
            this.PopulateMetroGridPayment(query);
        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void deleteToolStripMenuItemPayment_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void Delete()
        {
            try
            {
                if (this.metroGridPayment.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select A Row First");
                    return;
                }

                if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                string paymentId = this.metroGridPayment.CurrentRow.Cells["paymentId"].Value.ToString();
                bool decision = repoManage.Delete(paymentId);
                if (decision)
                {
                    MessageBox.Show("Payment Info Deleted.");
                    string s = null;
                    this.PopulateMetroGridPayment(s);
                    this.LoadAutoAppId();

                }
                else
                    MessageBox.Show("Failed To Delete Payment Info.Please,Input A Valid Payment Id.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
            }
        }

        private void updateToolStripMenuItemPayment_Click(object sender, EventArgs e)
        {
            this.UpdatePayment();
        }

        private void metroGridPayment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.UpdatePayment();
        }

        private void metroGridPayment_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.UpdatePayment();
        }

        private void UpdatePayment()
        {
            try
            {
                if (this.metroGridPayment.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select A Row First");
                    return;
                }

                this.metroTextBoxPaymentId.Text = this.metroGridPayment.CurrentRow.Cells["paymentId"].Value.ToString();
                this.metroTextBoxTicketId.Text = this.metroGridPayment.CurrentRow.Cells["ticketIdPayment"].Value.ToString();
                this.metroTextBoxMemberOrCustomerId.Text = this.metroGridPayment.CurrentRow.Cells["memberOrCustomerIdPayment"].Value.ToString();
                this.metroTextBoxMemberOrCustomerName.Text = this.metroGridPayment.CurrentRow.Cells["memberOrCustomerName"].Value.ToString();
                this.metroTextBoxAmount.Text = this.metroGridPayment.CurrentRow.Cells["amount"].Value.ToString();
                this.metroDateTimePaymentDate.Value = DateTime.Parse(this.metroGridPayment.CurrentRow.Cells["paymentDate"].Value.ToString());
                this.metroTextBoxPaymentTime.Text = this.metroGridPayment.CurrentRow.Cells["paymentTime"].Value.ToString();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
            }
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.LoadAutoAppId();
            
            this.metroTextBoxTicketId.Text = null;
            this.metroTextBoxMemberOrCustomerId.Text = null;
            this.metroTextBoxMemberOrCustomerName.Text = null;
            this.metroTextBoxAmount.Text = null;
            this.metroDateTimePaymentDate.Text = null;
            this.metroTextBoxPaymentTime.Text = null;
        }

        private void useInfoToolStripMenuItemBooking_Click(object sender, EventArgs e)
        {
            this.UpdateBooking();
        }

        private void metroGridBooking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.UpdateBooking();
        }

        private void metroGridBooking_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.UpdateBooking();
        }

        private void UpdateBooking()
        {
            try
            {
                if (this.metroGridBooking.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select A Row First");
                    return;
                }

                this.LoadAutoAppId();

                this.metroTextBoxTicketId.Text = this.metroGridBooking.CurrentRow.Cells["ticketIdBooking"].Value.ToString();
                this.metroTextBoxMemberOrCustomerId.Text = this.metroGridBooking.CurrentRow.Cells["memberOrCustomerIdBooking"].Value.ToString();

                string[] MorC=this.metroGridBooking.CurrentRow.Cells["memberOrCustomerIdBooking"].Value.ToString().Split('-');
                if (MorC[0] == "C")
                {
                    customer = repoManageCustomer.GetCustomer(this.metroGridBooking.CurrentRow.Cells["memberOrCustomerIdBooking"].Value.ToString());
                    this.metroTextBoxMemberOrCustomerName.Text = customer.CustomerName;
                }
                else
                {
                    member = repoManageMember.GetMember(this.metroGridBooking.CurrentRow.Cells["memberOrCustomerIdBooking"].Value.ToString());
                    this.metroTextBoxMemberOrCustomerName.Text = member.MemberName;
                }

                this.metroTextBoxAmount.Text = null;
                this.metroDateTimePaymentDate.Text = null;
                this.metroTextBoxPaymentTime.Text = null;

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
            }
        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void Save()
        {
            try
            {
                this.FillEntity();

                if (payment.PaymentId != null && payment.TicketId != null && payment.MemberOrCustomerId != null && payment.Amount > 0 && payment.MemberOrCustomerName != null && payment.PaymentDate != null && payment.PaymentTime!= null)
                {
                    int serial = repoManage.AutoIDValue();
                    repoManage.AppId = (++serial).ToString();
                    string appidcheck = repoManage.AppId;
                    if (appidcheck == this.metroTextBoxPaymentId.Text)
                    {
                        bool conformation = repoManage.Save(payment);

                        repoManageBooking.Delete(payment.TicketId);
                        
                        string[] MorC = payment.MemberOrCustomerId.Split('-');
                        
                        if (MorC[0] == "C")
                        {
                            repoManageCustomer.Delete(payment.MemberOrCustomerId);
                        }
                        else
                        {
                            member = repoManageMember.GetMember(payment.MemberOrCustomerId);
                            member.RewardPoint = member.RewardPoint + 5;
                            repoManageMember.UpdateReward(member.MemberId, member.RewardPoint);
                        }


                        if (conformation == true)
                        {
                            MessageBox.Show("Payment Info Added.");
                        }
                        else
                        {
                            MessageBox.Show("Failed To Add Payment Info");
                        }
                    }
                    else
                    {
                        bool conformation = repoManage.Save(payment);
                        if (conformation == true)
                        {
                            MessageBox.Show("Payment Info Updated");
                        }
                        else
                            MessageBox.Show("Failed To Updated Payment Info");
                    }

                    string s = null;
                    this.PopulateMetroGridPayment(s);
                    this.PopulateMetroGridBooking(s);
                    this.ClearAll();
                }
                else
                    MessageBox.Show("Please,Fill All The Valid Info First To Save.");


            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
                MessageBox.Show("Please Fill All The Valid Info First To Save.");
            }

        }

        private void FillEntity()
        {
            try
            {
                if (!IsValidToSave())
                {
                    payment.PaymentId = null;
                    payment.TicketId = null;
                    payment.MemberOrCustomerId = null;
                    payment.MemberOrCustomerName = null;
                    payment.Amount = 0;
                    payment.PaymentTime = null;
                    return;
                }


                payment.PaymentId = this.metroTextBoxPaymentId.Text;
                payment.TicketId = this.metroTextBoxTicketId.Text;
                payment.MemberOrCustomerId = this.metroTextBoxMemberOrCustomerId.Text;
                payment.MemberOrCustomerName = this.metroTextBoxMemberOrCustomerName.Text;
                payment.Amount = Double.Parse(this.metroTextBoxAmount.Text);
                payment.PaymentDate = DateTime.Parse(this.metroDateTimePaymentDate.Value.ToString());
                payment.PaymentTime = this.metroTextBoxPaymentTime.Text;


            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
            }

        }

        private bool IsValidToSave()
        {
            try
            {
                if (Validation.IsStringValid(this.metroTextBoxPaymentId.Text) && Validation.IsStringValid(this.metroTextBoxTicketId.Text) && Validation.IsStringValid(this.metroTextBoxMemberOrCustomerId.Text) && Validation.IsStringValid(this.metroTextBoxMemberOrCustomerName.Text) && Validation.IsDoubleValid(this.metroTextBoxAmount.Text) && Validation.IsDateTimeValid(this.metroDateTimePaymentDate.Value.ToString()) && Validation.IsStringValid(this.metroTextBoxPaymentTime.Text))
                {
                    MessageBox.Show("True");
                    return true;
                }
                else
                {
                    MessageBox.Show("False");
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
