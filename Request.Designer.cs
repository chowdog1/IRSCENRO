namespace Inspection_Report
{
    partial class Request
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
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nametextBox = new TextBox();
            depttextBox = new TextBox();
            emailtextBox = new TextBox();
            reasontextBox = new TextBox();
            sendBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(62, 35);
            label1.Name = "label1";
            label1.Size = new Size(372, 37);
            label1.TabIndex = 0;
            label1.Text = "Kindly fill all required fields";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(28, 116);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(116, 86, 174);
            label3.Location = new Point(28, 154);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Department:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(116, 86, 174);
            label4.Location = new Point(28, 191);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(28, 234);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Reason:";
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(112, 113);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(312, 23);
            nametextBox.TabIndex = 5;
            // 
            // depttextBox
            // 
            depttextBox.Location = new Point(112, 151);
            depttextBox.Name = "depttextBox";
            depttextBox.Size = new Size(312, 23);
            depttextBox.TabIndex = 6;
            // 
            // emailtextBox
            // 
            emailtextBox.Location = new Point(112, 188);
            emailtextBox.Name = "emailtextBox";
            emailtextBox.Size = new Size(312, 23);
            emailtextBox.TabIndex = 7;
            // 
            // reasontextBox
            // 
            reasontextBox.Location = new Point(112, 231);
            reasontextBox.Multiline = true;
            reasontextBox.Name = "reasontextBox";
            reasontextBox.Size = new Size(312, 112);
            reasontextBox.TabIndex = 8;
            // 
            // sendBtn
            // 
            sendBtn.BackColor = Color.FromArgb(116, 86, 174);
            sendBtn.Cursor = Cursors.Hand;
            sendBtn.FlatStyle = FlatStyle.Flat;
            sendBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sendBtn.ForeColor = Color.White;
            sendBtn.Location = new Point(62, 358);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(372, 47);
            sendBtn.TabIndex = 9;
            sendBtn.Text = "SEND REQUEST";
            sendBtn.UseVisualStyleBackColor = false;
            sendBtn.Click += button1_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.White;
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cancelBtn.ForeColor = Color.FromArgb(116, 86, 174);
            cancelBtn.Location = new Point(62, 411);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(372, 47);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "CANCEL";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // Request
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(481, 510);
            Controls.Add(cancelBtn);
            Controls.Add(sendBtn);
            Controls.Add(reasontextBox);
            Controls.Add(emailtextBox);
            Controls.Add(depttextBox);
            Controls.Add(nametextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Request";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Request";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nametextBox;
        private TextBox depttextBox;
        private TextBox emailtextBox;
        private TextBox reasontextBox;
        private Button sendBtn;
        private Button cancelBtn;
    }
}