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
    public partial class MetroFormEmployee : MetroForm
    {
        private Employee employee = new Employee();
        private EmployeeRepo repoManage = new EmployeeRepo();
        private User user = new User();
        private UserRepo repouser = new UserRepo();

        private string userstatus;
        private string userid;
        public MetroFormEmployee(string userstatus, string userid)
        {
            InitializeComponent();
            this.userstatus = userstatus;
            this.userid = userid;
            this.metroTextBoxEmployeeId.Enabled = false;
        }

        private void metroBtnClear_Click(object sender, EventArgs e)
        {
            this.ClearText();
        }

        private void ClearText()
        {
            this.LoadAutoAppId();
            this.metroTextBoxEmployeeName.Text = "";
            this.metroTextBoxJobCategory.Text = "";
            this.metroTextBoxSalary.Text = "";
            this.metroDateTimeJoiningDate.Text = "";
            this.metroTextBoxEmployeePhoneNo.Text = "";
            this.metroTextBoxEmployeeEmail.Text = "";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClearText();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormLogin().Visible = true;
        }

        private void metroButtonLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormLogin().Visible = true;
        }

        private void metroBtnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormDashboard(userstatus, userid).Visible = true;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormDashboard(userstatus, userid).Visible = true;
        }

        private void MetroFormEmployee_Load(object sender, EventArgs e)
        {
            this.LoadAutoAppId();
            string s = null;
            this.PopulateMetroGrid(s);
        }
        private void LoadAutoAppId()
        {
            int serial = repoManage.AutoIDValue();
            repoManage.AppId = (++serial).ToString();
            this.metroTextBoxEmployeeId.Text = repoManage.AppId;
        }

        private void metroBtnRefresh_Click(object sender, EventArgs e)
        {
            this.metroTxtSearch.Text = null;
            string s = null;
            this.PopulateMetroGrid(s);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.metroTxtSearch.Text = null;
            string s = null;
            this.PopulateMetroGrid(s);
        }

        private void PopulateMetroGrid(string query)
        {
            this.metroGridEmployee.AutoGenerateColumns = false;
            this.metroGridEmployee.DataSource = repoManage.GetAll(query).ToList();
            this.metroGridEmployee.ClearSelection();
            this.metroGridEmployee.Refresh();
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.metroTxtSearch.Text = null;
            string s = null;
            this.PopulateMetroGrid(s);
        }

        private void MetroFormEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroBtnDelete_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Delete();
        }


        private void Delete()
        {
            try
            {
                if (this.metroGridEmployee.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select A Row First");
                    return;
                }

                if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                string employeeId = this.metroGridEmployee.CurrentRow.Cells["employeeId"].Value.ToString();
                bool decision1 = repoManage.Delete(employeeId);

                if (decision1)
                {
                    bool decision2 = repouser.Delete(employeeId);
                    if (decision2)
                    {
                        MessageBox.Show("Employee Info Deleted.");
                        string s = null;
                        this.PopulateMetroGrid(s);
                        this.LoadAutoAppId();
                    }
                    else
                        MessageBox.Show("Failed To Delete Employee Info.");
                }
                else
                    MessageBox.Show("Failed To Delete Employee Info.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
            }
        }

        private void metroBtnSave_Click(object sender, EventArgs e)
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

                if(employee.EmployeeId!=null && employee.EmployeeName!=null && employee.JobCategory!=null && employee.Salary > 0 && employee.JoiningDate!=null && employee.EmployeePhoneNo!=null && employee.EmployeeEmail!=null)
                {
                    int serial = repoManage.AutoIDValue();
                    repoManage.AppId = (++serial).ToString();
                    string appidcheck = repoManage.AppId;
                    if (appidcheck == this.metroTextBoxEmployeeId.Text)
                    {
                        bool conformation1 = repoManage.Save(employee);
                        string conformatio2 = repouser.Insert(employee.EmployeeId, employee.JobCategory);
                        if (conformation1 == true)
                        {
                            if (conformatio2 != null)
                            {
                                MessageBox.Show("New Employee Info Added & User Info For This Employee Also Created");
                                MessageBox.Show("Login Password: " + conformatio2 + " -Please Note It Down For Future Use");
                            }
                            else
                            {
                                MessageBox.Show("Failed To Create User Info, Input A Valid EmployeeID");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed To Add New Employee Info");
                        }
                    }
                    else
                    {
                        bool conformation1 = repoManage.Save(employee);
                        bool conformation2 = repouser.UpdateStatus(employee.EmployeeId, employee.JobCategory);

                        if (conformation1 == true)
                        {
                            if (conformation2 == true)
                            {
                                MessageBox.Show("Employee Info Updated");
                            }
                            else
                                MessageBox.Show("Failed To Updated Employee Info");

                        }
                        else
                            MessageBox.Show("Failed To Updated Employee Info");
                    }

                    string s = null;
                    this.PopulateMetroGrid(s);
                    this.ClearText();
                }
                else
                    MessageBox.Show("Please,Fill All The Valid Info First To Save.");

            }
            catch
            {
                MessageBox.Show("Please Fill All The Valid Info First To Save.");
            }

        }

        private void FillEntity()
        {
            try
            {
                if (!IsValidToSave())
                {
                    employee.EmployeeId = null;
                    employee.EmployeeName = null;
                    employee.JobCategory = null;
                    employee.Salary = 0;
                    employee.EmployeePhoneNo = null;
                    employee.EmployeeEmail = null;
                    return;
                }


                employee.EmployeeId = this.metroTextBoxEmployeeId.Text;
                employee.EmployeeName = this.metroTextBoxEmployeeName.Text;
                employee.JobCategory = this.metroTextBoxJobCategory.Text;
                employee.Salary = Double.Parse(this.metroTextBoxSalary.Text);
                employee.JoiningDate = DateTime.Parse(this.metroDateTimeJoiningDate.Value.ToString());
                employee.EmployeePhoneNo = this.metroTextBoxEmployeePhoneNo.Text;
                employee.EmployeeEmail = this.metroTextBoxEmployeeEmail.Text;


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
                if (Validation.IsStringValid(this.metroTextBoxEmployeeId.Text) && Validation.IsStringValid(this.metroTextBoxEmployeeName.Text) && Validation.IsStringValid(this.metroTextBoxJobCategory.Text) && Validation.IsStringValid(this.metroTextBoxEmployeePhoneNo.Text) && Validation.IsStringValid(this.metroTextBoxEmployeeEmail.Text) && Validation.IsDoubleValid(this.metroTextBoxSalary.Text) && Validation.IsDateTimeValid(this.metroDateTimeJoiningDate.Value.ToString()))
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

        private void metroTxtSearch_TextChanged(object sender, EventArgs e)
        {
            var query = "select * from Employee where employeeId like '%" + this.metroTxtSearch.Text + "%' or employeeName like '%" + this.metroTxtSearch.Text + "%' or jobCategory like '%" + this.metroTxtSearch.Text + "%' or salary like '%" + this.metroTxtSearch.Text + "%' or joiningDate like '%" + this.metroTxtSearch.Text + "%' or employeePhoneNo like '%" + this.metroTxtSearch.Text + "%' or employeeEmail like '%" + this.metroTxtSearch.Text + "%' ;";
            this.PopulateMetroGrid(query);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.EmployeeUpdate();
        }
        private void metroGridEmployee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.EmployeeUpdate();
        }
        private void EmployeeUpdate()
        {
            try
            {
                if (this.metroGridEmployee.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select A Row First");
                    return;
                }

                this.metroTextBoxEmployeeId.Text = this.metroGridEmployee.CurrentRow.Cells["employeeId"].Value.ToString();
                this.metroTextBoxEmployeeName.Text = this.metroGridEmployee.CurrentRow.Cells["employeeName"].Value.ToString();
                this.metroTextBoxJobCategory.Text = this.metroGridEmployee.CurrentRow.Cells["jobCategory"].Value.ToString();
                this.metroTextBoxSalary.Text = this.metroGridEmployee.CurrentRow.Cells["salary"].Value.ToString();
                this.metroDateTimeJoiningDate.Value = DateTime.Parse(this.metroGridEmployee.CurrentRow.Cells["joiningDate"].Value.ToString());
                this.metroTextBoxEmployeePhoneNo.Text = this.metroGridEmployee.CurrentRow.Cells["employeePhoneNo"].Value.ToString();
                this.metroTextBoxEmployeeEmail.Text = this.metroGridEmployee.CurrentRow.Cells["employeeEmail"].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
            }

        }

        private void metroGridEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EmployeeUpdate();
        }

    }
}
