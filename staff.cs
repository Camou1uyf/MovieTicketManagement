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
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to quit ?", "Question message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to logout ?", "Question message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void buyticketform2_Load(object sender, EventArgs e)
        {

        }

        private void Dash_btn_Click(object sender, EventArgs e)
        {

            dashboardform1.Show();
            buyticketform1.Hide();
            dashboardform d = new dashboardform();
            if (d != null)
            {
                d.refreshdata();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardform1.Hide();
            buyticketform1.Show();
            buyticketform tck = new buyticketform();
            if (tck != null)
            {
                tck.refreshdata();
            }
        }
    }
    
}
