namespace Inspection_Report
{
    partial class PaymentBreakdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentBreakdown));
            lblAccountNo = new Label();
            lblBusinessName = new Label();
            lblApprehension = new Label();
            lblInspectors = new Label();
            lblTotal = new Label();
            lblOVR = new Label();
            lblViolations = new Label();
            printBtn = new Button();
            SuspendLayout();
            // 
            // lblAccountNo
            // 
            lblAccountNo.AutoSize = true;
            lblAccountNo.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccountNo.Location = new Point(26, 40);
            lblAccountNo.Name = "lblAccountNo";
            lblAccountNo.Size = new Size(111, 16);
            lblAccountNo.TabIndex = 0;
            lblAccountNo.Text = "Account No.: ";
            // 
            // lblBusinessName
            // 
            lblBusinessName.AutoSize = true;
            lblBusinessName.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBusinessName.Location = new Point(26, 66);
            lblBusinessName.Name = "lblBusinessName";
            lblBusinessName.Size = new Size(127, 16);
            lblBusinessName.TabIndex = 1;
            lblBusinessName.Text = "Business Name: ";
            // 
            // lblApprehension
            // 
            lblApprehension.AutoSize = true;
            lblApprehension.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblApprehension.Location = new Point(541, 40);
            lblApprehension.Name = "lblApprehension";
            lblApprehension.Size = new Size(159, 16);
            lblApprehension.TabIndex = 2;
            lblApprehension.Text = "Apprehension Date: ";
            // 
            // lblInspectors
            // 
            lblInspectors.AutoSize = true;
            lblInspectors.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInspectors.Location = new Point(541, 66);
            lblInspectors.Name = "lblInspectors";
            lblInspectors.Size = new Size(103, 16);
            lblInspectors.TabIndex = 3;
            lblInspectors.Text = "Inspectors: ";
            // 
            // lblTotal
            // 
            lblTotal.AccessibleName = "";
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Courier New", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(26, 407);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(126, 31);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "TOTAL: ";
            // 
            // lblOVR
            // 
            lblOVR.AutoSize = true;
            lblOVR.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblOVR.Location = new Point(26, 103);
            lblOVR.Name = "lblOVR";
            lblOVR.Size = new Size(47, 16);
            lblOVR.TabIndex = 5;
            lblOVR.Text = "OVR: ";
            // 
            // lblViolations
            // 
            lblViolations.AutoSize = true;
            lblViolations.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblViolations.Location = new Point(26, 143);
            lblViolations.Name = "lblViolations";
            lblViolations.Size = new Size(95, 16);
            lblViolations.TabIndex = 6;
            lblViolations.Text = "Violations:";
            lblViolations.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // printBtn
            // 
            printBtn.Location = new Point(690, 404);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(128, 42);
            printBtn.TabIndex = 7;
            printBtn.Text = "Print";
            printBtn.UseVisualStyleBackColor = true;
            printBtn.Click += printBtn_Click;
            // 
            // PaymentBreakdown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 475);
            Controls.Add(printBtn);
            Controls.Add(lblViolations);
            Controls.Add(lblOVR);
            Controls.Add(lblTotal);
            Controls.Add(lblInspectors);
            Controls.Add(lblApprehension);
            Controls.Add(lblBusinessName);
            Controls.Add(lblAccountNo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PaymentBreakdown";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Breakdown";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccountNo;
        private Label lblBusinessName;
        private Label lblApprehension;
        private Label lblInspectors;
        private Label lblTotal;
        private Label lblOVR;
        private Label lblViolations;
        private Button printBtn;
    }
}