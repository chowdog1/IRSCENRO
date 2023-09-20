namespace Inspection_Report
{
    partial class Compliance
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
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            label3 = new Label();
            otherstextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(643, 237);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 300);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Account No:";
            // 
            // acctnotextBox
            // 
            acctnotextBox.Location = new Point(127, 297);
            acctnotextBox.Name = "acctnotextBox";
            acctnotextBox.Size = new Size(158, 23);
            acctnotextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 339);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "For Compliance:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Environmental Compliance Certificate", "Certificate of Non-Coverage", "Wastewater Discharge Permit", "Hazardous Waste Generator ID", "Pollution Control Officer", "Permit to Operate For Air Pollution Source Installation or Equipment", "Transport, Storage and Disposal Certificate", "Installation of Septic Tank/Desludging Certificate Issued by DENR-EMB Accredited Hauler", "Installation of Grease Trap", "Waste Segregation Bins with Proper Markings and Cover" });
            checkedListBox1.Location = new Point(127, 340);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(498, 184);
            checkedListBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 533);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Others:";
            // 
            // otherstextBox
            // 
            otherstextBox.Location = new Point(127, 530);
            otherstextBox.Multiline = true;
            otherstextBox.Name = "otherstextBox";
            otherstextBox.Size = new Size(289, 55);
            otherstextBox.TabIndex = 6;
            // 
            // Compliance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 664);
            Controls.Add(otherstextBox);
            Controls.Add(label3);
            Controls.Add(checkedListBox1);
            Controls.Add(acctnotextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Compliance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compliance";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox acctnotextBox;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private Label label3;
        private TextBox otherstextBox;
    }
}