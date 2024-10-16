using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace MovieTicketManagement
{
   class staffData
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jskla\Documents\movie.mdf;Integrated Security=True;Connect Timeout=30";

        public int id { get; set; }
        public string username { get; set; }
        public string Password { get; set; }
        public string role { get; set; }
        public string status { get; set; }

        public List<staffData> staffDatalistData()
        {
            List<staffData> listadata = new List<staffData>();
            using(SqlConnection connect= new SqlConnection(conn))
            {
                connect.Open();
                string selectdata ="SELECT * FROM users WHERE role = 'staff' AND status !='Deleted'";
                using(SqlCommand cmd = new SqlCommand(selectdata, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        staffData sdata = new staffData();
                        sdata.id = (int)reader[0];
                        sdata.username = reader[1].ToString();
                        sdata.Password =  reader[2].ToString();
                        sdata.role = reader[3].ToString();
                        sdata.status=  reader[4].ToString();
                        listadata.Add(sdata);
                    }
                        
                }
            }
            return listadata;
        }
    }
}
