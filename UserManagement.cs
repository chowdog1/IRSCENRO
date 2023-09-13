using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inspection_Report
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Users", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewUsers.DataSource = dt;
        }

        private void PopulateDataGridView()
        {
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewUsers.DataSource = dt;
            }
        }
        private void promoteuserDatabase(string username, bool isAdmin)
        {
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string updateQuery = "UPDATE Users SET IsAdmin = @IsAdmin WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@IsAdmin", isAdmin);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Sql Error: " + ex.Message);
                    }
                }
            }
        }

        private void promoteuserBtn_Click(object sender, EventArgs e)
        {
            string searchUsername = usernametxtBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchUsername))
            {
                DataTable dt = (DataTable)dataGridViewUsers.DataSource;

                if (dt != null)
                {
                    DataRow[] foundRows = dt.Select($"Username = '{searchUsername}'");

                    if (foundRows.Length > 0)
                    {
                        if (!(bool)foundRows[0]["IsAdmin"])
                        {
                            foundRows[0]["IsAdmin"] = true;
                            promoteuserDatabase(searchUsername, true);
                            dataGridViewUsers.Refresh();
                            MessageBox.Show($"{searchUsername} has been promoted to Admin.");
                        }
                        else
                        {
                            MessageBox.Show($"{searchUsername} is already an Admin.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"User '{searchUsername}' not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a username to search.");
            }
        }
        private void dltuserBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string DeleteQuery = "DELETE Users where Username=@Username";

                using (SqlCommand cmd = new SqlCommand(DeleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Username", usernametxtBox.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        string message = usernametxtBox.Text + " has successfully deleted!";
                        MessageBox.Show(message);
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Sql Error: " + ex.Message);
                    }
                }
            }
        }
        private void demoteuserDatabase(string username, bool isAdmin)
        {
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string updateQuery = "UPDATE Users SET IsAdmin = @IsAdmin WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@IsAdmin", isAdmin);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Sql Error: " + ex.Message);
                    }
                }
            }
        }
        private void removeadminBtn_Click(object sender, EventArgs e)
        {
            string searchUsername = usernametxtBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchUsername))
            {
                DataTable dt = (DataTable)dataGridViewUsers.DataSource;

                if (dt != null)
                {
                    DataRow[] foundRows = dt.Select($"Username = '{searchUsername}'");

                    if (foundRows.Length > 0)
                    {
                        if ((bool)foundRows[0]["IsAdmin"])
                        {
                            foundRows[0]["IsAdmin"] = false;
                            demoteuserDatabase(searchUsername, false);

                            dataGridViewUsers.Refresh();

                            MessageBox.Show($"{searchUsername} admin rights removed.");
                        }
                        else
                        {
                            MessageBox.Show($"{searchUsername} is already a regular user.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"User '{searchUsername}' not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a username to search.");
            }
        }
    }
}
