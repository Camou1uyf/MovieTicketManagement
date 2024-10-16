using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace MovieTicketManagement
{
    public partial class registerFrm : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jskla\Documents\movie.mdf;Integrated Security=True;Connect Timeout=30";
        public registerFrm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            reg_pass.PasswordChar = reg_showpass.Checked ? '\0' : '*';
            reg_cpass.PasswordChar = reg_showpass.Checked ? '\0' : '*';
        }

        private void reg_registetBtn_Click(object sender, EventArgs e)
        {
            if(reg_pass.Text==""|| reg_username.Text=="" || reg_cpass.Text == "")
            {

                MessageBox.Show("Please fill all blank fields","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(reg_pass.Text != reg_cpass.Text)
                {
                    MessageBox.Show("Password do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (reg_pass.Text.Length < 8)
            {
                MessageBox.Show("Invalid password ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string checkUsername = "SELECT * FROM users WHERE username=@usern";
                    using (SqlCommand chechUsern = new SqlCommand(checkUsername, connect))
                    {
                        chechUsern.Parameters.AddWithValue("@usern", reg_username.Text.Trim()); // security from sql injection
                        SqlDataAdapter adapter = new SqlDataAdapter(chechUsern);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(reg_username.Text.Substring(0, 1).ToUpper()
                               + reg_username.Text.Substring(1) + "is taken already", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = " INSERT INTO users(username, password, role, status, date_reg)" +
                                " VALUES(@usern, @pass, @role, @status, @date) ";
                            DateTime today = DateTime.Today;
                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", reg_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", reg_pass.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "staff");
                                cmd.Parameters.AddWithValue("@status",  "Active");
                                cmd.Parameters.AddWithValue("@date",  today);

                                cmd.ExecuteNonQuery(); //for تستخدم عادةً لإجراء عمليات لا تُعيد بيانات insert delte update
                                MessageBox.Show("Regestered succsseful", "Infor;ation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 loginfrm = new Form1();
                                loginfrm.Show();
                                this.Hide();

                            }


                        }


                    } 

                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void reg_signinBtn_Click(object sender, EventArgs e)
        {
          
        }
    }
}
