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
            lblAccountNo = new Label();
            lblBusinessName = new Label();
            lblApprehension = new Label();
            lblInspectors = new Label();
            label5 = new Label();
            lblOVR = new Label();
            lblViolations = new Label();
            SuspendLayout();
            // 
            // lblAccountNo
            // 
            lblAccountNo.AutoSize = true;
            lblAccountNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccountNo.Location = new Point(26, 40);
            lblAccountNo.Name = "lblAccountNo";
            lblAccountNo.Size = new Size(101, 21);
            lblAccountNo.TabIndex = 0;
            lblAccountNo.Text = "Account No.: ";
            // 
            // lblBusinessName
            // 
            lblBusinessName.AutoSize = true;
            lblBusinessName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBusinessName.Location = new Point(26, 86);
            lblBusinessName.Name = "lblBusinessName";
            lblBusinessName.Size = new Size(123, 21);
            lblBusinessName.TabIndex = 1;
            lblBusinessName.Text = "Business Name: ";
            // 
            // lblApprehension
            // 
            lblApprehension.AutoSize = true;
            lblApprehension.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApprehension.Location = new Point(541, 40);
            lblApprehension.Name = "lblApprehension";
            lblApprehension.Size = new Size(150, 21);
            lblApprehension.TabIndex = 2;
            lblApprehension.Text = "Apprehension Date: ";
            // 
            // lblInspectors
            // 
            lblInspectors.AutoSize = true;
            lblInspectors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInspectors.Location = new Point(541, 86);
            lblInspectors.Name = "lblInspectors";
            lblInspectors.Size = new Size(88, 21);
            lblInspectors.TabIndex = 3;
            lblInspectors.Text = "Inspectors: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 536);
            label5.Name = "label5";
            label5.Size = new Size(112, 37);
            label5.TabIndex = 4;
            label5.Text = "TOTAL: ";
            // 
            // lblOVR
            // 
            lblOVR.AutoSize = true;
            lblOVR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOVR.Location = new Point(26, 142);
            lblOVR.Name = "lblOVR";
            lblOVR.Size = new Size(49, 21);
            lblOVR.TabIndex = 5;
            lblOVR.Text = "OVR: ";
            // 
            // lblViolations
            // 
            lblViolations.AutoSize = true;
            lblViolations.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblViolations.Location = new Point(26, 201);
            lblViolations.Name = "lblViolations";
            lblViolations.Size = new Size(82, 21);
            lblViolations.TabIndex = 6;
            lblViolations.Text = "Violations:";
            // 
            // PaymentBreakdown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 634);
            Controls.Add(lblViolations);
            Controls.Add(lblOVR);
            Controls.Add(label5);
            Controls.Add(lblInspectors);
            Controls.Add(lblApprehension);
            Controls.Add(lblBusinessName);
            Controls.Add(lblAccountNo);
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
        private Label label5;
        private Label lblOVR;
        private Label lblViolations;
    }
}