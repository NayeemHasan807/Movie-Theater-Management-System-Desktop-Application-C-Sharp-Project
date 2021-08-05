namespace MTMS.App.GUI
{
    partial class MetroFormBookingDashboard
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
            this.metroPanelBookingDashboard = new MetroFramework.Controls.MetroPanel();
            this.metroButtonLogout = new MetroFramework.Controls.MetroButton();
            this.metroButtonBack = new MetroFramework.Controls.MetroButton();
            this.metroButtonManageMember = new MetroFramework.Controls.MetroButton();
            this.metroButtonBookingForCustomer = new MetroFramework.Controls.MetroButton();
            this.metroButtonBookingForMember = new MetroFramework.Controls.MetroButton();
            this.metroPanelBookingDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelBookingDashboard
            // 
            this.metroPanelBookingDashboard.Controls.Add(this.metroButtonLogout);
            this.metroPanelBookingDashboard.Controls.Add(this.metroButtonBack);
            this.metroPanelBookingDashboard.Controls.Add(this.metroButtonManageMember);
            this.metroPanelBookingDashboard.Controls.Add(this.metroButtonBookingForCustomer);
            this.metroPanelBookingDashboard.Controls.Add(this.metroButtonBookingForMember);
            this.metroPanelBookingDashboard.HorizontalScrollbarBarColor = true;
            this.metroPanelBookingDashboard.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelBookingDashboard.HorizontalScrollbarSize = 10;
            this.metroPanelBookingDashboard.Location = new System.Drawing.Point(23, 63);
            this.metroPanelBookingDashboard.Name = "metroPanelBookingDashboard";
            this.metroPanelBookingDashboard.Size = new System.Drawing.Size(754, 364);
            this.metroPanelBookingDashboard.TabIndex = 6;
            this.metroPanelBookingDashboard.VerticalScrollbarBarColor = true;
            this.metroPanelBookingDashboard.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelBookingDashboard.VerticalScrollbarSize = 10;
            // 
            // metroButtonLogout
            // 
            this.metroButtonLogout.Location = new System.Drawing.Point(382, 222);
            this.metroButtonLogout.Name = "metroButtonLogout";
            this.metroButtonLogout.Size = new System.Drawing.Size(98, 36);
            this.metroButtonLogout.TabIndex = 11;
            this.metroButtonLogout.Text = "Logout";
            this.metroButtonLogout.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButtonLogout.UseSelectable = true;
            this.metroButtonLogout.Click += new System.EventHandler(this.metroButtonLogout_Click);
            // 
            // metroButtonBack
            // 
            this.metroButtonBack.Location = new System.Drawing.Point(265, 222);
            this.metroButtonBack.Name = "metroButtonBack";
            this.metroButtonBack.Size = new System.Drawing.Size(98, 36);
            this.metroButtonBack.TabIndex = 10;
            this.metroButtonBack.Text = "Back";
            this.metroButtonBack.UseSelectable = true;
            this.metroButtonBack.Click += new System.EventHandler(this.metroButtonBack_Click);
            // 
            // metroButtonManageMember
            // 
            this.metroButtonManageMember.Location = new System.Drawing.Point(265, 171);
            this.metroButtonManageMember.Name = "metroButtonManageMember";
            this.metroButtonManageMember.Size = new System.Drawing.Size(215, 36);
            this.metroButtonManageMember.TabIndex = 8;
            this.metroButtonManageMember.Text = "Manage Member";
            this.metroButtonManageMember.UseSelectable = true;
            this.metroButtonManageMember.Click += new System.EventHandler(this.metroButtonManageMember_Click);
            // 
            // metroButtonBookingForCustomer
            // 
            this.metroButtonBookingForCustomer.Location = new System.Drawing.Point(265, 129);
            this.metroButtonBookingForCustomer.Name = "metroButtonBookingForCustomer";
            this.metroButtonBookingForCustomer.Size = new System.Drawing.Size(215, 36);
            this.metroButtonBookingForCustomer.TabIndex = 7;
            this.metroButtonBookingForCustomer.Text = "Booking For Customer";
            this.metroButtonBookingForCustomer.UseSelectable = true;
            this.metroButtonBookingForCustomer.Click += new System.EventHandler(this.metroButtonBookingForCustomer_Click);
            // 
            // metroButtonBookingForMember
            // 
            this.metroButtonBookingForMember.Location = new System.Drawing.Point(265, 87);
            this.metroButtonBookingForMember.Name = "metroButtonBookingForMember";
            this.metroButtonBookingForMember.Size = new System.Drawing.Size(215, 36);
            this.metroButtonBookingForMember.TabIndex = 6;
            this.metroButtonBookingForMember.Text = "Booking For Member";
            this.metroButtonBookingForMember.UseSelectable = true;
            this.metroButtonBookingForMember.Click += new System.EventHandler(this.metroButtonBookingForMember_Click);
            // 
            // MetroFormBookingDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanelBookingDashboard);
            this.Name = "MetroFormBookingDashboard";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Booking Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MetroFormBookingDashboard_FormClosed);
            this.metroPanelBookingDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelBookingDashboard;
        private MetroFramework.Controls.MetroButton metroButtonLogout;
        private MetroFramework.Controls.MetroButton metroButtonBack;
        private MetroFramework.Controls.MetroButton metroButtonManageMember;
        private MetroFramework.Controls.MetroButton metroButtonBookingForCustomer;
        private MetroFramework.Controls.MetroButton metroButtonBookingForMember;

    }
}