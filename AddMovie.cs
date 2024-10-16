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
using System.IO;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace MovieTicketManagement
{
    public partial class AddMovie : UserControl
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jskla\Documents\movie.mdf;Integrated Security=True;Connect Timeout=30";


        public void displaydata()
        {
            moviedata mdata = new moviedata();
            List<moviedata> listdata = mdata.movielistdata();
            dataGridView1.DataSource = listdata;
        }

        public AddMovie()
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ImportMovie_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog(); //une boîte de dialogue pour ouvrir un fichier
                string imagepath = "";
                file.Filter = "Image File(*.jpg; *.png)|*.jpg;*.png";//spécifie les types de fichiers qui peuvent être affichés dans la boîte de dialogue d'ouverture de fichier. Cela permet à l'utilisateur de voir uniquement les fichiers qui à  critères
                if (file.ShowDialog() == DialogResult.OK)
                {
                    imagepath = file.FileName; //pour récupérer le chemin du fichier choisi par l'utilisateur
                    pictureBox1.ImageLocation = imagepath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addMovie_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string checkID = "SELECT movie_id FROM movies1 WHERE movie_id = @movie_id";
                    using (SqlCommand cID = new SqlCommand(checkID, connect))
                    {
                        cID.Parameters.AddWithValue("@movie_id", txtmovieid.Text.Trim());
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cID))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Movie ID already exists", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertdata = "INSERT INTO movies1 (movie_id, movie_name, genre, price, capacity, status1, movie_image, date1) " +
                                    "VALUES (@movie_id, @moviename, @genre, @price, @capacity, @status1, @movieimage, @date1)";

                                string path = Path.Combine("C:\\Users\\jskla\\source\\repos\\MovieTicketManagement\\MovieTicketManagement\\movie_directory\\"
                                    + txtmovieid.Text.Trim() + ".jpg");

                                string directory_path = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directory_path))
                                {
                                    Directory.CreateDirectory(directory_path);
                                }

                                // Check if pictureBox1 has a valid image
                                if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
                                {
                                    File.Copy(pictureBox1.ImageLocation, path, true);

                                    using (SqlCommand cmd = new SqlCommand(insertdata, connect))
                                    {
                                        cmd.Parameters.AddWithValue("@movie_id", txtmovieid.Text.Trim());
                                        cmd.Parameters.AddWithValue("@moviename", txtmoviename.Text.Trim());
                                        cmd.Parameters.AddWithValue("@genre", cmbmoviegenre.Text.Trim());

                                        // Convert price and capacity to proper data types
                                        decimal price = decimal.Parse(txtmovieprice.Text.Trim());
                                        int capacity = int.Parse(txtmoviecapacity.Text.Trim());

                                        cmd.Parameters.AddWithValue("@price", price);
                                        cmd.Parameters.AddWithValue("@capacity", capacity);
                                        cmd.Parameters.AddWithValue("@status1", statuts.Text.Trim());
                                        cmd.Parameters.AddWithValue("@movieimage", path);

                                        DateTime today = DateTime.Now;
                                        cmd.Parameters.AddWithValue("@date1", today);


                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Added successfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        displaydata();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No image selected", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ClearMovie_btn_Click(object sender, EventArgs e)
        {
            txtmovieid.Text = "";
            txtmoviename.Text = "";
            txtmovieprice.Text = "";
            txtmoviecapacity.Text = "";
            statuts.Text = "";
            cmbmoviegenre.Text = "";
            pictureBox1.Image = null;
        }


        private int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = (int)row.Cells[0].Value;
                txtmovieid.Text = row.Cells[1].Value.ToString();
                txtmoviename.Text = row.Cells[2].Value.ToString();
                cmbmoviegenre.Text = row.Cells[3].Value.ToString();
                txtmovieprice.Text = row.Cells[4].Value.ToString();
                txtmoviecapacity.Text = row.Cells[5].Value.ToString();
                statuts.Text = row.Cells[6].Value.ToString();
                pictureBox1.ImageLocation = row.Cells[7].Value.ToString();
            }
        }

        private void DeleteMovie_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete ID ?, ", "Confirmation message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();
                        string updatedata = "UPDATE movies1 SET delete_date=@deletedata WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(updatedata, connect))
                        {
                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@deletedata",today);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                            displaydata();
                           

                        }

                    }
                }


            }
            catch (Exception ex)
            {

            }

        }
    }
}