namespace SAD_CW3_2017_2018_00004628
{
    partial class StaffForm
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
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.chkStaffGender = new MetroFramework.Controls.MetroCheckBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.picStaff = new System.Windows.Forms.PictureBox();
            this.txtStaffModules = new MetroFramework.Controls.MetroTextBox();
            this.txtStaffEdBackgr = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtStaffBithdate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtStaffAge = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtStaffType = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtStaffName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pContainer = new MetroFramework.Controls.MetroPanel();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.staffGrid = new MetroFramework.Controls.MetroGrid();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edBackgroundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).BeginInit();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 504);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 504);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(295, 504);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(376, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkStaffGender
            // 
            this.chkStaffGender.AutoSize = true;
            this.chkStaffGender.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.staffBindingSource, "Gender", true));
            this.chkStaffGender.Location = new System.Drawing.Point(269, 262);
            this.chkStaffGender.Name = "chkStaffGender";
            this.chkStaffGender.Size = new System.Drawing.Size(38, 15);
            this.chkStaffGender.TabIndex = 6;
            this.chkStaffGender.Text = "???";
            this.chkStaffGender.UseSelectable = true;
            this.chkStaffGender.CheckStateChanged += new System.EventHandler(this.chkStaffGender_CheckStateChanged);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(SAD_CW3_2017_2018_00004628.Staff);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(43, 170);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picStaff
            // 
            this.picStaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picStaff.Location = new System.Drawing.Point(6, 14);
            this.picStaff.Name = "picStaff";
            this.picStaff.Size = new System.Drawing.Size(150, 150);
            this.picStaff.TabIndex = 4;
            this.picStaff.TabStop = false;
            // 
            // txtStaffModules
            // 
            // 
            // 
            // 
            this.txtStaffModules.CustomButton.Image = null;
            this.txtStaffModules.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtStaffModules.CustomButton.Name = "";
            this.txtStaffModules.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStaffModules.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffModules.CustomButton.TabIndex = 1;
            this.txtStaffModules.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStaffModules.CustomButton.UseSelectable = true;
            this.txtStaffModules.CustomButton.Visible = false;
            this.txtStaffModules.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Modules", true));
            this.txtStaffModules.Lines = new string[0];
            this.txtStaffModules.Location = new System.Drawing.Point(269, 218);
            this.txtStaffModules.MaxLength = 32767;
            this.txtStaffModules.Name = "txtStaffModules";
            this.txtStaffModules.PasswordChar = '\0';
            this.txtStaffModules.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStaffModules.SelectedText = "";
            this.txtStaffModules.SelectionLength = 0;
            this.txtStaffModules.SelectionStart = 0;
            this.txtStaffModules.ShortcutsEnabled = true;
            this.txtStaffModules.Size = new System.Drawing.Size(139, 23);
            this.txtStaffModules.TabIndex = 3;
            this.txtStaffModules.UseSelectable = true;
            this.txtStaffModules.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStaffModules.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStaffEdBackgr
            // 
            // 
            // 
            // 
            this.txtStaffEdBackgr.CustomButton.Image = null;
            this.txtStaffEdBackgr.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.txtStaffEdBackgr.CustomButton.Name = "";
            this.txtStaffEdBackgr.CustomButton.Size = new System.Drawing.Size(113, 113);
            this.txtStaffEdBackgr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffEdBackgr.CustomButton.TabIndex = 1;
            this.txtStaffEdBackgr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStaffEdBackgr.CustomButton.UseSelectable = true;
            this.txtStaffEdBackgr.CustomButton.Visible = false;
            this.txtStaffEdBackgr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "EdBackground", true));
            this.txtStaffEdBackgr.Lines = new string[0];
            this.txtStaffEdBackgr.Location = new System.Drawing.Point(269, 290);
            this.txtStaffEdBackgr.MaxLength = 32767;
            this.txtStaffEdBackgr.Multiline = true;
            this.txtStaffEdBackgr.Name = "txtStaffEdBackgr";
            this.txtStaffEdBackgr.PasswordChar = '\0';
            this.txtStaffEdBackgr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStaffEdBackgr.SelectedText = "";
            this.txtStaffEdBackgr.SelectionLength = 0;
            this.txtStaffEdBackgr.SelectionStart = 0;
            this.txtStaffEdBackgr.ShortcutsEnabled = true;
            this.txtStaffEdBackgr.Size = new System.Drawing.Size(139, 115);
            this.txtStaffEdBackgr.TabIndex = 3;
            this.txtStaffEdBackgr.UseSelectable = true;
            this.txtStaffEdBackgr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStaffEdBackgr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(181, 218);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(62, 19);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Modules:";
            // 
            // txtStaffBithdate
            // 
            // 
            // 
            // 
            this.txtStaffBithdate.CustomButton.Image = null;
            this.txtStaffBithdate.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtStaffBithdate.CustomButton.Name = "";
            this.txtStaffBithdate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStaffBithdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffBithdate.CustomButton.TabIndex = 1;
            this.txtStaffBithdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStaffBithdate.CustomButton.UseSelectable = true;
            this.txtStaffBithdate.CustomButton.Visible = false;
            this.txtStaffBithdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "BirthDate", true));
            this.txtStaffBithdate.Lines = new string[0];
            this.txtStaffBithdate.Location = new System.Drawing.Point(269, 179);
            this.txtStaffBithdate.MaxLength = 32767;
            this.txtStaffBithdate.Name = "txtStaffBithdate";
            this.txtStaffBithdate.PasswordChar = '\0';
            this.txtStaffBithdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStaffBithdate.SelectedText = "";
            this.txtStaffBithdate.SelectionLength = 0;
            this.txtStaffBithdate.SelectionStart = 0;
            this.txtStaffBithdate.ShortcutsEnabled = true;
            this.txtStaffBithdate.Size = new System.Drawing.Size(139, 23);
            this.txtStaffBithdate.TabIndex = 3;
            this.txtStaffBithdate.UseSelectable = true;
            this.txtStaffBithdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStaffBithdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(90, 290);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(153, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Educational Background:";
            // 
            // txtStaffAge
            // 
            // 
            // 
            // 
            this.txtStaffAge.CustomButton.Image = null;
            this.txtStaffAge.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtStaffAge.CustomButton.Name = "";
            this.txtStaffAge.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStaffAge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffAge.CustomButton.TabIndex = 1;
            this.txtStaffAge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStaffAge.CustomButton.UseSelectable = true;
            this.txtStaffAge.CustomButton.Visible = false;
            this.txtStaffAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Age", true));
            this.txtStaffAge.Lines = new string[0];
            this.txtStaffAge.Location = new System.Drawing.Point(269, 138);
            this.txtStaffAge.MaxLength = 32767;
            this.txtStaffAge.Name = "txtStaffAge";
            this.txtStaffAge.PasswordChar = '\0';
            this.txtStaffAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStaffAge.SelectedText = "";
            this.txtStaffAge.SelectionLength = 0;
            this.txtStaffAge.SelectionStart = 0;
            this.txtStaffAge.ShortcutsEnabled = true;
            this.txtStaffAge.Size = new System.Drawing.Size(139, 23);
            this.txtStaffAge.TabIndex = 3;
            this.txtStaffAge.UseSelectable = true;
            this.txtStaffAge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStaffAge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(177, 179);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Birthdate:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(204, 138);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Age:";
            // 
            // txtStaffType
            // 
            // 
            // 
            // 
            this.txtStaffType.CustomButton.Image = null;
            this.txtStaffType.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtStaffType.CustomButton.Name = "";
            this.txtStaffType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStaffType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffType.CustomButton.TabIndex = 1;
            this.txtStaffType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStaffType.CustomButton.UseSelectable = true;
            this.txtStaffType.CustomButton.Visible = false;
            this.txtStaffType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Type", true));
            this.txtStaffType.Lines = new string[0];
            this.txtStaffType.Location = new System.Drawing.Point(269, 95);
            this.txtStaffType.MaxLength = 32767;
            this.txtStaffType.Name = "txtStaffType";
            this.txtStaffType.PasswordChar = '\0';
            this.txtStaffType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStaffType.SelectedText = "";
            this.txtStaffType.SelectionLength = 0;
            this.txtStaffType.SelectionStart = 0;
            this.txtStaffType.ShortcutsEnabled = true;
            this.txtStaffType.Size = new System.Drawing.Size(139, 23);
            this.txtStaffType.TabIndex = 3;
            this.txtStaffType.UseSelectable = true;
            this.txtStaffType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStaffType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(187, 258);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Gender:";
            // 
            // txtStaffName
            // 
            // 
            // 
            // 
            this.txtStaffName.CustomButton.Image = null;
            this.txtStaffName.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtStaffName.CustomButton.Name = "";
            this.txtStaffName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStaffName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffName.CustomButton.TabIndex = 1;
            this.txtStaffName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStaffName.CustomButton.UseSelectable = true;
            this.txtStaffName.CustomButton.Visible = false;
            this.txtStaffName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "FullName", true));
            this.txtStaffName.Lines = new string[0];
            this.txtStaffName.Location = new System.Drawing.Point(269, 53);
            this.txtStaffName.MaxLength = 32767;
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.PasswordChar = '\0';
            this.txtStaffName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStaffName.SelectedText = "";
            this.txtStaffName.SelectionLength = 0;
            this.txtStaffName.SelectionStart = 0;
            this.txtStaffName.ShortcutsEnabled = true;
            this.txtStaffName.Size = new System.Drawing.Size(139, 23);
            this.txtStaffName.TabIndex = 3;
            this.txtStaffName.UseSelectable = true;
            this.txtStaffName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStaffName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(201, 95);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Type:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(174, 53);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Full name:";
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.chkStaffGender);
            this.pContainer.Controls.Add(this.btnBrowse);
            this.pContainer.Controls.Add(this.picStaff);
            this.pContainer.Controls.Add(this.txtStaffModules);
            this.pContainer.Controls.Add(this.txtStaffEdBackgr);
            this.pContainer.Controls.Add(this.metroLabel8);
            this.pContainer.Controls.Add(this.txtStaffBithdate);
            this.pContainer.Controls.Add(this.metroLabel7);
            this.pContainer.Controls.Add(this.txtStaffAge);
            this.pContainer.Controls.Add(this.metroLabel6);
            this.pContainer.Controls.Add(this.metroLabel5);
            this.pContainer.Controls.Add(this.txtStaffType);
            this.pContainer.Controls.Add(this.metroLabel4);
            this.pContainer.Controls.Add(this.txtStaffName);
            this.pContainer.Controls.Add(this.metroLabel3);
            this.pContainer.Controls.Add(this.metroLabel2);
            this.pContainer.HorizontalScrollbarBarColor = true;
            this.pContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pContainer.HorizontalScrollbarSize = 10;
            this.pContainer.Location = new System.Drawing.Point(23, 73);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(428, 425);
            this.pContainer.TabIndex = 7;
            this.pContainer.VerticalScrollbarBarColor = true;
            this.pContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pContainer.VerticalScrollbarSize = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(104, 504);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // staffGrid
            // 
            this.staffGrid.AllowUserToResizeRows = false;
            this.staffGrid.AutoGenerateColumns = false;
            this.staffGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.staffGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.staffGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.staffGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.staffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.genderDataGridViewCheckBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.modulesDataGridViewTextBoxColumn,
            this.edBackgroundDataGridViewTextBoxColumn});
            this.staffGrid.DataSource = this.staffBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.staffGrid.EnableHeadersVisualStyles = false;
            this.staffGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.staffGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.staffGrid.Location = new System.Drawing.Point(457, 73);
            this.staffGrid.Name = "staffGrid";
            this.staffGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.staffGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.staffGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffGrid.Size = new System.Drawing.Size(693, 425);
            this.staffGrid.TabIndex = 6;
            this.staffGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffGrid_CellClick);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewCheckBoxColumn
            // 
            this.genderDataGridViewCheckBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewCheckBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewCheckBoxColumn.Name = "genderDataGridViewCheckBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // modulesDataGridViewTextBoxColumn
            // 
            this.modulesDataGridViewTextBoxColumn.DataPropertyName = "Modules";
            this.modulesDataGridViewTextBoxColumn.HeaderText = "Modules";
            this.modulesDataGridViewTextBoxColumn.Name = "modulesDataGridViewTextBoxColumn";
            // 
            // edBackgroundDataGridViewTextBoxColumn
            // 
            this.edBackgroundDataGridViewTextBoxColumn.DataPropertyName = "EdBackground";
            this.edBackgroundDataGridViewTextBoxColumn.HeaderText = "EdBackground";
            this.edBackgroundDataGridViewTextBoxColumn.Name = "edBackgroundDataGridViewTextBoxColumn";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1075, 504);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 550);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.staffGrid);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).EndInit();
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroCheckBox chkStaffGender;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.PictureBox picStaff;
        private MetroFramework.Controls.MetroTextBox txtStaffModules;
        private MetroFramework.Controls.MetroTextBox txtStaffEdBackgr;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtStaffBithdate;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtStaffAge;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtStaffType;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtStaffName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel pContainer;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroGrid staffGrid;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edBackgroundDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}