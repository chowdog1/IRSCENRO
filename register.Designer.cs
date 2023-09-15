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
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(32, 51);
            label1.Name = "label1";
            label1.Size = new Size(164, 37);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 132);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // usernametxtBox
            // 
            usernametxtBox.ForeColor = Color.Black;
            usernametxtBox.Location = new Point(32, 155);
            usernametxtBox.Multiline = true;
            usernametxtBox.Name = "usernametxtBox";
            usernametxtBox.Size = new Size(284, 32);
            usernametxtBox.TabIndex = 2;
            // 
            // passwordtxtBox
            // 
            passwordtxtBox.ForeColor = Color.Black;
            passwordtxtBox.Location = new Point(32, 235);
            passwordtxtBox.Multiline = true;
            passwordtxtBox.Name = "passwordtxtBox";
            passwordtxtBox.PasswordChar = '•';
            passwordtxtBox.Size = new Size(284, 32);
            passwordtxtBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 214);
            label3.Name = "label3";
            label3.Size = new Size(117, 17);
            label3.TabIndex = 3;
            label3.Text = "Desired Password";
            // 
            // confirmpasswordtxtBox
            // 
            confirmpasswordtxtBox.ForeColor = Color.Black;
            confirmpasswordtxtBox.Location = new Point(32, 319);
            confirmpasswordtxtBox.Multiline = true;
            confirmpasswordtxtBox.Name = "confirmpasswordtxtBox";
            confirmpasswordtxtBox.PasswordChar = '•';
            confirmpasswordtxtBox.Size = new Size(284, 32);
            confirmpasswordtxtBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 297);
            label4.Name = "label4";
            label4.Size = new Size(120, 17);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // showchkBox
            // 
            showchkBox.AutoSize = true;
            showchkBox.Cursor = Cursors.Hand;
            showchkBox.Location = new Point(201, 359);
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
            registerBtn.Location = new Point(30, 398);
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
            button1.Location = new Point(30, 445);
            button1.Name = "button1";
            button1.Size = new Size(286, 40);
            button1.TabIndex = 9;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Red;
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(30, 520);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(286, 40);
            cancelBtn.TabIndex = 13;
            cancelBtn.Text = "CANCEL";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(351, 615);
            Controls.Add(cancelBtn);
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
        private Button cancelBtn;
    }
}