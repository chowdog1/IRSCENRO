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
            compliancechklistBox = new CheckedListBox();
            label3 = new Label();
            otherstextBox = new TextBox();
            confirmBtn = new Button();
            cancelBtn = new Button();
            groupBox1 = new GroupBox();
            submittednoradioBtn = new RadioButton();
            submittedyesradioBtn = new RadioButton();
            menuStrip1 = new MenuStrip();
            optionToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(680, 237);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 332);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Account No:";
            // 
            // acctnotextBox
            // 
            acctnotextBox.Location = new Point(127, 324);
            acctnotextBox.Name = "acctnotextBox";
            acctnotextBox.Size = new Size(158, 23);
            acctnotextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 401);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "For Compliance:";
            // 
            // compliancechklistBox
            // 
            compliancechklistBox.FormattingEnabled = true;
            compliancechklistBox.Items.AddRange(new object[] { "Environmental Compliance Certificate", "Certificate of Non-Coverage", "Wastewater Discharge Permit", "Hazardous Waste Generator ID", "Pollution Control Officer", "Permit to Operate For Air Pollution Source Installation or Equipment", "Transport, Storage and Disposal Certificate", "Installation of Septic Tank/Desludging Certificate Issued by DENR-EMB Accredited Hauler", "Installation of Grease Trap", "Waste Segregation Bins with Proper Markings and Cover" });
            compliancechklistBox.Location = new Point(127, 401);
            compliancechklistBox.Name = "compliancechklistBox";
            compliancechklistBox.Size = new Size(498, 184);
            compliancechklistBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 609);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Others:";
            // 
            // otherstextBox
            // 
            otherstextBox.Location = new Point(127, 609);
            otherstextBox.Multiline = true;
            otherstextBox.Name = "otherstextBox";
            otherstextBox.Size = new Size(289, 55);
            otherstextBox.TabIndex = 6;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(509, 609);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(195, 34);
            confirmBtn.TabIndex = 7;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(509, 654);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(195, 34);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(submittednoradioBtn);
            groupBox1.Controls.Add(submittedyesradioBtn);
            groupBox1.Location = new Point(333, 305);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(117, 78);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Submitted?";
            // 
            // submittednoradioBtn
            // 
            submittednoradioBtn.AutoSize = true;
            submittednoradioBtn.Location = new Point(61, 33);
            submittednoradioBtn.Name = "submittednoradioBtn";
            submittednoradioBtn.Size = new Size(41, 19);
            submittednoradioBtn.TabIndex = 1;
            submittednoradioBtn.TabStop = true;
            submittednoradioBtn.Text = "No";
            submittednoradioBtn.UseVisualStyleBackColor = true;
            // 
            // submittedyesradioBtn
            // 
            submittedyesradioBtn.AutoSize = true;
            submittedyesradioBtn.Location = new Point(13, 33);
            submittedyesradioBtn.Name = "submittedyesradioBtn";
            submittedyesradioBtn.Size = new Size(42, 19);
            submittedyesradioBtn.TabIndex = 0;
            submittedyesradioBtn.TabStop = true;
            submittedyesradioBtn.Text = "Yes";
            submittedyesradioBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(727, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            optionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { printToolStripMenuItem });
            optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            optionToolStripMenuItem.Size = new Size(56, 20);
            optionToolStripMenuItem.Text = "Option";
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(180, 22);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // Compliance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 723);
            Controls.Add(groupBox1);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Controls.Add(otherstextBox);
            Controls.Add(label3);
            Controls.Add(compliancechklistBox);
            Controls.Add(acctnotextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Compliance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compliance";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox acctnotextBox;
        private Label label2;
        private CheckedListBox compliancechklistBox;
        private Label label3;
        private TextBox otherstextBox;
        private Button confirmBtn;
        private Button cancelBtn;
        private GroupBox groupBox1;
        private RadioButton submittednoradioBtn;
        private RadioButton submittedyesradioBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
    }
}