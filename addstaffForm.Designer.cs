namespace MovieTicketManagement
{
    partial class addstaffForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_btn = new System.Windows.Forms.Button();
            this.deletestaff_btn = new System.Windows.Forms.Button();
            this.updatestaff_btn = new System.Windows.Forms.Button();
            this.addstaff_btn = new System.Windows.Forms.Button();
            this.status_staff = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pass_staff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.username_staff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(341, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 706);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(17, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 616);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "All Staff";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.deletestaff_btn);
            this.panel1.Controls.Add(this.updatestaff_btn);
            this.panel1.Controls.Add(this.addstaff_btn);
            this.panel1.Controls.Add(this.status_staff);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pass_staff);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.username_staff);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 706);
            this.panel1.TabIndex = 2;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.clear_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(167, 458);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(115, 45);
            this.clear_btn.TabIndex = 12;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // deletestaff_btn
            // 
            this.deletestaff_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.deletestaff_btn.FlatAppearance.BorderSize = 0;
            this.deletestaff_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.deletestaff_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.deletestaff_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletestaff_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletestaff_btn.ForeColor = System.Drawing.Color.White;
            this.deletestaff_btn.Location = new System.Drawing.Point(18, 458);
            this.deletestaff_btn.Name = "deletestaff_btn";
            this.deletestaff_btn.Size = new System.Drawing.Size(118, 45);
            this.deletestaff_btn.TabIndex = 11;
            this.deletestaff_btn.Text = "Delete";
            this.deletestaff_btn.UseVisualStyleBackColor = false;
            this.deletestaff_btn.Click += new System.EventHandler(this.deletestaff_btn_Click);
            // 
            // updatestaff_btn
            // 
            this.updatestaff_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.updatestaff_btn.FlatAppearance.BorderSize = 0;
            this.updatestaff_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.updatestaff_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.updatestaff_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatestaff_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatestaff_btn.ForeColor = System.Drawing.Color.White;
            this.updatestaff_btn.Location = new System.Drawing.Point(167, 380);
            this.updatestaff_btn.Name = "updatestaff_btn";
            this.updatestaff_btn.Size = new System.Drawing.Size(115, 45);
            this.updatestaff_btn.TabIndex = 10;
            this.updatestaff_btn.Text = "Update";
            this.updatestaff_btn.UseVisualStyleBackColor = false;
            this.updatestaff_btn.Click += new System.EventHandler(this.updatestaff_btn_Click);
            // 
            // addstaff_btn
            // 
            this.addstaff_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addstaff_btn.FlatAppearance.BorderSize = 0;
            this.addstaff_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addstaff_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addstaff_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addstaff_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstaff_btn.ForeColor = System.Drawing.Color.White;
            this.addstaff_btn.Location = new System.Drawing.Point(18, 380);
            this.addstaff_btn.Name = "addstaff_btn";
            this.addstaff_btn.Size = new System.Drawing.Size(118, 45);
            this.addstaff_btn.TabIndex = 9;
            this.addstaff_btn.Text = "Add";
            this.addstaff_btn.UseVisualStyleBackColor = false;
            this.addstaff_btn.Click += new System.EventHandler(this.addstaff_btn_Click);
            // 
            // status_staff
            // 
            this.status_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_staff.FormattingEnabled = true;
            this.status_staff.Items.AddRange(new object[] {
            "Active ",
            "Inactive"});
            this.status_staff.Location = new System.Drawing.Point(18, 309);
            this.status_staff.Name = "status_staff";
            this.status_staff.Size = new System.Drawing.Size(263, 30);
            this.status_staff.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status :";
            // 
            // pass_staff
            // 
            this.pass_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_staff.Location = new System.Drawing.Point(21, 216);
            this.pass_staff.Name = "pass_staff";
            this.pass_staff.Size = new System.Drawing.Size(263, 28);
            this.pass_staff.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password :";
            // 
            // username_staff
            // 
            this.username_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_staff.Location = new System.Drawing.Point(21, 117);
            this.username_staff.Name = "username_staff";
            this.username_staff.Size = new System.Drawing.Size(263, 28);
            this.username_staff.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fill Staff Information";
            // 
            // addstaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "addstaffForm";
            this.Size = new System.Drawing.Size(1017, 752);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button deletestaff_btn;
        private System.Windows.Forms.Button updatestaff_btn;
        private System.Windows.Forms.Button addstaff_btn;
        private System.Windows.Forms.ComboBox status_staff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pass_staff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username_staff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
