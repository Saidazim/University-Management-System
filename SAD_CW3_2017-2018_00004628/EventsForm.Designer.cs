namespace SAD_CW3_2017_2018_00004628
{
    partial class EventsForm
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
            this.pContainer = new MetroFramework.Controls.MetroPanel();
            this.chkEventsStatus = new MetroFramework.Controls.MetroCheckBox();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEventsType = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtEventsTime = new MetroFramework.Controls.MetroTextBox();
            this.txtEventsVenue = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtEventsParType = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtEventsDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.eventsGrid = new MetroFramework.Controls.MetroGrid();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.participantsTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 479);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 479);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(295, 479);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(376, 479);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.chkEventsStatus);
            this.pContainer.Controls.Add(this.txtEventsType);
            this.pContainer.Controls.Add(this.metroLabel7);
            this.pContainer.Controls.Add(this.txtEventsTime);
            this.pContainer.Controls.Add(this.txtEventsVenue);
            this.pContainer.Controls.Add(this.metroLabel6);
            this.pContainer.Controls.Add(this.metroLabel5);
            this.pContainer.Controls.Add(this.txtEventsParType);
            this.pContainer.Controls.Add(this.metroLabel4);
            this.pContainer.Controls.Add(this.txtEventsDesc);
            this.pContainer.Controls.Add(this.metroLabel3);
            this.pContainer.Controls.Add(this.metroLabel2);
            this.pContainer.HorizontalScrollbarBarColor = true;
            this.pContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pContainer.HorizontalScrollbarSize = 10;
            this.pContainer.Location = new System.Drawing.Point(23, 48);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(428, 425);
            this.pContainer.TabIndex = 14;
            this.pContainer.VerticalScrollbarBarColor = true;
            this.pContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pContainer.VerticalScrollbarSize = 10;
            // 
            // chkEventsStatus
            // 
            this.chkEventsStatus.AutoSize = true;
            this.chkEventsStatus.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.eventsBindingSource, "Status", true));
            this.chkEventsStatus.Location = new System.Drawing.Point(208, 257);
            this.chkEventsStatus.Name = "chkEventsStatus";
            this.chkEventsStatus.Size = new System.Drawing.Size(38, 15);
            this.chkEventsStatus.TabIndex = 6;
            this.chkEventsStatus.Text = "???";
            this.chkEventsStatus.UseSelectable = true;
            this.chkEventsStatus.CheckStateChanged += new System.EventHandler(this.chkEventsStatus_CheckStateChanged);
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataSource = typeof(SAD_CW3_2017_2018_00004628.Events);
            // 
            // txtEventsType
            // 
            // 
            // 
            // 
            this.txtEventsType.CustomButton.Image = null;
            this.txtEventsType.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtEventsType.CustomButton.Name = "";
            this.txtEventsType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEventsType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEventsType.CustomButton.TabIndex = 1;
            this.txtEventsType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEventsType.CustomButton.UseSelectable = true;
            this.txtEventsType.CustomButton.Visible = false;
            this.txtEventsType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "Type", true));
            this.txtEventsType.Lines = new string[0];
            this.txtEventsType.Location = new System.Drawing.Point(208, 289);
            this.txtEventsType.MaxLength = 32767;
            this.txtEventsType.Name = "txtEventsType";
            this.txtEventsType.PasswordChar = '\0';
            this.txtEventsType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEventsType.SelectedText = "";
            this.txtEventsType.SelectionLength = 0;
            this.txtEventsType.SelectionStart = 0;
            this.txtEventsType.ShortcutsEnabled = true;
            this.txtEventsType.Size = new System.Drawing.Size(139, 23);
            this.txtEventsType.TabIndex = 3;
            this.txtEventsType.UseSelectable = true;
            this.txtEventsType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEventsType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(137, 289);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(39, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Type:";
            // 
            // txtEventsTime
            // 
            // 
            // 
            // 
            this.txtEventsTime.CustomButton.Image = null;
            this.txtEventsTime.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtEventsTime.CustomButton.Name = "";
            this.txtEventsTime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEventsTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEventsTime.CustomButton.TabIndex = 1;
            this.txtEventsTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEventsTime.CustomButton.UseSelectable = true;
            this.txtEventsTime.CustomButton.Visible = false;
            this.txtEventsTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "Time", true));
            this.txtEventsTime.Lines = new string[0];
            this.txtEventsTime.Location = new System.Drawing.Point(208, 215);
            this.txtEventsTime.MaxLength = 32767;
            this.txtEventsTime.Name = "txtEventsTime";
            this.txtEventsTime.PasswordChar = '\0';
            this.txtEventsTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEventsTime.SelectedText = "";
            this.txtEventsTime.SelectionLength = 0;
            this.txtEventsTime.SelectionStart = 0;
            this.txtEventsTime.ShortcutsEnabled = true;
            this.txtEventsTime.Size = new System.Drawing.Size(139, 23);
            this.txtEventsTime.TabIndex = 3;
            this.txtEventsTime.UseSelectable = true;
            this.txtEventsTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEventsTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEventsVenue
            // 
            // 
            // 
            // 
            this.txtEventsVenue.CustomButton.Image = null;
            this.txtEventsVenue.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtEventsVenue.CustomButton.Name = "";
            this.txtEventsVenue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEventsVenue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEventsVenue.CustomButton.TabIndex = 1;
            this.txtEventsVenue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEventsVenue.CustomButton.UseSelectable = true;
            this.txtEventsVenue.CustomButton.Visible = false;
            this.txtEventsVenue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "Venue", true));
            this.txtEventsVenue.Lines = new string[0];
            this.txtEventsVenue.Location = new System.Drawing.Point(208, 174);
            this.txtEventsVenue.MaxLength = 32767;
            this.txtEventsVenue.Name = "txtEventsVenue";
            this.txtEventsVenue.PasswordChar = '\0';
            this.txtEventsVenue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEventsVenue.SelectedText = "";
            this.txtEventsVenue.SelectionLength = 0;
            this.txtEventsVenue.SelectionStart = 0;
            this.txtEventsVenue.ShortcutsEnabled = true;
            this.txtEventsVenue.Size = new System.Drawing.Size(139, 23);
            this.txtEventsVenue.TabIndex = 3;
            this.txtEventsVenue.UseSelectable = true;
            this.txtEventsVenue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEventsVenue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(135, 215);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Time:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(129, 174);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Venue:";
            // 
            // txtEventsParType
            // 
            // 
            // 
            // 
            this.txtEventsParType.CustomButton.Image = null;
            this.txtEventsParType.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtEventsParType.CustomButton.Name = "";
            this.txtEventsParType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEventsParType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEventsParType.CustomButton.TabIndex = 1;
            this.txtEventsParType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEventsParType.CustomButton.UseSelectable = true;
            this.txtEventsParType.CustomButton.Visible = false;
            this.txtEventsParType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "ParticipantsType", true));
            this.txtEventsParType.Lines = new string[0];
            this.txtEventsParType.Location = new System.Drawing.Point(208, 131);
            this.txtEventsParType.MaxLength = 32767;
            this.txtEventsParType.Name = "txtEventsParType";
            this.txtEventsParType.PasswordChar = '\0';
            this.txtEventsParType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEventsParType.SelectedText = "";
            this.txtEventsParType.SelectionLength = 0;
            this.txtEventsParType.SelectionStart = 0;
            this.txtEventsParType.ShortcutsEnabled = true;
            this.txtEventsParType.Size = new System.Drawing.Size(139, 23);
            this.txtEventsParType.TabIndex = 3;
            this.txtEventsParType.UseSelectable = true;
            this.txtEventsParType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEventsParType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(130, 253);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Status:";
            // 
            // txtEventsDesc
            // 
            // 
            // 
            // 
            this.txtEventsDesc.CustomButton.Image = null;
            this.txtEventsDesc.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtEventsDesc.CustomButton.Name = "";
            this.txtEventsDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEventsDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEventsDesc.CustomButton.TabIndex = 1;
            this.txtEventsDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEventsDesc.CustomButton.UseSelectable = true;
            this.txtEventsDesc.CustomButton.Visible = false;
            this.txtEventsDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "Description", true));
            this.txtEventsDesc.Lines = new string[0];
            this.txtEventsDesc.Location = new System.Drawing.Point(208, 89);
            this.txtEventsDesc.MaxLength = 32767;
            this.txtEventsDesc.Name = "txtEventsDesc";
            this.txtEventsDesc.PasswordChar = '\0';
            this.txtEventsDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEventsDesc.SelectedText = "";
            this.txtEventsDesc.SelectionLength = 0;
            this.txtEventsDesc.SelectionStart = 0;
            this.txtEventsDesc.ShortcutsEnabled = true;
            this.txtEventsDesc.Size = new System.Drawing.Size(139, 23);
            this.txtEventsDesc.TabIndex = 3;
            this.txtEventsDesc.UseSelectable = true;
            this.txtEventsDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEventsDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(66, 131);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Participants Type:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(99, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Description:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(104, 479);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // eventsGrid
            // 
            this.eventsGrid.AllowUserToResizeRows = false;
            this.eventsGrid.AutoGenerateColumns = false;
            this.eventsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eventsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eventsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.eventsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.eventsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.participantsTypeDataGridViewTextBoxColumn,
            this.venueDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.eventsGrid.DataSource = this.eventsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.eventsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.eventsGrid.EnableHeadersVisualStyles = false;
            this.eventsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.eventsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eventsGrid.Location = new System.Drawing.Point(457, 48);
            this.eventsGrid.Name = "eventsGrid";
            this.eventsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.eventsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.eventsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventsGrid.Size = new System.Drawing.Size(693, 425);
            this.eventsGrid.TabIndex = 13;
            this.eventsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventsGrid_CellClick);
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "EventID";
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // participantsTypeDataGridViewTextBoxColumn
            // 
            this.participantsTypeDataGridViewTextBoxColumn.DataPropertyName = "ParticipantsType";
            this.participantsTypeDataGridViewTextBoxColumn.HeaderText = "ParticipantsType";
            this.participantsTypeDataGridViewTextBoxColumn.Name = "participantsTypeDataGridViewTextBoxColumn";
            // 
            // venueDataGridViewTextBoxColumn
            // 
            this.venueDataGridViewTextBoxColumn.DataPropertyName = "Venue";
            this.venueDataGridViewTextBoxColumn.HeaderText = "Venue";
            this.venueDataGridViewTextBoxColumn.Name = "venueDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1075, 479);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EventsForm
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
            this.Controls.Add(this.eventsGrid);
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroPanel pContainer;
        private MetroFramework.Controls.MetroCheckBox chkEventsStatus;
        private MetroFramework.Controls.MetroTextBox txtEventsTime;
        private MetroFramework.Controls.MetroTextBox txtEventsVenue;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtEventsParType;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtEventsDesc;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroGrid eventsGrid;
        private MetroFramework.Controls.MetroTextBox txtEventsType;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn participantsTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}