namespace Inspection_Report
{
    partial class AdvancedSearch
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            brgyadvcmbBox = new ComboBox();
            advstatusbusscmbBox = new ComboBox();
            fddateTimePicker = new DateTimePicker();
            tddateTimePicker = new DateTimePicker();
            establishmenthasadvcmbBox = new ComboBox();
            advviolatedcmbBox = new ComboBox();
            advsearchBtn = new Button();
            advclearBtn = new Button();
            label8 = new Label();
            establishmentisadvcmbBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Filter by:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 57);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Barangay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 98);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "Business Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 140);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "From Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 182);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "To Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 126);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 5;
            label6.Text = "Establishment Has:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(306, 176);
            label7.Name = "label7";
            label7.Size = new Size(114, 15);
            label7.TabIndex = 6;
            label7.Text = "Violated ordinances:";
            // 
            // brgyadvcmbBox
            // 
            brgyadvcmbBox.FormattingEnabled = true;
            brgyadvcmbBox.Items.AddRange(new object[] { "Addition Hills", "Balong Bato", "Batis", "Corazon De Jesus", "Ermitaño", "Greenhills", "Isabelita", "Kabayanan", "Little Baguio", "Maytunas", "Onse", "Pasadena", "Pedro Cruz", "Progreso", "Rivera", "St. Joseph", "Salapan", "San Perfecto", "Sta. Lucia", "Tibagan", "West Crame" });
            brgyadvcmbBox.Location = new Point(114, 57);
            brgyadvcmbBox.Name = "brgyadvcmbBox";
            brgyadvcmbBox.Size = new Size(186, 23);
            brgyadvcmbBox.TabIndex = 7;
            // 
            // advstatusbusscmbBox
            // 
            advstatusbusscmbBox.FormattingEnabled = true;
            advstatusbusscmbBox.Items.AddRange(new object[] { "HIGHRISK", "LOWRISK" });
            advstatusbusscmbBox.Location = new Point(114, 95);
            advstatusbusscmbBox.Name = "advstatusbusscmbBox";
            advstatusbusscmbBox.Size = new Size(186, 23);
            advstatusbusscmbBox.TabIndex = 8;
            // 
            // fddateTimePicker
            // 
            fddateTimePicker.Location = new Point(114, 140);
            fddateTimePicker.Name = "fddateTimePicker";
            fddateTimePicker.Size = new Size(186, 23);
            fddateTimePicker.TabIndex = 9;
            fddateTimePicker.ValueChanged += fddateTimePicker_ValueChanged;
            // 
            // tddateTimePicker
            // 
            tddateTimePicker.Location = new Point(114, 182);
            tddateTimePicker.Name = "tddateTimePicker";
            tddateTimePicker.Size = new Size(186, 23);
            tddateTimePicker.TabIndex = 10;
            tddateTimePicker.ValueChanged += tddateTimePicker_ValueChanged;
            // 
            // establishmenthasadvcmbBox
            // 
            establishmenthasadvcmbBox.FormattingEnabled = true;
            establishmenthasadvcmbBox.Items.AddRange(new object[] { "Passed the CENRO standards", "Violated City Ordinances", "Notice/Warning", "BPLO Verification" });
            establishmenthasadvcmbBox.Location = new Point(419, 120);
            establishmenthasadvcmbBox.Name = "establishmenthasadvcmbBox";
            establishmenthasadvcmbBox.Size = new Size(186, 23);
            establishmenthasadvcmbBox.TabIndex = 11;
            // 
            // advviolatedcmbBox
            // 
            advviolatedcmbBox.FormattingEnabled = true;
            advviolatedcmbBox.Items.AddRange(new object[] { "3504-2A C.O. #35-2004 SEC. 2A (NO SEGREGATION)", "3099-5C C.O. #30-1999   SEC. 5C (NO LABELED MARK)", "9494-1 C.O. #94-1994   SEC. 1 (NO COVERED)", "5F-03D C.O. #91-2013 SEC. 5F-03D (NO ANTI-POLLUTION DEVICES)", "911-31 C.O. #09-2011   SEC. 3-1 (ANTI-LITTERING)", "2111-142 C.O. #21-2011  SEC. 14-2 (FAILURE TO DESLUDGE SEPTIC TANK)", "5F-03E C.O. #91-2013 SEC. 5F-03E (NO DENR-EMB PERMITS)", "5F-03B C.O. #91-2013 SEC. 5F-03B (NO PCO)", "1511-1B C.O. #15-2011  SEC. 1B (PROPER DISPOSAL OF USED COOKING OIL)", "5F-03A C.O. #91-2013 SEC. 5F-03A (FAILURE TO PAY EPP FEE)", "5F-03C C.O. #91-2013 SEC. 5F-03C (Refusal of ENTRY)", "517-A C.O. #05-2017 SEC. A (SMOKING IN PUBLIC PLACES)", "517-B C.O. #05-2017 SEC. B (PERSON INCHARGE)", "517-H C.O. #05-2017 SEC. H (SELLING TOBACCO W/O PERMIT)", "517-P C.O. #05-2017 SEC. P (DISPLAY & PLACE TOBACCO PRODUCT)" });
            advviolatedcmbBox.Location = new Point(419, 174);
            advviolatedcmbBox.Name = "advviolatedcmbBox";
            advviolatedcmbBox.Size = new Size(186, 23);
            advviolatedcmbBox.TabIndex = 12;
            // 
            // advsearchBtn
            // 
            advsearchBtn.Location = new Point(209, 239);
            advsearchBtn.Name = "advsearchBtn";
            advsearchBtn.Size = new Size(107, 34);
            advsearchBtn.TabIndex = 13;
            advsearchBtn.Text = "Search";
            advsearchBtn.UseVisualStyleBackColor = true;
            advsearchBtn.Click += advsearchBtn_Click;
            // 
            // advclearBtn
            // 
            advclearBtn.Location = new Point(331, 239);
            advclearBtn.Name = "advclearBtn";
            advclearBtn.Size = new Size(107, 34);
            advclearBtn.TabIndex = 14;
            advclearBtn.Text = "Clear";
            advclearBtn.UseVisualStyleBackColor = true;
            advclearBtn.Click += advclearBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(306, 76);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 15;
            label8.Text = "Establishment is:";
            // 
            // establishmentisadvcmbBox
            // 
            establishmentisadvcmbBox.FormattingEnabled = true;
            establishmentisadvcmbBox.Items.AddRange(new object[] { "Priority", "Less Priority", "Closed/Non-Operational", "Review for CEC", "Moveout/Pull-out/Unlocated/Others" });
            establishmentisadvcmbBox.Location = new Point(419, 70);
            establishmentisadvcmbBox.Name = "establishmentisadvcmbBox";
            establishmentisadvcmbBox.Size = new Size(186, 23);
            establishmentisadvcmbBox.TabIndex = 16;
            // 
            // AdvancedSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 313);
            Controls.Add(establishmentisadvcmbBox);
            Controls.Add(label8);
            Controls.Add(advclearBtn);
            Controls.Add(advsearchBtn);
            Controls.Add(advviolatedcmbBox);
            Controls.Add(establishmenthasadvcmbBox);
            Controls.Add(tddateTimePicker);
            Controls.Add(fddateTimePicker);
            Controls.Add(advstatusbusscmbBox);
            Controls.Add(brgyadvcmbBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdvancedSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Advanced Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox brgyadvcmbBox;
        private ComboBox advstatusbusscmbBox;
        private DateTimePicker fddateTimePicker;
        private DateTimePicker tddateTimePicker;
        private ComboBox establishmenthasadvcmbBox;
        private ComboBox advviolatedcmbBox;
        private Button advsearchBtn;
        private Button advclearBtn;
        private Label label8;
        private ComboBox establishmentisadvcmbBox;
    }
}