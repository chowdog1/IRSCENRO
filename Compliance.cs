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

                string query = "SELECT * FROM Compliance";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Compliance (AccountNo, BusinessName, Address, Barangay, BusinessStatus, Compliances) " +
                                     "SELECT i.AccountNo, i.BusinessName, i.Address, i.Barangay, i.BusinessStatus, i.SecuretheFF " +
                                     "FROM InspectionReport i " +
                                     "WHERE i.EstablishmentHas = 'Violated City Ordinances' " +
                                     "AND NOT EXISTS (SELECT 1 FROM Compliance c WHERE c.AccountNo = i.AccountNo)";

                string deleteQuery = "DELETE FROM Compliance " +
                                     "WHERE AccountNo NOT IN (SELECT AccountNo FROM InspectionReport WHERE EstablishmentHas = 'Violated City Ordinances')";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    int insertRowsAffected = insertCommand.ExecuteNonQuery();

                    int deleteRowsAffected = deleteCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
