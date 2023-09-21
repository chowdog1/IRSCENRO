namespace Inspection_Report
{
    partial class PrintCompliance
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
            accttxtBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(203, 45);
            label1.TabIndex = 0;
            label1.Text = "Account No.:";
            // 
            // accttxtBox
            // 
            accttxtBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            accttxtBox.Location = new Point(239, 36);
            accttxtBox.Name = "accttxtBox";
            accttxtBox.Size = new Size(269, 50);
            accttxtBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(124, 102);
            button1.Name = "button1";
            button1.Size = new Size(131, 45);
            button1.TabIndex = 2;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(277, 102);
            button2.Name = "button2";
            button2.Size = new Size(131, 45);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PrintCompliance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 169);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(accttxtBox);
            Controls.Add(label1);
            Name = "PrintCompliance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Print";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox accttxtBox;
        private Button button1;
        private Button button2;
    }
}