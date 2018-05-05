namespace Login
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RePassword = new System.Windows.Forms.TextBox();
            this.RegBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(135, 64);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(215, 61);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(116, 21);
            this.Username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(135, 114);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(215, 105);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(116, 21);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(135, 160);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码:";
            // 
            // RePassword
            // 
            this.RePassword.Location = new System.Drawing.Point(215, 155);
            this.RePassword.Name = "RePassword";
            this.RePassword.Size = new System.Drawing.Size(116, 21);
            this.RePassword.TabIndex = 5;
            this.RePassword.UseSystemPasswordChar = true;
            // 
            // RegBtn
            // 
            this.RegBtn.Location = new System.Drawing.Point(123, 232);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(76, 27);
            this.RegBtn.TabIndex = 6;
            this.RegBtn.Text = "注册";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(270, 232);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(76, 27);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Register
            // 
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(480, 355);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.RePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RePassword;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}