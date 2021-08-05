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
    public partial class MetroFormDashboard : MetroForm
    {
        private string userstatus;
        private string userid;
        public MetroFormDashboard(string userstatus ,string userid)
        {
            InitializeComponent();
            if (userstatus == "Manager")
            {
                this.userstatus = userstatus;
                this.userid = userid;
            }
            else if (userstatus == "Cashier")
            {
                this.userstatus = userstatus;
                this.userid = userid;
                this.metroButtonManageEmployee.Enabled = false;

            }
            else
            {
                this.userstatus = userstatus;
                this.userid = userid;
                this.metroButtonManageBooking.Enabled = false;
                this.metroButtonManageEmployee.Enabled = false;
                this.metroButtonManageMovie.Enabled = false;
                this.metroButtonManagePayment.Enabled = false;
                this.metroButtonManageSeat.Enabled = false;

            }
        }

        private void metroButtonLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormLogin().Visible = true;
        }

        private void metroButtonManageMovie_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormMovie(userstatus, userid).Visible = true;
        }

        private void metroButtonManageEmployee_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormEmployee(userstatus,userid).Visible = true;
        }

        private void metroButtonManageSeat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormSeat(userstatus, userid).Visible = true;
        }

        private void MetroFormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroButtonSeeOwnInfo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormSeeOwnInfo(userstatus, userid).Visible = true;
        }

        private void metroButtonManagePayment_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFromPayment(userstatus, userid).Visible = true;

        }

        private void metroButtonManageBooking_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormBookingDashboard(userstatus, userid).Visible = true;
        }
    }
}
