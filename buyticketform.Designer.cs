namespace MovieTicketManagement
{
    partial class buyticketform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.calculatebtn = new System.Windows.Forms.Button();
            this.btnbuyticket = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.total_price = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.drinkticket = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.foodticket = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.chairticket = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.avlblprice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rprice = new System.Windows.Forms.Label();
            this.moviegenre = new System.Windows.Forms.Label();
            this.btnclearmovie = new System.Windows.Forms.Button();
            this.btnselectmovie = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.moviename = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.movieid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 339);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(951, 295);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available movies";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.calculatebtn);
            this.panel3.Controls.Add(this.btnbuyticket);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.total_price);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.drinkticket);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.foodticket);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.chairticket);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(590, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 364);
            this.panel3.TabIndex = 2;
            // 
            // calculatebtn
            // 
            this.calculatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.calculatebtn.FlatAppearance.BorderSize = 0;
            this.calculatebtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.calculatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.calculatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculatebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebtn.ForeColor = System.Drawing.Color.White;
            this.calculatebtn.Location = new System.Drawing.Point(119, 192);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(227, 37);
            this.calculatebtn.TabIndex = 29;
            this.calculatebtn.Text = "CALCULATE";
            this.calculatebtn.UseVisualStyleBackColor = false;
            this.calculatebtn.Click += new System.EventHandler(this.calculatebtn_Click);
            // 
            // btnbuyticket
            // 
            this.btnbuyticket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnbuyticket.FlatAppearance.BorderSize = 0;
            this.btnbuyticket.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.btnbuyticket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.btnbuyticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuyticket.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuyticket.ForeColor = System.Drawing.Color.White;
            this.btnbuyticket.Location = new System.Drawing.Point(92, 294);
            this.btnbuyticket.Name = "btnbuyticket";
            this.btnbuyticket.Size = new System.Drawing.Size(227, 39);
            this.btnbuyticket.TabIndex = 27;
            this.btnbuyticket.Text = "BUY";
            this.btnbuyticket.UseVisualStyleBackColor = false;
            this.btnbuyticket.Click += new System.EventHandler(this.button2_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(44, 257);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 19);
            this.label19.TabIndex = 18;
            this.label19.Text = "Total price:";
            // 
            // total_price
            // 
            this.total_price.AutoSize = true;
            this.total_price.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_price.Location = new System.Drawing.Point(164, 257);
            this.total_price.Name = "total_price";
            this.total_price.Size = new System.Drawing.Size(50, 19);
            this.total_price.TabIndex = 17;
            this.total_price.Text = "$0,00";
            this.total_price.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(56, -5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 22);
            this.label17.TabIndex = 16;
            // 
            // drinkticket
            // 
            this.drinkticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkticket.FormattingEnabled = true;
            this.drinkticket.Items.AddRange(new object[] {
            "Orange drink",
            "Softdrink"});
            this.drinkticket.Location = new System.Drawing.Point(134, 147);
            this.drinkticket.Name = "drinkticket";
            this.drinkticket.Size = new System.Drawing.Size(197, 26);
            this.drinkticket.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(74, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 22);
            this.label15.TabIndex = 14;
            this.label15.Text = "Drinks:";
            // 
            // foodticket
            // 
            this.foodticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodticket.FormattingEnabled = true;
            this.foodticket.Items.AddRange(new object[] {
            "Popcorn",
            "Fries"});
            this.foodticket.Location = new System.Drawing.Point(134, 104);
            this.foodticket.Name = "foodticket";
            this.foodticket.Size = new System.Drawing.Size(197, 26);
            this.foodticket.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(74, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 22);
            this.label16.TabIndex = 12;
            this.label16.Text = "Foods:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(44, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 19);
            this.label14.TabIndex = 11;
            this.label14.Text = "Available Foods";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // chairticket
            // 
            this.chairticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chairticket.FormattingEnabled = true;
            this.chairticket.Items.AddRange(new object[] {
            "Normal chair",
            "VIP chair"});
            this.chairticket.Location = new System.Drawing.Point(134, 14);
            this.chairticket.Name = "chairticket";
            this.chairticket.Size = new System.Drawing.Size(197, 26);
            this.chairticket.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 22);
            this.label13.TabIndex = 9;
            this.label13.Text = "Available Chair:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(16, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.avlblprice);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.rprice);
            this.panel2.Controls.Add(this.moviegenre);
            this.panel2.Controls.Add(this.btnclearmovie);
            this.panel2.Controls.Add(this.btnselectmovie);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.moviename);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.movieid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(17, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 361);
            this.panel2.TabIndex = 1;
            // 
            // avlblprice
            // 
            this.avlblprice.AutoSize = true;
            this.avlblprice.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avlblprice.Location = new System.Drawing.Point(355, 246);
            this.avlblprice.Name = "avlblprice";
            this.avlblprice.Size = new System.Drawing.Size(25, 22);
            this.avlblprice.TabIndex = 25;
            this.avlblprice.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(238, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 22);
            this.label11.TabIndex = 24;
            this.label11.Text = "Available price :";
            // 
            // rprice
            // 
            this.rprice.AutoSize = true;
            this.rprice.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rprice.Location = new System.Drawing.Point(355, 198);
            this.rprice.Name = "rprice";
            this.rprice.Size = new System.Drawing.Size(25, 22);
            this.rprice.TabIndex = 23;
            this.rprice.Text = "---";
            // 
            // moviegenre
            // 
            this.moviegenre.AutoSize = true;
            this.moviegenre.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviegenre.Location = new System.Drawing.Point(355, 148);
            this.moviegenre.Name = "moviegenre";
            this.moviegenre.Size = new System.Drawing.Size(25, 22);
            this.moviegenre.TabIndex = 22;
            this.moviegenre.Text = "---";
            // 
            // btnclearmovie
            // 
            this.btnclearmovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnclearmovie.FlatAppearance.BorderSize = 0;
            this.btnclearmovie.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.btnclearmovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.btnclearmovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclearmovie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclearmovie.ForeColor = System.Drawing.Color.White;
            this.btnclearmovie.Location = new System.Drawing.Point(411, 290);
            this.btnclearmovie.Name = "btnclearmovie";
            this.btnclearmovie.Size = new System.Drawing.Size(139, 43);
            this.btnclearmovie.TabIndex = 21;
            this.btnclearmovie.Text = "CLEAR";
            this.btnclearmovie.UseVisualStyleBackColor = false;
            this.btnclearmovie.Click += new System.EventHandler(this.btnclearmovie_Click);
            // 
            // btnselectmovie
            // 
            this.btnselectmovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btnselectmovie.FlatAppearance.BorderSize = 0;
            this.btnselectmovie.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.btnselectmovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.btnselectmovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselectmovie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselectmovie.ForeColor = System.Drawing.Color.White;
            this.btnselectmovie.Location = new System.Drawing.Point(223, 290);
            this.btnselectmovie.Name = "btnselectmovie";
            this.btnselectmovie.Size = new System.Drawing.Size(141, 43);
            this.btnselectmovie.TabIndex = 20;
            this.btnselectmovie.Text = "SELECT ";
            this.btnselectmovie.UseVisualStyleBackColor = false;
            this.btnselectmovie.Click += new System.EventHandler(this.btnselectmovie_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Regular price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Genre:";
            // 
            // moviename
            // 
            this.moviename.AutoSize = true;
            this.moviename.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviename.Location = new System.Drawing.Point(355, 98);
            this.moviename.Name = "moviename";
            this.moviename.Size = new System.Drawing.Size(25, 22);
            this.moviename.TabIndex = 9;
            this.moviename.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = " Movie name:";
            // 
            // movieid
            // 
            this.movieid.AutoSize = true;
            this.movieid.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieid.Location = new System.Drawing.Point(355, 48);
            this.movieid.Name = "movieid";
            this.movieid.Size = new System.Drawing.Size(25, 22);
            this.movieid.TabIndex = 7;
            this.movieid.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = " Movie ID:";
            // 
            // buyticketform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "buyticketform";
            this.Size = new System.Drawing.Size(1017, 752);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label moviename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label movieid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclearmovie;
        private System.Windows.Forms.Button btnselectmovie;
        private System.Windows.Forms.Label rprice;
        private System.Windows.Forms.Label moviegenre;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label avlblprice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox chairticket;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox drinkticket;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox foodticket;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label total_price;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnbuyticket;
        private System.Windows.Forms.Button calculatebtn;
    }
}
