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

namespace MovieTicketManagement
{
    public partial class Form1 : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jskla\Documents\movie.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void login_checkpass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_checkpass.Checked ? '\0' : '*';
        }

        private void login_signupbtn_Click(object sender, EventArgs e)
        {
            registerFrm regForm = new registerFrm();
            regForm.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(login_username.Text=="" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else
            {
                SqlConnection connect = new SqlConnection(conn);
                connect.Open();
                string selectdata = "SELECT * FROM users WHERE username=@usern AND password=@pass ";
                 using (   SqlCommand cmd= new SqlCommand(selectdata,connect))
                 {
                    cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);


                    if (table.Rows.Count > 0)
                    {
                        string role = table.Rows[0]["role"].ToString();

                        MessageBox.Show("Login successfull","Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        if (role == "admin")
                        {
                            adminform admin = new adminform();
                            admin.Show();
                        }
                        else if( role == "staff")
                        {
                            staff sform = new staff();
                            sform.Show();
                        }
                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username / Password","Error message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                 }

            }
        }
    }
}
