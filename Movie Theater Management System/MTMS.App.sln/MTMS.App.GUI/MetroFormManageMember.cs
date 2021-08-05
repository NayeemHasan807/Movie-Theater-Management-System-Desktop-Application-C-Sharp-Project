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
    public partial class MetroGridManageMember : MetroForm
    {
        private Member member = new Member();
        private MemberRepo repoManage = new MemberRepo();

        private string userstatus;
        private string userid;

        public MetroGridManageMember(string userstatus, string userid)
        {
            InitializeComponent();
            this.userstatus = userstatus;
            this.userid = userid;
            this.metroTextBoxMemberId.Enabled = false;
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
            new MetroFormBookingDashboard(userstatus, userid).Visible = true;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormBookingDashboard(userstatus, userid).Visible = true;
        }

        private void MetroGridManageMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MetroGridManageMember_Load(object sender, EventArgs e)
        {
            this.LoadAutoAppId();
            string s = null;
            this.PopulateMetroGrid(s);
        }

        private void PopulateMetroGrid(string query)
        {
            this.metroGridManMember.AutoGenerateColumns = false;
            this.metroGridManMember.DataSource = repoManage.GetAll(query).ToList();
            this.metroGridManMember.ClearSelection();
            this.metroGridManMember.Refresh();
        }

        private void LoadAutoAppId()
        {
            int serial = repoManage.AutoIDValue();
            repoManage.AppId = (++serial).ToString();
            this.metroTextBoxMemberId.Text = repoManage.AppId;
        }

        private void metroButtonRefresh_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearch.Text = null;
            string s = null;
            this.PopulateMetroGrid(s);
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearch.Text = null;
            string s = null;
            this.PopulateMetroGrid(s);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearch.Text = null;
            string s = null;
            this.PopulateMetroGrid(s);
        }

        private void metroTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var query = "select * from Member where memberId like '%" + this.metroTextBoxSearch.Text + "%' or memberName like '%" + this.metroTextBoxSearch.Text + "%' or memberPhoneNo like '%" + this.metroTextBoxSearch.Text + "%' or rewardPoint like '%" + this.metroTextBoxSearch.Text + "%' or memberEmail like '%" + this.metroTextBoxSearch.Text + "%';";
            this.PopulateMetroGrid(query);
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
            this.metroTextBoxMemberName.Text = null;
            this.metroTextBoxMemberPhoneNo.Text = null;
            this.metroTextBoxRewardPoint.Text = null;
            this.metroTextBoxMemberEmail.Text = null;
        }

        private void metroGridManMember_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.MemberUpdate();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MemberUpdate();
        }

        private void metroGridManMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.MemberUpdate();
        }

        private void MemberUpdate()
        {
            try
            {
                if (this.metroGridManMember.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select A Row First");
                    return;
                }


                this.metroTextBoxMemberId.Text = this.metroGridManMember.CurrentRow.Cells["memberId"].Value.ToString();
                this.metroTextBoxMemberName.Text = this.metroGridManMember.CurrentRow.Cells["memberName"].Value.ToString();
                this.metroTextBoxMemberPhoneNo.Text = this.metroGridManMember.CurrentRow.Cells["memberPhoneNo"].Value.ToString();
                this.metroTextBoxRewardPoint.Text = this.metroGridManMember.CurrentRow.Cells["rewardPoint"].Value.ToString();
                this.metroTextBoxMemberEmail.Text = this.metroGridManMember.CurrentRow.Cells["memberEmail"].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
            }
        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
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
                if (this.metroGridManMember.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select A Row First");
                    return;
                }

                if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                string memberId = this.metroGridManMember.CurrentRow.Cells["memberId"].Value.ToString();
                bool decision = repoManage.Delete(memberId);
                if (decision)
                {
                    MessageBox.Show("Member Info Deleted.");
                    string s = null;
                    this.PopulateMetroGrid(s);
                    this.LoadAutoAppId();

                }
                else
                    MessageBox.Show("Failed TO Delete Member Info.Please,Input A Valid Member Id.");
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

                if (member.MemberId != null && member.MemberName != null && member.MemberPhoneNo != null && member.RewardPoint >= 0 && member.MemberEmail != null)
                {
                    int serial = repoManage.AutoIDValue();
                    repoManage.AppId = (++serial).ToString();
                    string appidcheck = repoManage.AppId;
                    if (appidcheck == this.metroTextBoxMemberId.Text)
                    {
                        bool conformation = repoManage.Save(member);
                        
                        if (conformation == true)
                        {
                            MessageBox.Show("New Member Info Added.");       
                        }
                        else
                        {
                            MessageBox.Show("Failed To Add New Member Info");
                        }
                    }
                    else
                    {
                        bool conformation = repoManage.Save(member);
                        if (conformation == true)
                        {
                            MessageBox.Show("Member Info Updated");
                        }
                        else
                            MessageBox.Show("Failed To Updated Member Info");
                    }

                    string s = null;
                    this.PopulateMetroGrid(s);
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
                    member.MemberId = null;
                    member.MemberName = null;
                    member.MemberPhoneNo = null;
                    member.MemberEmail = null;
                    member.RewardPoint = -1;
                    return;
                }


                member.MemberId = this.metroTextBoxMemberId.Text;
                member.MemberName = this.metroTextBoxMemberName.Text;
                member.MemberPhoneNo = this.metroTextBoxMemberPhoneNo.Text;
                member.RewardPoint = Convert.ToInt32(this.metroTextBoxRewardPoint.Text);
                member.MemberEmail = this.metroTextBoxMemberEmail.Text;
                
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
                if (Validation.IsStringValid(this.metroTextBoxMemberId.Text) && Validation.IsStringValid(this.metroTextBoxMemberName.Text) && Validation.IsStringValid(this.metroTextBoxMemberPhoneNo.Text) && Validation.IsStringValid(this.metroTextBoxMemberEmail.Text) && Validation.IsIntValid(this.metroTextBoxRewardPoint.Text))
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
