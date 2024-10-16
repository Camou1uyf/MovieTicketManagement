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
using System.Net.Http.Headers;
using System.Web;
using System.Linq.Expressions;

namespace MovieTicketManagement
{
    public partial class buyticketform : UserControl
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jskla\Documents\movie.mdf;Integrated Security=True;Connect Timeout=30";

        public buyticketform()
        {
            InitializeComponent();

            DisplayAvailablemovie();

            displayseatvlbl();
        }

        public void refreshdata()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshdata);
                return;
            }
        }
        public void DisplayAvailablemovie()
        {
            moviedata mdata = new moviedata();
            List<moviedata>listdata = mdata.movieAvailablelistdata();
            dataGridView1.DataSource =listdata;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        string movie_id;
       
            private void button2_Click(object sender, EventArgs e)
            {
                if (movie_id == null || getTotaleprice == 0)
                {
                    MessageBox.Show("Please select movie first", "Message error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();
                        string selectdata = "INSERT INTO butticket (movie_id, seat_number, price, status1, created_at) VALUES " +
                            "(@movieid, @seatnumber, @price, @status, @createdat)";

                        using (SqlCommand cmd = new SqlCommand(selectdata, connect))
                        {

                            cmd.Parameters.AddWithValue("@movieid", movie_id);
                            cmd.Parameters.AddWithValue("@seatnumber", 1); 
                            cmd.Parameters.AddWithValue("@price", getTotaleprice);
                            cmd.Parameters.AddWithValue("@status", "Paid");
                            DateTime today = DateTime.Now;
                            cmd.Parameters.AddWithValue("@createdat", today);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

       

        private void button4_Click(object sender, EventArgs e)
        {

        }
    private int id=0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = (int)row.Cells[0].Value;
                movieid.Text = row.Cells[1].Value.ToString();
                moviename.Text = row.Cells[2].Value.ToString();
                moviegenre.Text = row.Cells[3].Value.ToString();
                rprice.Text = row.Cells[4].Value.ToString();
                avlblprice.Text = row.Cells[5].Value.ToString();
                pictureBox1.ImageLocation = row.Cells[6].Value.ToString();

            }
        }

        public void displayseatvlbl()
        {
           string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jskla\Documents\movie.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectseatavlbl = $"SELECT capacity FROM movies1 WHERE delete_date IS NULL AND status1 != 'Delete' AND movie_id = '" + movie_id + "'";
                int seatavlbl = 0;
                using (SqlCommand clientselect= new SqlCommand(selectseatavlbl,connect))
                {
                     SqlDataReader reader = clientselect.ExecuteReader();
                    if (reader.Read())
                    {
                        seatavlbl = (int)reader["capacity"];

                    }
                    reader.Close();
                }
                if (seatavlbl > 0)
                {
                    string selectbookseat = "SELECT seat_number FROM butticket WHERE movie_id = @movie_id";
                    List<int> bookseats = new List<int>();
                    using(SqlCommand cmd = new SqlCommand(selectbookseat, connect))
                    {
                        cmd.Parameters.AddWithValue("@movie_id",movie_id);
                           SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            bookseats.Add((int)reader["seat_number"]);
                        }
                        reader.Close();
                        List<int> allseat = Enumerable.Range(1, seatavlbl).ToList();
                        List<int> vaialableseat = allseat.Except(bookseats).ToList();
                        DataTable table = new DataTable();
                        table.Columns.Add("seat_number", typeof(int));
                        foreach(int seat in vaialableseat)
                        {
                            table.Rows.Add(seat);
                        }
                        if (table.Rows.Count > 0)
                        {
                            chairticket.DataSource = table;
                            chairticket.DisplayMember = "seat_number";
                            chairticket.ValueMember = "seat_number";
                            chairticket.Refresh();
                        }
                        else
                        {
                            chairticket.DataSource = null;
                        }
                    }
                }
            }              
        }

        private void btnselectmovie_Click(object sender, EventArgs e)
        {
            movie_id = movieid.Text.Trim();
            displayseatvlbl();
        }

        double getTotaleprice = 0;
        private void calculatebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectprice = "SELECT movie_id, price FROM movies1 WHERE movie_id = @movie_id";
                double getprice = 0;
                using (SqlCommand cmd = new SqlCommand(selectprice, connect))
                {
                    // Ajout du paramètre pour éviter l'injection SQL
                    cmd.Parameters.AddWithValue("@movie_id", movie_id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())  // S'assure qu'il y a des résultats
                        {
                            getprice = Convert.ToDouble(reader["price"]);
                        }
                    }

                    double getfoodprice = (foodticket.SelectedIndex == -1) ? 0 : 100;
                    double getdrinkprice = (foodticket.SelectedIndex == -1) ? 0 : 50;
                    getTotaleprice = getprice + getfoodprice + getdrinkprice; 

                    total_price.Text = "$" + getTotaleprice.ToString("0.00");
                    total_price.Refresh();
                }
            }
        }

        private void btnclearmovie_Click(object sender, EventArgs e)
        {
            id = 0;
            movieid.Text = "" ;
            moviename.Text = "" ;
            moviegenre.Text = "";
            rprice.Text = "";
            avlblprice.Text = "";
            pictureBox1.ImageLocation = null ;

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
 
