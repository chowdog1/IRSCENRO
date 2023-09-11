using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using OfficeOpenXml;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System.Windows.Forms;
using System.IO;
using PdfSharp;

namespace Inspection_Report
{
    public partial class MainPage : Form
    {
        private DateTime? doidate;
        private DateTime? ecccncdate;
        private DateTime? ptodate;
        private DateTime? validitypcodate;
        private DateTime? septicdate;
        private DateTime? wdpdate;
        private DateTime? hwiddate;
        private DateTime? reinspectdate;
        private LogForm? logform;
        private List<string> logEntries = new List<string>();
        private string logFilePath = "log.txt";
        public MainPage()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from InspectionReport", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            doidate = null;
            ecccncdate = null;
            ptodate = null;
            validitypcodate = null;
            septicdate = null;
            wdpdate = null;
            hwiddate = null;
            reinspectdate = null;

            doidateTimePicker.Format = DateTimePickerFormat.Custom;
            doidateTimePicker.CustomFormat = " ";

            ecccncdateTimePicker.Format = DateTimePickerFormat.Custom;
            ecccncdateTimePicker.CustomFormat = " ";

            ptodateTimePicker.Format = DateTimePickerFormat.Custom;
            ptodateTimePicker.CustomFormat = " ";

            validitypcodateTimePicker.Format = DateTimePickerFormat.Custom;
            validitypcodateTimePicker.CustomFormat = " ";

            septicdateTimePicker.Format = DateTimePickerFormat.Custom;
            septicdateTimePicker.CustomFormat = " ";

            wdpdateTimePicker.Format = DateTimePickerFormat.Custom;
            wdpdateTimePicker.CustomFormat = " ";

            hwiddateTimePicker.Format = DateTimePickerFormat.Custom;
            hwiddateTimePicker.CustomFormat = " ";

            reinspectdateTimePicker.Format = DateTimePickerFormat.Custom;
            reinspectdateTimePicker.CustomFormat = " ";

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LogEvent(string eventDescription)
        {
            string logEntry = $"{DateTime.Now} - {accttxtBox.Text} {AuthenticatedUser.UserName}: {eventDescription}";
            if (logform != null)
            {
                logform.AppendLog(logEntry);
            }
            logEntries.Add(logEntry);
            File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
        }
        private void ShowLogForm()
        {
            if (logform == null || logform.IsDisposed)
            {
                logform = new LogForm(logEntries, logFilePath);
            }
            logform.Show();
        }
        private void checkedListBox1_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == establishmenthaschklistBox.Items.IndexOf("Violated City Ordinances") || e.Index == establishmenthaschklistBox.Items.IndexOf("Notice/Warning"))
            {
                if (e.NewValue == CheckState.Checked)
                {
                    violationschklistBox.Enabled = true;
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    violationschklistBox.Enabled = false;
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (ecccncyesRadioBtn.Checked)
            {
                ecccnctxtBox.Enabled = true;
                ecccncdateTimePicker.Enabled = true;
            }
            else
            {
                ecccnctxtBox.Enabled = false;
                ecccncdateTimePicker.Enabled = false;
            }
        }

        private void radioButton8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (wdpyesRadioBtn.Checked)
            {
                wdptxtBox.Enabled = true;
                wdpdateTimePicker.Enabled = true;
            }
            else
            {
                wdptxtBox.Enabled = false;
                wdpdateTimePicker.Enabled = false;
            }
        }

        private void radioButton10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ptoyesRadioBtn.Checked)
            {
                ptotxtBox.Enabled = true;
                ptodateTimePicker.Enabled = true;
            }
            else
            {
                ptotxtBox.Enabled = false;
                ptodateTimePicker.Enabled = false;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (hwyesRadioBtn.Checked)
            {
                hwidtxtBox.Enabled = true;
                hwiddateTimePicker.Enabled = true;
            }
            else
            {
                hwidtxtBox.Enabled = false;
                hwiddateTimePicker.Enabled = false;
            }
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            if (wastecollectyesRadioBtn.Checked)
            {
                haulertxtBox.Enabled = true;
                frequencycmbBox.Enabled = true;
            }
            else
            {
                haulertxtBox.Enabled = false;
                frequencycmbBox.Enabled = false;
            }
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            if (pcdyesRadioBtn.Checked)
            {
                providertxtBox.Enabled = true;
                pcdtxtBox.Enabled = true;
            }
            else
            {
                providertxtBox.Enabled = false;
                pcdtxtBox.Enabled = false;
            }
        }

        private void radioButton47_CheckedChanged(object sender, EventArgs e)
        {
            if (pcoyesRadioBtn.Checked)
            {
                pollutionofficertxtBox.Enabled = true;
                accreditationtxtBox.Enabled = true;
                validitypcodateTimePicker.Enabled = true;
                contacttxtBox.Enabled = true;
                emailaddtxtBox.Enabled = true;
            }
            else
            {
                pollutionofficertxtBox.Enabled = false;
                accreditationtxtBox.Enabled = false;
                validitypcodateTimePicker.Enabled = false;
                contacttxtBox.Enabled = false;
                emailaddtxtBox.Enabled = false;
            }
        }

        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {
            if (septicyesRadioBtn.Checked)
            {
                locationSeptictxtBox.Enabled = true;
                frequencysepticcmbBox.Enabled = true;
                septicdateTimePicker.Enabled = true;
                serviceseptictxtBox.Enabled = true;
            }
            else
            {
                locationSeptictxtBox.Enabled = false;
                frequencysepticcmbBox.Enabled = false;
                septicdateTimePicker.Enabled = false;
                serviceseptictxtBox.Enabled = false;
            }
        }

        private void radioButton52_CheckedChanged(object sender, EventArgs e)
        {
            if (greaseyesRadioBtn.Checked)
            {
                locationgreasetxtBox.Enabled = true;
                capacitygreasetxtBox.Enabled = true;
                greasefrequencycmbBox.Enabled = true;
                haulergreasetxtBox.Enabled = true;
            }
            else
            {
                locationgreasetxtBox.Enabled = false;
                capacitygreasetxtBox.Enabled = false;
                greasefrequencycmbBox.Enabled = false;
                haulergreasetxtBox.Enabled = false;
            }
        }

        private void radioButton59_CheckedChanged(object sender, EventArgs e)
        {
            if (usedoilyesRadioBtn.Checked)
            {
                oiltxtBox.Enabled = true;
                oilfrequencycmbBox.Enabled = true;
                hauleroiltxtBox.Enabled = true;
            }
            else
            {
                oiltxtBox.Enabled = false;
                oilfrequencycmbBox.Enabled = false;
                hauleroiltxtBox.Enabled = false;
            }
        }
        void ClearSelectedItems(CheckedListBox listBox)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                listBox.SetItemChecked(i, false);
            }
        }
        private void ClearForm()
        {
            // Clear textboxes
            accttxtBox.Clear();
            businesstxtBox.Clear();
            addresstxtBox.Clear();
            obstxtBox.Clear();
            directivestxtBox.Clear();
            oiltxtBox.Clear();
            haulergreasetxtBox.Clear();
            capacitygreasetxtBox.Clear();
            locationgreasetxtBox.Clear();
            locationSeptictxtBox.Clear();
            serviceseptictxtBox.Clear();
            haulertxtBox.Clear();
            pollutionofficertxtBox.Clear();
            accreditationtxtBox.Clear();
            contacttxtBox.Clear();
            emailaddtxtBox.Clear();
            hwidtxtBox.Clear();
            wdptxtBox.Clear();
            ecccnctxtBox.Clear();

            // Clear combobox
            brgycmbBox.SelectedIndex = -1;
            establishmentiscmbBox.SelectedIndex = -1;
            complywithincmbBox.SelectedIndex = -1;
            purposecmbBox.SelectedIndex = -1;
            oilfrequencycmbBox.SelectedIndex = -1;
            greasefrequencycmbBox.SelectedIndex = -1;
            frequencysepticcmbBox.SelectedIndex = -1;
            frequencycmbBox.SelectedIndex = -1;


            // Clear radio buttons
            lowriskRadioBtn.Checked = false;
            highriskRadioBtn.Checked = false;
            mayoryesRadioBtn.Checked = false;
            mayornoRadioBtn.Checked = false;
            eppyesRadioBtn.Checked = false;
            eppnoRadioBtn.Checked = false;
            eppnaRadioBtn.Checked = false;
            ecccncyesRadioBtn.Checked = false;
            ecccncnoRadioBtn.Checked = false;
            ecccncnaRadioBtn.Checked = false;
            wdpyesRadioBtn.Checked = false;
            wdpnoRadioBtn.Checked = false;
            wdpnaRadioBtn.Checked = false;
            hwyesRadioBtn.Checked = false;
            hwnoRadioBtn.Checked = false;
            hwnaRadioBtn.Checked = false;
            pcoyesRadioBtn.Checked = false;
            pconoRadioBtn.Checked = false;
            pconaRadioBtn.Checked = false;
            ptoyesRadioBtn.Checked = false;
            ptonoRadioBtn.Checked = false;
            ptonaRadioBtn.Checked = false;
            wastebinyesRadioBtn.Checked = false;
            wastebinnoRadioBtn.Checked = false;
            binproperyesRadioBtn.Checked = false;
            binpropernoRadioBtn.Checked = false;
            bincoveryesRadioBtn.Checked = false;
            bincovernoRadioBtn.Checked = false;
            wastesegyesRadioBtn.Checked = false;
            wastesegnoRadioBtn.Checked = false;
            mrfyesRadioBtn.Checked = false;
            mrfnoRadioBtn.Checked = false;
            wastecollectyesRadioBtn.Checked = false;
            wastecollectnoRadioBtn.Checked = false;
            pcdyesRadioBtn.Checked = false;
            pcdnoRadioBtn.Checked = false;
            pcdnaRadioBtn.Checked = false;
            pcoyesRadioBtn.Checked = false;
            pconoRadioBtn.Checked = false;
            pconaRadioBtn.Checked = false;
            septicyesRadioBtn.Checked = false;
            septicnoRadioBtn.Checked = false;
            septicnaRadioBtn.Checked = false;
            greaseyesRadioBtn.Checked = false;
            greasenoRadioBtn.Checked = false;
            greasenaRadioBtn.Checked = false;
            wastewateryesRadioBtn.Checked = false;
            wastewaternoRadioBtn.Checked = false;
            wastewaternaRadioBtn.Checked = false;
            usedoilyesRadioBtn.Checked = false;
            usedoilnoRadioBtn.Checked = false;
            usedoilnaRadioBtn.Checked = false;
            landusecommercialRadioBtn.Checked = false;
            landuseresidentialRadioBtn.Checked = false;
            landuseindustrialRadioBtn.Checked = false;
            landuseinstitutionalRadioBtn.Checked = false;
            proprietorshipRadioBtn.Checked = false;
            privatecorpRadioBtn.Checked = false;
            multinationalRadioBtn.Checked = false;
            standaloneyesRadioBtn.Checked = false;
            standalonenoRadioBtn.Checked = false;
            lesseeyesRadioBtn.Checked = false;
            lesseenoRadioBtn.Checked = false;
            statusoperationalRadioBtn.Checked = false;
            statusnooperationRadioBtn.Checked = false;
            statusclosedRadioBtn.Checked = false;
            statuswfhRadioBtn.Checked = false;

            // Clear checkedlistboxes
            ClearSelectedItems(establishmenthaschklistBox);
            ClearSelectedItems(violationschklistBox);
            ClearSelectedItems(securetheffchklistBox);
            ClearSelectedItems(recommendationchklistBox);
            ClearSelectedItems(inspectorschklistBox);
            ClearSelectedItems(levelofinspectionchklistBox);

            // Clear date pickers
            doidate = null;
            ecccncdate = null;
            ptodate = null;
            validitypcodate = null;
            septicdate = null;
            wdpdate = null;
            hwiddate = null;
            reinspectdate = null;

            doidateTimePicker.Format = DateTimePickerFormat.Custom;
            doidateTimePicker.CustomFormat = " ";

            ecccncdateTimePicker.Format = DateTimePickerFormat.Custom;
            ecccncdateTimePicker.CustomFormat = " ";

            ptodateTimePicker.Format = DateTimePickerFormat.Custom;
            ptodateTimePicker.CustomFormat = " ";

            validitypcodateTimePicker.Format = DateTimePickerFormat.Custom;
            validitypcodateTimePicker.CustomFormat = " ";

            septicdateTimePicker.Format = DateTimePickerFormat.Custom;
            septicdateTimePicker.CustomFormat = " ";

            wdpdateTimePicker.Format = DateTimePickerFormat.Custom;
            wdpdateTimePicker.CustomFormat = " ";

            hwiddateTimePicker.Format = DateTimePickerFormat.Custom;
            hwiddateTimePicker.CustomFormat = " ";

            reinspectdateTimePicker.Format = DateTimePickerFormat.Custom;
            reinspectdateTimePicker.CustomFormat = " ";
        }
        private void PopulateDataGridView()
        {
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string selectQuery = "SELECT * FROM InspectionReport";

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
        private void doidateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            doidateTimePicker.CustomFormat = "dd-MM-yyyy";
            doidate = doidateTimePicker.Value;
        }
        private void ecccncdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ecccncdateTimePicker.CustomFormat = "dd-MM-yyyy";
            ecccncdate = ecccncdateTimePicker.Value;
        }
        private void wdpdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            wdpdateTimePicker.CustomFormat = "dd-MM-yyyy";
            wdpdate = wdpdateTimePicker.Value;
        }
        private void ptodateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ptodateTimePicker.CustomFormat = "dd-MM-yyyy";
            ptodate = ptodateTimePicker.Value;
        }
        private void hwiddateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            hwiddateTimePicker.CustomFormat = "dd-MM-yyyy";
            hwiddate = hwiddateTimePicker.Value;
        }

        private void validitypcodateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            validitypcodateTimePicker.CustomFormat = "dd-MM-yyyy";
            validitypcodate = validitypcodateTimePicker.Value;
        }

        private void septicdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            septicdateTimePicker.CustomFormat = "dd-MM-yyyy";
            septicdate = septicdateTimePicker.Value;
        }
        private void reinspectdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            reinspectdateTimePicker.CustomFormat = "dd-MM-yyyy";
            reinspectdate = reinspectdateTimePicker.Value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = AuthenticatedUser.UserName ?? "DefaultUsername";
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string insertQuery = "INSERT INTO InspectionReport (AccountNo, BusinessName, Address, Barangay, Date, " +
                                     "EstablishmentHas, BusinessStatus, EstablishmentIs, Violations, ComplyWithin, SecuretheFF, AttendSeminar, " +
                                     "MayorsPermit, EPPFee, ECCCNC, ECCCNCNo, ECCDateIssued, WDP, WDPNo, WDPDateIssued, PTO, PTONo, PTODateIssued, HWID, HWIDNo, " +
                                     "HWIDDateIssued, HasPollutionOfficer, PollutionOfficer, Accreditation, ValidityOfPOC, ContactNo, Email, " +
                                     "HasWasteBin, BinsLabeled, BinsCovered, BinsSegregated, MRF, WasteCollected, FrequencyHauling, Hauler, " +
                                     "HasSeptic, LocationSeptic, FrequencyDesludge, DateDesludge, ServiceProvider, HasGreaseTrap, LocationGrease, " +
                                     "CapacityGreaseTrap, FrequencyGrease, HaulerGrease, HasWasteWater, UsedOilProperlyDisposed, TypeofOil, " +
                                     "FrequencyofHaulingOil, HaulerOil, HasAirPollutionManager, DeviceType, MaintenanceProvider, PurposeOfInspection, " +
                                     "ReinspectDate, LevelofInspection, LandUse, OwnershipTerms, Lessee, StandAlone, EstablishmentStatus, InspectorObservation, " +
                                     "Directives, Recommendations, Inspector, Encoder) " +
                                     "VALUES (@AccountNo, @BusinessName, @Address, @Barangay, @Date, @EstablishmentHas, @BusinessStatus, " +
                                     "@EstablishmentIs, @Violations, @ComplyWithin, @SecuretheFF, @AttendSeminar, @MayorsPermit, @EPPFee, " +
                                     "@ECCCNC, @ECCCNCNo, @ECCDateIssued, @WDP, @WDPNo, @WDPDateIssued, @PTO, @PTONo, @PTODateIssued, @HWID, @HWIDNo, @HWIDDateIssued, " +
                                     "@HasPollutionOfficer, @PollutionOfficer, @Accreditation, @ValidityOfPOC, @ContactNo, @Email, @HasWasteBin, " +
                                     "@BinsLabeled, @BinsCovered, @BinsSegregated, @MRF, @WasteCollected, @FrequencyHauling, @Hauler, " +
                                     "@HasSeptic, @LocationSeptic, @FrequencyDesludge, @DateDesludge, @ServiceProvider, @HasGreaseTrap, " +
                                     "@LocationGrease, @CapacityGreaseTrap, @FrequencyGrease, @HaulerGrease, @HasWasteWater, " +
                                     "@UsedOilProperlyDisposed, @TypeofOil, @FrequencyofHaulingOil, @HaulerOil, @HasAirPollutionManager, " +
                                     "@DeviceType, @MaintenanceProvider, @PurposeOfInspection, @ReinspectDate, @LevelofInspection, @LandUse, @OwnershipTerms, " +
                                     "@Lessee, @StandAlone, @EstablishmentStatus, @InspectorObservation, @Directives, @Recommendations, @Inspector, @Encoder)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@AccountNo", accttxtBox.Text);
                    cmd.Parameters.AddWithValue("@BusinessName", businesstxtBox.Text);
                    cmd.Parameters.AddWithValue("@Address", addresstxtBox.Text);
                    cmd.Parameters.AddWithValue("@Barangay", brgycmbBox.Text);
                    if (doidate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@Date", doidateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Date", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@EstablishmentHas", string.Join(", ", establishmenthaschklistBox.CheckedItems.Cast<string>()));
                    cmd.Parameters.AddWithValue("@BusinessStatus", GetSelectedRadioButtonText(lowriskRadioBtn, highriskRadioBtn));
                    cmd.Parameters.AddWithValue("@EstablishmentIs", establishmentiscmbBox.Text);
                    cmd.Parameters.AddWithValue("@Violations", string.Join(", ", violationschklistBox.CheckedItems.Cast<string>()));
                    cmd.Parameters.AddWithValue("@ComplyWithin", complywithincmbBox.Text);
                    cmd.Parameters.AddWithValue("@SecuretheFF", string.Join(", ", securetheffchklistBox.CheckedItems.Cast<string>()));
                    cmd.Parameters.AddWithValue("@AttendSeminar", seminartxtBox.Text);
                    cmd.Parameters.AddWithValue("@MayorsPermit", GetSelectedRadioButtonText(mayoryesRadioBtn, mayornoRadioBtn));
                    cmd.Parameters.AddWithValue("@EPPFee", GetSelectedRadioButtonText(eppyesRadioBtn, eppnoRadioBtn, eppnaRadioBtn));
                    cmd.Parameters.AddWithValue("@ECCCNC", GetSelectedRadioButtonText(ecccncyesRadioBtn, ecccncnoRadioBtn, ecccncnaRadioBtn));
                    cmd.Parameters.AddWithValue("@ECCCNCNo", ecccnctxtBox.Text);
                    if (ecccncdate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@ECCDateIssued", ecccncdateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ECCDateIssued", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@WDP", GetSelectedRadioButtonText(wdpyesRadioBtn, wdpnoRadioBtn, wdpnaRadioBtn));
                    cmd.Parameters.AddWithValue("@WDPNo", wdptxtBox.Text);
                    if (wdpdate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@WDPDateIssued", wdpdateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@WDPDateIssued", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@PTO", GetSelectedRadioButtonText(ptoyesRadioBtn, ptonoRadioBtn, ptonaRadioBtn));
                    cmd.Parameters.AddWithValue("@PTONo", ptotxtBox.Text);
                    if (ptodate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@PTODateIssued", ptodateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@PTODateIssued", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@HWID", GetSelectedRadioButtonText(hwyesRadioBtn, hwnoRadioBtn, hwnaRadioBtn));
                    cmd.Parameters.AddWithValue("@HWIDNo", hwidtxtBox.Text);
                    if (hwiddate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@HWIDDateIssued", hwiddateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@HWIDDateIssued", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@HasPollutionOfficer", GetSelectedRadioButtonText(pcoyesRadioBtn, pconoRadioBtn, pconaRadioBtn));
                    cmd.Parameters.AddWithValue("@PollutionOfficer", pollutionofficertxtBox.Text);
                    cmd.Parameters.AddWithValue("@Accreditation", accreditationtxtBox.Text);
                    if (validitypcodate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@ValidityOfPOC", validitypcodateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ValidityOfPOC", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@ContactNo", contacttxtBox.Text);
                    cmd.Parameters.AddWithValue("@Email", emailaddtxtBox.Text);
                    cmd.Parameters.AddWithValue("@HasWasteBin", GetSelectedRadioButtonText(wastebinyesRadioBtn, wastebinnoRadioBtn));
                    cmd.Parameters.AddWithValue("@BinsLabeled", GetSelectedRadioButtonText(binproperyesRadioBtn, binpropernoRadioBtn));
                    cmd.Parameters.AddWithValue("@BinsCovered", GetSelectedRadioButtonText(bincoveryesRadioBtn, bincovernoRadioBtn));
                    cmd.Parameters.AddWithValue("@BinsSegregated", GetSelectedRadioButtonText(wastesegyesRadioBtn, wastesegnoRadioBtn));
                    cmd.Parameters.AddWithValue("@MRF", GetSelectedRadioButtonText(mrfyesRadioBtn, mrfnoRadioBtn));
                    cmd.Parameters.AddWithValue("@WasteCollected", GetSelectedRadioButtonText(wastecollectyesRadioBtn, wastecollectnoRadioBtn));
                    cmd.Parameters.AddWithValue("@FrequencyHauling", frequencycmbBox.Text);
                    cmd.Parameters.AddWithValue("@Hauler", haulertxtBox.Text);
                    cmd.Parameters.AddWithValue("@HasSeptic", GetSelectedRadioButtonText(septicyesRadioBtn, septicnoRadioBtn, septicnaRadioBtn));
                    cmd.Parameters.AddWithValue("@LocationSeptic", locationSeptictxtBox.Text);
                    cmd.Parameters.AddWithValue("@FrequencyDesludge", frequencysepticcmbBox.Text);
                    if (septicdate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@DateDesludge", septicdateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@DateDesludge", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@ServiceProvider", serviceseptictxtBox.Text);
                    cmd.Parameters.AddWithValue("@HasGreaseTrap", GetSelectedRadioButtonText(greaseyesRadioBtn, greasenoRadioBtn, greasenaRadioBtn));
                    cmd.Parameters.AddWithValue("@LocationGrease", locationgreasetxtBox.Text);
                    cmd.Parameters.AddWithValue("@CapacityGreaseTrap", capacitygreasetxtBox.Text);
                    cmd.Parameters.AddWithValue("@FrequencyGrease", greasefrequencycmbBox.Text);
                    cmd.Parameters.AddWithValue("@HaulerGrease", haulergreasetxtBox.Text);
                    cmd.Parameters.AddWithValue("@HasWasteWater", GetSelectedRadioButtonText(wastewateryesRadioBtn, wastewaternoRadioBtn, wastewaternaRadioBtn));
                    cmd.Parameters.AddWithValue("@UsedOilProperlyDisposed", GetSelectedRadioButtonText(usedoilyesRadioBtn, usedoilnoRadioBtn, usedoilnaRadioBtn));
                    cmd.Parameters.AddWithValue("@TypeofOil", oiltxtBox.Text);
                    cmd.Parameters.AddWithValue("@FrequencyofHaulingOil", oilfrequencycmbBox.Text);
                    cmd.Parameters.AddWithValue("@HaulerOil", hauleroiltxtBox.Text);
                    cmd.Parameters.AddWithValue("@HasAirPollutionManager", GetSelectedRadioButtonText(pcdyesRadioBtn, pcdnoRadioBtn, pcdnaRadioBtn));
                    cmd.Parameters.AddWithValue("@DeviceType", pcdtxtBox.Text);
                    cmd.Parameters.AddWithValue("@MaintenanceProvider", providertxtBox.Text);
                    cmd.Parameters.AddWithValue("@PurposeOfInspection", purposecmbBox.Text);
                    if (reinspectdate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@ReinspectDate", reinspectdateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ReinspectDate", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@LevelofInspection", string.Join(", ", levelofinspectionchklistBox.CheckedItems.Cast<string>()));
                    cmd.Parameters.AddWithValue("@LandUse", GetSelectedRadioButtonText(landusecommercialRadioBtn, landuseresidentialRadioBtn, landuseindustrialRadioBtn, landuseinstitutionalRadioBtn));
                    cmd.Parameters.AddWithValue("@OwnershipTerms", GetSelectedRadioButtonText(proprietorshipRadioBtn, privatecorpRadioBtn, multinationalRadioBtn));
                    cmd.Parameters.AddWithValue("@Lessee", GetSelectedRadioButtonText(lesseeyesRadioBtn, lesseenoRadioBtn));
                    cmd.Parameters.AddWithValue("@StandAlone", GetSelectedRadioButtonText(standaloneyesRadioBtn, standalonenoRadioBtn));
                    cmd.Parameters.AddWithValue("@EstablishmentStatus", GetSelectedRadioButtonText(statusoperationalRadioBtn, statusnooperationRadioBtn, statusclosedRadioBtn, statuswfhRadioBtn));
                    cmd.Parameters.AddWithValue("@InspectorObservation", obstxtBox.Text);
                    cmd.Parameters.AddWithValue("@Directives", directivestxtBox.Text);
                    cmd.Parameters.AddWithValue("@Recommendations", string.Join(", ", recommendationchklistBox.CheckedItems.Cast<string>()));
                    cmd.Parameters.AddWithValue("@Inspector", string.Join(", ", inspectorschklistBox.CheckedItems.Cast<string>()));
                    cmd.Parameters.AddWithValue("@Encoder", username);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved!");
                        LogEvent("Added Data");
                        ClearForm();
                        PopulateDataGridView();
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
        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string updateQuery = "UPDATE InspectionReport SET " +
                                    "BusinessName = ISNULL(BusinessName, '') + @BusinessName, " +
                                    "Address = COALESCE(@Address, Address), " +
                                    "Barangay = COALESCE(@Barangay, Barangay), " +
                                    "Date = COALESCE(@Date, Date), " +
                                    "EstablishmentHas = COALESCE(@EstablishmentHas, EstablishmentHas), " +
                                    "BusinessStatus = COALESCE(@BusinessStatus, BusinessStatus), " +
                                    "EstablishmentIs = COALESCE(@EstablishmentIs, EstablishmentIs), " +
                                    "Violations = ISNULL(Violations, '') + @Violations, " +
                                    "ComplyWithin = COALESCE(@ComplyWithin, ComplyWithin), " +
                                    "SecuretheFF = ISNULL(SecuretheFF, '') + @SecuretheFF, " +
                                    "AttendSeminar = COALESCE(@AttendSeminar, AttendSeminar), " +
                                    "MayorsPermit = COALESCE(@MayorsPermit, MayorsPermit), " +
                                    "EPPFee = COALESCE(@EPPFee, EPPFee), " +
                                    "ECCCNC = COALESCE(@ECCCNC, ECCCNC), " +
                                    "ECCCNCNo = COALESCE(@ECCCNCNo, ECCCNCNo), " +
                                    "ECCDateIssued = COALESCE(@ECCDateIssued, ECCDateIssued), " +
                                    "WDP = COALESCE(@WDP, WDP), " +
                                    "WDPNo = COALESCE(@WDPNo, WDPNo), " +
                                    "WDPDateIssued = COALESCE(@WDPDateIssued, WDPDateIssued), " +
                                    "PTO = COALESCE(@PTO, PTO), " +
                                    "PTONo = COALESCE(@PTONo, PTONo), " +
                                    "PTODateIssued = COALESCE(@PTODateIssued, PTODateIssued), " +
                                    "HWID = COALESCE(@HWID, HWID), " +
                                    "HWIDNo = COALESCE(@HWIDNo, HWIDNo), " +
                                    "HWIDDateIssued = COALESCE(@HWIDDateIssued, HWIDDateIssued), " +
                                    "HasPollutionOfficer = COALESCE(@HasPollutionOfficer, HasPollutionOfficer), " +
                                    "PollutionOfficer = COALESCE(@PollutionOfficer, PollutionOfficer), " +
                                    "Accreditation = COALESCE(@Accreditation, Accreditation), " +
                                    "ValidityOfPOC = COALESCE(@ValidityOfPOC, ValidityOfPOC), " +
                                    "ContactNo = COALESCE(@ContactNo, ContactNo), " +
                                    "Email = COALESCE(@Email, Email), " +
                                    "HasWasteBin = COALESCE(@HasWasteBin, HasWasteBin), " +
                                    "BinsLabeled = COALESCE(@BinsLabeled, BinsLabeled), " +
                                    "BinsCovered = COALESCE(@BinsCovered, BinsCovered), " +
                                    "BinsSegregated = COALESCE(@BinsSegregated, BinsSegregated), " +
                                    "MRF = COALESCE(@MRF, MRF), " +
                                    "WasteCollected = COALESCE(@WasteCollected, WasteCollected), " +
                                    "FrequencyHauling = COALESCE(@FrequencyHauling, FrequencyHauling), " +
                                    "Hauler = COALESCE(@Hauler, Hauler), " +
                                    "HasSeptic = COALESCE(@HasSeptic, HasSeptic), " +
                                    "LocationSeptic = COALESCE(@LocationSeptic, LocationSeptic), " +
                                    "FrequencyDesludge = COALESCE(@FrequencyDesludge, FrequencyDesludge), " +
                                    "DateDesludge = COALESCE(@DateDesludge, DateDesludge), " +
                                    "ServiceProvider = COALESCE(@ServiceProvider, ServiceProvider), " +
                                    "HasGreaseTrap = COALESCE(@HasGreaseTrap, HasGreaseTrap), " +
                                    "LocationGrease = COALESCE(@LocationGrease, LocationGrease), " +
                                    "CapacityGreaseTrap = COALESCE(@CapacityGreaseTrap, CapacityGreaseTrap), " +
                                    "FrequencyGrease = COALESCE(@FrequencyGrease, FrequencyGrease), " +
                                    "HaulerGrease = COALESCE(@HaulerGrease, HaulerGrease), " +
                                    "HasWasteWater = COALESCE(@HasWasteWater, HasWasteWater), " +
                                    "UsedOilProperlyDisposed = COALESCE(@UsedOilProperlyDisposed, UsedOilProperlyDisposed), " +
                                    "TypeofOil = COALESCE(@TypeofOil, TypeofOil), " +
                                    "FrequencyofHaulingOil = COALESCE(@FrequencyofHaulingOil, FrequencyofHaulingOil), " +
                                    "HaulerOil = COALESCE(@HaulerOil, HaulerOil), " +
                                    "HasAirPollutionManager = COALESCE(@HasAirPollutionManager, HasAirPollutionManager), " +
                                    "DeviceType = COALESCE(@DeviceType, DeviceType), " +
                                    "MaintenanceProvider = COALESCE(@MaintenanceProvider, MaintenanceProvider), " +
                                    "PurposeOfInspection = COALESCE(@PurposeOfInspection, PurposeOfInspection), " +
                                    "ReinspectDate = COALESCE(@ReinspectDate, ReinspectDate), " +
                                    "LevelofInspection = ISNULL(LevelofInspection, '') + @LevelofInspection, " +
                                    "LandUse = COALESCE(@LandUse, LandUse), " +
                                    "OwnershipTerms = COALESCE(@OwnershipTerms, OwnershipTerms), " +
                                    "Lessee = COALESCE(@Lessee, Lessee), " +
                                    "StandAlone = COALESCE(@StandAlone, StandAlone), " +
                                    "EstablishmentStatus = COALESCE(@EstablishmentStatus, EstablishmentStatus), " +
                                    "InspectorObservation = ISNULL(InspectorObservation, '') + @InspectorObservation, " +
                                    "Directives = ISNULL(Directives, '') + @Directives, " +
                                    "Recommendations = ISNULL(Recommendations, '') + @Recommendations, " +
                                    "Inspector = ISNULL(Inspector, '') + @Inspector " +
                                    "WHERE AccountNo = @AccountNo";

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@AccountNo", accttxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@BusinessName", businesstxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@Address", addresstxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@Barangay", brgycmbBox.Text);
                    if (doidate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@Date", doidateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Date", DBNull.Value);
                    }
                    AddParameterIfNotEmpty(cmd, "@EstablishmentHas", string.Join(", ", establishmenthaschklistBox.CheckedItems.Cast<string>()));
                    AddParameterIfNotEmpty(cmd, "@BusinessStatus", GetSelectedRadioButtonText(lowriskRadioBtn, highriskRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@EstablishmentIs", establishmentiscmbBox.Text);
                    AddParameterIfNotEmpty(cmd, "@Violations", string.Join(", ", violationschklistBox.CheckedItems.Cast<string>()));
                    AddParameterIfNotEmpty(cmd, "@ComplyWithin", complywithincmbBox.Text);
                    AddParameterIfNotEmpty(cmd, "@SecuretheFF", string.Join(", ", securetheffchklistBox.CheckedItems.Cast<string>()));
                    AddParameterIfNotEmpty(cmd, "@AttendSeminar", seminartxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@MayorsPermit", GetSelectedRadioButtonText(mayoryesRadioBtn, mayornoRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@EPPFee", GetSelectedRadioButtonText(eppyesRadioBtn, eppnoRadioBtn, eppnaRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@ECCCNC", GetSelectedRadioButtonText(ecccncyesRadioBtn, ecccncnoRadioBtn, ecccncnaRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@ECCCNCNo", ecccnctxtBox.Text);
                    if (ecccncdate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@ECCDateIssued", ecccncdateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ECCDateIssued", DBNull.Value);
                    }
                    AddParameterIfNotEmpty(cmd, "@WDP", GetSelectedRadioButtonText(wdpyesRadioBtn, wdpnoRadioBtn, wdpnaRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@WDPNo", wdptxtBox.Text);
                    if (wdpdate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@WDPDateIssued", wdpdateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@WDPDateIssued", DBNull.Value);
                    }
                    AddParameterIfNotEmpty(cmd, "@PTO", GetSelectedRadioButtonText(ptoyesRadioBtn, ptonoRadioBtn, ptonaRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@PTONo", ptotxtBox.Text);
                    if (ptodate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@PTODateIssued", ptodateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@PTODateIssued", DBNull.Value);
                    }
                    AddParameterIfNotEmpty(cmd, "@HWID", GetSelectedRadioButtonText(hwyesRadioBtn, hwnoRadioBtn, hwnaRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@HWIDNo", hwidtxtBox.Text);
                    if (hwiddate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@HWIDDateIssued", hwiddateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@HWIDDateIssued", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@HasPollutionOfficer", GetSelectedRadioButtonText(pcoyesRadioBtn, pconoRadioBtn, pconaRadioBtn));
                    cmd.Parameters.AddWithValue("@PollutionOfficer", pollutionofficertxtBox.Text);
                    cmd.Parameters.AddWithValue("@Accreditation", accreditationtxtBox.Text);
                    if (validitypcodate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@ValidityOfPOC", validitypcodateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ValidityOfPOC", DBNull.Value);
                    }
                    AddParameterIfNotEmpty(cmd, "@ContactNo", contacttxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@Email", emailaddtxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@HasWasteBin", GetSelectedRadioButtonText(wastebinyesRadioBtn, wastebinnoRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@BinsLabeled", GetSelectedRadioButtonText(binproperyesRadioBtn, binpropernoRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@BinsCovered", GetSelectedRadioButtonText(bincoveryesRadioBtn, bincovernoRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@BinsSegregated", GetSelectedRadioButtonText(wastesegyesRadioBtn, wastesegnoRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@MRF", GetSelectedRadioButtonText(mrfyesRadioBtn, mrfnoRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@WasteCollected", GetSelectedRadioButtonText(wastecollectyesRadioBtn, wastecollectnoRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@FrequencyHauling", frequencycmbBox.Text);
                    AddParameterIfNotEmpty(cmd, "@Hauler", haulertxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@HasSeptic", GetSelectedRadioButtonText(septicyesRadioBtn, septicnoRadioBtn, septicnaRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@LocationSeptic", locationSeptictxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@FrequencyDesludge", frequencysepticcmbBox.Text);
                    if (septicdate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@DateDesludge", septicdateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@DateDesludge", DBNull.Value);
                    }
                    AddParameterIfNotEmpty(cmd, "@ServiceProvider", serviceseptictxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@HasGreaseTrap", GetSelectedRadioButtonText(greaseyesRadioBtn, greasenoRadioBtn, greasenaRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@LocationGrease", locationgreasetxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@CapacityGreaseTrap", capacitygreasetxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@FrequencyGrease", greasefrequencycmbBox.Text);
                    AddParameterIfNotEmpty(cmd, "@HaulerGrease", haulergreasetxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@HasWasteWater", GetSelectedRadioButtonText(wastewateryesRadioBtn, wastewaternoRadioBtn, wastewaternaRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@UsedOilProperlyDisposed", GetSelectedRadioButtonText(usedoilyesRadioBtn, usedoilnoRadioBtn, usedoilnaRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@TypeofOil", oiltxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@FrequencyofHaulingOil", oilfrequencycmbBox.Text);
                    AddParameterIfNotEmpty(cmd, "@HaulerOil", hauleroiltxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@HasAirPollutionManager", GetSelectedRadioButtonText(pcdyesRadioBtn, pcdnoRadioBtn, pcdnaRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@DeviceType", pcdtxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@MaintenanceProvider", providertxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@PurposeOfInspection", purposecmbBox.Text);
                    if (reinspectdate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@ReinspectDate", reinspectdateTimePicker.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ReinspectDate", DBNull.Value);
                    }
                    AddParameterIfNotEmpty(cmd, "@LevelofInspection", string.Join(", ", levelofinspectionchklistBox.CheckedItems.Cast<string>()));
                    AddParameterIfNotEmpty(cmd, "@LandUse", GetSelectedRadioButtonText(landusecommercialRadioBtn, landuseresidentialRadioBtn, landuseindustrialRadioBtn, landuseinstitutionalRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@OwnershipTerms", GetSelectedRadioButtonText(proprietorshipRadioBtn, privatecorpRadioBtn, multinationalRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@Lessee", GetSelectedRadioButtonText(lesseeyesRadioBtn, lesseenoRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@StandAlone", GetSelectedRadioButtonText(standaloneyesRadioBtn, standalonenoRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@EstablishmentStatus", GetSelectedRadioButtonText(statusoperationalRadioBtn, statusnooperationRadioBtn, statusclosedRadioBtn, statuswfhRadioBtn));
                    AddParameterIfNotEmpty(cmd, "@InspectorObservation", obstxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@Directives", directivestxtBox.Text);
                    AddParameterIfNotEmpty(cmd, "@Recommendations", string.Join(", ", recommendationchklistBox.CheckedItems.Cast<string>()));
                    AddParameterIfNotEmpty(cmd, "@Inspector", string.Join(", ", inspectorschklistBox.CheckedItems.Cast<string>()));

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated!");
                        LogEvent("Updated Data");
                        ClearForm();
                        PopulateDataGridView();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Sql Error: " + ex.Message);
                    }
                }
            }
        }
        private void AddParameterIfNotEmpty(SqlCommand cmd, string paramName, string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                cmd.Parameters.AddWithValue(paramName, value);
            }
            else
            {
                cmd.Parameters.AddWithValue(paramName, DBNull.Value);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string DeleteQuery = "DELETE InspectionReport where AccountNo=@AccountNo";

                using (SqlCommand cmd = new SqlCommand(DeleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@AccountNo", accttxtBox.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Deleted!");
                        LogEvent("Deleted Data");
                        ClearForm();
                        PopulateDataGridView();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Sql Error: " + ex.Message);
                    }
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string searchQuery = "SELECT * FROM InspectionReport where AccountNo=@AccountNo";

                using (SqlCommand cmd = new SqlCommand(searchQuery, con))
                {
                    cmd.Parameters.AddWithValue("@AccountNo", accttxtBox.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                        MessageBox.Show("Record Found!");
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("No record found!");
                    }
                }
            }
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
            PopulateDataGridView();
        }
        private void switchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {

                MessageBox.Show($"Switched to user: {loginForm.Username}");
            }
        }
        private void registerNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm loginform = new loginForm();
            loginform.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generateReportsToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-HTKIB76\\SQLEXPRESS01;Initial Catalog=InspectionReport;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sqlQuery = "SELECT * FROM InspectionReport";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);


                        using (ExcelPackage excelPackage = new ExcelPackage())
                        {

                            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Data");


                            worksheet.Cells["A1"].LoadFromDataTable(dt, true);


                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Filter = "Excel Files|*.xlsx";
                            saveFileDialog.Title = "Save Excel File";
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                string filePath = saveFileDialog.FileName;
                                excelPackage.SaveAs(new System.IO.FileInfo(filePath));
                                MessageBox.Show("Report generated successfully!");
                            }
                        }
                    }
                }
            }
        }

        private void generateReportsToPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save PDF File";
            saveFileDialog.FileName = "output.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                Document doc = new Document();
                doc.Info.Title = "Data Report";

                Section section = doc.AddSection();

                Table table = section.AddTable();
                table.Style = "Table";
                table.Borders.Color = Colors.Black;
                table.Borders.Width = 0.5;

                double[] columnWidths = new double[dataGridView1.Columns.Count];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    string headerText = dataGridView1.Columns[i].HeaderText;
                    double multiplier = 1.5;
                    columnWidths[i] = Math.Max(headerText.Length * multiplier, 2.0);
                    table.AddColumn(Unit.FromCentimeter(columnWidths[i]));
                }

                Row headerRow = table.AddRow();
                headerRow.HeadingFormat = true;
                headerRow.Format.Alignment = ParagraphAlignment.Center;
                headerRow.Format.Font.Bold = true;
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    headerRow.Cells[column.Index].AddParagraph(column.HeaderText);
                }

                foreach (DataGridViewRow dataRow in dataGridView1.Rows)
                {
                    Row row = table.AddRow();
                    foreach (DataGridViewCell cell in dataRow.Cells)
                    {
                        if (cell.Value != null)
                        {
                            Paragraph paragraph = row.Cells[cell.ColumnIndex].AddParagraph();
                            paragraph.AddText(cell.Value.ToString());
                        }
                        else
                        {
                            Paragraph paragraph = row.Cells[cell.ColumnIndex].AddParagraph();
                            paragraph.AddText("");
                        }
                    }
                }

                section.PageSetup.Orientation = MigraDoc.DocumentObjectModel.Orientation.Landscape;

                PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
                pdfRenderer.Document = doc;
                pdfRenderer.RenderDocument();

                PdfDocument pdfDocument = new PdfDocument();

                using (MemoryStream ms = new MemoryStream())
                {
                    pdfRenderer.PdfDocument.Save(ms, false);
                    ms.Position = 0;
                    PdfDocument importPdfDocument = PdfReader.Open(ms, PdfDocumentOpenMode.Import);

                    foreach (PdfPage page in importPdfDocument.Pages)
                    {
                        pdfDocument.AddPage(page);
                    }
                }
                pdfDocument.Save(filePath);
                MessageBox.Show("Data exported to PDF successfully!");
            }
        }

        private void auditTrailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLogForm();
        }
    }
}