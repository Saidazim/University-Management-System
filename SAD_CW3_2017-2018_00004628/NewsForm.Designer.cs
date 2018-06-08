namespace SAD_CW3_2017_2018_00004628
{
    partial class NewsForm
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
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.picNews = new System.Windows.Forms.PictureBox();
            this.txtNewsTimestamp = new MetroFramework.Controls.MetroTextBox();
            this.newsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtNewsBody = new MetroFramework.Controls.MetroTextBox();
            this.txtNewsTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.newsGrid = new MetroFramework.Controls.MetroGrid();
            this.newsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 508);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 508);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(295, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(376, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.btnBrowse);
            this.pContainer.Controls.Add(this.picNews);
            this.pContainer.Controls.Add(this.txtNewsTimestamp);
            this.pContainer.Controls.Add(this.metroLabel5);
            this.pContainer.Controls.Add(this.txtNewsBody);
            this.pContainer.Controls.Add(this.txtNewsTitle);
            this.pContainer.Controls.Add(this.metroLabel3);
            this.pContainer.Controls.Add(this.metroLabel2);
            this.pContainer.HorizontalScrollbarBarColor = true;
            this.pContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pContainer.HorizontalScrollbarSize = 10;
            this.pContainer.Location = new System.Drawing.Point(23, 77);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(428, 425);
            this.pContainer.TabIndex = 21;
            this.pContainer.VerticalScrollbarBarColor = true;
            this.pContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pContainer.VerticalScrollbarSize = 10;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(182, 181);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picNews
            // 
            this.picNews.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picNews.Location = new System.Drawing.Point(145, 25);
            this.picNews.Name = "picNews";
            this.picNews.Size = new System.Drawing.Size(150, 150);
            this.picNews.TabIndex = 6;
            this.picNews.TabStop = false;
            // 
            // txtNewsTimestamp
            // 
            // 
            // 
            // 
            this.txtNewsTimestamp.CustomButton.Image = null;
            this.txtNewsTimestamp.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtNewsTimestamp.CustomButton.Name = "";
            this.txtNewsTimestamp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewsTimestamp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewsTimestamp.CustomButton.TabIndex = 1;
            this.txtNewsTimestamp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewsTimestamp.CustomButton.UseSelectable = true;
            this.txtNewsTimestamp.CustomButton.Visible = false;
            this.txtNewsTimestamp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newsBindingSource, "Timestamp", true));
            this.txtNewsTimestamp.Lines = new string[0];
            this.txtNewsTimestamp.Location = new System.Drawing.Point(156, 365);
            this.txtNewsTimestamp.MaxLength = 32767;
            this.txtNewsTimestamp.Name = "txtNewsTimestamp";
            this.txtNewsTimestamp.PasswordChar = '\0';
            this.txtNewsTimestamp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewsTimestamp.SelectedText = "";
            this.txtNewsTimestamp.SelectionLength = 0;
            this.txtNewsTimestamp.SelectionStart = 0;
            this.txtNewsTimestamp.ShortcutsEnabled = true;
            this.txtNewsTimestamp.Size = new System.Drawing.Size(139, 23);
            this.txtNewsTimestamp.TabIndex = 3;
            this.txtNewsTimestamp.UseSelectable = true;
            this.txtNewsTimestamp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewsTimestamp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newsBindingSource
            // 
            this.newsBindingSource.DataSource = typeof(SAD_CW3_2017_2018_00004628.News);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(40, 365);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(77, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Timestamp:";
            // 
            // txtNewsBody
            // 
            // 
            // 
            // 
            this.txtNewsBody.CustomButton.Image = null;
            this.txtNewsBody.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtNewsBody.CustomButton.Name = "";
            this.txtNewsBody.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewsBody.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewsBody.CustomButton.TabIndex = 1;
            this.txtNewsBody.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewsBody.CustomButton.UseSelectable = true;
            this.txtNewsBody.CustomButton.Visible = false;
            this.txtNewsBody.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newsBindingSource, "Body", true));
            this.txtNewsBody.Lines = new string[0];
            this.txtNewsBody.Location = new System.Drawing.Point(156, 322);
            this.txtNewsBody.MaxLength = 32767;
            this.txtNewsBody.Name = "txtNewsBody";
            this.txtNewsBody.PasswordChar = '\0';
            this.txtNewsBody.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewsBody.SelectedText = "";
            this.txtNewsBody.SelectionLength = 0;
            this.txtNewsBody.SelectionStart = 0;
            this.txtNewsBody.ShortcutsEnabled = true;
            this.txtNewsBody.Size = new System.Drawing.Size(139, 23);
            this.txtNewsBody.TabIndex = 3;
            this.txtNewsBody.UseSelectable = true;
            this.txtNewsBody.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewsBody.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNewsTitle
            // 
            // 
            // 
            // 
            this.txtNewsTitle.CustomButton.Image = null;
            this.txtNewsTitle.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtNewsTitle.CustomButton.Name = "";
            this.txtNewsTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewsTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewsTitle.CustomButton.TabIndex = 1;
            this.txtNewsTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewsTitle.CustomButton.UseSelectable = true;
            this.txtNewsTitle.CustomButton.Visible = false;
            this.txtNewsTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newsBindingSource, "Title", true));
            this.txtNewsTitle.Lines = new string[0];
            this.txtNewsTitle.Location = new System.Drawing.Point(156, 280);
            this.txtNewsTitle.MaxLength = 32767;
            this.txtNewsTitle.Name = "txtNewsTitle";
            this.txtNewsTitle.PasswordChar = '\0';
            this.txtNewsTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewsTitle.SelectedText = "";
            this.txtNewsTitle.SelectionLength = 0;
            this.txtNewsTitle.SelectionStart = 0;
            this.txtNewsTitle.ShortcutsEnabled = true;
            this.txtNewsTitle.Size = new System.Drawing.Size(139, 23);
            this.txtNewsTitle.TabIndex = 3;
            this.txtNewsTitle.UseSelectable = true;
            this.txtNewsTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewsTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(75, 322);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Body:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(81, 280);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Title:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(104, 508);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // newsGrid
            // 
            this.newsGrid.AllowUserToResizeRows = false;
            this.newsGrid.AutoGenerateColumns = false;
            this.newsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.newsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.newsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.newsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.newsIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.bodyDataGridViewTextBoxColumn,
            this.timestampDataGridViewTextBoxColumn});
            this.newsGrid.DataSource = this.newsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.newsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.newsGrid.EnableHeadersVisualStyles = false;
            this.newsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.newsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newsGrid.Location = new System.Drawing.Point(457, 77);
            this.newsGrid.Name = "newsGrid";
            this.newsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.newsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.newsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.newsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.newsGrid.Size = new System.Drawing.Size(693, 425);
            this.newsGrid.TabIndex = 20;
            this.newsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.newsGrid_CellClick);
            // 
            // newsIDDataGridViewTextBoxColumn
            // 
            this.newsIDDataGridViewTextBoxColumn.DataPropertyName = "NewsID";
            this.newsIDDataGridViewTextBoxColumn.HeaderText = "NewsID";
            this.newsIDDataGridViewTextBoxColumn.Name = "newsIDDataGridViewTextBoxColumn";
            this.newsIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            this.bodyDataGridViewTextBoxColumn.DataPropertyName = "Body";
            this.bodyDataGridViewTextBoxColumn.HeaderText = "Body";
            this.bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1075, 508);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // NewsForm
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
            this.Controls.Add(this.newsGrid);
            this.Name = "NewsForm";
            this.Text = "NewsForm";
            this.Load += new System.EventHandler(this.NewsForm_Load);
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroPanel pContainer;
        private MetroFramework.Controls.MetroTextBox txtNewsTimestamp;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtNewsBody;
        private MetroFramework.Controls.MetroTextBox txtNewsTitle;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroGrid newsGrid;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.PictureBox picNews;
        private System.Windows.Forms.DataGridViewTextBoxColumn newsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource newsBindingSource;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}