namespace MovieTicketManagement
{
    partial class AddMovie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statuts = new System.Windows.Forms.ComboBox();
            this.cmbstatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addMovie_btn = new System.Windows.Forms.Button();
            this.ClearMovie_btn = new System.Windows.Forms.Button();
            this.DeleteMovie_btn = new System.Windows.Forms.Button();
            this.txtmoviecapacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ImportMovie_btn = new System.Windows.Forms.Button();
            this.txtmovieprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbmoviegenre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmoviename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmovieid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 291);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(958, 229);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "All Movie";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.statuts);
            this.panel2.Controls.Add(this.cmbstatus);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.addMovie_btn);
            this.panel2.Controls.Add(this.ClearMovie_btn);
            this.panel2.Controls.Add(this.DeleteMovie_btn);
            this.panel2.Controls.Add(this.txtmoviecapacity);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.ImportMovie_btn);
            this.panel2.Controls.Add(this.txtmovieprice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbmoviegenre);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtmoviename);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtmovieid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(17, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 407);
            this.panel2.TabIndex = 1;
            // 
            // statuts
            // 
            this.statuts.FormattingEnabled = true;
            this.statuts.Items.AddRange(new object[] {
            "Vailabale",
            "Unvailabale",
            "Delete"});
            this.statuts.Location = new System.Drawing.Point(478, 159);
            this.statuts.Name = "statuts";
            this.statuts.Size = new System.Drawing.Size(176, 24);
            this.statuts.TabIndex = 23;
            // 
            // cmbstatus
            // 
            this.cmbstatus.AutoSize = true;
            this.cmbstatus.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstatus.Location = new System.Drawing.Point(418, 161);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(53, 22);
            this.cmbstatus.TabIndex = 22;
            this.cmbstatus.Text = "Status:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(825, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addMovie_btn
            // 
            this.addMovie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addMovie_btn.FlatAppearance.BorderSize = 0;
            this.addMovie_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addMovie_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addMovie_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovie_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_btn.ForeColor = System.Drawing.Color.White;
            this.addMovie_btn.Location = new System.Drawing.Point(143, 300);
            this.addMovie_btn.Name = "addMovie_btn";
            this.addMovie_btn.Size = new System.Drawing.Size(163, 55);
            this.addMovie_btn.TabIndex = 19;
            this.addMovie_btn.Text = "Add";
            this.addMovie_btn.UseVisualStyleBackColor = false;
            this.addMovie_btn.Click += new System.EventHandler(this.addMovie_btn_Click);
            // 
            // ClearMovie_btn
            // 
            this.ClearMovie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.ClearMovie_btn.FlatAppearance.BorderSize = 0;
            this.ClearMovie_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.ClearMovie_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.ClearMovie_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearMovie_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearMovie_btn.ForeColor = System.Drawing.Color.White;
            this.ClearMovie_btn.Location = new System.Drawing.Point(676, 300);
            this.ClearMovie_btn.Name = "ClearMovie_btn";
            this.ClearMovie_btn.Size = new System.Drawing.Size(163, 55);
            this.ClearMovie_btn.TabIndex = 18;
            this.ClearMovie_btn.Text = "Clear";
            this.ClearMovie_btn.UseVisualStyleBackColor = false;
            this.ClearMovie_btn.Click += new System.EventHandler(this.ClearMovie_btn_Click);
            // 
            // DeleteMovie_btn
            // 
            this.DeleteMovie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.DeleteMovie_btn.FlatAppearance.BorderSize = 0;
            this.DeleteMovie_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.DeleteMovie_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.DeleteMovie_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteMovie_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMovie_btn.ForeColor = System.Drawing.Color.White;
            this.DeleteMovie_btn.Location = new System.Drawing.Point(405, 300);
            this.DeleteMovie_btn.Name = "DeleteMovie_btn";
            this.DeleteMovie_btn.Size = new System.Drawing.Size(163, 55);
            this.DeleteMovie_btn.TabIndex = 17;
            this.DeleteMovie_btn.Text = "Delete";
            this.DeleteMovie_btn.UseVisualStyleBackColor = false;
            this.DeleteMovie_btn.Click += new System.EventHandler(this.DeleteMovie_btn_Click);
            // 
            // txtmoviecapacity
            // 
            this.txtmoviecapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmoviecapacity.Location = new System.Drawing.Point(478, 114);
            this.txtmoviecapacity.Name = "txtmoviecapacity";
            this.txtmoviecapacity.Size = new System.Drawing.Size(178, 24);
            this.txtmoviecapacity.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(403, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Capacity:";
            // 
            // ImportMovie_btn
            // 
            this.ImportMovie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.ImportMovie_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportMovie_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportMovie_btn.ForeColor = System.Drawing.Color.White;
            this.ImportMovie_btn.Location = new System.Drawing.Point(819, 202);
            this.ImportMovie_btn.Name = "ImportMovie_btn";
            this.ImportMovie_btn.Size = new System.Drawing.Size(121, 43);
            this.ImportMovie_btn.TabIndex = 14;
            this.ImportMovie_btn.Text = "Import";
            this.ImportMovie_btn.UseVisualStyleBackColor = false;
            this.ImportMovie_btn.Click += new System.EventHandler(this.ImportMovie_btn_Click);
            // 
            // txtmovieprice
            // 
            this.txtmovieprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmovieprice.Location = new System.Drawing.Point(478, 71);
            this.txtmovieprice.Name = "txtmovieprice";
            this.txtmovieprice.Size = new System.Drawing.Size(178, 24);
            this.txtmovieprice.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price:";
            // 
            // cmbmoviegenre
            // 
            this.cmbmoviegenre.FormattingEnabled = true;
            this.cmbmoviegenre.Items.AddRange(new object[] {
            "Educationnal",
            "Drama",
            "Action",
            "Comedy",
            "Horror"});
            this.cmbmoviegenre.Location = new System.Drawing.Point(154, 159);
            this.cmbmoviegenre.Name = "cmbmoviegenre";
            this.cmbmoviegenre.Size = new System.Drawing.Size(176, 24);
            this.cmbmoviegenre.TabIndex = 10;
            this.cmbmoviegenre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Genre:";
            // 
            // txtmoviename
            // 
            this.txtmoviename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmoviename.Location = new System.Drawing.Point(154, 114);
            this.txtmoviename.Name = "txtmoviename";
            this.txtmoviename.Size = new System.Drawing.Size(178, 24);
            this.txtmoviename.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Movie Name:";
            // 
            // txtmovieid
            // 
            this.txtmovieid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmovieid.Location = new System.Drawing.Point(152, 69);
            this.txtmovieid.Name = "txtmovieid";
            this.txtmovieid.Size = new System.Drawing.Size(178, 24);
            this.txtmovieid.TabIndex = 6;
            this.txtmovieid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = " Movie ID:";
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddMovie";
            this.Size = new System.Drawing.Size(1017, 752);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmovieid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmoviename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbmoviegenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmovieprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ImportMovie_btn;
        private System.Windows.Forms.TextBox txtmoviecapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addMovie_btn;
        private System.Windows.Forms.Button ClearMovie_btn;
        private System.Windows.Forms.Button DeleteMovie_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox statuts;
        private System.Windows.Forms.Label cmbstatus;
    }
}
