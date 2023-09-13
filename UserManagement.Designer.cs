namespace Inspection_Report
{
    partial class UserManagement
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
            dataGridViewUsers = new DataGridView();
            dltuserBtn = new Button();
            promoteuserBtn = new Button();
            label1 = new Label();
            usernametxtBox = new TextBox();
            removeadminBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(28, 26);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowTemplate.Height = 25;
            dataGridViewUsers.Size = new Size(447, 150);
            dataGridViewUsers.TabIndex = 0;
            // 
            // dltuserBtn
            // 
            dltuserBtn.Location = new Point(28, 384);
            dltuserBtn.Name = "dltuserBtn";
            dltuserBtn.Size = new Size(447, 44);
            dltuserBtn.TabIndex = 2;
            dltuserBtn.Text = "Delete User";
            dltuserBtn.UseVisualStyleBackColor = true;
            dltuserBtn.Click += dltuserBtn_Click;
            // 
            // promoteuserBtn
            // 
            promoteuserBtn.Location = new Point(28, 271);
            promoteuserBtn.Name = "promoteuserBtn";
            promoteuserBtn.Size = new Size(447, 44);
            promoteuserBtn.TabIndex = 3;
            promoteuserBtn.Text = "Make this User an Admin";
            promoteuserBtn.UseVisualStyleBackColor = true;
            promoteuserBtn.Click += promoteuserBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 217);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // usernametxtBox
            // 
            usernametxtBox.Location = new Point(182, 214);
            usernametxtBox.Name = "usernametxtBox";
            usernametxtBox.Size = new Size(181, 23);
            usernametxtBox.TabIndex = 5;
            // 
            // removeadminBtn
            // 
            removeadminBtn.Location = new Point(28, 329);
            removeadminBtn.Name = "removeadminBtn";
            removeadminBtn.Size = new Size(447, 44);
            removeadminBtn.TabIndex = 6;
            removeadminBtn.Text = "Remove admin rights";
            removeadminBtn.UseVisualStyleBackColor = true;
            removeadminBtn.Click += removeadminBtn_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 451);
            Controls.Add(removeadminBtn);
            Controls.Add(usernametxtBox);
            Controls.Add(label1);
            Controls.Add(promoteuserBtn);
            Controls.Add(dltuserBtn);
            Controls.Add(dataGridViewUsers);
            Name = "UserManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Button dltuserBtn;
        private Button promoteuserBtn;
        private Label label1;
        private TextBox usernametxtBox;
        private Button removeadminBtn;
    }
}