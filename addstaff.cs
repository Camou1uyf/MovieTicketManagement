using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketManagement
{
    public partial class addstaff : Form
    {
        public addstaff()
        {
            InitializeComponent();
        }

        private void addstaff_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private int getid = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getid = (int)row.Cells[0].Value ;
                username_staff.Text = row.Cells[1].Value.ToString();
                pass_staff.Text = row.Cells[2].Value.ToString();
                 status_staff.SelectedItem= row.Cells[3].Value.ToString();
            }
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addbtn_staff_Click(object sender, EventArgs e)
        {

        }

        private void updatebtn_staff_Click(object sender, EventArgs e)
        {
           
        }
    }

}

