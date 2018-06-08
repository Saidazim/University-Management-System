namespace SAD_CW3_2017_2018_00004628
{
    partial class ModulesForm
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
            this.txtModulesMLeader = new MetroFramework.Controls.MetroTextBox();
            this.modulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtModulesEnStud = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtModulesDesc = new MetroFramework.Controls.MetroTextBox();
            this.txtModulesName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.modulesGrid = new MetroFramework.Controls.MetroGrid();
            this.moduleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolledStudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleLeaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 508);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 508);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(295, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(376, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.txtModulesMLeader);
            this.pContainer.Controls.Add(this.txtModulesEnStud);
            this.pContainer.Controls.Add(this.metroLabel6);
            this.pContainer.Controls.Add(this.metroLabel5);
            this.pContainer.Controls.Add(this.txtModulesDesc);
            this.pContainer.Controls.Add(this.txtModulesName);
            this.pContainer.Controls.Add(this.metroLabel3);
            this.pContainer.Controls.Add(this.metroLabel2);
            this.pContainer.HorizontalScrollbarBarColor = true;
            this.pContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pContainer.HorizontalScrollbarSize = 10;
            this.pContainer.Location = new System.Drawing.Point(23, 77);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(428, 425);
            this.pContainer.TabIndex = 14;
            this.pContainer.VerticalScrollbarBarColor = true;
            this.pContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pContainer.VerticalScrollbarSize = 10;
            // 
            // txtModulesMLeader
            // 
            // 
            // 
            // 
            this.txtModulesMLeader.CustomButton.Image = null;
            this.txtModulesMLeader.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtModulesMLeader.CustomButton.Name = "";
            this.txtModulesMLeader.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModulesMLeader.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModulesMLeader.CustomButton.TabIndex = 1;
            this.txtModulesMLeader.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModulesMLeader.CustomButton.UseSelectable = true;
            this.txtModulesMLeader.CustomButton.Visible = false;
            this.txtModulesMLeader.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modulesBindingSource, "ModuleLeader", true));
            this.txtModulesMLeader.Lines = new string[0];
            this.txtModulesMLeader.Location = new System.Drawing.Point(195, 245);
            this.txtModulesMLeader.MaxLength = 32767;
            this.txtModulesMLeader.Name = "txtModulesMLeader";
            this.txtModulesMLeader.PasswordChar = '\0';
            this.txtModulesMLeader.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModulesMLeader.SelectedText = "";
            this.txtModulesMLeader.SelectionLength = 0;
            this.txtModulesMLeader.SelectionStart = 0;
            this.txtModulesMLeader.ShortcutsEnabled = true;
            this.txtModulesMLeader.Size = new System.Drawing.Size(139, 23);
            this.txtModulesMLeader.TabIndex = 3;
            this.txtModulesMLeader.UseSelectable = true;
            this.txtModulesMLeader.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModulesMLeader.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // modulesBindingSource
            // 
            this.modulesBindingSource.DataSource = typeof(SAD_CW3_2017_2018_00004628.Modules);
            // 
            // txtModulesEnStud
            // 
            // 
            // 
            // 
            this.txtModulesEnStud.CustomButton.Image = null;
            this.txtModulesEnStud.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtModulesEnStud.CustomButton.Name = "";
            this.txtModulesEnStud.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModulesEnStud.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModulesEnStud.CustomButton.TabIndex = 1;
            this.txtModulesEnStud.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModulesEnStud.CustomButton.UseSelectable = true;
            this.txtModulesEnStud.CustomButton.Visible = false;
            this.txtModulesEnStud.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modulesBindingSource, "EnrolledStudents", true));
            this.txtModulesEnStud.Lines = new string[0];
            this.txtModulesEnStud.Location = new System.Drawing.Point(195, 204);
            this.txtModulesEnStud.MaxLength = 32767;
            this.txtModulesEnStud.Name = "txtModulesEnStud";
            this.txtModulesEnStud.PasswordChar = '\0';
            this.txtModulesEnStud.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModulesEnStud.SelectedText = "";
            this.txtModulesEnStud.SelectionLength = 0;
            this.txtModulesEnStud.SelectionStart = 0;
            this.txtModulesEnStud.ShortcutsEnabled = true;
            this.txtModulesEnStud.Size = new System.Drawing.Size(139, 23);
            this.txtModulesEnStud.TabIndex = 3;
            this.txtModulesEnStud.UseSelectable = true;
            this.txtModulesEnStud.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModulesEnStud.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(65, 245);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(102, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Module Leader:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(50, 204);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(113, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Enrolled Students:";
            // 
            // txtModulesDesc
            // 
            // 
            // 
            // 
            this.txtModulesDesc.CustomButton.Image = null;
            this.txtModulesDesc.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtModulesDesc.CustomButton.Name = "";
            this.txtModulesDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModulesDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModulesDesc.CustomButton.TabIndex = 1;
            this.txtModulesDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModulesDesc.CustomButton.UseSelectable = true;
            this.txtModulesDesc.CustomButton.Visible = false;
            this.txtModulesDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modulesBindingSource, "Description", true));
            this.txtModulesDesc.Lines = new string[0];
            this.txtModulesDesc.Location = new System.Drawing.Point(195, 161);
            this.txtModulesDesc.MaxLength = 32767;
            this.txtModulesDesc.Name = "txtModulesDesc";
            this.txtModulesDesc.PasswordChar = '\0';
            this.txtModulesDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModulesDesc.SelectedText = "";
            this.txtModulesDesc.SelectionLength = 0;
            this.txtModulesDesc.SelectionStart = 0;
            this.txtModulesDesc.ShortcutsEnabled = true;
            this.txtModulesDesc.Size = new System.Drawing.Size(139, 23);
            this.txtModulesDesc.TabIndex = 3;
            this.txtModulesDesc.UseSelectable = true;
            this.txtModulesDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModulesDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtModulesName
            // 
            // 
            // 
            // 
            this.txtModulesName.CustomButton.Image = null;
            this.txtModulesName.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtModulesName.CustomButton.Name = "";
            this.txtModulesName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModulesName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModulesName.CustomButton.TabIndex = 1;
            this.txtModulesName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModulesName.CustomButton.UseSelectable = true;
            this.txtModulesName.CustomButton.Visible = false;
            this.txtModulesName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modulesBindingSource, "Name", true));
            this.txtModulesName.Lines = new string[0];
            this.txtModulesName.Location = new System.Drawing.Point(195, 119);
            this.txtModulesName.MaxLength = 32767;
            this.txtModulesName.Name = "txtModulesName";
            this.txtModulesName.PasswordChar = '\0';
            this.txtModulesName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModulesName.SelectedText = "";
            this.txtModulesName.SelectionLength = 0;
            this.txtModulesName.SelectionStart = 0;
            this.txtModulesName.ShortcutsEnabled = true;
            this.txtModulesName.Size = new System.Drawing.Size(139, 23);
            this.txtModulesName.TabIndex = 3;
            this.txtModulesName.UseSelectable = true;
            this.txtModulesName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModulesName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(86, 161);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Description:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(115, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Name:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(104, 508);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // modulesGrid
            // 
            this.modulesGrid.AllowUserToResizeRows = false;
            this.modulesGrid.AutoGenerateColumns = false;
            this.modulesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.modulesGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.modulesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.modulesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modulesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.modulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modulesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moduleIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.enrolledStudentsDataGridViewTextBoxColumn,
            this.moduleLeaderDataGridViewTextBoxColumn});
            this.modulesGrid.DataSource = this.modulesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.modulesGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.modulesGrid.EnableHeadersVisualStyles = false;
            this.modulesGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.modulesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.modulesGrid.Location = new System.Drawing.Point(457, 77);
            this.modulesGrid.Name = "modulesGrid";
            this.modulesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modulesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.modulesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.modulesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modulesGrid.Size = new System.Drawing.Size(693, 425);
            this.modulesGrid.TabIndex = 13;
            this.modulesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modulesGrid_CellClick);
            // 
            // moduleIDDataGridViewTextBoxColumn
            // 
            this.moduleIDDataGridViewTextBoxColumn.DataPropertyName = "ModuleID";
            this.moduleIDDataGridViewTextBoxColumn.HeaderText = "ModuleID";
            this.moduleIDDataGridViewTextBoxColumn.Name = "moduleIDDataGridViewTextBoxColumn";
            this.moduleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // enrolledStudentsDataGridViewTextBoxColumn
            // 
            this.enrolledStudentsDataGridViewTextBoxColumn.DataPropertyName = "EnrolledStudents";
            this.enrolledStudentsDataGridViewTextBoxColumn.HeaderText = "EnrolledStudents";
            this.enrolledStudentsDataGridViewTextBoxColumn.Name = "enrolledStudentsDataGridViewTextBoxColumn";
            // 
            // moduleLeaderDataGridViewTextBoxColumn
            // 
            this.moduleLeaderDataGridViewTextBoxColumn.DataPropertyName = "ModuleLeader";
            this.moduleLeaderDataGridViewTextBoxColumn.HeaderText = "ModuleLeader";
            this.moduleLeaderDataGridViewTextBoxColumn.Name = "moduleLeaderDataGridViewTextBoxColumn";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1075, 508);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ModulesForm
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
            this.Controls.Add(this.modulesGrid);
            this.Name = "ModulesForm";
            this.Text = "ModulesForm";
            this.Load += new System.EventHandler(this.ModulesForm_Load);
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroPanel pContainer;
        private MetroFramework.Controls.MetroTextBox txtModulesMLeader;
        private MetroFramework.Controls.MetroTextBox txtModulesEnStud;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtModulesDesc;
        private MetroFramework.Controls.MetroTextBox txtModulesName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroGrid modulesGrid;
        private System.Windows.Forms.BindingSource modulesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrolledStudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleLeaderDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}