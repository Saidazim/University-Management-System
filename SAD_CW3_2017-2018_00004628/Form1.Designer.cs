namespace SAD_CW3_2017_2018_00004628
{
    partial class Form1
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
            this.btnStaff = new MetroFramework.Controls.MetroTile();
            this.btnModules = new MetroFramework.Controls.MetroTile();
            this.btnEvents = new MetroFramework.Controls.MetroTile();
            this.btnNews = new MetroFramework.Controls.MetroTile();
            this.btnGoBack = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnStaff
            // 
            this.btnStaff.ActiveControl = null;
            this.btnStaff.Location = new System.Drawing.Point(65, 154);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(250, 250);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseSelectable = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnModules
            // 
            this.btnModules.ActiveControl = null;
            this.btnModules.Location = new System.Drawing.Point(321, 154);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(250, 250);
            this.btnModules.TabIndex = 0;
            this.btnModules.Text = "Modules";
            this.btnModules.UseSelectable = true;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.ActiveControl = null;
            this.btnEvents.Location = new System.Drawing.Point(577, 154);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(250, 250);
            this.btnEvents.TabIndex = 0;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseSelectable = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnNews
            // 
            this.btnNews.ActiveControl = null;
            this.btnNews.Location = new System.Drawing.Point(833, 154);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(250, 250);
            this.btnNews.TabIndex = 0;
            this.btnNews.Text = "News";
            this.btnNews.UseSelectable = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.ActiveControl = null;
            this.btnGoBack.Location = new System.Drawing.Point(841, 20);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(242, 48);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.Text = "Go to Back-desk";
            this.btnGoBack.UseSelectable = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 550);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnNews);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnModules);
            this.Controls.Add(this.btnStaff);
            this.Name = "Form1";
            this.Text = "Front-desk";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnStaff;
        private MetroFramework.Controls.MetroTile btnModules;
        private MetroFramework.Controls.MetroTile btnEvents;
        private MetroFramework.Controls.MetroTile btnNews;
        private MetroFramework.Controls.MetroTile btnGoBack;
    }
}

