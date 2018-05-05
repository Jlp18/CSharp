namespace Login
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.manager_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.fenxi_button = new System.Windows.Forms.Button();
            this.tongji_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manager_button
            // 
            this.manager_button.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manager_button.Location = new System.Drawing.Point(106, 155);
            this.manager_button.Name = "manager_button";
            this.manager_button.Size = new System.Drawing.Size(191, 58);
            this.manager_button.TabIndex = 0;
            this.manager_button.Text = "成绩录入";
            this.manager_button.UseVisualStyleBackColor = true;
            this.manager_button.Click += new System.EventHandler(this.manager_button_Click);
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search_button.Location = new System.Drawing.Point(106, 265);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(191, 59);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "成绩查询";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Header.Location = new System.Drawing.Point(249, 67);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(201, 26);
            this.Header.TabIndex = 2;
            this.Header.Text = "S U T 修选课成绩系统";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(584, 417);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(71, 33);
            this.quit.TabIndex = 3;
            this.quit.Text = "退出";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(584, 365);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(71, 33);
            this.logout.TabIndex = 4;
            this.logout.Text = "注销";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // fenxi_button
            // 
            this.fenxi_button.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fenxi_button.Location = new System.Drawing.Point(395, 155);
            this.fenxi_button.Name = "fenxi_button";
            this.fenxi_button.Size = new System.Drawing.Size(191, 58);
            this.fenxi_button.TabIndex = 5;
            this.fenxi_button.Text = "成绩分析";
            this.fenxi_button.UseVisualStyleBackColor = true;
            this.fenxi_button.Click += new System.EventHandler(this.fenxi_button_Click);
            // 
            // tongji_button
            // 
            this.tongji_button.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tongji_button.Location = new System.Drawing.Point(395, 266);
            this.tongji_button.Name = "tongji_button";
            this.tongji_button.Size = new System.Drawing.Size(191, 58);
            this.tongji_button.TabIndex = 6;
            this.tongji_button.Text = "选课统计";
            this.tongji_button.UseVisualStyleBackColor = true;
            this.tongji_button.Click += new System.EventHandler(this.tongji_button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.tongji_button);
            this.Controls.Add(this.fenxi_button);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.manager_button);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选修课成绩管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manager_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button fenxi_button;
        private System.Windows.Forms.Button tongji_button;


    }
}