﻿namespace Inspection_Report
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
            label3.Location = new Point(17, 94);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "Business Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 133);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "From Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 170);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "To Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(257, 57);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 5;
            label6.Text = "Establishment Has:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(257, 116);
            label7.Name = "label7";
            label7.Size = new Size(114, 15);
            label7.TabIndex = 6;
            label7.Text = "Violated ordinances:";
            // 
            // AdvancedSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 313);
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
    }
}