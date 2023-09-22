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
    public partial class PaymentBreakdown : Form
    {
        private string accountNo;
        private List<ViolationClass> violationsList;
        public PaymentBreakdown(string accountNo, List<ViolationClass> violationsList)
        {
            InitializeComponent();

            this.accountNo = accountNo;
            this.violationsList = violationsList;
            PopulateLabels();
        }
        private void PopulateLabels()
        {
            // Assuming you have labels named lblAccountNo, lblBusinessName, lblApprehensionDate, lblViolation, lblInspector, and lblOVR

            if (violationsList.Count > 0)
            {
                // Display the first item in the list (you can loop through the list to display all items)
                var violation = violationsList[0];

                lblAccountNo.Text = "Account Number: " + violation.AccountNo;
                lblBusinessName.Text = "Business Name: " + violation.BusinessName;
                lblApprehension.Text = "Apprehension Date: " + violation.ApprehensionDate?.ToString("yyyy-MM-dd");
                if (!string.IsNullOrEmpty(violation.ViolationCommitted))
                {
                    // Split the violations by commas and add each one as a new line
                    string[] violations = violation.ViolationCommitted.Split(',');

                    foreach (string singleViolation in violations)
                    {
                        lblViolations.Text += "\n" + singleViolation.Trim(); // Trim to remove leading/trailing spaces
                    }
                }
                lblInspectors.Text = "Inspector: " + violation.Inspector;
                lblOVR.Text = "OVR: " + violation.OVR;
            }
            else
            {
                // Handle the case where the list is empty or no data is available
                lblAccountNo.Text = "Account Number: ";
                lblBusinessName.Text = "Business Name: ";
                lblApprehension.Text = "Apprehension Date: ";
                lblViolations.Text = "Violation: ";
                lblInspectors.Text = "Inspector: ";
                lblOVR.Text = "OVR: ";
            }
        }
    }
}
