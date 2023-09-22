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

                decimal total = 0;

                Dictionary<string, decimal> violationFees = new Dictionary<string, decimal>
                {
                    { "3504-2A C.O. #35-2004 SEC. 2A (NO SEGREGATION)", 1000.0m },
                    { "3099-5C C.O. #30-1999 SEC. 5C (NO LABELED MARK)", 500.0m },
                    { "9494-1 C.O. #94-1994 SEC. 1 (NO COVERED)", 500.0m },
                    { "5F-03D C.O. #91-2013 SEC. 5F-03D (NO ANTI-POLLUTION DEVICES)", 1000.0m },
                    { "911-31 C.O. #09-2011 SEC. 3-1 (ANTI-LITTERING)", 1500.0m },
                    { "2111-142 C.O. #21-2011 SEC. 14-2 (FAILURE TO DESLUDGE SEPTIC TANK)", 2000.0m },
                    { "5F-03E C.O. #91-2013 SEC. 5F-03E (NO DENR-EMB PERMITS)", 3500.0m },
                    { "5F-03B C.O. #91-2013 SEC. 5F-03B (NO PCO)", 2000.0m },
                    { "1511-1B C.O. #15-2011 SEC. 1B (PROPER DISPOSAL OF USED COOKING OIL)", 2000.0m },
                    { "5F-03A C.O. #91-2013 SEC. 5F-03A (FAILURE TO PAY EPP FEE)", 1000.0m },
                    { "5F-03C C.O. #91-2013 SEC. 5F-03C (Refusal of ENTRY)", 3000.0m },
                    { "517-A C.O. #05-2017 SEC. A (SMOKING IN PUBLIC PLACES)", 500.0m },
                    { "517-B C.O. #05-2017 SEC. B (PERSON INCHARGE)", 1000.0m },
                    { "517-H C.O. #05-2017 SEC. H (SELLING TOBACCO W/O PERMIT)", 1000.0m },
                    { "517-P C.O. #05-2017 SEC. P (DISPLAY & PLACE TOBACCO PRODUCT)", 1000.0m }
                };


                lblViolations.Text = "Violations:\n";
                if (!string.IsNullOrEmpty(violation.ViolationCommitted))
                {
                    // Split the violations by commas and add each one as a new line
                    string[] violations = violation.ViolationCommitted.Split(',');

                    // Determine the maximum width needed for the fees
                    int maxViolationWidth = 5;

                    foreach (string singleViolation in violations)
                    {
                        string trimmedViolation = singleViolation.Trim();
                        decimal fee = violationFees.GetValueOrDefault(trimmedViolation, 0);
                        total += fee;

                        // Calculate the width of the violation as a string
                        int violationWidth = trimmedViolation.Length;
                        if (violationWidth > maxViolationWidth)
                        {
                            maxViolationWidth = violationWidth;
                        }
                    }

                    foreach (string singleViolation in violations)
                    {
                        string trimmedViolation = singleViolation.Trim();
                        decimal fee = violationFees.GetValueOrDefault(trimmedViolation, 0);

                        // Create a formatted string with the violation and fee columns aligned
                        string violationLine = String.Format("{0,-" + maxViolationWidth + "} {1,20:C2}", trimmedViolation, fee);

                        lblViolations.Text += violationLine + "\n";
                    }

                    // Set the font to a monospaced font for proper alignment
                    lblViolations.Font = new Font("Courier New", 10); // You can adjust the font size if needed
                }

                lblInspectors.Text = "Inspectors: ";
                if (!string.IsNullOrEmpty(violation.Inspector))
                {
                    // Split the inspectors by commas and add each one as a new line
                    string[] inspectors = violation.Inspector.Split(',');

                    for (int i = 0; i < inspectors.Length; i++)
                    {
                        string singleInspector = inspectors[i].Trim();
                        if (i == 0)
                        {
                            lblInspectors.Text += " " + singleInspector; // Display the first inspector without a newline
                        }
                        else
                        {
                            lblInspectors.Text += "\n             " + singleInspector; // Add spaces for alignment
                        }
                    }
                }
                lblOVR.Text = "OVR: " + violation.OVR;
                lblTotal.Text = "Total Fees: " + total.ToString("C2");
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
