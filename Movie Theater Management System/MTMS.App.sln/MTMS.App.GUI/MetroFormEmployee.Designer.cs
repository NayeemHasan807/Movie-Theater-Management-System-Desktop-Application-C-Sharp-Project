namespace MTMS.App.GUI
{
    partial class MetroFormEmployee
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroGridEmployee = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroContextMenuGrid = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanelButton = new MetroFramework.Controls.MetroPanel();
            this.metroButtonLogout = new MetroFramework.Controls.MetroButton();
            this.metroBtnBack = new MetroFramework.Controls.MetroButton();
            this.metroBtnClear = new MetroFramework.Controls.MetroButton();
            this.metroBtnSave = new MetroFramework.Controls.MetroButton();
            this.metroBtnDelete = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanelText = new MetroFramework.Controls.MetroPanel();
            this.metroLabelEmployeeEmail = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeJoiningDate = new MetroFramework.Controls.MetroDateTime();
            this.metroTextBoxEmployeeId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelEmployeePhoneNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabelJoiningDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabelSalary = new MetroFramework.Controls.MetroLabel();
            this.metroLabelJobCategory = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEmployeeName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEmployeeId = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEmployeeEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxEmployeePhoneNo = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSalary = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxJobCategory = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxEmployeeName = new MetroFramework.Controls.MetroTextBox();
            this.metroTxtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroBtnRefresh = new MetroFramework.Controls.MetroButton();
            this.menuStripEmployee = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optioinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEmployee)).BeginInit();
            this.metroContextMenuGrid.SuspendLayout();
            this.metroPanelButton.SuspendLayout();
            this.metroPanelText.SuspendLayout();
            this.menuStripEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroGridEmployee);
            this.metroPanel1.Controls.Add(this.metroPanelButton);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroPanelText);
            this.metroPanel1.Controls.Add(this.metroTxtSearch);
            this.metroPanel1.Controls.Add(this.metroBtnRefresh);
            this.metroPanel1.Controls.Add(this.menuStripEmployee);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(10, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(779, 376);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroGridEmployee
            // 
            this.metroGridEmployee.AllowUserToAddRows = false;
            this.metroGridEmployee.AllowUserToDeleteRows = false;
            this.metroGridEmployee.AllowUserToResizeRows = false;
            this.metroGridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.metroGridEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.employeeId,
            this.employeeName,
            this.jobCategory,
            this.salary,
            this.joiningDate,
            this.employeePhoneNo,
            this.employeeEmail});
            this.metroGridEmployee.ContextMenuStrip = this.metroContextMenuGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridEmployee.EnableHeadersVisualStyles = false;
            this.metroGridEmployee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEmployee.Location = new System.Drawing.Point(0, 244);
            this.metroGridEmployee.MultiSelect = false;
            this.metroGridEmployee.Name = "metroGridEmployee";
            this.metroGridEmployee.ReadOnly = true;
            this.metroGridEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridEmployee.Size = new System.Drawing.Size(776, 129);
            this.metroGridEmployee.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroGridEmployee.TabIndex = 34;
            this.metroGridEmployee.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridEmployee_CellDoubleClick);
            this.metroGridEmployee.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGridEmployee_RowHeaderMouseDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // employeeId
            // 
            this.employeeId.DataPropertyName = "employeeId";
            this.employeeId.HeaderText = "Employee Id";
            this.employeeId.Name = "employeeId";
            this.employeeId.ReadOnly = true;
            // 
            // employeeName
            // 
            this.employeeName.DataPropertyName = "employeeName";
            this.employeeName.HeaderText = "Employee Name";
            this.employeeName.Name = "employeeName";
            this.employeeName.ReadOnly = true;
            // 
            // jobCategory
            // 
            this.jobCategory.DataPropertyName = "jobCategory";
            this.jobCategory.HeaderText = "Job Category";
            this.jobCategory.Name = "jobCategory";
            this.jobCategory.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // joiningDate
            // 
            this.joiningDate.DataPropertyName = "joiningDate";
            this.joiningDate.HeaderText = "Joining Date";
            this.joiningDate.Name = "joiningDate";
            this.joiningDate.ReadOnly = true;
            // 
            // employeePhoneNo
            // 
            this.employeePhoneNo.DataPropertyName = "employeePhoneNo";
            this.employeePhoneNo.HeaderText = "Employee Phone No";
            this.employeePhoneNo.Name = "employeePhoneNo";
            this.employeePhoneNo.ReadOnly = true;
            // 
            // employeeEmail
            // 
            this.employeeEmail.DataPropertyName = "employeeEmail";
            this.employeeEmail.HeaderText = "Employee Email";
            this.employeeEmail.Name = "employeeEmail";
            this.employeeEmail.ReadOnly = true;
            // 
            // metroContextMenuGrid
            // 
            this.metroContextMenuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.refreshToolStripMenuItem1});
            this.metroContextMenuGrid.Name = "metroContextMenuGrid";
            this.metroContextMenuGrid.Size = new System.Drawing.Size(114, 70);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // metroPanelButton
            // 
            this.metroPanelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanelButton.Controls.Add(this.metroButtonLogout);
            this.metroPanelButton.Controls.Add(this.metroBtnBack);
            this.metroPanelButton.Controls.Add(this.metroBtnClear);
            this.metroPanelButton.Controls.Add(this.metroBtnSave);
            this.metroPanelButton.Controls.Add(this.metroBtnDelete);
            this.metroPanelButton.HorizontalScrollbarBarColor = true;
            this.metroPanelButton.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelButton.HorizontalScrollbarSize = 10;
            this.metroPanelButton.Location = new System.Drawing.Point(505, 34);
            this.metroPanelButton.Name = "metroPanelButton";
            this.metroPanelButton.Size = new System.Drawing.Size(180, 141);
            this.metroPanelButton.TabIndex = 33;
            this.metroPanelButton.VerticalScrollbarBarColor = true;
            this.metroPanelButton.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelButton.VerticalScrollbarSize = 10;
            // 
            // metroButtonLogout
            // 
            this.metroButtonLogout.Location = new System.Drawing.Point(95, 88);
            this.metroButtonLogout.Name = "metroButtonLogout";
            this.metroButtonLogout.Size = new System.Drawing.Size(75, 23);
            this.metroButtonLogout.TabIndex = 25;
            this.metroButtonLogout.Text = "Logout";
            this.metroButtonLogout.UseSelectable = true;
            this.metroButtonLogout.Click += new System.EventHandler(this.metroButtonLogout_Click);
            // 
            // metroBtnBack
            // 
            this.metroBtnBack.Location = new System.Drawing.Point(10, 88);
            this.metroBtnBack.Name = "metroBtnBack";
            this.metroBtnBack.Size = new System.Drawing.Size(75, 23);
            this.metroBtnBack.TabIndex = 24;
            this.metroBtnBack.Text = "Back";
            this.metroBtnBack.UseSelectable = true;
            this.metroBtnBack.Click += new System.EventHandler(this.metroBtnBack_Click);
            // 
            // metroBtnClear
            // 
            this.metroBtnClear.Location = new System.Drawing.Point(95, 29);
            this.metroBtnClear.Name = "metroBtnClear";
            this.metroBtnClear.Size = new System.Drawing.Size(75, 23);
            this.metroBtnClear.TabIndex = 23;
            this.metroBtnClear.Text = "Clear";
            this.metroBtnClear.UseSelectable = true;
            this.metroBtnClear.Click += new System.EventHandler(this.metroBtnClear_Click);
            // 
            // metroBtnSave
            // 
            this.metroBtnSave.Location = new System.Drawing.Point(10, 29);
            this.metroBtnSave.Name = "metroBtnSave";
            this.metroBtnSave.Size = new System.Drawing.Size(75, 23);
            this.metroBtnSave.TabIndex = 22;
            this.metroBtnSave.Text = "Save";
            this.metroBtnSave.UseSelectable = true;
            this.metroBtnSave.Click += new System.EventHandler(this.metroBtnSave_Click);
            // 
            // metroBtnDelete
            // 
            this.metroBtnDelete.Location = new System.Drawing.Point(10, 59);
            this.metroBtnDelete.Name = "metroBtnDelete";
            this.metroBtnDelete.Size = new System.Drawing.Size(75, 23);
            this.metroBtnDelete.TabIndex = 21;
            this.metroBtnDelete.Text = "Delete";
            this.metroBtnDelete.UseSelectable = true;
            this.metroBtnDelete.Click += new System.EventHandler(this.metroBtnDelete_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(451, 215);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Search";
            // 
            // metroPanelText
            // 
            this.metroPanelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanelText.Controls.Add(this.metroLabelEmployeeEmail);
            this.metroPanelText.Controls.Add(this.metroDateTimeJoiningDate);
            this.metroPanelText.Controls.Add(this.metroTextBoxEmployeeId);
            this.metroPanelText.Controls.Add(this.metroLabelEmployeePhoneNo);
            this.metroPanelText.Controls.Add(this.metroLabelJoiningDate);
            this.metroPanelText.Controls.Add(this.metroLabelSalary);
            this.metroPanelText.Controls.Add(this.metroLabelJobCategory);
            this.metroPanelText.Controls.Add(this.metroLabelEmployeeName);
            this.metroPanelText.Controls.Add(this.metroLabelEmployeeId);
            this.metroPanelText.Controls.Add(this.metroTextBoxEmployeeEmail);
            this.metroPanelText.Controls.Add(this.metroTextBoxEmployeePhoneNo);
            this.metroPanelText.Controls.Add(this.metroTextBoxSalary);
            this.metroPanelText.Controls.Add(this.metroTextBoxJobCategory);
            this.metroPanelText.Controls.Add(this.metroTextBoxEmployeeName);
            this.metroPanelText.HorizontalScrollbarBarColor = true;
            this.metroPanelText.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelText.HorizontalScrollbarSize = 10;
            this.metroPanelText.Location = new System.Drawing.Point(3, 27);
            this.metroPanelText.Name = "metroPanelText";
            this.metroPanelText.Size = new System.Drawing.Size(387, 211);
            this.metroPanelText.TabIndex = 31;
            this.metroPanelText.VerticalScrollbarBarColor = true;
            this.metroPanelText.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelText.VerticalScrollbarSize = 10;
            // 
            // metroLabelEmployeeEmail
            // 
            this.metroLabelEmployeeEmail.AutoSize = true;
            this.metroLabelEmployeeEmail.Location = new System.Drawing.Point(1, 182);
            this.metroLabelEmployeeEmail.Name = "metroLabelEmployeeEmail";
            this.metroLabelEmployeeEmail.Size = new System.Drawing.Size(103, 19);
            this.metroLabelEmployeeEmail.TabIndex = 44;
            this.metroLabelEmployeeEmail.Text = "Employee Email";
            // 
            // metroDateTimeJoiningDate
            // 
            this.metroDateTimeJoiningDate.CustomFormat = "yyyy-MM-dd";
            this.metroDateTimeJoiningDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTimeJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTimeJoiningDate.Location = new System.Drawing.Point(136, 122);
            this.metroDateTimeJoiningDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateTimeJoiningDate.Name = "metroDateTimeJoiningDate";
            this.metroDateTimeJoiningDate.Size = new System.Drawing.Size(243, 25);
            this.metroDateTimeJoiningDate.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroDateTimeJoiningDate.TabIndex = 43;
            this.metroDateTimeJoiningDate.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTextBoxEmployeeId
            // 
            // 
            // 
            // 
            this.metroTextBoxEmployeeId.CustomButton.Image = null;
            this.metroTextBoxEmployeeId.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.metroTextBoxEmployeeId.CustomButton.Name = "";
            this.metroTextBoxEmployeeId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxEmployeeId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEmployeeId.CustomButton.TabIndex = 1;
            this.metroTextBoxEmployeeId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEmployeeId.CustomButton.UseSelectable = true;
            this.metroTextBoxEmployeeId.CustomButton.Visible = false;
            this.metroTextBoxEmployeeId.Lines = new string[0];
            this.metroTextBoxEmployeeId.Location = new System.Drawing.Point(136, 5);
            this.metroTextBoxEmployeeId.MaxLength = 32767;
            this.metroTextBoxEmployeeId.Name = "metroTextBoxEmployeeId";
            this.metroTextBoxEmployeeId.PasswordChar = '\0';
            this.metroTextBoxEmployeeId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEmployeeId.SelectedText = "";
            this.metroTextBoxEmployeeId.SelectionLength = 0;
            this.metroTextBoxEmployeeId.SelectionStart = 0;
            this.metroTextBoxEmployeeId.ShortcutsEnabled = true;
            this.metroTextBoxEmployeeId.Size = new System.Drawing.Size(243, 23);
            this.metroTextBoxEmployeeId.TabIndex = 42;
            this.metroTextBoxEmployeeId.UseSelectable = true;
            this.metroTextBoxEmployeeId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEmployeeId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelEmployeePhoneNo
            // 
            this.metroLabelEmployeePhoneNo.AutoSize = true;
            this.metroLabelEmployeePhoneNo.Location = new System.Drawing.Point(0, 153);
            this.metroLabelEmployeePhoneNo.Name = "metroLabelEmployeePhoneNo";
            this.metroLabelEmployeePhoneNo.Size = new System.Drawing.Size(130, 19);
            this.metroLabelEmployeePhoneNo.TabIndex = 41;
            this.metroLabelEmployeePhoneNo.Text = "Employee Phone No";
            // 
            // metroLabelJoiningDate
            // 
            this.metroLabelJoiningDate.AutoSize = true;
            this.metroLabelJoiningDate.Location = new System.Drawing.Point(0, 121);
            this.metroLabelJoiningDate.Name = "metroLabelJoiningDate";
            this.metroLabelJoiningDate.Size = new System.Drawing.Size(81, 19);
            this.metroLabelJoiningDate.TabIndex = 40;
            this.metroLabelJoiningDate.Text = "Joining Date";
            // 
            // metroLabelSalary
            // 
            this.metroLabelSalary.AutoSize = true;
            this.metroLabelSalary.Location = new System.Drawing.Point(1, 93);
            this.metroLabelSalary.Name = "metroLabelSalary";
            this.metroLabelSalary.Size = new System.Drawing.Size(45, 19);
            this.metroLabelSalary.TabIndex = 39;
            this.metroLabelSalary.Text = "Salary";
            // 
            // metroLabelJobCategory
            // 
            this.metroLabelJobCategory.AutoSize = true;
            this.metroLabelJobCategory.Location = new System.Drawing.Point(0, 63);
            this.metroLabelJobCategory.Name = "metroLabelJobCategory";
            this.metroLabelJobCategory.Size = new System.Drawing.Size(89, 19);
            this.metroLabelJobCategory.TabIndex = 38;
            this.metroLabelJobCategory.Text = "Job Category";
            // 
            // metroLabelEmployeeName
            // 
            this.metroLabelEmployeeName.AutoSize = true;
            this.metroLabelEmployeeName.Location = new System.Drawing.Point(-1, 34);
            this.metroLabelEmployeeName.Name = "metroLabelEmployeeName";
            this.metroLabelEmployeeName.Size = new System.Drawing.Size(107, 19);
            this.metroLabelEmployeeName.TabIndex = 37;
            this.metroLabelEmployeeName.Text = "Employee Name";
            // 
            // metroLabelEmployeeId
            // 
            this.metroLabelEmployeeId.AutoSize = true;
            this.metroLabelEmployeeId.Location = new System.Drawing.Point(0, 5);
            this.metroLabelEmployeeId.Name = "metroLabelEmployeeId";
            this.metroLabelEmployeeId.Size = new System.Drawing.Size(82, 19);
            this.metroLabelEmployeeId.TabIndex = 36;
            this.metroLabelEmployeeId.Text = "Employee Id";
            // 
            // metroTextBoxEmployeeEmail
            // 
            // 
            // 
            // 
            this.metroTextBoxEmployeeEmail.CustomButton.Image = null;
            this.metroTextBoxEmployeeEmail.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.metroTextBoxEmployeeEmail.CustomButton.Name = "";
            this.metroTextBoxEmployeeEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxEmployeeEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEmployeeEmail.CustomButton.TabIndex = 1;
            this.metroTextBoxEmployeeEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEmployeeEmail.CustomButton.UseSelectable = true;
            this.metroTextBoxEmployeeEmail.CustomButton.Visible = false;
            this.metroTextBoxEmployeeEmail.Lines = new string[0];
            this.metroTextBoxEmployeeEmail.Location = new System.Drawing.Point(136, 182);
            this.metroTextBoxEmployeeEmail.MaxLength = 32767;
            this.metroTextBoxEmployeeEmail.Name = "metroTextBoxEmployeeEmail";
            this.metroTextBoxEmployeeEmail.PasswordChar = '\0';
            this.metroTextBoxEmployeeEmail.PromptText = "Email";
            this.metroTextBoxEmployeeEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEmployeeEmail.SelectedText = "";
            this.metroTextBoxEmployeeEmail.SelectionLength = 0;
            this.metroTextBoxEmployeeEmail.SelectionStart = 0;
            this.metroTextBoxEmployeeEmail.ShortcutsEnabled = true;
            this.metroTextBoxEmployeeEmail.Size = new System.Drawing.Size(243, 23);
            this.metroTextBoxEmployeeEmail.TabIndex = 35;
            this.metroTextBoxEmployeeEmail.UseSelectable = true;
            this.metroTextBoxEmployeeEmail.WaterMark = "Email";
            this.metroTextBoxEmployeeEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEmployeeEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxEmployeePhoneNo
            // 
            // 
            // 
            // 
            this.metroTextBoxEmployeePhoneNo.CustomButton.Image = null;
            this.metroTextBoxEmployeePhoneNo.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.metroTextBoxEmployeePhoneNo.CustomButton.Name = "";
            this.metroTextBoxEmployeePhoneNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxEmployeePhoneNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEmployeePhoneNo.CustomButton.TabIndex = 1;
            this.metroTextBoxEmployeePhoneNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEmployeePhoneNo.CustomButton.UseSelectable = true;
            this.metroTextBoxEmployeePhoneNo.CustomButton.Visible = false;
            this.metroTextBoxEmployeePhoneNo.Lines = new string[0];
            this.metroTextBoxEmployeePhoneNo.Location = new System.Drawing.Point(136, 153);
            this.metroTextBoxEmployeePhoneNo.MaxLength = 32767;
            this.metroTextBoxEmployeePhoneNo.Name = "metroTextBoxEmployeePhoneNo";
            this.metroTextBoxEmployeePhoneNo.PasswordChar = '\0';
            this.metroTextBoxEmployeePhoneNo.PromptText = "Phone No";
            this.metroTextBoxEmployeePhoneNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEmployeePhoneNo.SelectedText = "";
            this.metroTextBoxEmployeePhoneNo.SelectionLength = 0;
            this.metroTextBoxEmployeePhoneNo.SelectionStart = 0;
            this.metroTextBoxEmployeePhoneNo.ShortcutsEnabled = true;
            this.metroTextBoxEmployeePhoneNo.Size = new System.Drawing.Size(243, 23);
            this.metroTextBoxEmployeePhoneNo.TabIndex = 34;
            this.metroTextBoxEmployeePhoneNo.UseSelectable = true;
            this.metroTextBoxEmployeePhoneNo.WaterMark = "Phone No";
            this.metroTextBoxEmployeePhoneNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEmployeePhoneNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxSalary
            // 
            // 
            // 
            // 
            this.metroTextBoxSalary.CustomButton.Image = null;
            this.metroTextBoxSalary.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.metroTextBoxSalary.CustomButton.Name = "";
            this.metroTextBoxSalary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSalary.CustomButton.TabIndex = 1;
            this.metroTextBoxSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSalary.CustomButton.UseSelectable = true;
            this.metroTextBoxSalary.CustomButton.Visible = false;
            this.metroTextBoxSalary.Lines = new string[0];
            this.metroTextBoxSalary.Location = new System.Drawing.Point(136, 93);
            this.metroTextBoxSalary.MaxLength = 32767;
            this.metroTextBoxSalary.Name = "metroTextBoxSalary";
            this.metroTextBoxSalary.PasswordChar = '\0';
            this.metroTextBoxSalary.PromptText = "Salary";
            this.metroTextBoxSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSalary.SelectedText = "";
            this.metroTextBoxSalary.SelectionLength = 0;
            this.metroTextBoxSalary.SelectionStart = 0;
            this.metroTextBoxSalary.ShortcutsEnabled = true;
            this.metroTextBoxSalary.Size = new System.Drawing.Size(243, 23);
            this.metroTextBoxSalary.TabIndex = 33;
            this.metroTextBoxSalary.UseSelectable = true;
            this.metroTextBoxSalary.WaterMark = "Salary";
            this.metroTextBoxSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxJobCategory
            // 
            // 
            // 
            // 
            this.metroTextBoxJobCategory.CustomButton.Image = null;
            this.metroTextBoxJobCategory.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.metroTextBoxJobCategory.CustomButton.Name = "";
            this.metroTextBoxJobCategory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxJobCategory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxJobCategory.CustomButton.TabIndex = 1;
            this.metroTextBoxJobCategory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxJobCategory.CustomButton.UseSelectable = true;
            this.metroTextBoxJobCategory.CustomButton.Visible = false;
            this.metroTextBoxJobCategory.Lines = new string[0];
            this.metroTextBoxJobCategory.Location = new System.Drawing.Point(136, 64);
            this.metroTextBoxJobCategory.MaxLength = 32767;
            this.metroTextBoxJobCategory.Name = "metroTextBoxJobCategory";
            this.metroTextBoxJobCategory.PasswordChar = '\0';
            this.metroTextBoxJobCategory.PromptText = "Job Category";
            this.metroTextBoxJobCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxJobCategory.SelectedText = "";
            this.metroTextBoxJobCategory.SelectionLength = 0;
            this.metroTextBoxJobCategory.SelectionStart = 0;
            this.metroTextBoxJobCategory.ShortcutsEnabled = true;
            this.metroTextBoxJobCategory.Size = new System.Drawing.Size(243, 23);
            this.metroTextBoxJobCategory.TabIndex = 32;
            this.metroTextBoxJobCategory.UseSelectable = true;
            this.metroTextBoxJobCategory.WaterMark = "Job Category";
            this.metroTextBoxJobCategory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxJobCategory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxEmployeeName
            // 
            // 
            // 
            // 
            this.metroTextBoxEmployeeName.CustomButton.Image = null;
            this.metroTextBoxEmployeeName.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.metroTextBoxEmployeeName.CustomButton.Name = "";
            this.metroTextBoxEmployeeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxEmployeeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEmployeeName.CustomButton.TabIndex = 1;
            this.metroTextBoxEmployeeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEmployeeName.CustomButton.UseSelectable = true;
            this.metroTextBoxEmployeeName.CustomButton.Visible = false;
            this.metroTextBoxEmployeeName.Lines = new string[0];
            this.metroTextBoxEmployeeName.Location = new System.Drawing.Point(136, 34);
            this.metroTextBoxEmployeeName.MaxLength = 32767;
            this.metroTextBoxEmployeeName.Name = "metroTextBoxEmployeeName";
            this.metroTextBoxEmployeeName.PasswordChar = '\0';
            this.metroTextBoxEmployeeName.PromptText = "Name";
            this.metroTextBoxEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEmployeeName.SelectedText = "";
            this.metroTextBoxEmployeeName.SelectionLength = 0;
            this.metroTextBoxEmployeeName.SelectionStart = 0;
            this.metroTextBoxEmployeeName.ShortcutsEnabled = true;
            this.metroTextBoxEmployeeName.Size = new System.Drawing.Size(243, 23);
            this.metroTextBoxEmployeeName.TabIndex = 31;
            this.metroTextBoxEmployeeName.UseSelectable = true;
            this.metroTextBoxEmployeeName.WaterMark = "Name";
            this.metroTextBoxEmployeeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEmployeeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTxtSearch
            // 
            // 
            // 
            // 
            this.metroTxtSearch.CustomButton.Image = null;
            this.metroTxtSearch.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.metroTxtSearch.CustomButton.Name = "";
            this.metroTxtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtSearch.CustomButton.TabIndex = 1;
            this.metroTxtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtSearch.CustomButton.UseSelectable = true;
            this.metroTxtSearch.CustomButton.Visible = false;
            this.metroTxtSearch.Lines = new string[0];
            this.metroTxtSearch.Location = new System.Drawing.Point(505, 215);
            this.metroTxtSearch.MaxLength = 32767;
            this.metroTxtSearch.Name = "metroTxtSearch";
            this.metroTxtSearch.PasswordChar = '\0';
            this.metroTxtSearch.PromptText = "Search";
            this.metroTxtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtSearch.SelectedText = "";
            this.metroTxtSearch.SelectionLength = 0;
            this.metroTxtSearch.SelectionStart = 0;
            this.metroTxtSearch.ShortcutsEnabled = true;
            this.metroTxtSearch.Size = new System.Drawing.Size(130, 23);
            this.metroTxtSearch.TabIndex = 2;
            this.metroTxtSearch.UseSelectable = true;
            this.metroTxtSearch.WaterMark = "Search";
            this.metroTxtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTxtSearch.TextChanged += new System.EventHandler(this.metroTxtSearch_TextChanged);
            // 
            // metroBtnRefresh
            // 
            this.metroBtnRefresh.Location = new System.Drawing.Point(641, 215);
            this.metroBtnRefresh.Name = "metroBtnRefresh";
            this.metroBtnRefresh.Size = new System.Drawing.Size(126, 23);
            this.metroBtnRefresh.TabIndex = 11;
            this.metroBtnRefresh.Text = "Refresh";
            this.metroBtnRefresh.UseSelectable = true;
            this.metroBtnRefresh.Click += new System.EventHandler(this.metroBtnRefresh_Click);
            // 
            // menuStripEmployee
            // 
            this.menuStripEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.optioinToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStripEmployee.Location = new System.Drawing.Point(0, 0);
            this.menuStripEmployee.Name = "menuStripEmployee";
            this.menuStripEmployee.Size = new System.Drawing.Size(779, 24);
            this.menuStripEmployee.TabIndex = 27;
            this.menuStripEmployee.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // optioinToolStripMenuItem
            // 
            this.optioinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.backToolStripMenuItem});
            this.optioinToolStripMenuItem.Name = "optioinToolStripMenuItem";
            this.optioinToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.optioinToolStripMenuItem.Text = "Optioin";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
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
            // MetroFormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.MainMenuStrip = this.menuStripEmployee;
            this.Name = "MetroFormEmployee";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = " Employee ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MetroFormEmployee_FormClosed);
            this.Load += new System.EventHandler(this.MetroFormEmployee_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEmployee)).EndInit();
            this.metroContextMenuGrid.ResumeLayout(false);
            this.metroPanelButton.ResumeLayout(false);
            this.metroPanelText.ResumeLayout(false);
            this.metroPanelText.PerformLayout();
            this.menuStripEmployee.ResumeLayout(false);
            this.menuStripEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox metroTxtSearch;
        private MetroFramework.Controls.MetroButton metroBtnRefresh;
        private System.Windows.Forms.MenuStrip menuStripEmployee;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optioinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private MetroFramework.Controls.MetroGrid metroGridEmployee;
        private MetroFramework.Controls.MetroPanel metroPanelButton;
        private MetroFramework.Controls.MetroButton metroButtonLogout;
        private MetroFramework.Controls.MetroButton metroBtnBack;
        private MetroFramework.Controls.MetroButton metroBtnClear;
        private MetroFramework.Controls.MetroButton metroBtnSave;
        private MetroFramework.Controls.MetroButton metroBtnDelete;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanelText;
        private MetroFramework.Controls.MetroLabel metroLabelEmployeeEmail;
        private MetroFramework.Controls.MetroDateTime metroDateTimeJoiningDate;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEmployeeId;
        private MetroFramework.Controls.MetroLabel metroLabelEmployeePhoneNo;
        private MetroFramework.Controls.MetroLabel metroLabelJoiningDate;
        private MetroFramework.Controls.MetroLabel metroLabelSalary;
        private MetroFramework.Controls.MetroLabel metroLabelJobCategory;
        private MetroFramework.Controls.MetroLabel metroLabelEmployeeName;
        private MetroFramework.Controls.MetroLabel metroLabelEmployeeId;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEmployeeEmail;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEmployeePhoneNo;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSalary;
        private MetroFramework.Controls.MetroTextBox metroTextBoxJobCategory;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEmployeeName;
        private MetroFramework.Controls.MetroContextMenu metroContextMenuGrid;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmail;
    }
}