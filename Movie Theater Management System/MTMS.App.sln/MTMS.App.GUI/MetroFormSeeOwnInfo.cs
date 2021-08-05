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
    public partial class MetroFormSeeOwnInfo : MetroForm
    {
        private User userPassUp = new User();
        private UserRepo repoUser = new UserRepo();
        private EmployeeRepo repoEmployee = new EmployeeRepo();
        private Employee employeeInfo = new Employee();
 
        private string userstatus;
        private string userid;
        private string newPassword;

        public MetroFormSeeOwnInfo(string userstatus,string userid)
        {
            InitializeComponent();
            this.userstatus = userstatus;
            this.userid = userid;

            this.metroTextBoxId.Enabled = false;
            this.metroTextBoxName.Enabled = false;
            this.metroTextBoxJobCategory.Enabled = false;
            this.metroTextBoxSalary.Enabled = false;
            this.metroDateTimeJoiningDate.Enabled = false;
            this.metroTextBoxPhoneNo.Enabled=false;
            this.metroTextBoxEmail.Enabled = false;

            employeeInfo = repoEmployee.GetEmployee(userid);
            this.metroTextBoxId.Text = employeeInfo.EmployeeId;
            this.metroTextBoxName.Text = employeeInfo.EmployeeName;
            this.metroTextBoxJobCategory.Text = employeeInfo.JobCategory;
            this.metroTextBoxSalary.Text = employeeInfo.Salary.ToString();
            this.metroDateTimeJoiningDate.Value = DateTime.Parse(employeeInfo.JoiningDate.ToString());
            this.metroTextBoxPhoneNo.Text=employeeInfo.EmployeePhoneNo;
            this.metroTextBoxEmail.Text = employeeInfo.EmployeeEmail;
            

        }

        private void metroButtonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormDashboard(userstatus, userid).Visible = true;
        }

        private void metroButtonLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormLogin().Visible = true;
        }

        private void metroButtonChangePassword_Click(object sender, EventArgs e)
        {
            this.metroPanelChangePassword.Visible = true;
            this.metroButtonClose.Visible = true;
            this.metroButtonSave.Visible = true;
            this.metroButtonClear.Visible = true;
            this.ClearAll();
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.metroTextBoxCurrentPassword.Text = null;
            this.metroTextBoxNewPassword.Text = null;
            this.metroTextBoxReNewPassword.Text = null;
        }

        private void VisibleFalse()
        {
            this.metroPanelChangePassword.Visible = false;
            this.metroButtonClose.Visible = false;
            this.metroButtonSave.Visible = false;
            this.metroButtonClear.Visible = false;
        }

        private void MetroFormSeeOwnInfo_Load(object sender, EventArgs e)
        {
            this.VisibleFalse();
            this.ClearAll();
        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            try 
            {
                this.FillEntity();
                if (userPassUp.UserId!=null && userPassUp.UserPassword!=null)
                {
                    User user = repoUser.GetUser(userPassUp);
                    if (user != null)
                    {
                        if (this.metroTextBoxNewPassword.Text == this.metroTextBoxReNewPassword.Text)
                        {
                            newPassword = this.metroTextBoxNewPassword.Text;
                            bool conformation = repoUser.Update(userPassUp, newPassword);
                            if (conformation)
                            {
                                MessageBox.Show("Your Password Has Been Changed");
                                this.ClearAll();
                            }

                            else
                                MessageBox.Show("Failed To Change Your Password");

                        }
                        else
                            MessageBox.Show("New Password & Re-New Password Must Need To Be Same");

                    }
                    else
                    {
                        MessageBox.Show("Current Password That You Provided Is Wrong.Please,Retry Using Currect Current Password");
                    }
                }
                else
                    MessageBox.Show("Please Fill All The Info First");
            }
            catch { }

        }

        private void MetroFormSeeOwnInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FillEntity()
        {
            if (!IsValidToSave())
            {
                userPassUp.UserId = null;
                userPassUp.UserPassword=null;
                return;
            }
                
            userPassUp.UserId = userid;
            userPassUp.UserPassword = this.metroTextBoxCurrentPassword.Text;
        }

        private bool IsValidToSave()
        {
            if (Validation.IsStringValid(this.metroTextBoxCurrentPassword.Text) && Validation.IsStringValid(this.metroTextBoxNewPassword.Text) && Validation.IsStringValid(this.metroTextBoxReNewPassword.Text))
            {   
               // MessageBox.Show("True");
                return true;
            }
            else
            {
               // MessageBox.Show("False");
                return false;
            }

                
        }

        private void metroButtonClose_Click(object sender, EventArgs e)
        {
            this.VisibleFalse();
            this.ClearAll();
        }
        
    }
}
