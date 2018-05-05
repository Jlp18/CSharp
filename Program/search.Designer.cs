namespace Login
{
    partial class search
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
            this.studentId_label = new System.Windows.Forms.Label();
            this.studentClass_label = new System.Windows.Forms.Label();
            this.studentId_textBox = new System.Windows.Forms.TextBox();
            this.studentClass_textBox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentId_label
            // 
            this.studentId_label.AutoSize = true;
            this.studentId_label.Location = new System.Drawing.Point(31, 13);
            this.studentId_label.Name = "studentId_label";
            this.studentId_label.Padding = new System.Windows.Forms.Padding(2);
            this.studentId_label.Size = new System.Drawing.Size(69, 16);
            this.studentId_label.TabIndex = 0;
            this.studentId_label.Text = "请输入学号";
            this.studentId_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentClass_label
            // 
            this.studentClass_label.AutoSize = true;
            this.studentClass_label.Location = new System.Drawing.Point(67, 55);
            this.studentClass_label.Name = "studentClass_label";
            this.studentClass_label.Padding = new System.Windows.Forms.Padding(2);
            this.studentClass_label.Size = new System.Drawing.Size(33, 16);
            this.studentClass_label.TabIndex = 2;
            this.studentClass_label.Text = "班级";
            this.studentClass_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentId_textBox
            // 
            this.studentId_textBox.Location = new System.Drawing.Point(116, 12);
            this.studentId_textBox.Name = "studentId_textBox";
            this.studentId_textBox.Size = new System.Drawing.Size(109, 21);
            this.studentId_textBox.TabIndex = 4;
            // 
            // studentClass_textBox
            // 
            this.studentClass_textBox.Location = new System.Drawing.Point(116, 50);
            this.studentClass_textBox.Name = "studentClass_textBox";
            this.studentClass_textBox.Size = new System.Drawing.Size(109, 21);
            this.studentClass_textBox.TabIndex = 6;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(269, 13);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(73, 58);
            this.search_button.TabIndex = 7;
            this.search_button.Text = "成绩查询";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentName,
            this.subjectId,
            this.subjectName,
            this.score});
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(460, 273);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // studentName
            // 
            this.studentName.HeaderText = "姓名";
            this.studentName.Name = "studentName";
            // 
            // subjectId
            // 
            this.subjectId.HeaderText = "课程编号";
            this.subjectId.Name = "subjectId";
            this.subjectId.Width = 90;
            // 
            // subjectName
            // 
            this.subjectName.HeaderText = "课程名称";
            this.subjectName.Name = "subjectName";
            this.subjectName.Width = 130;
            // 
            // score
            // 
            this.score.HeaderText = "成绩";
            this.score.Name = "score";
            this.score.Width = 90;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(371, 13);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(73, 25);
            this.back_button.TabIndex = 9;
            this.back_button.Text = "返回";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(371, 44);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(73, 25);
            this.clear_button.TabIndex = 10;
            this.clear_button.Text = "清除";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.studentClass_textBox);
            this.Controls.Add(this.studentId_textBox);
            this.Controls.Add(this.studentClass_label);
            this.Controls.Add(this.studentId_label);
            this.Name = "search";
            this.Text = "学成成绩查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentId_label;
        private System.Windows.Forms.Label studentClass_label;
        private System.Windows.Forms.TextBox studentId_textBox;
        private System.Windows.Forms.TextBox studentClass_textBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.Button clear_button;
    }
}