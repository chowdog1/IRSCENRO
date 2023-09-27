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
    public partial class Compliance : Form
    {
        public Compliance()
        {
            InitializeComponent();

            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Compliance (AccountNo, BusinessName, Address, Barangay, BusinessStatus, Compliances) " +
                                     "SELECT i.AccountNo, i.BusinessName, i.Address, i.Barangay, i.BusinessStatus, i.SecuretheFF " +
                                     "FROM InspectionReport i " +
                                     "WHERE i.EstablishmentHas IN ('Violated City Ordinances', 'Notice/Warning') " +
                                     "AND NOT EXISTS (SELECT 1 FROM Compliance c WHERE c.AccountNo = i.AccountNo)";

                string deleteQuery = "DELETE FROM Compliance " +
                                     "WHERE AccountNo NOT IN (SELECT AccountNo FROM InspectionReport WHERE EstablishmentHas IN ('Violated City Ordinances', 'Notice/Warning'))";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    int insertRowsAffected = insertCommand.ExecuteNonQuery();

                    int deleteRowsAffected = deleteCommand.ExecuteNonQuery();
                    PopulateDataGridView();
                }
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string update = "Update Compliance SET " +
                                "Compliances = " +
                                "CASE " +
                                "WHEN LEN(ISNULL(@Compliances, '')) > 0 AND LEN(ISNULL(Compliances, '')) > 0 " +
                                "THEN COALESCE(Compliances + ', ', '') + @Compliances " +
                                "WHEN LEN(ISNULL(@Compliances, '')) > 0 " +
                                "THEN @Compliances " +
                                "ELSE Compliances " +
                                "END, " +
                                "Others = " +
                                "CASE " +
                                "WHEN LEN(ISNULL(@Others, '')) > 0 AND LEN(ISNULL(Others, '')) > 0 " +
                                "THEN COALESCE(Others + ', ', '') + @Others " +
                                "WHEN LEN(ISNULL(@Others, '')) > 0 " +
                                "THEN @Others " +
                                "ELSE Others " +
                                "END, " +
                                "IsComplied = CASE " +
                                "WHEN LEN(ISNULL(@IsComplied, '')) > 0 THEN @IsComplied " +
                                "ELSE IsComplied " +
                                "END " +
                                "WHERE AccountNo = @AccountNo";
                using (SqlCommand cmd = new SqlCommand(update, con))
                {
                    cmd.Parameters.AddWithValue("@AccountNo", acctnotextBox.Text);
                    cmd.Parameters.AddWithValue("@Compliances", string.Join(", ", compliancechklistBox.CheckedItems.Cast<string>()));
                    cmd.Parameters.AddWithValue("@Others", otherstextBox.Text);
                    cmd.Parameters.AddWithValue("@IsComplied", GetSelectedRadioButtonText(submittedyesradioBtn, submittednoradioBtn));

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully Updated!");
                            PopulateDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No record found for the specified Account No.", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Sql Error: " + ex.Message);
                    }
                }
            }
        }
        private string GetSelectedRadioButtonText(params RadioButton[] radioButtons)
        {
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return string.Empty;
        }
        private void PopulateDataGridView()
        {
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string selectQuery = "SELECT * FROM Compliance";

                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PrintCompliance().Show();
        }
        private bool isHighlighted = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isHighlighted)
            {
                this.Opacity = 1.0;
            }
            else
            {
                this.Opacity = 0.7;
            }

            isHighlighted = !isHighlighted;

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Inspection_Report.Properties.Resources.Windows_Error);
            player.Play();
        }
        private void Compliance_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPage? mainPage = Application.OpenForms.OfType<MainPage>().FirstOrDefault();
            if (mainPage != null)
            {
                mainPage.Enabled = true;
            }
        }
    }
}
