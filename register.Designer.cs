namespace Inspection_Report
{
    partial class registerForm
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
            usernametxtBox = new TextBox();
            passwordtxtBox = new TextBox();
            label3 = new Label();
            confirmpasswordtxtBox = new TextBox();
            label4 = new Label();
            showchkBox = new CheckBox();
            registerBtn = new Button();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(33, 68);
            label1.Name = "label1";
            label1.Size = new Size(164, 37);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 149);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // usernametxtBox
            // 
            usernametxtBox.ForeColor = Color.Black;
            usernametxtBox.Location = new Point(33, 172);
            usernametxtBox.Multiline = true;
            usernametxtBox.Name = "usernametxtBox";
            usernametxtBox.Size = new Size(284, 32);
            usernametxtBox.TabIndex = 2;
            // 
            // passwordtxtBox
            // 
            passwordtxtBox.ForeColor = Color.Black;
            passwordtxtBox.Location = new Point(33, 252);
            passwordtxtBox.Multiline = true;
            passwordtxtBox.Name = "passwordtxtBox";
            passwordtxtBox.PasswordChar = '•';
            passwordtxtBox.Size = new Size(284, 32);
            passwordtxtBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 231);
            label3.Name = "label3";
            label3.Size = new Size(117, 17);
            label3.TabIndex = 3;
            label3.Text = "Desired Password";
            // 
            // confirmpasswordtxtBox
            // 
            confirmpasswordtxtBox.ForeColor = Color.Black;
            confirmpasswordtxtBox.Location = new Point(33, 336);
            confirmpasswordtxtBox.Multiline = true;
            confirmpasswordtxtBox.Name = "confirmpasswordtxtBox";
            confirmpasswordtxtBox.PasswordChar = '•';
            confirmpasswordtxtBox.Size = new Size(284, 32);
            confirmpasswordtxtBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 314);
            label4.Name = "label4";
            label4.Size = new Size(120, 17);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // showchkBox
            // 
            showchkBox.AutoSize = true;
            showchkBox.Cursor = Cursors.Hand;
            showchkBox.Location = new Point(202, 376);
            showchkBox.Name = "showchkBox";
            showchkBox.Size = new Size(122, 21);
            showchkBox.TabIndex = 7;
            showchkBox.Text = "Show Password";
            showchkBox.UseVisualStyleBackColor = true;
            showchkBox.CheckedChanged += showchkBox_CheckedChanged;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(116, 86, 174);
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(31, 415);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(286, 40);
            registerBtn.TabIndex = 8;
            registerBtn.Text = "REGISTER";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(31, 462);
            button1.Name = "button1";
            button1.Size = new Size(286, 40);
            button1.TabIndex = 9;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 518);
            label5.Name = "label5";
            label5.Size = new Size(164, 17);
            label5.TabIndex = 10;
            label5.Text = "Aleady Have an Account?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(125, 538);
            label6.Name = "label6";
            label6.Size = new Size(92, 17);
            label6.TabIndex = 11;
            label6.Text = "Back to Login";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(116, 86, 174);
            label7.Location = new Point(304, 9);
            label7.Name = "label7";
            label7.Size = new Size(35, 37);
            label7.TabIndex = 12;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(351, 615);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(registerBtn);
            Controls.Add(showchkBox);
            Controls.Add(confirmpasswordtxtBox);
            Controls.Add(label4);
            Controls.Add(passwordtxtBox);
            Controls.Add(label3);
            Controls.Add(usernametxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            TransparencyKey = Color.Black;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernametxtBox;
        private TextBox passwordtxtBox;
        private Label label3;
        private TextBox confirmpasswordtxtBox;
        private Label label4;
        private CheckBox showchkBox;
        private Button registerBtn;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}