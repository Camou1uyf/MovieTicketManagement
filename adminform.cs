using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketManagement
{
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit ?", "Confirmation message",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to logout ?", "Confirmation message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void addstaffForm1_Load(object sender, EventArgs e)
        {

        }

        private void addMovie1_Load(object sender, EventArgs e)
        {

        }

        private void Dash_btn_Click(object sender, EventArgs e)
        {
            dashboardform1.Show();
             addMovie1.Hide();
            addstaffForm1.Hide();

            dashboardform d = new dashboardform();
            if(d != null)
            {
                d.refreshdata();
            }
        }

        private void addstaff_btn_Click(object sender, EventArgs e)
        {
            dashboardform1.Hide();
            addMovie1.Hide();
            addstaffForm1.Show();
           addstaffForm stf = new addstaffForm();
            if (stf != null)
            {
                stf.refreshdata();
            }

        }

        private void addmovie_btn_Click(object sender, EventArgs e)
        {
            dashboardform1.Hide();
            addMovie1.Show();
            addstaffForm1.Hide();
            AddMovie am = new AddMovie();
            if (am != null)
            {
                am.refreshdata();
            }
        }
    }
}
