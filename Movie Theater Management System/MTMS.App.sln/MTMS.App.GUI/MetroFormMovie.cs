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
    
    public partial class MetroFormMovie : MetroForm
    {
        private Movie movie = new Movie();
        private MovieRepo repoManage = new MovieRepo();
        private SeatRepo repoSeat = new SeatRepo();
        

        private string userstatus;
        private string userid;

        public MetroFormMovie(string status,string userid)
        {
            InitializeComponent();
            this.userstatus = status;
            this.userid = userid;
            this.metroTextBoxMovieId.Enabled = false;

        }

        private void MetroFormMovie_Load(object sender, EventArgs e)
        {
            this.LoadAutoAppId();
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

        private void metroTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var query = "select * from Movie where movieId like '%" + this.metroTextBoxSearch.Text + "%' or movieName like '%" + this.metroTextBoxSearch.Text + "%' or movieLanguage like '%" + this.metroTextBoxSearch.Text + "%' or movieType like '%" + this.metroTextBoxSearch.Text + "%' or movieHour like '%" + this.metroTextBoxSearch.Text + "%' or movieDate like '%" + this.metroTextBoxSearch.Text + "%' ;";
            this.PopulateMetroGrid(query);
        }

        private void PopulateMetroGrid(string query)
        {
            this.metroGridMovie.AutoGenerateColumns = false;
            this.metroGridMovie.DataSource = repoManage.GetAll(query).ToList();
            this.metroGridMovie.ClearSelection();
            this.metroGridMovie.Refresh();
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();     
        }
        
        private void clearTextsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.LoadAutoAppId();
            this.metroTextBoxMovieName.Text = null;
            this.metroComboBoxMovieLanguage.SelectedItem = null;
            this.metroComboBoxMovieHour.SelectedItem = null;
            this.metroComboBoxMovieType.SelectedItem = null;
            //this.metroComboBoxMovieType.SelectedIndex = -1;                         //this is also working
            this.metroDateTimeMovieDate.Text = null;
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
            new MetroFormDashboard(userstatus,userid).Visible = true;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MetroFormDashboard(userstatus,userid).Visible = true;
        }

        private void LoadAutoAppId()
        {
            int serial = repoManage.AutoIDValue();
            repoManage.AppId = (++serial).ToString();
            this.metroTextBoxMovieId.Text = repoManage.AppId;
        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void Delete()
        {
            try
            {
                if (this.metroGridMovie.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select A Row First");
                    return;
                }

                if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                string movieId = this.metroGridMovie.CurrentRow.Cells["movieId"].Value.ToString();
                bool decision1 = repoManage.Delete(movieId);
                if (decision1)
                {
                    bool decision2 = repoSeat.Delete(movieId);
                    if (decision2)
                    {
                        MessageBox.Show("Movie Info Deleted And Seat's Info Related To This Movie Are Also Deleted.");
                        string s = null;
                        this.PopulateMetroGrid(s);
                        this.LoadAutoAppId();
                    }
                    else
                        MessageBox.Show("Failed TO Delete Movie Info.Please,Input A Valid Movie Id.");

                }
                else
                    MessageBox.Show("Failed TO Delete Movie Info.Please,Input A Valid Movie Id.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
            }
        }

        private void metroGridMovie_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.MovieUpdate();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MovieUpdate();
        }

        private void metroGridMovie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.MovieUpdate();
        }

        private void MovieUpdate()
        {
            try
            {
                if (this.metroGridMovie.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select A Row First");
                    return;
                }
                

                this.metroTextBoxMovieId.Text = this.metroGridMovie.CurrentRow.Cells["movieId"].Value.ToString();
                this.metroTextBoxMovieName.Text = this.metroGridMovie.CurrentRow.Cells["movieName"].Value.ToString();
                this.metroComboBoxMovieLanguage.SelectedItem = this.metroGridMovie.CurrentRow.Cells["movieLanguage"].Value.ToString();
                this.metroComboBoxMovieType.SelectedItem = this.metroGridMovie.CurrentRow.Cells["movieType"].Value.ToString();

                /* string index=this.metroGridMovie.CurrentRow.Cells["movieType"].Value.ToString(); //First used this then learned about Selected item
                if (index == "Action")
                    this.metroComboBoxMovieType.SelectedIndex = 0;
                else if (index == "Adventure")
                    this.metroComboBoxMovieType.SelectedIndex = 1;
                else if (index == "Comedy")
                    this.metroComboBoxMovieType.SelectedIndex = 2;
                 else if (index == "Horror")
                    this.metroComboBoxMovieType.SelectedIndex = 3;
                 else if (index == "Romance")
                    this.metroComboBoxMovieType.SelectedIndex = 4;
                 else if (index == "Animated")
                    this.metroComboBoxMovieType.SelectedIndex = 5;
                 else
                    this.metroComboBoxMovieType.SelectedIndex = 6;*/

                this.metroComboBoxMovieHour.SelectedItem = this.metroGridMovie.CurrentRow.Cells["movieHour"].Value.ToString();
                this.metroDateTimeMovieDate.Value = DateTime.Parse(this.metroGridMovie.CurrentRow.Cells["movieDate"].Value.ToString());
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

               /* MessageBox.Show(movie.MovieId);                                         //For test
                MessageBox.Show(movie.MovieName);
                MessageBox.Show(movie.MovieLanguage);
                MessageBox.Show(movie.MovieType);
                MessageBox.Show(movie.MovieHour);
                MessageBox.Show(movie.MovieDate.ToString());*/

                /*MessageBox.Show(this.metroTextBoxMovieId.Text);                         //For Test
                MessageBox.Show(this.metroTextBoxMovieName.Text);
                MessageBox.Show(this.metroComboBoxMovieLanguage.SelectedItem.ToString());
                MessageBox.Show(this.metroComboBoxMovieType.SelectedItem.ToString());
                MessageBox.Show(this.metroComboBoxMovieHour.SelectedItem.ToString());
                MessageBox.Show(this.metroDateTimeMovieDate.Value.ToString());*/

                bool conformation1 = false;

                string[] gg = this.metroDateTimeMovieDate.Value.ToString().Split(' ');
                //MessageBox.Show(gg[0]);

                for (int i = 0; i < this.metroGridMovie.Rows.Count; i++)
                {
                    //MessageBox.Show(this.metroGridMovie.Rows[i].Cells[4].Value.ToString());
                    //MessageBox.Show(this.metroComboBoxMovieHour.SelectedItem.ToString());
                    if (this.metroGridMovie.Rows[i].Cells[4].Value.ToString() == this.metroComboBoxMovieHour.SelectedItem.ToString())
                    {
                        string[] hh = this.metroGridMovie.Rows[i].Cells[6].Value.ToString().Split(' ');
                        //MessageBox.Show(hh[0]);
                        if (hh[0] == gg[0])
                        {
                            if (this.metroGridMovie.Rows[i].Cells[1].Value.ToString() != this.metroTextBoxMovieId.Text)
                            {
                                conformation1 = true;
                                break;
                            }
                            else
                                continue;
                        }
                        else
                        {
                            continue;
                        }
                        
                    }
                    else
                    {
                        continue;
                    }
                }
                //MessageBox.Show(conformation1.ToString());

                if (!conformation1)
                {
                    if (movie.MovieId != null && movie.MovieName != null && movie.MovieLanguage != null && movie.MovieType != null && movie.MovieHour != null && movie.MovieDate != null)
                    {
                        int serial = repoManage.AutoIDValue();
                        repoManage.AppId = (++serial).ToString();
                        string appidcheck = repoManage.AppId;
                        if (appidcheck == this.metroTextBoxMovieId.Text)
                        {
                            bool conformation3 = repoManage.Save(movie);
                            //MessageBox.Show(conformation1.ToString());
                            if (conformation3 == true)
                            {
                                MessageBox.Show("New Movie Info Added");
                                bool conformation4 = repoSeat.Insert(movie.MovieId);
                                //MessageBox.Show(conformation2.ToString());
                                if (conformation4 == true)
                                {
                                    MessageBox.Show("Seat's Info For This New Movie Added");
                                }
                                else
                                    MessageBox.Show("Failed To Create Seat's Info For This New Movie");
                            }
                            else
                            {
                                MessageBox.Show("Failed To Add New Movie Info");
                            }
                        }
                        else
                        {
                            bool conformation3 = repoManage.Save(movie);
                            //MessageBox.Show(conformation1.ToString());
                            if (conformation3 == true)
                                MessageBox.Show("Movie Info Updated");
                            else
                                MessageBox.Show("Failed To Updated Movie Info");
                        }

                        string s = null;
                        this.PopulateMetroGrid(s);
                        this.ClearAll();
                    }
                    else
                        MessageBox.Show("Please,Fill All The Info First To Save.");
                }
                else
                    MessageBox.Show("Alredy there is a show at the time that you selected on this date");
                
              

            }
            catch(Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
                MessageBox.Show("Please Fill All The Info First To Save.");
            }
            
        }

        private void FillEntity()
        {
            try
            {
                if (!IsValidToSave())
                {
                    movie.MovieId = null;
                    movie.MovieName = null;
                    movie.MovieLanguage = null;
                    movie.MovieType = null;
                    movie.MovieHour = null;
                    return;
                }

                //MessageBox.Show(this.metroDateTimeMovieDate.Value.ToString());
                movie.MovieId = this.metroTextBoxMovieId.Text;
                movie.MovieName = this.metroTextBoxMovieName.Text;
                movie.MovieLanguage = this.metroComboBoxMovieLanguage.SelectedItem.ToString();
                movie.MovieType = this.metroComboBoxMovieType.SelectedItem.ToString();
                movie.MovieHour = this.metroComboBoxMovieHour.SelectedItem.ToString();
                movie.MovieDate = DateTime.Parse(this.metroDateTimeMovieDate.Value.ToString());
                //MessageBox.Show("entity fill done");     //for test
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
                if (Validation.IsStringValid(this.metroTextBoxMovieName.Text) && Validation.IsDateTimeValid(this.metroDateTimeMovieDate.Value.ToString()))
                {
                    //MessageBox.Show("valid");     //for test
                    return true;
                }
                else
                {
                    //MessageBox.Show("invalid");    //for test
                    return false;
                }
            }
            catch //(Exception exception)
            {
                //MessageBox.Show("Error:" + exception.Message);
                return false;
            }

        }

        private void MetroFormMovie_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
       
    }
}
