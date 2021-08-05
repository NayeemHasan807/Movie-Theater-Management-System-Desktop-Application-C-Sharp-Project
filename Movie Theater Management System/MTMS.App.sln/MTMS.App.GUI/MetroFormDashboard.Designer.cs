namespace MTMS.App.GUI
{
    partial class MetroFormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanelDashboard = new MetroFramework.Controls.MetroPanel();
            this.metroButtonManageSeat = new MetroFramework.Controls.MetroButton();
            this.metroButtonManageMovie = new MetroFramework.Controls.MetroButton();
            this.metroButtonManageBooking = new MetroFramework.Controls.MetroButton();
            this.metroButtonLogout = new MetroFramework.Controls.MetroButton();
            this.metroButtonSeeOwnInfo = new MetroFramework.Controls.MetroButton();
            this.metroButtonManagePayment = new MetroFramework.Controls.MetroButton();
            this.metroButtonManageEmployee = new MetroFramework.Controls.MetroButton();
            this.metroPanelDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelDashboard
            // 
            this.metroPanelDashboard.Controls.Add(this.metroButtonManageSeat);
            this.metroPanelDashboard.Controls.Add(this.metroButtonManageMovie);
            this.metroPanelDashboard.Controls.Add(this.metroButtonManageBooking);
            this.metroPanelDashboard.Controls.Add(this.metroButtonLogout);
            this.metroPanelDashboard.Controls.Add(this.metroButtonSeeOwnInfo);
            this.metroPanelDashboard.Controls.Add(this.metroButtonManagePayment);
            this.metroPanelDashboard.Controls.Add(this.metroButtonManageEmployee);
            this.metroPanelDashboard.HorizontalScrollbarBarColor = true;
            this.metroPanelDashboard.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelDashboard.HorizontalScrollbarSize = 10;
            this.metroPanelDashboard.Location = new System.Drawing.Point(23, 63);
            this.metroPanelDashboard.Name = "metroPanelDashboard";
            this.metroPanelDashboard.Size = new System.Drawing.Size(754, 364);
            this.metroPanelDashboard.TabIndex = 0;
            this.metroPanelDashboard.VerticalScrollbarBarColor = true;
            this.metroPanelDashboard.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelDashboard.VerticalScrollbarSize = 10;
            // 
            // metroButtonManageSeat
            // 
            this.metroButtonManageSeat.Location = new System.Drawing.Point(527, 150);
            this.metroButtonManageSeat.Name = "metroButtonManageSeat";
            this.metroButtonManageSeat.Size = new System.Drawing.Size(112, 36);
            this.metroButtonManageSeat.TabIndex = 8;
            this.metroButtonManageSeat.Text = "Manage Seat";
            this.metroButtonManageSeat.UseSelectable = true;
            this.metroButtonManageSeat.Click += new System.EventHandler(this.metroButtonManageSeat_Click);
            // 
            // metroButtonManageMovie
            // 
            this.metroButtonManageMovie.Location = new System.Drawing.Point(320, 150);
            this.metroButtonManageMovie.Name = "metroButtonManageMovie";
            this.metroButtonManageMovie.Size = new System.Drawing.Size(112, 36);
            this.metroButtonManageMovie.TabIndex = 7;
            this.metroButtonManageMovie.Text = "Manage Movie";
            this.metroButtonManageMovie.UseSelectable = true;
            this.metroButtonManageMovie.Click += new System.EventHandler(this.metroButtonManageMovie_Click);
            // 
            // metroButtonManageBooking
            // 
            this.metroButtonManageBooking.Location = new System.Drawing.Point(413, 89);
            this.metroButtonManageBooking.Name = "metroButtonManageBooking";
            this.metroButtonManageBooking.Size = new System.Drawing.Size(112, 36);
            this.metroButtonManageBooking.TabIndex = 6;
            this.metroButtonManageBooking.Text = "Manage Booking";
            this.metroButtonManageBooking.UseSelectable = true;
            this.metroButtonManageBooking.Click += new System.EventHandler(this.metroButtonManageBooking_Click);
            // 
            // metroButtonLogout
            // 
            this.metroButtonLogout.Location = new System.Drawing.Point(413, 215);
            this.metroButtonLogout.Name = "metroButtonLogout";
            this.metroButtonLogout.Size = new System.Drawing.Size(112, 36);
            this.metroButtonLogout.TabIndex = 5;
            this.metroButtonLogout.Text = "Logout";
            this.metroButtonLogout.UseSelectable = true;
            this.metroButtonLogout.Click += new System.EventHandler(this.metroButtonLogout_Click);
            // 
            // metroButtonSeeOwnInfo
            // 
            this.metroButtonSeeOwnInfo.Location = new System.Drawing.Point(222, 215);
            this.metroButtonSeeOwnInfo.Name = "metroButtonSeeOwnInfo";
            this.metroButtonSeeOwnInfo.Size = new System.Drawing.Size(112, 36);
            this.metroButtonSeeOwnInfo.TabIndex = 4;
            this.metroButtonSeeOwnInfo.Text = "See Own Info";
            this.metroButtonSeeOwnInfo.UseSelectable = true;
            this.metroButtonSeeOwnInfo.Click += new System.EventHandler(this.metroButtonSeeOwnInfo_Click);
            // 
            // metroButtonManagePayment
            // 
            this.metroButtonManagePayment.Location = new System.Drawing.Point(108, 150);
            this.metroButtonManagePayment.Name = "metroButtonManagePayment";
            this.metroButtonManagePayment.Size = new System.Drawing.Size(112, 36);
            this.metroButtonManagePayment.TabIndex = 3;
            this.metroButtonManagePayment.Text = "Manage Payment";
            this.metroButtonManagePayment.UseSelectable = true;
            this.metroButtonManagePayment.Click += new System.EventHandler(this.metroButtonManagePayment_Click);
            // 
            // metroButtonManageEmployee
            // 
            this.metroButtonManageEmployee.Location = new System.Drawing.Point(222, 89);
            this.metroButtonManageEmployee.Name = "metroButtonManageEmployee";
            this.metroButtonManageEmployee.Size = new System.Drawing.Size(112, 36);
            this.metroButtonManageEmployee.TabIndex = 2;
            this.metroButtonManageEmployee.Text = "Manage Employee";
            this.metroButtonManageEmployee.UseSelectable = true;
            this.metroButtonManageEmployee.Click += new System.EventHandler(this.metroButtonManageEmployee_Click);
            // 
            // MetroFormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanelDashboard);
            this.Name = "MetroFormDashboard";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MetroFormDashboard_FormClosed);
            this.metroPanelDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelDashboard;
        private MetroFramework.Controls.MetroButton metroButtonManageSeat;
        private MetroFramework.Controls.MetroButton metroButtonManageMovie;
        private MetroFramework.Controls.MetroButton metroButtonManageBooking;
        private MetroFramework.Controls.MetroButton metroButtonLogout;
        private MetroFramework.Controls.MetroButton metroButtonSeeOwnInfo;
        private MetroFramework.Controls.MetroButton metroButtonManagePayment;
        private MetroFramework.Controls.MetroButton metroButtonManageEmployee;
    }
}