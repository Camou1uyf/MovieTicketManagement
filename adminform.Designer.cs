namespace MovieTicketManagement
{
    partial class adminform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.addmovie_btn = new System.Windows.Forms.Button();
            this.addstaff_btn = new System.Windows.Forms.Button();
            this.Dash_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardform1 = new MovieTicketManagement.dashboardform();
            this.addstaffForm1 = new MovieTicketManagement.addstaffForm();
            this.addMovie1 = new MovieTicketManagement.AddMovie();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(244, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 44);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Movie Ticket Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(847, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(986, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(22, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(817, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.addmovie_btn);
            this.panel2.Controls.Add(this.addstaff_btn);
            this.panel2.Controls.Add(this.Dash_btn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 794);
            this.panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(12, 748);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(212, 34);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click_1);
            // 
            // addmovie_btn
            // 
            this.addmovie_btn.FlatAppearance.BorderSize = 0;
            this.addmovie_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addmovie_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmovie_btn.Image = ((System.Drawing.Image)(resources.GetObject("addmovie_btn.Image")));
            this.addmovie_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addmovie_btn.Location = new System.Drawing.Point(10, 412);
            this.addmovie_btn.Name = "addmovie_btn";
            this.addmovie_btn.Size = new System.Drawing.Size(225, 34);
            this.addmovie_btn.TabIndex = 4;
            this.addmovie_btn.Text = "ADD MOVIE";
            this.addmovie_btn.UseVisualStyleBackColor = true;
            this.addmovie_btn.Click += new System.EventHandler(this.addmovie_btn_Click);
            // 
            // addstaff_btn
            // 
            this.addstaff_btn.FlatAppearance.BorderSize = 0;
            this.addstaff_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addstaff_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstaff_btn.Image = ((System.Drawing.Image)(resources.GetObject("addstaff_btn.Image")));
            this.addstaff_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addstaff_btn.Location = new System.Drawing.Point(10, 348);
            this.addstaff_btn.Name = "addstaff_btn";
            this.addstaff_btn.Size = new System.Drawing.Size(225, 34);
            this.addstaff_btn.TabIndex = 3;
            this.addstaff_btn.Text = " ADD STAFF";
            this.addstaff_btn.UseVisualStyleBackColor = true;
            this.addstaff_btn.Click += new System.EventHandler(this.addstaff_btn_Click);
            // 
            // Dash_btn
            // 
            this.Dash_btn.FlatAppearance.BorderSize = 0;
            this.Dash_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dash_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dash_btn.Image = ((System.Drawing.Image)(resources.GetObject("Dash_btn.Image")));
            this.Dash_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dash_btn.Location = new System.Drawing.Point(10, 284);
            this.Dash_btn.Name = "Dash_btn";
            this.Dash_btn.Size = new System.Drawing.Size(225, 34);
            this.Dash_btn.TabIndex = 2;
            this.Dash_btn.Text = " DASHBOARD";
            this.Dash_btn.UseVisualStyleBackColor = true;
            this.Dash_btn.Click += new System.EventHandler(this.Dash_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardform1
            // 
            this.dashboardform1.Location = new System.Drawing.Point(255, 50);
            this.dashboardform1.Name = "dashboardform1";
            this.dashboardform1.Size = new System.Drawing.Size(1009, 744);
            this.dashboardform1.TabIndex = 4;
            // 
            // addstaffForm1
            // 
            this.addstaffForm1.Location = new System.Drawing.Point(255, 42);
            this.addstaffForm1.Name = "addstaffForm1";
            this.addstaffForm1.Size = new System.Drawing.Size(1017, 752);
            this.addstaffForm1.TabIndex = 3;
            // 
            // addMovie1
            // 
            this.addMovie1.Location = new System.Drawing.Point(255, 42);
            this.addMovie1.Name = "addMovie1";
            this.addMovie1.Size = new System.Drawing.Size(1017, 752);
            this.addMovie1.TabIndex = 2;
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 794);
            this.Controls.Add(this.dashboardform1);
            this.Controls.Add(this.addstaffForm1);
            this.Controls.Add(this.addMovie1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Dash_btn;
        private System.Windows.Forms.Button addmovie_btn;
        private System.Windows.Forms.Button addstaff_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AddMovie addMovie1;
        private addstaffForm addstaffForm1;
        private dashboardform dashboardform1;
    }
}