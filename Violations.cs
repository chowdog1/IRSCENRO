using Microsoft.VisualBasic;
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
    public partial class Violations : Form
    {
        private DateTime? dopdate;
        private DateTime? apprehension;
        public Violations()
        {
            InitializeComponent();

            dopdate = null;
            apprehension = null;

            dopdatetimePicker.Format = DateTimePickerFormat.Custom;
            dopdatetimePicker.CustomFormat = " ";

            apprehensiondatetimePicker.Format = DateTimePickerFormat.Custom;
            apprehensiondatetimePicker.CustomFormat = " ";

            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Violations (AccountNo, BusinessName, Address, Barangay, BusinessStatus, ApprehensionDate, Violation, InspectorEEandEO, OVR) " +
                                     "SELECT i.AccountNo, i.BusinessName, i.Address, i.Barangay, i.BusinessStatus, i.Date, i.Violations, i.Inspector, i.OVR " +
                                     "FROM InspectionReport i " +
                                     "WHERE i.EstablishmentHas IN ('Violated City Ordinances') " +
                                     "AND NOT EXISTS (SELECT 1 FROM Violations v WHERE v.AccountNo = i.AccountNo)";

                string deleteQuery = "DELETE FROM Violations " +
                                     "WHERE AccountNo NOT IN (SELECT AccountNo FROM InspectionReport WHERE EstablishmentHas = 'Violated City Ordinances')";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    int insertRowsAffected = insertCommand.ExecuteNonQuery();

                    int deleteRowsAffected = deleteCommand.ExecuteNonQuery();
                    PopulateDataGridView();
                }
            }
        }
        private void PopulateDataGridView()
        {
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string selectQuery = "SELECT * FROM Violations";

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
        private void dopdatetimePicker_ValueChanged(object sender, EventArgs e)
        {
            dopdatetimePicker.CustomFormat = "dd-MM-yyyy";
            dopdate = dopdatetimePicker.Value;
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string update = "UPDATE Violations SET " +
                                "ApprehensionDate = CASE " +
                                "WHEN LEN(ISNULL(@ApprehensionDate, '')) > 0 " +
                                "THEN COALESCE(ApprehensionDate + ', ', '') + @ApprehensionDate " +
                                "ELSE ApprehensionDate " +
                                "END, " +
                                "InspectorEEandEO = CASE " +
                                "WHEN LEN(ISNULL(@InspectorEEandEO, '')) > 0 AND LEN(ISNULL(InspectorEEandEO, '')) > 0 " +
                                "THEN COALESCE(InspectorEEandEO + ', ', '') + @InspectorEEandEO " +
                                "WHEN LEN(ISNULL(@InspectorEEandEO, '')) > 0 " +
                                "THEN @InspectorEEandEO " +
                                "ELSE InspectorEEandEO " +
                                "END, " +
                                "Violation = CASE " +
                                "WHEN LEN(ISNULL(@Violation, '')) > 0 AND LEN(ISNULL(Violation, '')) > 0 " +
                                "THEN COALESCE(Violation + ', ', '') + @Violation " +
                                "WHEN LEN(ISNULL(@Violation, '')) > 0 " +
                                "THEN @Violation " +
                                "ELSE Violation " +
                                "END, " +
                                "OVR = CASE " +
                                "WHEN LEN(ISNULL(@OVR, '')) > 0 AND LEN(ISNULL(OVR, '')) > 0 " +
                                "THEN COALESCE(OVR + ', ', '') + @OVR " +
                                "WHEN LEN(ISNULL(@OVR, '')) > 0 " +
                                "THEN @OVR " +
                                "ELSE OVR " +
                                "END, " +
                                "Paid = CASE " +
                                "WHEN LEN(ISNULL(@Paid, '')) > 0 THEN @Paid " +
                                "ELSE Paid " +
                                "END, " +
                                "ReceiptNo = CASE " +
                                "WHEN LEN(ISNULL(@ReceiptNo, '')) > 0 AND LEN(ISNULL(ReceiptNo, '')) > 0 " +
                                "THEN COALESCE(ReceiptNo + ', ', '') + @ReceiptNo " +
                                "WHEN LEN(ISNULL(@ReceiptNo, '')) > 0 " +
                                "THEN @ReceiptNo " +
                                "ELSE ReceiptNo " +
                                "END, " +
                                "DatePaid = CASE " +
                                "WHEN LEN(ISNULL(@DatePaid, '')) > 0 " +
                                "THEN COALESCE(DatePaid + ', ', '') + @DatePaid " +
                                "ELSE DatePaid " +
                                "END " +
                                "WHERE AccountNo = @AccountNo";

                using (SqlCommand cmd = new SqlCommand(update, con))
                {
                    cmd.Parameters.AddWithValue("@AccountNo", acctnotextBox.Text);
                    cmd.Parameters.AddWithValue("@ApprehensionDate", apprehensiondatetimePicker.Value.ToString("dd-MM-yyyy"));
                    cmd.Parameters.AddWithValue("@InspectorEEandEO", string.Join(", ", eoeechklistBox.CheckedItems.Cast<string>()));
                    cmd.Parameters.AddWithValue("@Violation", string.Join(", ", violationschklistBox.CheckedItems.Cast<string>()));
                    cmd.Parameters.AddWithValue("@OVR", ovrtextBox.Text);
                    cmd.Parameters.AddWithValue("@Paid", GetSelectedRadioButtonText(paidyesradioBtn, paidnoradioBtn));
                    cmd.Parameters.AddWithValue("@ReceiptNo", ornotextBox.Text);
                    cmd.Parameters.AddWithValue("@DatePaid", dopdatetimePicker.Value.ToString("dd-MM-yyyy"));

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
                        Console.WriteLine("SQL Error: " + ex.Message);
                        MessageBox.Show("An error occurred while updating the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paymentbreakdownBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
