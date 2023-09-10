namespace Inspection_Report
{
    partial class loginForm
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
            label6 = new Label();
            label5 = new Label();
            clrBtn = new Button();
            loginBtn = new Button();
            showchkBox = new CheckBox();
            passwordtxtBox = new TextBox();
            label3 = new Label();
            usernametxtBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(118, 429);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 23;
            label6.Text = "Create Account";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 409);
            label5.Name = "label5";
            label5.Size = new Size(138, 15);
            label5.TabIndex = 22;
            label5.Text = "Don't have an Account?";
            // 
            // clrBtn
            // 
            clrBtn.BackColor = Color.White;
            clrBtn.Cursor = Cursors.Hand;
            clrBtn.FlatStyle = FlatStyle.Flat;
            clrBtn.ForeColor = Color.FromArgb(116, 86, 174);
            clrBtn.Location = new Point(24, 353);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(286, 40);
            clrBtn.TabIndex = 21;
            clrBtn.Text = "CLEAR";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(116, 86, 174);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(24, 306);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(286, 40);
            loginBtn.TabIndex = 20;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // showchkBox
            // 
            showchkBox.AutoSize = true;
            showchkBox.Cursor = Cursors.Hand;
            showchkBox.Location = new Point(195, 267);
            showchkBox.Name = "showchkBox";
            showchkBox.Size = new Size(112, 19);
            showchkBox.TabIndex = 19;
            showchkBox.Text = "Show Password";
            showchkBox.UseVisualStyleBackColor = true;
            showchkBox.CheckedChanged += showchkBox_CheckedChanged;
            // 
            // passwordtxtBox
            // 
            passwordtxtBox.ForeColor = Color.Black;
            passwordtxtBox.Location = new Point(26, 230);
            passwordtxtBox.Multiline = true;
            passwordtxtBox.Name = "passwordtxtBox";
            passwordtxtBox.PasswordChar = '•';
            passwordtxtBox.Size = new Size(284, 32);
            passwordtxtBox.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 209);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // usernametxtBox
            // 
            usernametxtBox.ForeColor = Color.Black;
            usernametxtBox.Location = new Point(26, 150);
            usernametxtBox.Multiline = true;
            usernametxtBox.Name = "usernametxtBox";
            usernametxtBox.Size = new Size(284, 32);
            usernametxtBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 127);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(26, 46);
            label1.Name = "label1";
            label1.Size = new Size(95, 37);
            label1.TabIndex = 12;
            label1.Text = "Hello!";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(335, 576);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(clrBtn);
            Controls.Add(loginBtn);
            Controls.Add(showchkBox);
            Controls.Add(passwordtxtBox);
            Controls.Add(label3);
            Controls.Add(usernametxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            TransparencyKey = Color.Black;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button clrBtn;
        private Button loginBtn;
        private CheckBox showchkBox;
        private TextBox passwordtxtBox;
        private Label label3;
        private TextBox usernametxtBox;
        private Label label2;
        private Label label1;
    }
}