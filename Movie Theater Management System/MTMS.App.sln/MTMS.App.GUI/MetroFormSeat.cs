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
    public partial class MetroFormSeat : MetroForm
    {
        private Seat seat = new Seat();
        private SeatRepo repoManage = new SeatRepo();
        private string userstatus;
        private string userid;

        public MetroFormSeat(string userstatus, string userid)
        {
            InitializeComponent();
            this.userstatus = userstatus;
            this.userid = userid;
            this.EnableFalse();
        }

        private void EnableTrue()
        {
            this.metroComboBoxS101.Enabled = true;
            this.metroComboBoxS102.Enabled = true;
            this.metroComboBoxS103.Enabled = true;
            this.metroComboBoxS104.Enabled = true;
            this.metroComboBoxS105.Enabled = true;
            this.metroComboBoxS106.Enabled = true;
            this.metroComboBoxS107.Enabled = true;
            this.metroComboBoxS108.Enabled = true;
            this.metroComboBoxS109.Enabled = true;
            this.metroComboBoxS110.Enabled = true;

        }
        private void EnableFalse()
        {
            this.metroTextBoxMovieId.Enabled = false;
            this.metroComboBoxS101.Enabled = false;
            this.metroComboBoxS102.Enabled = false;
            this.metroComboBoxS103.Enabled = false;
            this.metroComboBoxS104.Enabled = false;
            this.metroComboBoxS105.Enabled = false;
            this.metroComboBoxS106.Enabled = false;
            this.metroComboBoxS107.Enabled = false;
            this.metroComboBoxS108.Enabled = false;
            this.metroComboBoxS109.Enabled = false;
            this.metroComboBoxS110.Enabled = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormLogin().Visible = true;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormLogin().Visible = true;
        }

        private void metroButtonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormDashboard(userstatus,userid).Visible = true;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormDashboard(userstatus,userid).Visible = true;
        }


        private void PopulateMetroGrid(string query)
        {
            this.metroGridSeat.AutoGenerateColumns = false;
            this.metroGridSeat.DataSource = repoManage.GetAll(query).ToList();
            this.metroGridSeat.ClearSelection();
            this.metroGridSeat.Refresh();
        }

        private void MetroFormSeat_Load(object sender, EventArgs e)
        {
            string s = null;
            this.PopulateMetroGrid(s);
        }

        private void metroButtonRefresh_Click(object sender, EventArgs e)
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

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearch.Text = null;
            string s = null;
            this.PopulateMetroGrid(s);
        }

        private void SeatUpdate()
        {
            if (this.metroGridSeat.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }

            this.EnableTrue();
            
            this.metroTextBoxMovieId.Text = this.metroGridSeat.CurrentRow.Cells["movieId"].Value.ToString();
            this.metroComboBoxS101.SelectedItem = this.metroGridSeat.CurrentRow.Cells["s101"].Value.ToString();
            this.metroComboBoxS102.SelectedItem = this.metroGridSeat.CurrentRow.Cells["s102"].Value.ToString();
            this.metroComboBoxS103.SelectedItem = this.metroGridSeat.CurrentRow.Cells["s103"].Value.ToString();
            this.metroComboBoxS104.SelectedItem = this.metroGridSeat.CurrentRow.Cells["s104"].Value.ToString();
            this.metroComboBoxS105.SelectedItem = this.metroGridSeat.CurrentRow.Cells["s105"].Value.ToString();
            this.metroComboBoxS106.SelectedItem = this.metroGridSeat.CurrentRow.Cells["s106"].Value.ToString();
            this.metroComboBoxS107.SelectedItem = this.metroGridSeat.CurrentRow.Cells["s107"].Value.ToString();
            this.metroComboBoxS108.SelectedItem = this.metroGridSeat.CurrentRow.Cells["s108"].Value.ToString();
            this.metroComboBoxS109.SelectedItem = this.metroGridSeat.CurrentRow.Cells["s109"].Value.ToString();
            this.metroComboBoxS110.SelectedItem = this.metroGridSeat.CurrentRow.Cells["s110"].Value.ToString();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SeatUpdate();
        }

        private void metroGridSeat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SeatUpdate();

        }

        private void metroGridSeat_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.SeatUpdate();
        }

        private void ClearAll()
        {
            this.metroTextBoxMovieId.Text = null;
            this.metroComboBoxS101.SelectedItem = null;
            this.metroComboBoxS102.SelectedItem = null;
            this.metroComboBoxS103.SelectedItem = null;
            this.metroComboBoxS104.SelectedItem = null;
            this.metroComboBoxS105.SelectedItem = null;
            this.metroComboBoxS106.SelectedItem = null;
            this.metroComboBoxS107.SelectedItem = null;
            this.metroComboBoxS108.SelectedItem = null;
            this.metroComboBoxS109.SelectedItem = null;
            this.metroComboBoxS110.SelectedItem = null;
            
            this.EnableFalse();

        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void metroTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var query = "select * from Seat where movieId like '%" + this.metroTextBoxSearch.Text + "%' or s101 like '%" + this.metroTextBoxSearch.Text + "%' or s102 like '%" + this.metroTextBoxSearch.Text + "%' or s103 like '%" + this.metroTextBoxSearch.Text + "%' or s104 like '%" + this.metroTextBoxSearch.Text + "%' or s105 like '%" + this.metroTextBoxSearch.Text + "%' or s106 like '%" + this.metroTextBoxSearch.Text + "%' or s107 like '%" + this.metroTextBoxSearch.Text + "%' or s108 like '%" + this.metroTextBoxSearch.Text + "%' or s109 like '%" + this.metroTextBoxSearch.Text + "%' or s110 like '%" + this.metroTextBoxSearch.Text + "%' ;";
            this.PopulateMetroGrid(query);
        }

        private void MetroFormSeat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FillEntity()
        {
            try
            {
                seat.MovieId = this.metroTextBoxMovieId.Text;
                seat.S101 = this.metroComboBoxS101.SelectedItem.ToString();
                seat.S102 = this.metroComboBoxS102.SelectedItem.ToString();
                seat.S103 = this.metroComboBoxS103.SelectedItem.ToString();
                seat.S104 = this.metroComboBoxS104.SelectedItem.ToString();
                seat.S105 = this.metroComboBoxS105.SelectedItem.ToString();
                seat.S106 = this.metroComboBoxS106.SelectedItem.ToString();
                seat.S107 = this.metroComboBoxS107.SelectedItem.ToString();
                seat.S108 = this.metroComboBoxS108.SelectedItem.ToString();
                seat.S109 = this.metroComboBoxS109.SelectedItem.ToString();
                seat.S110 = this.metroComboBoxS110.SelectedItem.ToString();
                //MessageBox.Show("entity fill done");     //for test
            }
            catch //(Exception exception)
            {
               // MessageBox.Show("Error:" + exception.Message);
            }

        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            this.SaveSeatUpdate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveSeatUpdate();
        }

        private void SaveSeatUpdate()
        {
            try
            {
                this.FillEntity();

                /*MessageBox.Show(seat.MovieId);
                MessageBox.Show(seat.S101);
                MessageBox.Show(seat.S102);
                MessageBox.Show(seat.S103);
                MessageBox.Show(seat.S104);
                MessageBox.Show(seat.S105);
                MessageBox.Show(seat.S106);
                MessageBox.Show(seat.S107);
                MessageBox.Show(seat.S108);
                MessageBox.Show(seat.S109);
                MessageBox.Show(seat.S110);*/

                if (seat.S101 != null && seat.S102 != null && seat.S103 != null && seat.S104 != null && seat.S105 != null && seat.S106 != null && seat.S107 != null && seat.S108 != null && seat.S109 != null && seat.S110 != null)
                {
                    bool conformation = repoManage.Update(seat);
                    //MessageBox.Show(conformation.ToString());
                    if (conformation == true)
                    {
                        MessageBox.Show("Seat Info Updated.");
                    }
                    else
                        MessageBox.Show("Failed To Update Seat Info.");

                    string s = null;
                    this.PopulateMetroGrid(s);
                    this.ClearAll();
                }
                else
                    MessageBox.Show("No Data Is Selected To Update.Please,Select Some Data First Which You Want To Update.");

            }
            catch //(Exception exception)
            {
               // MessageBox.Show("Error:" + exception.Message);
            }
 
        }

    }
}
