namespace MTMS.App.GUI
{
    partial class MetroGridManageMember
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanelManageMember = new MetroFramework.Controls.MetroPanel();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonRefresh = new MetroFramework.Controls.MetroButton();
            this.metroButtonClear = new MetroFramework.Controls.MetroButton();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.metroButtonLogout = new MetroFramework.Controls.MetroButton();
            this.metroButtonBack = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroGridManMember = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroContextMenuManageMember = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanelInfo = new MetroFramework.Controls.MetroPanel();
            this.metroTextBoxMemberEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxRewardPoint = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxMemberPhoneNo = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxMemberName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelMemberEmail = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxMemberId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelRewardPoint = new MetroFramework.Controls.MetroLabel();
            this.metroLabelMemberPhoneNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabelMemberName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelMemberId = new MetroFramework.Controls.MetroLabel();
            this.menuStripManageMember = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanelManageMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridManMember)).BeginInit();
            this.metroContextMenuManageMember.SuspendLayout();
            this.metroPanelInfo.SuspendLayout();
            this.menuStripManageMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelManageMember
            // 
            this.metroPanelManageMember.Controls.Add(this.metroButtonDelete);
            this.metroPanelManageMember.Controls.Add(this.metroButtonRefresh);
            this.metroPanelManageMember.Controls.Add(this.metroButtonClear);
            this.metroPanelManageMember.Controls.Add(this.metroButtonSave);
            this.metroPanelManageMember.Controls.Add(this.metroButtonLogout);
            this.metroPanelManageMember.Controls.Add(this.metroButtonBack);
            this.metroPanelManageMember.Controls.Add(this.metroTextBoxSearch);
            this.metroPanelManageMember.Controls.Add(this.metroGridManMember);
            this.metroPanelManageMember.Controls.Add(this.metroPanelInfo);
            this.metroPanelManageMember.Controls.Add(this.menuStripManageMember);
            this.metroPanelManageMember.HorizontalScrollbarBarColor = true;
            this.metroPanelManageMember.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelManageMember.HorizontalScrollbarSize = 10;
            this.metroPanelManageMember.Location = new System.Drawing.Point(11, 63);
            this.metroPanelManageMember.Name = "metroPanelManageMember";
            this.metroPanelManageMember.Size = new System.Drawing.Size(779, 376);
            this.metroPanelManageMember.TabIndex = 0;
            this.metroPanelManageMember.VerticalScrollbarBarColor = true;
            this.metroPanelManageMember.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelManageMember.VerticalScrollbarSize = 10;
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(327, 56);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(146, 23);
            this.metroButtonDelete.TabIndex = 20;
            this.metroButtonDelete.Text = "Delete";
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // metroButtonRefresh
            // 
            this.metroButtonRefresh.Location = new System.Drawing.Point(687, 165);
            this.metroButtonRefresh.Name = "metroButtonRefresh";
            this.metroButtonRefresh.Size = new System.Drawing.Size(89, 23);
            this.metroButtonRefresh.TabIndex = 19;
            this.metroButtonRefresh.Text = "Refresh";
            this.metroButtonRefresh.UseSelectable = true;
            this.metroButtonRefresh.Click += new System.EventHandler(this.metroButtonRefresh_Click);
            // 
            // metroButtonClear
            // 
            this.metroButtonClear.Location = new System.Drawing.Point(327, 85);
            this.metroButtonClear.Name = "metroButtonClear";
            this.metroButtonClear.Size = new System.Drawing.Size(146, 23);
            this.metroButtonClear.TabIndex = 18;
            this.metroButtonClear.Text = "Clear";
            this.metroButtonClear.UseSelectable = true;
            this.metroButtonClear.Click += new System.EventHandler(this.metroButtonClear_Click);
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(327, 27);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(146, 23);
            this.metroButtonSave.TabIndex = 17;
            this.metroButtonSave.Text = "Save";
            this.metroButtonSave.UseSelectable = true;
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // metroButtonLogout
            // 
            this.metroButtonLogout.Location = new System.Drawing.Point(405, 114);
            this.metroButtonLogout.Name = "metroButtonLogout";
            this.metroButtonLogout.Size = new System.Drawing.Size(68, 23);
            this.metroButtonLogout.TabIndex = 17;
            this.metroButtonLogout.Text = "Logout";
            this.metroButtonLogout.UseSelectable = true;
            this.metroButtonLogout.Click += new System.EventHandler(this.metroButtonLogout_Click);
            // 
            // metroButtonBack
            // 
            this.metroButtonBack.Location = new System.Drawing.Point(327, 114);
            this.metroButtonBack.Name = "metroButtonBack";
            this.metroButtonBack.Size = new System.Drawing.Size(68, 23);
            this.metroButtonBack.TabIndex = 16;
            this.metroButtonBack.Text = "Back";
            this.metroButtonBack.UseSelectable = true;
            this.metroButtonBack.Click += new System.EventHandler(this.metroButtonBack_Click);
            // 
            // metroTextBoxSearch
            // 
            // 
            // 
            // 
            this.metroTextBoxSearch.CustomButton.Image = null;
            this.metroTextBoxSearch.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.metroTextBoxSearch.CustomButton.Name = "";
            this.metroTextBoxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSearch.CustomButton.TabIndex = 1;
            this.metroTextBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSearch.CustomButton.UseSelectable = true;
            this.metroTextBoxSearch.CustomButton.Visible = false;
            this.metroTextBoxSearch.Lines = new string[0];
            this.metroTextBoxSearch.Location = new System.Drawing.Point(516, 165);
            this.metroTextBoxSearch.MaxLength = 32767;
            this.metroTextBoxSearch.Name = "metroTextBoxSearch";
            this.metroTextBoxSearch.PasswordChar = '\0';
            this.metroTextBoxSearch.PromptText = "Search";
            this.metroTextBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSearch.SelectedText = "";
            this.metroTextBoxSearch.SelectionLength = 0;
            this.metroTextBoxSearch.SelectionStart = 0;
            this.metroTextBoxSearch.ShortcutsEnabled = true;
            this.metroTextBoxSearch.Size = new System.Drawing.Size(165, 23);
            this.metroTextBoxSearch.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxSearch.TabIndex = 15;
            this.metroTextBoxSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSearch.UseSelectable = true;
            this.metroTextBoxSearch.WaterMark = "Search";
            this.metroTextBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxSearch.TextChanged += new System.EventHandler(this.metroTextBoxSearch_TextChanged);
            // 
            // metroGridManMember
            // 
            this.metroGridManMember.AllowUserToAddRows = false;
            this.metroGridManMember.AllowUserToDeleteRows = false;
            this.metroGridManMember.AllowUserToResizeRows = false;
            this.metroGridManMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridManMember.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridManMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridManMember.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridManMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridManMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridManMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridManMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.memberId,
            this.memberName,
            this.memberPhoneNo,
            this.rewardPoint,
            this.memberEmail});
            this.metroGridManMember.ContextMenuStrip = this.metroContextMenuManageMember;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridManMember.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridManMember.EnableHeadersVisualStyles = false;
            this.metroGridManMember.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridManMember.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridManMember.Location = new System.Drawing.Point(3, 194);
            this.metroGridManMember.Name = "metroGridManMember";
            this.metroGridManMember.ReadOnly = true;
            this.metroGridManMember.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridManMember.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridManMember.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridManMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridManMember.Size = new System.Drawing.Size(773, 179);
            this.metroGridManMember.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroGridManMember.TabIndex = 14;
            this.metroGridManMember.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridManMember.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridManMember_CellDoubleClick);
            this.metroGridManMember.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGridManMember_RowHeaderMouseDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // memberId
            // 
            this.memberId.DataPropertyName = "memberId";
            this.memberId.HeaderText = "MemberId";
            this.memberId.Name = "memberId";
            this.memberId.ReadOnly = true;
            // 
            // memberName
            // 
            this.memberName.DataPropertyName = "memberName";
            this.memberName.HeaderText = "MemberName";
            this.memberName.Name = "memberName";
            this.memberName.ReadOnly = true;
            // 
            // memberPhoneNo
            // 
            this.memberPhoneNo.DataPropertyName = "memberPhoneNo";
            this.memberPhoneNo.HeaderText = "MemberPhoneNo";
            this.memberPhoneNo.Name = "memberPhoneNo";
            this.memberPhoneNo.ReadOnly = true;
            // 
            // rewardPoint
            // 
            this.rewardPoint.DataPropertyName = "rewardPoint";
            this.rewardPoint.HeaderText = "RewardPoint";
            this.rewardPoint.Name = "rewardPoint";
            this.rewardPoint.ReadOnly = true;
            // 
            // memberEmail
            // 
            this.memberEmail.DataPropertyName = "memberEmail";
            this.memberEmail.HeaderText = "MemberEmail";
            this.memberEmail.Name = "memberEmail";
            this.memberEmail.ReadOnly = true;
            // 
            // metroContextMenuManageMember
            // 
            this.metroContextMenuManageMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.metroContextMenuManageMember.Name = "metroContextMenuManageMember";
            this.metroContextMenuManageMember.Size = new System.Drawing.Size(114, 70);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // metroPanelInfo
            // 
            this.metroPanelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanelInfo.Controls.Add(this.metroTextBoxMemberEmail);
            this.metroPanelInfo.Controls.Add(this.metroTextBoxRewardPoint);
            this.metroPanelInfo.Controls.Add(this.metroTextBoxMemberPhoneNo);
            this.metroPanelInfo.Controls.Add(this.metroTextBoxMemberName);
            this.metroPanelInfo.Controls.Add(this.metroLabelMemberEmail);
            this.metroPanelInfo.Controls.Add(this.metroTextBoxMemberId);
            this.metroPanelInfo.Controls.Add(this.metroLabelRewardPoint);
            this.metroPanelInfo.Controls.Add(this.metroLabelMemberPhoneNo);
            this.metroPanelInfo.Controls.Add(this.metroLabelMemberName);
            this.metroPanelInfo.Controls.Add(this.metroLabelMemberId);
            this.metroPanelInfo.HorizontalScrollbarBarColor = true;
            this.metroPanelInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelInfo.HorizontalScrollbarSize = 10;
            this.metroPanelInfo.Location = new System.Drawing.Point(3, 27);
            this.metroPanelInfo.Name = "metroPanelInfo";
            this.metroPanelInfo.Size = new System.Drawing.Size(304, 161);
            this.metroPanelInfo.TabIndex = 13;
            this.metroPanelInfo.VerticalScrollbarBarColor = true;
            this.metroPanelInfo.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelInfo.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxMemberEmail
            // 
            // 
            // 
            // 
            this.metroTextBoxMemberEmail.CustomButton.Image = null;
            this.metroTextBoxMemberEmail.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.metroTextBoxMemberEmail.CustomButton.Name = "";
            this.metroTextBoxMemberEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxMemberEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMemberEmail.CustomButton.TabIndex = 1;
            this.metroTextBoxMemberEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMemberEmail.CustomButton.UseSelectable = true;
            this.metroTextBoxMemberEmail.CustomButton.Visible = false;
            this.metroTextBoxMemberEmail.Lines = new string[0];
            this.metroTextBoxMemberEmail.Location = new System.Drawing.Point(146, 129);
            this.metroTextBoxMemberEmail.MaxLength = 32767;
            this.metroTextBoxMemberEmail.Name = "metroTextBoxMemberEmail";
            this.metroTextBoxMemberEmail.PasswordChar = '\0';
            this.metroTextBoxMemberEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMemberEmail.SelectedText = "";
            this.metroTextBoxMemberEmail.SelectionLength = 0;
            this.metroTextBoxMemberEmail.SelectionStart = 0;
            this.metroTextBoxMemberEmail.ShortcutsEnabled = true;
            this.metroTextBoxMemberEmail.Size = new System.Drawing.Size(149, 23);
            this.metroTextBoxMemberEmail.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxMemberEmail.TabIndex = 22;
            this.metroTextBoxMemberEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMemberEmail.UseSelectable = true;
            this.metroTextBoxMemberEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMemberEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxRewardPoint
            // 
            // 
            // 
            // 
            this.metroTextBoxRewardPoint.CustomButton.Image = null;
            this.metroTextBoxRewardPoint.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.metroTextBoxRewardPoint.CustomButton.Name = "";
            this.metroTextBoxRewardPoint.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxRewardPoint.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxRewardPoint.CustomButton.TabIndex = 1;
            this.metroTextBoxRewardPoint.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxRewardPoint.CustomButton.UseSelectable = true;
            this.metroTextBoxRewardPoint.CustomButton.Visible = false;
            this.metroTextBoxRewardPoint.Lines = new string[0];
            this.metroTextBoxRewardPoint.Location = new System.Drawing.Point(146, 97);
            this.metroTextBoxRewardPoint.MaxLength = 32767;
            this.metroTextBoxRewardPoint.Name = "metroTextBoxRewardPoint";
            this.metroTextBoxRewardPoint.PasswordChar = '\0';
            this.metroTextBoxRewardPoint.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRewardPoint.SelectedText = "";
            this.metroTextBoxRewardPoint.SelectionLength = 0;
            this.metroTextBoxRewardPoint.SelectionStart = 0;
            this.metroTextBoxRewardPoint.ShortcutsEnabled = true;
            this.metroTextBoxRewardPoint.Size = new System.Drawing.Size(149, 23);
            this.metroTextBoxRewardPoint.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxRewardPoint.TabIndex = 21;
            this.metroTextBoxRewardPoint.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxRewardPoint.UseSelectable = true;
            this.metroTextBoxRewardPoint.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxRewardPoint.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxMemberPhoneNo
            // 
            // 
            // 
            // 
            this.metroTextBoxMemberPhoneNo.CustomButton.Image = null;
            this.metroTextBoxMemberPhoneNo.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.metroTextBoxMemberPhoneNo.CustomButton.Name = "";
            this.metroTextBoxMemberPhoneNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxMemberPhoneNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMemberPhoneNo.CustomButton.TabIndex = 1;
            this.metroTextBoxMemberPhoneNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMemberPhoneNo.CustomButton.UseSelectable = true;
            this.metroTextBoxMemberPhoneNo.CustomButton.Visible = false;
            this.metroTextBoxMemberPhoneNo.Lines = new string[0];
            this.metroTextBoxMemberPhoneNo.Location = new System.Drawing.Point(146, 68);
            this.metroTextBoxMemberPhoneNo.MaxLength = 32767;
            this.metroTextBoxMemberPhoneNo.Name = "metroTextBoxMemberPhoneNo";
            this.metroTextBoxMemberPhoneNo.PasswordChar = '\0';
            this.metroTextBoxMemberPhoneNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMemberPhoneNo.SelectedText = "";
            this.metroTextBoxMemberPhoneNo.SelectionLength = 0;
            this.metroTextBoxMemberPhoneNo.SelectionStart = 0;
            this.metroTextBoxMemberPhoneNo.ShortcutsEnabled = true;
            this.metroTextBoxMemberPhoneNo.Size = new System.Drawing.Size(149, 23);
            this.metroTextBoxMemberPhoneNo.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxMemberPhoneNo.TabIndex = 20;
            this.metroTextBoxMemberPhoneNo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMemberPhoneNo.UseSelectable = true;
            this.metroTextBoxMemberPhoneNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMemberPhoneNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxMemberName
            // 
            // 
            // 
            // 
            this.metroTextBoxMemberName.CustomButton.Image = null;
            this.metroTextBoxMemberName.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.metroTextBoxMemberName.CustomButton.Name = "";
            this.metroTextBoxMemberName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxMemberName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMemberName.CustomButton.TabIndex = 1;
            this.metroTextBoxMemberName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMemberName.CustomButton.UseSelectable = true;
            this.metroTextBoxMemberName.CustomButton.Visible = false;
            this.metroTextBoxMemberName.Lines = new string[0];
            this.metroTextBoxMemberName.Location = new System.Drawing.Point(146, 39);
            this.metroTextBoxMemberName.MaxLength = 32767;
            this.metroTextBoxMemberName.Name = "metroTextBoxMemberName";
            this.metroTextBoxMemberName.PasswordChar = '\0';
            this.metroTextBoxMemberName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMemberName.SelectedText = "";
            this.metroTextBoxMemberName.SelectionLength = 0;
            this.metroTextBoxMemberName.SelectionStart = 0;
            this.metroTextBoxMemberName.ShortcutsEnabled = true;
            this.metroTextBoxMemberName.Size = new System.Drawing.Size(149, 23);
            this.metroTextBoxMemberName.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxMemberName.TabIndex = 19;
            this.metroTextBoxMemberName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMemberName.UseSelectable = true;
            this.metroTextBoxMemberName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMemberName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelMemberEmail
            // 
            this.metroLabelMemberEmail.AutoSize = true;
            this.metroLabelMemberEmail.Location = new System.Drawing.Point(17, 129);
            this.metroLabelMemberEmail.Name = "metroLabelMemberEmail";
            this.metroLabelMemberEmail.Size = new System.Drawing.Size(96, 19);
            this.metroLabelMemberEmail.TabIndex = 16;
            this.metroLabelMemberEmail.Text = "Member Email";
            // 
            // metroTextBoxMemberId
            // 
            // 
            // 
            // 
            this.metroTextBoxMemberId.CustomButton.Image = null;
            this.metroTextBoxMemberId.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.metroTextBoxMemberId.CustomButton.Name = "";
            this.metroTextBoxMemberId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxMemberId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMemberId.CustomButton.TabIndex = 1;
            this.metroTextBoxMemberId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMemberId.CustomButton.UseSelectable = true;
            this.metroTextBoxMemberId.CustomButton.Visible = false;
            this.metroTextBoxMemberId.Lines = new string[0];
            this.metroTextBoxMemberId.Location = new System.Drawing.Point(146, 10);
            this.metroTextBoxMemberId.MaxLength = 32767;
            this.metroTextBoxMemberId.Name = "metroTextBoxMemberId";
            this.metroTextBoxMemberId.PasswordChar = '\0';
            this.metroTextBoxMemberId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMemberId.SelectedText = "";
            this.metroTextBoxMemberId.SelectionLength = 0;
            this.metroTextBoxMemberId.SelectionStart = 0;
            this.metroTextBoxMemberId.ShortcutsEnabled = true;
            this.metroTextBoxMemberId.Size = new System.Drawing.Size(149, 23);
            this.metroTextBoxMemberId.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxMemberId.TabIndex = 18;
            this.metroTextBoxMemberId.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMemberId.UseSelectable = true;
            this.metroTextBoxMemberId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMemberId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelRewardPoint
            // 
            this.metroLabelRewardPoint.AutoSize = true;
            this.metroLabelRewardPoint.Location = new System.Drawing.Point(17, 97);
            this.metroLabelRewardPoint.Name = "metroLabelRewardPoint";
            this.metroLabelRewardPoint.Size = new System.Drawing.Size(86, 19);
            this.metroLabelRewardPoint.TabIndex = 17;
            this.metroLabelRewardPoint.Text = "Reward Point";
            // 
            // metroLabelMemberPhoneNo
            // 
            this.metroLabelMemberPhoneNo.AutoSize = true;
            this.metroLabelMemberPhoneNo.Location = new System.Drawing.Point(17, 68);
            this.metroLabelMemberPhoneNo.Name = "metroLabelMemberPhoneNo";
            this.metroLabelMemberPhoneNo.Size = new System.Drawing.Size(123, 19);
            this.metroLabelMemberPhoneNo.TabIndex = 15;
            this.metroLabelMemberPhoneNo.Text = "Member Phone No";
            // 
            // metroLabelMemberName
            // 
            this.metroLabelMemberName.AutoSize = true;
            this.metroLabelMemberName.Location = new System.Drawing.Point(17, 39);
            this.metroLabelMemberName.Name = "metroLabelMemberName";
            this.metroLabelMemberName.Size = new System.Drawing.Size(100, 19);
            this.metroLabelMemberName.TabIndex = 14;
            this.metroLabelMemberName.Text = "Member Name";
            // 
            // metroLabelMemberId
            // 
            this.metroLabelMemberId.AutoSize = true;
            this.metroLabelMemberId.Location = new System.Drawing.Point(17, 10);
            this.metroLabelMemberId.Name = "metroLabelMemberId";
            this.metroLabelMemberId.Size = new System.Drawing.Size(75, 19);
            this.metroLabelMemberId.TabIndex = 13;
            this.metroLabelMemberId.Text = "Member Id";
            // 
            // menuStripManageMember
            // 
            this.menuStripManageMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStripManageMember.Location = new System.Drawing.Point(0, 0);
            this.menuStripManageMember.Name = "menuStripManageMember";
            this.menuStripManageMember.Size = new System.Drawing.Size(779, 24);
            this.menuStripManageMember.TabIndex = 2;
            this.menuStripManageMember.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.refreshToolStripMenuItem1,
            this.backToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // MetroGridManageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanelManageMember);
            this.MainMenuStrip = this.menuStripManageMember;
            this.Name = "MetroGridManageMember";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Manage Member";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MetroGridManageMember_FormClosed);
            this.Load += new System.EventHandler(this.MetroGridManageMember_Load);
            this.metroPanelManageMember.ResumeLayout(false);
            this.metroPanelManageMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridManMember)).EndInit();
            this.metroContextMenuManageMember.ResumeLayout(false);
            this.metroPanelInfo.ResumeLayout(false);
            this.metroPanelInfo.PerformLayout();
            this.menuStripManageMember.ResumeLayout(false);
            this.menuStripManageMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelManageMember;
        private System.Windows.Forms.MenuStrip menuStripManageMember;
        private MetroFramework.Controls.MetroContextMenu metroContextMenuManageMember;
        private MetroFramework.Controls.MetroPanel metroPanelInfo;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMemberEmail;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRewardPoint;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMemberPhoneNo;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMemberName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMemberId;
        private MetroFramework.Controls.MetroLabel metroLabelRewardPoint;
        private MetroFramework.Controls.MetroLabel metroLabelMemberEmail;
        private MetroFramework.Controls.MetroLabel metroLabelMemberPhoneNo;
        private MetroFramework.Controls.MetroLabel metroLabelMemberName;
        private MetroFramework.Controls.MetroLabel metroLabelMemberId;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearch;
        private MetroFramework.Controls.MetroGrid metroGridManMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberEmail;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroButton metroButtonRefresh;
        private MetroFramework.Controls.MetroButton metroButtonClear;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private MetroFramework.Controls.MetroButton metroButtonLogout;
        private MetroFramework.Controls.MetroButton metroButtonBack;
    }
}