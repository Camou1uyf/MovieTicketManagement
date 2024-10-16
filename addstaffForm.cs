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
using System.Diagnostics.Eventing.Reader;
using System.Net.Http.Headers;

namespace MovieTicketManagement
{
    public partial class addstaffForm : UserControl
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jskla\Documents\movie.mdf;Integrated Security=True;Connect Timeout=30";
        public addstaffForm()
        {
            InitializeComponent();
            displaydata();
        }

        public void refreshdata()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshdata);
                return;
            }
        }
        public void displaydata()
        {
            staffData sdata = new staffData();
            List<staffData> listdata = sdata.staffDatalistData();
            dataGridView1.DataSource = listdata;
        }
        private void addstaff_btn_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageBox.Show("Empty fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string selectusername = "SELECT * FROM users WHERE username= @usern";

                    using (SqlCommand checkuser = new SqlCommand(selectusername, connect))
                    {
                        checkuser.Parameters.AddWithValue("@usern", username_staff.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkuser);

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(username_staff.Text.Substring(0, 1).ToUpper() +
                                username_staff.Text.Substring(1) + " is already existing", "Error message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertdata = "INSERT INTO users (username, password, role, status, date_reg) VALUES " +
                                "(@usern, @pass, @role, @status, @date)";

                            using (SqlCommand cmd = new SqlCommand(insertdata, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", username_staff.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", pass_staff.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "staff");
                                cmd.Parameters.AddWithValue("@status", status_staff.Text.ToString());
                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Added successfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearfields();
                            }
                        }
                    }
                }
            }

        }

        public bool IsEmpty()
        {
            if (username_staff.Text == "" || pass_staff.Text == "" || status_staff.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void updatestaff_btn_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageBox.Show("Empty fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string selectusername = "SELECT * FROM users WHERE username=@usern";
                    using (SqlCommand checkuser = new SqlCommand(selectusername, connect))
                    {
                        checkuser.Parameters.AddWithValue("@usern", username_staff.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkuser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count >= 2)
                        {
                            MessageBox.Show(username_staff.Text.Substring(0, 1).ToUpper() +
                                       username_staff.Text.Substring(1) + " is already existing", "Error message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string updatedata = "UPDATE users SET username=@usern, password =@pass, status=@status WHERE id=@id ";
                            using (SqlCommand cmd = new SqlCommand(updatedata, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", username_staff.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", pass_staff.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", status_staff.SelectedText.ToString());
                                cmd.Parameters.AddWithValue("@id", getid);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Updated successfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
            }
        }
        public void clearfields()
        {
            username_staff.Text = "";
            pass_staff.Text = "";
            status_staff.Text = "";
        }

        private int getid = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getid = (int)row.Cells[0].Value;
                username_staff.Text = row.Cells[1].Value.ToString();
                pass_staff.Text = row.Cells[2].Value.ToString();
                status_staff.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void deletestaff_btn_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageBox.Show("Empty fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    
                         
                      string updatedata = "UPDATE users SET status = @status WHERE id = @id ";
                            using (SqlCommand cmd = new SqlCommand(updatedata, connect))
                            {
                       
                         cmd.Parameters.AddWithValue("@status", "Deleted");
                         cmd.Parameters.AddWithValue("@id", getid);
                         cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted successfully", "Information message", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information); 

                       clearfields();
                   }
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clearfields();
        }
    }
}



 