using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OfficeOpenXml.ConditionalFormatting;

namespace Inspection_Report
{
    public partial class loginForm : Form
    {
        public string Username { get; private set; }
        public event EventHandler? AdminLoggedIn;
        public event EventHandler? RegularLoggedIn;
        public MainPage? MainPageInstance { get; set; }
        private int animationfadein = 0;

        public loginForm()
        {
            Username = "defaultusername";
            InitializeComponent();
            timer1.Start();
            this.AcceptButton = loginBtn;
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernametxtBox.Text;
            string password = passwordtxtBox.Text;

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True"))
            {
                con.Open();

                string loginQuery = "SELECT * FROM Users WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(loginQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        string storedHashedPassword = dr["Password"]?.ToString() ?? string.Empty;
                        bool IsAdmin = (bool)dr["IsAdmin"];

                        if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                        {
                            AuthenticatedUser.UserName = username;
                            MainPage mainPage = new MainPage();
                            if (!IsAdmin)
                            {
                                RegularLoggedIn?.Invoke(this, EventArgs.Empty);
                                mainPage.DisableTrailMenuItem();
                            }
                            else if (IsAdmin)
                            {
                                AdminLoggedIn?.Invoke(this, EventArgs.Empty);
                                mainPage.EnableTrailMenuItem();
                            }
                            mainPage.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password. Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            usernametxtBox.Clear();
                            passwordtxtBox.Clear();
                            usernametxtBox.Focus();
                        }
                    }
                    else
                    {
                        // User with the given username doesn't exist
                        MessageBox.Show("User does not exist", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usernametxtBox.Clear();
                        passwordtxtBox.Clear();
                        usernametxtBox.Focus();
                    }
                }
            }
            timer2.Start();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            usernametxtBox.Clear();
            passwordtxtBox.Clear();
            usernametxtBox.Focus();
        }

        private void showchkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showchkBox.Checked)
            {
                passwordtxtBox.PasswordChar = '\0';
            }
            else
            {
                passwordtxtBox.PasswordChar = '•';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Request().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ResetForm()
        {
            usernametxtBox.Clear();
            passwordtxtBox.Clear();
            usernametxtBox.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (animationfadein < 255)
            {
                this.Opacity = animationfadein / 255.0;
                animationfadein += 40;
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
