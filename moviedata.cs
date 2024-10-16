using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace MovieTicketManagement
{

    internal class moviedata
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jskla\Documents\movie.mdf;Integrated Security=True;Connect Timeout=30";

        public int id { get; set; }
        public string movieid { get; set; }
        public string moviename { get; set; }
        public string genre { get; set; }
        public string price { get; set; }
        public string capacity { get; set; }
        public string status { get; set; }
        public string image { get; set; }
        public string date { get; set; }


        public List<moviedata> movielistdata()
        {
            List<moviedata> listdata = new List<moviedata>();
            using(SqlConnection connect= new SqlConnection(conn))
            {
                connect.Open();
                string selectdata = "SELECT * FROM movies1 WHERE delete_date IS NULL";
                using(SqlCommand  cmd = new SqlCommand(selectdata, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        moviedata mdata = new moviedata();
                        mdata.id = Convert.ToInt32(reader["id"]);
                        mdata.movieid = reader["movie_id"].ToString();
                        mdata.moviename = reader["movie_name"].ToString();
                        mdata.genre = reader["genre"].ToString();
                        mdata.price = reader["price"].ToString();
                        mdata.capacity = reader["capacity"].ToString();
                        mdata.status = reader["status1"].ToString();
                        mdata.image = reader["movie_image"].ToString();
                        mdata.date = reader["date1"].ToString();

                        listdata.Add(mdata);
                    }
                }
            }
            return listdata;
        }



        public List<moviedata> movieAvailablelistdata()
        {
            List<moviedata> listdata = new List<moviedata>();
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectdata = "SELECT * FROM movies1 WHERE status1='Vailabale' AND delete_date IS NULL";
                using (SqlCommand cmd = new SqlCommand(selectdata, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        moviedata mdata = new moviedata();
                        mdata.id = Convert.ToInt32(reader["id"]);
                        mdata.movieid = reader["movie_id"].ToString();
                        mdata.moviename = reader["movie_name"].ToString();
                        mdata.genre = reader["genre"].ToString();
                        mdata.price = reader["price"].ToString();
                        mdata.capacity = reader["capacity"].ToString();
                        mdata.status = reader["status1"].ToString();
                        mdata.image = reader["movie_image"].ToString();
                        mdata.date = reader["date1"].ToString();


                        listdata.Add(mdata);
                    }
                }
            }
            return listdata;
        }

    }
}
