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
    public partial class MetroFormBookingForMember : MetroForm
    {
        private Booking booking = new Booking();
        private BookingRepo repoManage = new BookingRepo();
        private MovieRepo repoManageMovie = new MovieRepo();
        private MemberRepo repoManageMember = new MemberRepo();
        private Seat seat = new Seat();
        private SeatRepo repoManageSeat = new SeatRepo();

        private string updatebookingseatcheck;
        private string userstatus;
        private string userid;

        public MetroFormBookingForMember(string userstatus, string userid)
        {
            InitializeComponent();
            this.userstatus = userstatus;
            this.userid = userid;
            this.metroTextBoxTicketId.Enabled = false;
            this.metroTextBoxMemberOrCustomerId.Enabled = false;
            this.metroTextBoxMovieId.Enabled = false;
            this.metroTextBoxMovieName.Enabled = false;
        }

        private void MetroFormBookingForMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void MetroFormBookingForMember_Load(object sender, EventArgs e)
        {
            this.LoadAutoAppId();
            string s = null;
            string ss = "select * from Booking where memberOrCustomerId like 'Me-%';";
            this.PopulateMetroGridBooking(ss);
            this.PopulateMetroGridMovie(s);
            this.PopulateMetroGridMember(s);
        }

        private void LoadAutoAppId()
        {
            int serial = repoManage.AutoIDValue();
            repoManage.AppId = (++serial).ToString();
            this.metroTextBoxTicketId.Text = repoManage.AppId;
        }

        private void PopulateMetroGridBooking(string query)
        {
            this.metroGridBooking.AutoGenerateColumns = false;
            this.metroGridBooking.DataSource = repoManage.GetAll(query).ToList();
            this.metroGridBooking.ClearSelection();
            this.metroGridBooking.Refresh();
        }

        private void PopulateMetroGridMovie(string query)
        {
            this.metroGridMovie.AutoGenerateColumns = false;
            this.metroGridMovie.DataSource = repoManageMovie.GetAll(query).ToList();
            this.metroGridMovie.ClearSelection();
            this.metroGridMovie.Refresh();
        }

        private void PopulateMetroGridMember(string query)
        {
            this.metroGridMember.AutoGenerateColumns = false;
            this.metroGridMember.DataSource = repoManageMember.GetAll(query).ToList();
            this.metroGridMember.ClearSelection();
            this.metroGridMember.Refresh();
        }

        private void metroButtonRefreshMember_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearchMember.Text = null;
            string s = null;
            this.PopulateMetroGridMember(s);
        }

        private void refreshToolStripMenuItemMember_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearchMember.Text = null;
            string s = null;
            this.PopulateMetroGridMember(s);
        }

        private void metroButtonRefreshMovie_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearchMovie.Text = null;
            string s = null;
            this.PopulateMetroGridMovie(s);
        }

        private void refreshToolStripMenuItemMovie_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearchMovie.Text = null;
            string s = null;
            this.PopulateMetroGridMovie(s);
        }

        private void metroButtonRefreshBooking_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearchBooking.Text = null;
            string ss = "select * from Booking where memberOrCustomerId like 'Me-%';";
            this.PopulateMetroGridBooking(ss);
        }

        private void refreshToolStripMenuItemBooking_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearchBooking.Text = null;
            string ss = "select * from Booking where memberOrCustomerId like 'Me-%';";
            this.PopulateMetroGridBooking(ss);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.metroTextBoxSearchMember.Text = null;
            this.metroTextBoxSearchMovie.Text = null;
            this.metroTextBoxSearchBooking.Text = null;
            string s = null;
            string ss = "select * from Booking where memberOrCustomerId like 'Me-%';";
            this.PopulateMetroGridMember(s);
            this.PopulateMetroGridMovie(s);
            this.PopulateMetroGridBooking(ss);
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

            this.metroTextBoxMemberOrCustomerId.Text = null;
            this.metroTextBoxMovieId.Text = null;
            this.metroTextBoxMovieName.Text = null;
            this.metroDateTimeBookingDate.Text = null;
            this.metroTextBoxBookingTime.Text = null;
            this.metroComboBoxSeatNumber.SelectedItem = null;
        }

        private void metroGridBooking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.UpdateBooking();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
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

                this.metroTextBoxTicketId.Text = this.metroGridBooking.CurrentRow.Cells["ticketId"].Value.ToString();
                this.metroTextBoxMemberOrCustomerId.Text = this.metroGridBooking.CurrentRow.Cells["memberOrCustomerId"].Value.ToString();
                this.metroTextBoxMovieId.Text = this.metroGridBooking.CurrentRow.Cells["movieIdBooking"].Value.ToString();
                this.metroTextBoxMovieName.Text = this.metroGridBooking.CurrentRow.Cells["movieNameBooking"].Value.ToString();
                this.metroDateTimeBookingDate.Value = DateTime.Parse(this.metroGridBooking.CurrentRow.Cells["bookingDate"].Value.ToString());
                this.metroTextBoxBookingTime.Text = this.metroGridBooking.CurrentRow.Cells["bookingTime"].Value.ToString();
                this.metroComboBoxSeatNumber.Text = this.metroGridBooking.CurrentRow.Cells["seatNumber"].Value.ToString();
                this.updatebookingseatcheck = this.metroGridBooking.CurrentRow.Cells["seatNumber"].Value.ToString();
                //MessageBox.Show(updatebookingseatcheck);
           
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
            }
        }

        private void useInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.UpdateMember();
        }

        private void metroGridMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.UpdateMember();
        }

        private void metroGridMember_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.UpdateMember();
        }

        private void UpdateMember()
        {
            try
            {
                if (this.metroGridMember.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select A Row First");
                    return;
                }

                this.metroTextBoxMemberOrCustomerId.Text = this.metroGridMember.CurrentRow.Cells["memberId"].Value.ToString();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
            }
        }

        private void useInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.UpdateMovie();
        }

        private void metroGridMovie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.UpdateMovie();
        }

        private void metroGridMovie_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.UpdateMovie();
        }

        private void UpdateMovie()
        {
            try
            {
                if (this.metroGridMovie.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select A Row First");
                    return;
                }

                this.metroTextBoxMovieId.Text = this.metroGridMovie.CurrentRow.Cells["movieIdMovie"].Value.ToString();
                this.metroTextBoxMovieName.Text = this.metroGridMovie.CurrentRow.Cells["movieNameMovie"].Value.ToString();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
            }

        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            this.DeleteBooking();
        }

        private void deleteToolStripMenuItemBooking_Click(object sender, EventArgs e)
        {
            this.DeleteBooking();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DeleteBooking();
        }

        private void DeleteBooking()
        {
            try
            {
                if (this.metroGridBooking.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select A Row First");
                    return;
                }

                if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                seat = repoManageSeat.GetSeatInfo(this.metroGridBooking.CurrentRow.Cells["movieIdBooking"].Value.ToString());
                bool conformation = this.FreeUpSeat(this.metroGridBooking.CurrentRow.Cells["seatNumber"].Value.ToString());
                if (conformation)
                {
                    bool decision1 = repoManageSeat.Update(seat);
                    if (decision1)
                    {
                        string ticketId = this.metroGridBooking.CurrentRow.Cells["ticketId"].Value.ToString();
                        bool decision2 = repoManage.Delete(ticketId);
                        if (decision2)
                        {
                            MessageBox.Show("Booking Info Deleted.");
                            string ss = "select * from Booking where memberOrCustomerId like 'Me-%';";
                            this.PopulateMetroGridBooking(ss);
                            this.LoadAutoAppId();
                        }
                        else
                            MessageBox.Show("Failed To Delete Booking Info.");
                    }
                    else
                        MessageBox.Show("Failed To Delete Booking Info.");
                }
                else
                    MessageBox.Show("Failed To Delete Booking Info.");

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
            }
        }

        private bool FreeUpSeat(string seatnumber)
        {
            try
            {

                if (seatnumber == "s101")
                {
                    seat.S101 = "Available";
                    return true;
                }
                else if (seatnumber == "s102")
                {
                    seat.S102 = "Available";
                    return true;
                }
                else if (seatnumber == "s103")
                {
                    seat.S103 = "Available";
                    return true;
                }
                else if (seatnumber == "s104")
                {
                    seat.S104 = "Available";
                    return true;
                }
                else if (seatnumber == "s105")
                {
                    seat.S105 = "Available";
                    return true;
                }
                else if (seatnumber == "s106")
                {
                    seat.S106 = "Available";
                    return true;
                }
                else if (seatnumber == "s107")
                {
                    seat.S107 = "Available";
                    return true;
                }
                else if (seatnumber == "s108")
                {
                    seat.S108 = "Available";
                    return true;
                }
                else if (seatnumber == "s109")
                {
                    seat.S109 = "Available";
                    return true;
                }
                else if (seatnumber == "s110")
                {
                    seat.S110 = "Available";
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveBooking();
        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            this.SaveBooking();
        }

        private void SaveBooking()
        {
            try
            {
                this.FillEntity();
                seat = repoManageSeat.GetSeatInfo(this.metroTextBoxMovieId.Text);

                if (booking.TicketId != null && booking.MemberOrCustomerId != null && booking.MovieId != null && booking.MovieName != null && booking.BookingDate != null && booking.BookingTime != null && booking.SeatNumber != null)
                {
                    int serial = repoManage.AutoIDValue();
                    repoManage.AppId = (++serial).ToString();
                    string appidcheck = repoManage.AppId;
                    if (appidcheck == this.metroTextBoxTicketId.Text)
                    {
                        bool conformation = FillUpSeat();
                        if (conformation)
                        {
                            bool decision = repoManageSeat.Update(seat);
                            if (decision)
                            {
                                bool decision1 = repoManage.Save(booking);
                                if (decision1 == true)
                                {
                                    MessageBox.Show("Booking Info Saved");
                                    string ss = "select * from Booking where memberOrCustomerId like 'Me-%';";
                                    this.PopulateMetroGridBooking(ss);
                                    this.ClearAll();
                                }
                                else
                                {
                                    MessageBox.Show("Failed To Save Booking Info");
                                }
                            }
                            else
                                MessageBox.Show("Faid To Save Booking Info");
                        }
                        else
                            MessageBox.Show("This Seat Is Not Available.Please, Select Another Seat");
                    }
                    else
                    {
                        if (updatebookingseatcheck == booking.SeatNumber)
                        {
                            bool decision = repoManage.Save(booking);
                            if (decision == true)
                            {
                                MessageBox.Show("Booking Info Updated");
                                string ss = "select * from Booking where memberOrCustomerId like 'Me-%';";
                                this.PopulateMetroGridBooking(ss);
                                this.ClearAll();
                            }
                            else
                                MessageBox.Show("Failed To Update Booking Info");
                        }
                        else
                        {
                            bool conformation1 = FreeUpSeat(updatebookingseatcheck);
                            bool conformation2 = FillUpSeat();
                            if (conformation1 && conformation2)
                            {
                                repoManageSeat.Update(seat);
                                bool decision = repoManage.Save(booking);
                                if (decision == true)
                                {
                                    MessageBox.Show("Booking Info Updated.");
                                    string ss = "select * from Booking where memberOrCustomerId like 'Me-%';";
                                    this.PopulateMetroGridBooking(ss);
                                    this.ClearAll();
                                }
                                else
                                    MessageBox.Show("Failed To Update Booking Info.");

                            }
                            else
                                MessageBox.Show("Failed To Update Booking Info.");

                        }
                        
                    }

                }
                else
                    MessageBox.Show("Please,Fill All The Info First To Save.");


            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
                MessageBox.Show("Please Fill All The Info First To Save.");
            }
        }

        private bool FillUpSeat()
        {
            try
            {
                string seatnumber = this.metroComboBoxSeatNumber.SelectedItem.ToString();
                //MessageBox.Show(seatnumber);

                if (seatnumber == "s101")
                {
                    if (seat.S101 == "Available")
                    {
                        seat.S101 = "Booked";
                        return true;
                    }
                    return false;
                }
                else if (seatnumber == "s102")
                {
                    if (seat.S102 == "Available")
                    {
                        seat.S102 = "Booked";
                        return true;
                    }
                    return false;
                }
                else if (seatnumber == "s103")
                {
                    if (seat.S103 == "Available")
                    {
                        seat.S103 = "Booked";
                        return true;
                    }
                    return false;
                }
                else if (seatnumber == "s104")
                {
                    if (seat.S104 == "Available")
                    {
                        seat.S104 = "Booked";
                        return true;
                    }
                    return false;
                }
                else if (seatnumber == "s105")
                {
                    if (seat.S105 == "Available")
                    {
                        seat.S105 = "Booked";
                        return true;
                    }
                    return false;
                }
                else if (seatnumber == "s106")
                {
                    if (seat.S106 == "Available")
                    {
                        seat.S106 = "Booked";
                        return true;
                    }
                    return false;
                }
                else if (seatnumber == "s107")
                {
                    if (seat.S107 == "Available")
                    {
                        seat.S107 = "Booked";
                        return true;
                    }
                    return false;
                }
                else if (seatnumber == "s108")
                {
                    if (seat.S108 == "Available")
                    {
                        seat.S108 = "Booked";
                        return true;
                    }
                    return false;
                }
                else if (seatnumber == "s109")
                {
                    if (seat.S109 == "Available")
                    {
                        seat.S109 = "Booked";
                        return true;
                    }
                    return false;
                }
                else if (seatnumber == "s110")
                {
                    if (seat.S110 == "Available")
                    {
                        seat.S110 = "Booked";
                        return true;
                    }
                    return false;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        private void FillEntity()
        {
            try
            {
                if (!IsValidToSave())
                {
                    booking.TicketId = null;
                    booking.MemberOrCustomerId = null;
                    booking.MovieId = null;
                    booking.MovieName = null;
                    booking.BookingTime = null;
                    booking.SeatNumber = null;
                    return;
                }


                booking.TicketId = this.metroTextBoxTicketId.Text;
                booking.MemberOrCustomerId = this.metroTextBoxMemberOrCustomerId.Text;
                booking.MovieId = this.metroTextBoxMovieId.Text;
                booking.MovieName = this.metroTextBoxMovieName.Text;
                booking.BookingDate = DateTime.Parse(this.metroDateTimeBookingDate.Value.ToString());
                booking.BookingTime = this.metroTextBoxBookingTime.Text;
                booking.SeatNumber = this.metroComboBoxSeatNumber.SelectedItem.ToString();


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
                if (Validation.IsStringValid(this.metroTextBoxTicketId.Text) && Validation.IsStringValid(this.metroTextBoxMemberOrCustomerId.Text) && Validation.IsStringValid(this.metroTextBoxMovieId.Text) && Validation.IsStringValid(this.metroTextBoxMovieName.Text) && Validation.IsStringValid(this.metroTextBoxBookingTime.Text) && Validation.IsStringValid(this.metroComboBoxSeatNumber.SelectedItem.ToString()) && Validation.IsDateTimeValid(this.metroDateTimeBookingDate.Value.ToString()))
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

        private void metroTextBoxSearchMember_TextChanged(object sender, EventArgs e)
        {
            var query = "select * from Member where memberId like '%" + this.metroTextBoxSearchMember.Text + "%' or memberName like '%" + this.metroTextBoxSearchMember.Text + "%';";
            this.PopulateMetroGridMember(query);
        }

        private void metroTextBoxSearchMovie_TextChanged(object sender, EventArgs e)
        {
            var query = "select * from Movie where movieId like '%" + this.metroTextBoxSearchMovie.Text + "%' or movieName like '%" + this.metroTextBoxSearchMovie.Text + "%' or movieHour like '%" + this.metroTextBoxSearchMovie.Text + "%' or movieDate like '%" + this.metroTextBoxSearchMovie.Text + "%' ;";
            this.PopulateMetroGridMovie(query);
        }

        private void metroTextBoxSearchBooking_TextChanged(object sender, EventArgs e)
        {
            var query = "select * from Booking where ticketId like '%" + this.metroTextBoxSearchBooking.Text + "%' or memberOrCustomerId like '%" + this.metroTextBoxSearchBooking.Text + "%' or movieId like '%" + this.metroTextBoxSearchBooking.Text + "%' or movieName like '%" + this.metroTextBoxSearchBooking.Text + "%' or bookingDate like '%" + this.metroTextBoxSearchBooking.Text + "%' or bookingTime like '%" + this.metroTextBoxSearchBooking.Text + "%' or seatNumber like '%" + this.metroTextBoxSearchBooking.Text + "%';";
            this.PopulateMetroGridBooking(query);
        }
    }
}
