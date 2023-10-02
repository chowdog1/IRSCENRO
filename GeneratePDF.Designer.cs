namespace Inspection_Report
{
    partial class GeneratePDF
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePDF));
            label1 = new Label();
            accttxtBox = new TextBox();
            printBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 33);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 0;
            label1.Text = "Account No:";
            // 
            // accttxtBox
            // 
            accttxtBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            accttxtBox.Location = new Point(207, 30);
            accttxtBox.Name = "accttxtBox";
            accttxtBox.Size = new Size(223, 43);
            accttxtBox.TabIndex = 1;
            // 
            // printBtn
            // 
            printBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            printBtn.Location = new Point(151, 93);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(167, 47);
            printBtn.TabIndex = 2;
            printBtn.Text = "Print";
            printBtn.UseVisualStyleBackColor = true;
            printBtn.Click += printBtn_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // GeneratePDF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 160);
            Controls.Add(printBtn);
            Controls.Add(accttxtBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GeneratePDF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GeneratePDF";
            FormClosed += GeneratePDF_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox accttxtBox;
        private Button printBtn;
        private System.Windows.Forms.Timer timer1;
    }
}