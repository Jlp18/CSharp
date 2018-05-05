using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }


        //序号自动递增
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                dataGridView1.RowHeadersWidth - 4,
                e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
            dataGridView1.RowHeadersDefaultCellStyle.Font,
            rectangle,
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor,
            TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            //取出查询的条件
            string ID = this.studentId_textBox.Text.Trim();
            string CLASS = this.studentClass_textBox.Text.Trim();

            //连接数据库
            string constr = "DataBase = test; Data Source = 127.0.0.1;Port = 3307;User Id=root;Password=jlp1996;pooling=false;CharSet=utf8;";
            MySqlConnection mycon = new MySqlConnection();
            mycon.ConnectionString = constr;
            mycon.Open();

            MySqlCommand cmd = new MySqlCommand();
            string s = "select student_name,subject_id,subject_name,score from score where student_id='"+ID+"'or student_class='"+CLASS+"'";
            cmd.CommandText = s;
            cmd.Connection = mycon;
            MySqlDataReader rec = cmd.ExecuteReader();
            //数据存储容器初始化
            GetInfoList.student_name.Clear();
            GetInfoList.subject_id.Clear();
            GetInfoList.subject_name.Clear();
            GetInfoList.student_score.Clear();
            int a = 0;  //计算成绩信息条数
            while (rec.Read())
            {
                GetInfoList.student_name.Add(rec.GetString(0)); //将学生姓名存储到容器
                GetInfoList.subject_id.Add(rec.GetString(1));  //将课程编号存储到容器
                GetInfoList.subject_name.Add(rec.GetString(2));  //将课程名称存储到容器
                GetInfoList.student_score.Add(rec.GetString(3));  //将成绩信息存储到容器
                a++;
            }
            for (int i = 0; i < GetInfoList.student_name.Count; i++)
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = GetInfoList.student_name[i];
                this.dataGridView1.Rows[index].Cells[1].Value = GetInfoList.subject_id[i];
                this.dataGridView1.Rows[index].Cells[2].Value = GetInfoList.subject_name[i];
                this.dataGridView1.Rows[index].Cells[3].Value = GetInfoList.student_score[i];
            }

            MessageBox.Show("查询到"+a+"条数据 ");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            this.studentId_textBox.Text = "";
            this.studentClass_textBox.Text = "";
            this.studentId_textBox.Focus();
        }
    }
}
