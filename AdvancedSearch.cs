using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Inspection_Report
{
    public partial class AdvancedSearch : Form
    {
        private bool datePickersChanged = false;
        private DateTime? fddate;
        private DateTime? tddate;
        public string SearchQuery { get; private set; }
        public AdvancedSearch()
        {
            InitializeComponent();
            SearchQuery = "";

            fddate = null;
            tddate = null;

            fddateTimePicker.Format = DateTimePickerFormat.Custom;
            fddateTimePicker.CustomFormat = " ";

            tddateTimePicker.Format = DateTimePickerFormat.Custom;
            tddateTimePicker.CustomFormat = " ";
        }

        private void advsearchBtn_Click(object sender, EventArgs e)
        {
            string barangay = brgyadvcmbBox.Text;
            string businessstatus = advstatusbusscmbBox.Text;
            string establishmentstatus = establishmenthasadvcmbBox.Text;
            string establishmentis = establishmentisadvcmbBox.Text;
            string violations = advviolatedcmbBox.Text;
            DateTime startdate = fddateTimePicker.Value;
            DateTime enddate = tddateTimePicker.Value;

            if (datePickersChanged)
            {
                SearchQuery = "SELECT * FROM InspectionReport WHERE " +
                    $"(Barangay LIKE '%{barangay}%') " +
                    $"AND (BusinessStatus LIKE '%{businessstatus}%') " +
                    $"AND (EstablishmentHas LIKE '%{establishmentstatus}%') " +
                    $"AND (EstablishmentIs LIKE '%{establishmentis}%') " +
                    $"AND (Violations LIKE '%{violations}%')" +
                    $"AND (Date >= '{startdate:yyyy-MM-dd}' AND Date <= '{enddate:yyyy-MM-dd}')";
            }
            else
            {
                SearchQuery = "SELECT * FROM InspectionReport WHERE " +
                    $"(Barangay LIKE '{barangay}') " +
                    $"AND (BusinessStatus LIKE '%{businessstatus}%') " +
                    $"AND (EstablishmentHas LIKE '%{establishmentstatus}%') " +
                    $"AND (EstablishmentIs LIKE '%{establishmentis}%') " +
                    $"AND (Violations LIKE '%{violations}%')";
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fddateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            datePickersChanged = true;
            fddateTimePicker.CustomFormat = "dd-MM-yyyy";
            fddate = fddateTimePicker.Value;
        }

        private void tddateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            datePickersChanged = true;
            tddateTimePicker.CustomFormat = "dd-MM-yyyy";
            tddate = tddateTimePicker.Value;
        }

        private void advclearBtn_Click(object sender, EventArgs e)
        {
            brgyadvcmbBox.SelectedIndex = -1;
            advstatusbusscmbBox.SelectedIndex = -1;
            advviolatedcmbBox.SelectedIndex = -1;
            establishmentisadvcmbBox.SelectedIndex = -1;
            establishmenthasadvcmbBox.SelectedIndex = -1;
            fddate = null;
            tddate = null;

            fddateTimePicker.Format = DateTimePickerFormat.Custom;
            fddateTimePicker.CustomFormat = " ";

            tddateTimePicker.Format = DateTimePickerFormat.Custom;
            tddateTimePicker.CustomFormat = " ";
        }
    }
}
