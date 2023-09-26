using PdfSharp.Drawing.Layout;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
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
using System.Diagnostics;
using MigraDoc.DocumentObjectModel;

namespace Inspection_Report
{
    public partial class GeneratePDF : Form
    {
        public GeneratePDF()
        {
            InitializeComponent();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";

            string sqlQuery = "Select * from InspectionReport Where AccountNo = @AccountNo";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AccountNo", accttxtBox.Text);

                        using (SqlDataReader reader = command.ExecuteReader()) 
                        {
                            if (reader.Read())
                            {
                                PdfDocument document = new PdfDocument();
                                PdfPage page = document.AddPage();
                                XGraphics gfx = XGraphics.FromPdfPage(page);
                                XFont regularFont = new XFont("Courier New", 8);
                                XFont labelFont = new XFont("Courier New", 8, XFontStyle.Bold);
                                XFont titleFont = new XFont("Courier New", 14, XFontStyle.Bold);
                                XTextFormatter tf = new XTextFormatter(gfx);

                                XUnit leftMargin = XUnit.FromInch(0.5);
                                XUnit rightMargin = XUnit.FromInch(0.5);
                                XUnit topMargin = XUnit.FromInch(0.5);
                                XUnit bottomMargin = XUnit.FromInch(0.5);

                                XUnit xPositioncomply = XUnit.FromInch(0.20); // Change this to the desired X position
                                XUnit yPositioncomply = XUnit.FromInch(3.80);

                                XRect rect = new XRect(xPositioncomply, yPositioncomply, page.Width - leftMargin - rightMargin, page.Height - topMargin - bottomMargin);

                                page.Width = XUnit.FromMillimeter(210);
                                page.Height = XUnit.FromMillimeter(297);

                                string AccountNo = (reader["AccountNo"] as string) ?? string.Empty;
                                string BusinessName = (reader["BusinessName"] as string) ?? string.Empty;
                                string Address = (reader["Address"] as string) ?? string.Empty;
                                string Barangay = (reader["Barangay"] as string) ?? string.Empty;
                                DateTime Date = (DateTime)reader["Date"];
                                string formattedDate = Date.ToString("yyyy-MM-dd");
                                string NatureOfBusiness = (reader["NatureOfBusiness"] as string) ?? string.Empty;
                                string EstablishmentHas = (reader["EstablishmentHas"] as string) ?? string.Empty;
                                string BusinessStatus = (reader["BusinessStatus"] as string) ?? string.Empty;
                                string EstablishmentIs = (reader["EstablishmentIs"] as string) ?? string.Empty;
                                string Violations = (reader["Violations"] as string) ?? string.Empty;
                                string ComplyWithin = (reader["ComplyWithin"] as string) ?? string.Empty;
                                string SecuretheFF = (reader["SecuretheFF"] as string) ?? string.Empty;
                                string AttendSeminar = (reader["AttendSeminar"] as string) ?? string.Empty;
                                string MayorsPermit = (reader["MayorsPermit"] as string) ?? string.Empty;
                                string EPPFee = (reader["EPPFee"] as string) ?? string.Empty;
                                string ECCCNC = (reader["ECCCNC"] as string) ?? string.Empty;
                                string ECCCNCNo = (reader["ECCCNCNo"] as string) ?? string.Empty;
                                //DateTime ECCDateIssued = (DateTime)reader["ECCDateIssued"];
                                //string formattedECCDateIssued = ECCDateIssued.ToString("yyyy-MM-dd");
                                string WDP = (reader["WDP"] as string) ?? string.Empty;
                                string WDPNo = (reader["WDPNo"] as string) ?? string.Empty;
                                //DateTime WDPDateIssued = (DateTime)reader["WDPDateIssued"];
                                //string formattedWDPDateIssued = WDPDateIssued.ToString("yyyy-MM-dd");
                                string PTO = (reader["PTO"] as string) ?? string.Empty;
                                string PTONo = (reader["PTONo"] as string) ?? string.Empty;
                                //DateTime PTODateIssued = (DateTime)reader["PTODateIssued"];
                                //string formattedPTODateIssued = PTODateIssued.ToString("yyyy-MM-dd");
                                string HWID = (reader["HWID"] as string) ?? string.Empty;
                                string HWIDNo = (reader["HWIDNo"] as string) ?? string.Empty;
                                //DateTime HWIDDateIssued = (DateTime)reader["HWIDDateIssued"];
                                //string formattedHWIDDateIssued = HWIDDateIssued.ToString("yyyy-MM-dd");
                                string HasPollutionOfficer = (reader["HasPollutionOfficer"] as string) ?? string.Empty;
                                string PollutionOfficer = (reader["PollutionOfficer"] as string) ?? string.Empty;
                                string Accreditation = (reader["Accreditation"] as string) ?? string.Empty;
                                //DateTime ValidityOfPOC = (DateTime)reader["ValidityOfPOC"];
                                //string formattedValidityOfPOC = ValidityOfPOC.ToString("yyyy-MM-dd");
                                string ContactNo = (reader["ContactNo"] as string) ?? string.Empty;
                                string Email = (reader["Email"] as string) ?? string.Empty;
                                string HasWasteBin = (reader["HasWasteBin"] as string) ?? string.Empty;
                                string BinsLabeled = (reader["BinsLabeled"] as string) ?? string.Empty;
                                string BinsCovered = (reader["BinsCovered"] as string) ?? string.Empty;
                                string BinsSegregated = (reader["BinsSegregated"] as string) ?? string.Empty;
                                string MRF = (reader["MRF"] as string) ?? string.Empty;
                                string WasteCollected = (reader["WasteCollected"] as string) ?? string.Empty;
                                string FrequencyHauling = (reader["FrequencyHauling"] as string) ?? string.Empty;
                                string Hauler = (reader["Hauler"] as string) ?? string.Empty;
                                string HasSeptic = (reader["HasSeptic"] as string) ?? string.Empty;
                                string LocationSeptic = (reader["LocationSeptic"] as string) ?? string.Empty;
                                string FrequencyDesludge = (reader["FrequencyDesludge"] as string) ?? string.Empty;
                                //DateTime DateDesludge = (DateTime)reader["DateDesludge"];
                                //string formmatedDateDesludge = DateDesludge.ToString("yyyy-MM-dd");
                                string ServiceProvider = (reader["ServiceProvider"] as string) ?? string.Empty;
                                string HasGreaseTrap = (reader["HasGreaseTrap"] as string) ?? string.Empty;
                                string LocationGrease = (reader["LocationGrease"] as string) ?? string.Empty;
                                string CapacityGreaseTrap = (reader["CapacityGreaseTrap"] as string) ?? string.Empty;
                                string FrequencyGrease = (reader["FrequencyGrease"] as string) ?? string.Empty;
                                string HaulerGrease = (reader["HaulerGrease"] as string) ?? string.Empty;
                                string HasWasteWater = (reader["HasWasteWater"] as string) ?? string.Empty;
                                string UsedOilProperlyDisposed = (reader["UsedOilProperlyDisposed"] as string) ?? string.Empty;
                                string TypeofOil = (reader["TypeofOil"] as string) ?? string.Empty;
                                string FrequencyofHaulingOil = (reader["FrequencyofHaulingOil"] as string) ?? string.Empty;
                                string HaulerOil = (reader["HaulerOil"] as string) ?? string.Empty;
                                string HasAirPollutionManager = (reader["HasAirPollutionManager"] as string) ?? string.Empty;
                                string DeviceType = (reader["DeviceType"] as string) ?? string.Empty;
                                string MaintenanceProvider = (reader["MaintenanceProvider"] as string) ?? string.Empty;
                                string PurposeOfInspection = (reader["PurposeOfInspection"] as string) ?? string.Empty;
                                //DateTime ReinspectDate = (DateTime)reader["ReinspectDate"];
                                //string formattedReinspectDate = ReinspectDate.ToString("yyyy-MM-dd");
                                string LevelofInspection = (reader["LevelofInspection"] as string) ?? string.Empty;
                                string LandUse = (reader["LandUse"] as string) ?? string.Empty;
                                string OwnershipTerms = (reader["OwnershipTerms"] as string) ?? string.Empty;
                                string Lessee = (reader["Lessee"] as string) ?? string.Empty;
                                string StandAlone = (reader["StandAlone"] as string) ?? string.Empty;
                                string EstablishmentStatus = (reader["EstablishmentStatus"] as string) ?? string.Empty;
                                string InspectorObservation = (reader["InspectorObservation"] as string) ?? string.Empty;
                                string Directives = (reader["Directives"] as string) ?? string.Empty;
                                string Recommendations = (reader["Recommendations"] as string) ?? string.Empty;
                                string Inspector = (reader["Inspector"] as string) ?? string.Empty;

                                string complytext = "The establishment must comply the following recommendations which covers the rules of doing business in the City of San Juan within ";
                                string[] comply = complytext.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                                gfx.DrawString("***NOTICE OF INSPECTION***", titleFont, XBrushes.Black, new XRect(190, 10, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString("Account No:", labelFont, XBrushes.Black, new XRect(10, 30, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString(AccountNo, regularFont, XBrushes.Black, new XRect(70, 30, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString("Business Name:", labelFont, XBrushes.Black, new XRect(10, 45, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString(BusinessName, regularFont, XBrushes.Black, new XRect(80, 45, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString("Address:", labelFont, XBrushes.Black, new XRect(10, 60, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString(Address, regularFont, XBrushes.Black, new XRect(55, 60, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString("Barangay:", labelFont, XBrushes.Black, new XRect(10, 75, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString(Barangay, regularFont, XBrushes.Black, new XRect(60, 75, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString("Date of Inspection:", labelFont, XBrushes.Black, new XRect(10, 90, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString(formattedDate, regularFont, XBrushes.Black, new XRect(110, 90, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString("Establishment Has:", labelFont, XBrushes.Black, new XRect(10, 120, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString(EstablishmentHas, regularFont, XBrushes.Black, new XRect(110, 120, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString("VIOLATED CITY ORDINANCES:", labelFont, XBrushes.Black, new XRect(10, 135, 1000, 1000), XStringFormats.TopLeft);
                                string[] violationLines = Violations.Split('\n');
                                float yCoordinates = 150;
                                foreach (var line in violationLines)
                                {
                                    string[] segments = line.Trim().Split(", ");
                                    if (segments.Length > 1)
                                    {
                                        for (int i = 0; i < segments.Length - 1; i++)
                                        {
                                            tf.DrawString(segments[i], regularFont, XBrushes.Black, new XRect(10, yCoordinates, 1000, 1000), XStringFormats.TopLeft);
                                            yCoordinates += regularFont.Height;
                                        }
                                        tf.DrawString(segments[segments.Length - 1].Trim(), regularFont, XBrushes.Black, new XRect(10, yCoordinates, 1000, 1000), XStringFormats.TopLeft);
                                    }
                                    else
                                    {
                                        tf.DrawString(line.Trim(), regularFont, XBrushes.Black, new XRect(10, yCoordinates, 1000, 1000), XStringFormats.TopLeft);
                                    }

                                    yCoordinates += regularFont.Height;
                                }
                                foreach (string paragraph in comply)
                                {
                                    tf.DrawString(paragraph, regularFont, XBrushes.Black, rect, XStringFormats.TopLeft);
                                    rect = new XRect(leftMargin, rect.Top + labelFont.Height, page.Width - leftMargin - rightMargin, page.Height - topMargin - bottomMargin);
                                }
                                gfx.DrawString(ComplyWithin, labelFont, XBrushes.Black, new XRect(145, 283, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString("from the actual date of inspection.", regularFont, XBrushes.Black, new XRect(200, 283, 1000, 1000), XStringFormats.TopLeft);
                                gfx.DrawString("SECURE THE FOLLOWING:", labelFont, XBrushes.Black, new XRect(10, 298, 1000, 1000), XStringFormats.TopLeft);
                                string[] securethefflines = SecuretheFF.Split('\n');
                                float secureyCoordinates = 313;
                                foreach (var line in securethefflines)
                                {
                                    string[] segments = line.Trim().Split(", ");
                                    if (segments.Length > 1)
                                    {
                                        for (int i = 0; i < segments.Length - 1; i++)
                                        {
                                            tf.DrawString(segments[i], regularFont, XBrushes.Black, new XRect(10, secureyCoordinates, 1000, 1000), XStringFormats.TopLeft);
                                            secureyCoordinates += regularFont.Height;
                                        }
                                        tf.DrawString(segments[segments.Length - 1].Trim(), regularFont, XBrushes.Black, new XRect(10, secureyCoordinates, 1000, 1000), XStringFormats.TopLeft);
                                    }
                                    else
                                    {
                                        tf.DrawString(line.Trim(), regularFont, XBrushes.Black, new XRect(10, secureyCoordinates, 1000, 1000), XStringFormats.TopLeft);
                                    }

                                    yCoordinates += regularFont.Height;
                                }

                                using (MemoryStream stream = new MemoryStream())
                                {
                                    document.Save(stream);

                                    // Specify the full path to the Google Chrome executable
                                    string chromePath = @"C:\Program Files (x86)\AVAST Software\Browser\Application\AvastBrowser.exe"; // Update with the correct path

                                    // Create a temporary PDF file to open in Chrome
                                    string tempPdfPath = Path.Combine(Path.GetTempPath(), "temp.pdf");

                                    // Check if the temporary PDF file exists
                                    if (File.Exists(tempPdfPath))
                                    {
                                        // Delete the temporary PDF file
                                        File.Delete(tempPdfPath);
                                    }

                                    // Create the temporary PDF file
                                    File.WriteAllBytes(tempPdfPath, stream.ToArray());

                                    // Open the temporary PDF file with Google Chrome
                                    Process.Start(new ProcessStartInfo
                                    {
                                        FileName = chromePath,
                                        Arguments = $"\"{tempPdfPath}\"",
                                        UseShellExecute = true,
                                    });
                                }
                            }    
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
