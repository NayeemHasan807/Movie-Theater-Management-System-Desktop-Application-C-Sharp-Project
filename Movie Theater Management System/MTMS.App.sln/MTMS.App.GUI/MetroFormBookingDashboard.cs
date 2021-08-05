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

namespace MTMS.App.GUI
{
    public partial class MetroFormBookingDashboard : MetroForm
    {
        private string userstatus;
        private string userid;
        public MetroFormBookingDashboard(string userstatus, string userid)
        {
            InitializeComponent();
            this.userstatus = userstatus;
            this.userid = userid;
        }

        private void MetroFormBookingDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void metroButtonManageMember_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroGridManageMember(userstatus, userid).Visible = true;
        }

        private void metroButtonBookingForMember_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormBookingForMember(userstatus, userid).Visible = true;
        }

        private void metroButtonBookingForCustomer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormBookingForCustomer(userstatus, userid).Visible = true;
        }
    }
}
