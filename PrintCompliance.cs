using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Inspection_Report
{
    public partial class PrintCompliance : Form
    {
        public PrintCompliance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accountNumber = accttxtBox.Text;
            string query = "SELECT AccountNo, BusinessName, Compliances FROM Compliance WHERE AccountNo = @AccountNo";

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True"))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@AccountNo", accountNumber);
                    con.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string accountNo = reader["AccountNo"].ToString() ?? "DefaultValue";
                            string businessName = reader["BusinessName"].ToString() ?? "DefaultValue";
                            string compliances = reader["Compliances"].ToString() ?? "DefaultValue";

                            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                            saveFileDialog1.Filter = "PDF Files|*.pdf";
                            saveFileDialog1.Title = "Save PDF File";
                            saveFileDialog1.FileName = "Receipt.pdf";

                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                PdfDocument document = new PdfDocument();
                                PdfPage page = document.AddPage();
                                XGraphics gfx = XGraphics.FromPdfPage(page);
                                XFont font = new XFont("Arial", 8);

                                double currentX = 20;
                                double currentY = 20;
                                double pageWidth = page.Width - 2 * currentX; // Adjust for page margins

                                string[] lines = new string[]
                                {
                                    "Receipt",
                                    "Account No: " + accountNo,
                                    "Business Name: " + businessName,
                                    "Compliances: ",
                                    "  Environmental Compliance Certificate",
                                    "  Certificate of Non-Coverage",
                                    "  Wastewater Discharge Permit",
                                    "  Hazardous Waste Generator ID",
                                    "  Pollution Control Officer",
                                    "  Permit to Operate for Air Pollution Source Installation or Equipment",
                                    "  Transport, Storage and Disposal Certificate",
                                    "  Installation of Septic Tank/Desludging Certificate Issued by a DENR-EMB Accredited Hauler",
                                    "  Installation of Grease Trap",
                                    "  Proper Waste Segregation in Accordance With The Markings"
                                };

                                bool hasEnvironmentalCompliance = Regex.IsMatch(compliances, @"\bEnvironmental Compliance Certificate\b");
                                bool hasCNC = Regex.IsMatch(compliances, @"\bCertificate of Non-Coverage\b");
                                bool hasWWD = Regex.IsMatch(compliances, @"\bWastewater Discharge Permit\b");
                                bool hasGENID = Regex.IsMatch(compliances, @"\bHazardous Waste Generator ID\b");
                                bool hasPCO = Regex.IsMatch(compliances, @"\bPollution Control Officer\b");
                                bool hasPTO = Regex.IsMatch(compliances, @"\bPermit to Operate for Air Pollution Source Installation or Equipment\b");
                                bool hasTSD = Regex.IsMatch(compliances, @"\bTransport, Storage and Disposal Certificate\b");
                                bool hasSeptic = Regex.IsMatch(compliances, @"\bInstallation of Septic Tank/Desludging Certificate Issued by a DENR-EMB Accredited Hauler\b");
                                bool hasGrease = Regex.IsMatch(compliances, @"\bInstallation of Grease Trap\b");
                                bool hasSeg = Regex.IsMatch(compliances, @"\bProper Waste Segregation in Accordance With The Markings\b");

                                foreach (string line in lines)
                                {
                                    string displayLine = line;
                                    if (line.Contains("Environmental Compliance Certificate") && hasEnvironmentalCompliance)
                                    {
                                        displayLine = "***" + line;
                                    }
                                    else if (line.Contains("Certificate of Non-Coverage") && hasCNC)
                                    {
                                        displayLine = "***" + line;
                                    }
                                    else if (line.Contains("Wastewater Discharge Permit") && hasWWD)
                                    {
                                        displayLine = "***" + line;
                                    }
                                    else if (line.Contains("Hazardous Waste Generator ID") && hasGENID)
                                    {
                                        displayLine = "***" + line;
                                    }
                                    else if (line.Contains("Pollution Control Officer") && hasPCO)
                                    {
                                        displayLine = "***" + line;
                                    }
                                    else if (line.Contains("Permit to Operate for Air Pollution Source Installation or Equipment") && hasPTO)
                                    {
                                        displayLine = "***" + line;
                                    }
                                    else if (line.Contains("Transport, Storage and Disposal Certificate") && hasTSD)
                                    {
                                        displayLine = "***" + line;
                                    }
                                    else if (line.Contains("Installation of Septic Tank/Desludging Certificate Issued by a DENR-EMB Accredited Hauler") && hasSeptic)
                                    {
                                        displayLine = "***" + line;
                                    }
                                    else if (line.Contains("Installation of Grease Trap") && hasGrease)
                                    {
                                        displayLine = "***" + line;
                                    }
                                    else if (line.Contains("Proper Waste Segregation in Accordance With The Markings") && hasSeg)
                                    {
                                        displayLine = "***" + line;
                                    }

                                    // Calculate text size
                                    XSize textSize = gfx.MeasureString(displayLine, font);

                                    if (currentY + textSize.Height > page.Height - currentY)
                                    {
                                        // If the text exceeds the page height, start a new page
                                        page = document.AddPage();
                                        gfx = XGraphics.FromPdfPage(page);
                                        currentX = 20;
                                        currentY = 20;
                                    }

                                    gfx.DrawString(displayLine, font, XBrushes.Black, new XRect(currentX, currentY, pageWidth, page.Height - currentY), XStringFormats.TopLeft);
                                    currentY += textSize.Height + 5;
                                }

                                document.Save(saveFileDialog1.FileName);

                                MessageBox.Show("PDF saved successfully.");                            }
                        }
                        else
                        {
                            MessageBox.Show("Account not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
