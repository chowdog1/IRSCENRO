namespace Inspection_Report
{
    partial class ChangePassword
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
            label2 = new Label();
            label3 = new Label();
            oldpwtextBox = new TextBox();
            newpwtextBox = new TextBox();
            confirmnewtextBox = new TextBox();
            confirmBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 27);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Old Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 57);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 88);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 2;
            label3.Text = "Confirm New Password";
            // 
            // oldpwtextBox
            // 
            oldpwtextBox.Location = new Point(144, 20);
            oldpwtextBox.Name = "oldpwtextBox";
            oldpwtextBox.PasswordChar = '•';
            oldpwtextBox.Size = new Size(196, 23);
            oldpwtextBox.TabIndex = 3;
            // 
            // newpwtextBox
            // 
            newpwtextBox.Location = new Point(144, 51);
            newpwtextBox.Name = "newpwtextBox";
            newpwtextBox.PasswordChar = '•';
            newpwtextBox.Size = new Size(196, 23);
            newpwtextBox.TabIndex = 4;
            // 
            // confirmnewtextBox
            // 
            confirmnewtextBox.Location = new Point(144, 84);
            confirmnewtextBox.Name = "confirmnewtextBox";
            confirmnewtextBox.PasswordChar = '•';
            confirmnewtextBox.Size = new Size(196, 23);
            confirmnewtextBox.TabIndex = 5;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(112, 120);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(116, 37);
            confirmBtn.TabIndex = 6;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 169);
            Controls.Add(confirmBtn);
            Controls.Add(confirmnewtextBox);
            Controls.Add(newpwtextBox);
            Controls.Add(oldpwtextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            FormClosed += ChangePassword_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox oldpwtextBox;
        private TextBox newpwtextBox;
        private TextBox confirmnewtextBox;
        private Button confirmBtn;
        private System.Windows.Forms.Timer timer1;
    }
}