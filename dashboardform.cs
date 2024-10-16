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
using System.Runtime.CompilerServices;

namespace MovieTicketManagement
{
    public partial class dashboardform : UserControl
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jskla\Documents\movie.mdf;Integrated Security=True;Connect Timeout=30";

        public dashboardform()
        {
            InitializeComponent();
            displayablblMobie();
            displayTotalstaff();
            displayTotalbuys();
            displayTotalincome();
            displaynewM();
         }

        public void refreshdata()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshdata);
                return;
            }
        }
        public void displaynewM()
        {
            moviedata mdata = new moviedata();
            List<moviedata> listdata = mdata.movieAvailablelistdata();
            dataGridView1.DataSource = listdata;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void displayablblMobie()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectdata = "SELECT COUNT(id) as avmovie FROM movies1 WHERE status1 ='Vailabale'";
                using(SqlCommand cmd = new SqlCommand(selectdata, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["avmovie"] != DBNull.Value)
                        {
                            Decimal totalqvmovie = Convert.ToDecimal(reader["avmovie"]);
                            dashavlbm.Text = totalqvmovie.ToString();
                        }
                    }
                }
            }
        }

        public void displayTotalstaff()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectdata = "SELECT COUNT(id) as totalstaff FROM users WHERE role ='staff' AND status = 'Active'";
                using (SqlCommand cmd = new SqlCommand(selectdata, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["totalstaff"] != DBNull.Value)
                        {
                            Decimal totalqvmovie = Convert.ToDecimal(reader["totalstaff"]);
                            dashtotalstaff.Text = totalqvmovie.ToString();
                        }
                    }
                }
            }
        }

        public void displayTotalbuys()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectdata = "SELECT COUNT (id) as totalbuys FROM butticket WHERE status1 ='Paid'";
                using (SqlCommand cmd = new SqlCommand(selectdata, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["totalbuys"] != DBNull.Value)
                        {
                            Decimal totalqvmovie = Convert.ToDecimal(reader["totalbuys"]);
                            dashbuys.Text = totalqvmovie.ToString();
                        }
                    }
                }
            }
        }

        public void displayTotalincome()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectdata = "SELECT SUM (price) as totalincome FROM butticket WHERE status1 ='Paid'";
                using (SqlCommand cmd = new SqlCommand(selectdata, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                         
                       
                            Decimal totalqvmovie = Convert.ToDecimal(reader["totalincome"]);
                            dashincome.Text = "$"+totalqvmovie.ToString("0.00");
                        
                    }
                }
            }
        }

    }
}
