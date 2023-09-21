namespace Inspection_Report
{
    partial class Violations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            acctnotextBox = new TextBox();
            groupBox1 = new GroupBox();
            paidnoradioBtn = new RadioButton();
            paidyesradioBtn = new RadioButton();
            label2 = new Label();
            violationschklistBox = new CheckedListBox();
            paymentbreakdownBtn = new Button();
            submitBtn = new Button();
            cancelBtn = new Button();
            label3 = new Label();
            ornotextBox = new TextBox();
            label4 = new Label();
            dopdatetimePicker = new DateTimePicker();
            label5 = new Label();
            ovrtextBox = new TextBox();
            eoeechklistBox = new CheckedListBox();
            label6 = new Label();
            label7 = new Label();
            apprehensiondatetimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(751, 196);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 244);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Account No.:";
            // 
            // acctnotextBox
            // 
            acctnotextBox.Location = new Point(117, 236);
            acctnotextBox.Name = "acctnotextBox";
            acctnotextBox.Size = new Size(238, 23);
            acctnotextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(paidnoradioBtn);
            groupBox1.Controls.Add(paidyesradioBtn);
            groupBox1.Location = new Point(34, 529);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(148, 74);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Violations Paid?";
            // 
            // paidnoradioBtn
            // 
            paidnoradioBtn.AutoSize = true;
            paidnoradioBtn.Location = new Point(83, 33);
            paidnoradioBtn.Name = "paidnoradioBtn";
            paidnoradioBtn.Size = new Size(41, 19);
            paidnoradioBtn.TabIndex = 1;
            paidnoradioBtn.TabStop = true;
            paidnoradioBtn.Text = "No";
            paidnoradioBtn.UseVisualStyleBackColor = true;
            // 
            // paidyesradioBtn
            // 
            paidyesradioBtn.AutoSize = true;
            paidyesradioBtn.Location = new Point(28, 32);
            paidyesradioBtn.Name = "paidyesradioBtn";
            paidyesradioBtn.Size = new Size(42, 19);
            paidyesradioBtn.TabIndex = 0;
            paidyesradioBtn.TabStop = true;
            paidyesradioBtn.Text = "Yes";
            paidyesradioBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 269);
            label2.Name = "label2";
            label2.Size = new Size(315, 15);
            label2.TabIndex = 4;
            label2.Text = "Violations (ADD VIOLATIONS ONLY IF TICKETED BY EO/EE):";
            // 
            // violationschklistBox
            // 
            violationschklistBox.FormattingEnabled = true;
            violationschklistBox.Items.AddRange(new object[] { "3504-2A C.O. #35-2004 SEC. 2A (NO SEGREGATION)", "3099-5C C.O. #30-1999   SEC. 5C (NO LABELED MARK)", "9494-1 C.O. #94-1994   SEC. 1 (NO COVERED)", "5F-03D C.O. #91-2013 SEC. 5F-03D (NO ANTI-POLLUTION DEVICES)", "911-31 C.O. #09-2011   SEC. 3-1 (ANTI-LITTERING)", "2111-142 C.O. #21-2011  SEC. 14-2 (FAILURE TO DESLUDGE SEPTIC TANK)", "5F-03E C.O. #91-2013 SEC. 5F-03E (NO DENR-EMB PERMITS)", "5F-03B C.O. #91-2013 SEC. 5F-03B (NO PCO)", "1511-1B C.O. #15-2011  SEC. 1B (PROPER DISPOSAL OF USED COOKING OIL)", "5F-03A C.O. #91-2013 SEC. 5F-03A (FAILURE TO PAY EPP FEE)", "5F-03C C.O. #91-2013 SEC. 5F-03C (Refusal of ENTRY)", "517-A C.O. #05-2017 SEC. A (SMOKING IN PUBLIC PLACES)", "517-B C.O. #05-2017 SEC. B (PERSON INCHARGE)", "517-H C.O. #05-2017 SEC. H (SELLING TOBACCO W/O PERMIT)", "517-P C.O. #05-2017 SEC. P (DISPLAY & PLACE TOBACCO PRODUCT)" });
            violationschklistBox.Location = new Point(34, 293);
            violationschklistBox.Name = "violationschklistBox";
            violationschklistBox.Size = new Size(409, 220);
            violationschklistBox.TabIndex = 5;
            // 
            // paymentbreakdownBtn
            // 
            paymentbreakdownBtn.Location = new Point(524, 549);
            paymentbreakdownBtn.Name = "paymentbreakdownBtn";
            paymentbreakdownBtn.Size = new Size(115, 42);
            paymentbreakdownBtn.TabIndex = 6;
            paymentbreakdownBtn.Text = "Payment Breakdown";
            paymentbreakdownBtn.UseVisualStyleBackColor = true;
            paymentbreakdownBtn.Click += paymentbreakdownBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(666, 534);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(109, 33);
            submitBtn.TabIndex = 7;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(666, 575);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(109, 33);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 543);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 9;
            label3.Text = "OR:";
            // 
            // ornotextBox
            // 
            ornotextBox.Location = new Point(222, 540);
            ornotextBox.Name = "ornotextBox";
            ornotextBox.Size = new Size(147, 23);
            ornotextBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 579);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 11;
            label4.Text = "Date of Payment:";
            // 
            // dopdatetimePicker
            // 
            dopdatetimePicker.Location = new Point(294, 575);
            dopdatetimePicker.Name = "dopdatetimePicker";
            dopdatetimePicker.Size = new Size(200, 23);
            dopdatetimePicker.TabIndex = 12;
            dopdatetimePicker.ValueChanged += dopdatetimePicker_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 244);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 13;
            label5.Text = "OVR:";
            // 
            // ovrtextBox
            // 
            ovrtextBox.Location = new Point(413, 238);
            ovrtextBox.Name = "ovrtextBox";
            ovrtextBox.Size = new Size(238, 23);
            ovrtextBox.TabIndex = 14;
            // 
            // eoeechklistBox
            // 
            eoeechklistBox.FormattingEnabled = true;
            eoeechklistBox.Items.AddRange(new object[] { "Alfa Teodosio", "Michelle Anora", "Jenny Sandrino", "Dwight Babagay", "Gina Terana", "Edwin Paderes", "Carmencita Valdemoro", "Princess Eduarte", "Lhen Landoy", "Anna Pacheco" });
            eoeechklistBox.Location = new Point(449, 293);
            eoeechklistBox.Name = "eoeechklistBox";
            eoeechklistBox.Size = new Size(326, 184);
            eoeechklistBox.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(449, 269);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 16;
            label6.Text = "EO and EE:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(449, 487);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 17;
            label7.Text = "Apprehension Date:";
            // 
            // apprehensiondatetimePicker
            // 
            apprehensiondatetimePicker.Location = new Point(562, 484);
            apprehensiondatetimePicker.Name = "apprehensiondatetimePicker";
            apprehensiondatetimePicker.Size = new Size(213, 23);
            apprehensiondatetimePicker.TabIndex = 18;
            apprehensiondatetimePicker.ValueChanged += apprehensiondatetimePicker_ValueChanged;
            // 
            // Violations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 634);
            Controls.Add(apprehensiondatetimePicker);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(eoeechklistBox);
            Controls.Add(ovrtextBox);
            Controls.Add(label5);
            Controls.Add(dopdatetimePicker);
            Controls.Add(label4);
            Controls.Add(ornotextBox);
            Controls.Add(label3);
            Controls.Add(cancelBtn);
            Controls.Add(submitBtn);
            Controls.Add(paymentbreakdownBtn);
            Controls.Add(violationschklistBox);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(acctnotextBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Violations";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Violations";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox acctnotextBox;
        private GroupBox groupBox1;
        private Label label2;
        private CheckedListBox violationschklistBox;
        private RadioButton paidnoradioBtn;
        private RadioButton paidyesradioBtn;
        private Button paymentbreakdownBtn;
        private Button submitBtn;
        private Button cancelBtn;
        private Label label3;
        private TextBox ornotextBox;
        private Label label4;
        private DateTimePicker dopdatetimePicker;
        private Label label5;
        private TextBox ovrtextBox;
        private CheckedListBox eoeechklistBox;
        private Label label6;
        private Label label7;
        private DateTimePicker apprehensiondatetimePicker;
    }
}