namespace SAD_CW3_2017_2018_00004628
{
    partial class Back_desk
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
            this.btnGoFront = new MetroFramework.Controls.MetroTile();
            this.btnNews = new MetroFramework.Controls.MetroTile();
            this.btnEvents = new MetroFramework.Controls.MetroTile();
            this.btnModules = new MetroFramework.Controls.MetroTile();
            this.btnStaff = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnGoFront
            // 
            this.btnGoFront.ActiveControl = null;
            this.btnGoFront.Location = new System.Drawing.Point(841, 21);
            this.btnGoFront.Name = "btnGoFront";
            this.btnGoFront.Size = new System.Drawing.Size(242, 48);
            this.btnGoFront.TabIndex = 1;
            this.btnGoFront.Text = "Go to Front-desk";
            this.btnGoFront.UseSelectable = true;
            this.btnGoFront.Click += new System.EventHandler(this.btnGoFront_Click);
            // 
            // btnNews
            // 
            this.btnNews.ActiveControl = null;
            this.btnNews.Location = new System.Drawing.Point(833, 155);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(250, 250);
            this.btnNews.TabIndex = 2;
            this.btnNews.Text = "News";
            this.btnNews.UseSelectable = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.ActiveControl = null;
            this.btnEvents.Location = new System.Drawing.Point(577, 155);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(250, 250);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseSelectable = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnModules
            // 
            this.btnModules.ActiveControl = null;
            this.btnModules.Location = new System.Drawing.Point(321, 155);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(250, 250);
            this.btnModules.TabIndex = 4;
            this.btnModules.Text = "Modules";
            this.btnModules.UseSelectable = true;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.ActiveControl = null;
            this.btnStaff.Location = new System.Drawing.Point(65, 155);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(250, 250);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseSelectable = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // Back_desk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 550);
            this.Controls.Add(this.btnGoFront);
            this.Controls.Add(this.btnNews);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnModules);
            this.Controls.Add(this.btnStaff);
            this.Name = "Back_desk";
            this.Text = "Back-desk";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnGoFront;
        private MetroFramework.Controls.MetroTile btnNews;
        private MetroFramework.Controls.MetroTile btnEvents;
        private MetroFramework.Controls.MetroTile btnModules;
        private MetroFramework.Controls.MetroTile btnStaff;
    }
}