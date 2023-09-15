using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inspection_Report
{
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text;
            string dept = depttextBox.Text;
            string email = emailtextBox.Text;
            string reason = reasontextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(dept) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            EmailHelper.SendRequestEmail(name, dept, email, reason);

            MessageBox.Show("Request successfully sent. Always check your email.");

            Application.Exit();
        }
    }
}
