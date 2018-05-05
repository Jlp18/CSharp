using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using MySql.Data.MySqlClient;

namespace Login
{
    public partial class grade_management : Form
    {
        private string id;  //课程编号
        public grade_management()
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

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "DataBase = test; Data Source = 127.0.0.1;Port = 3307;User Id=root;Password=jlp1996;pooling=false;CharSet=utf8;";
            MySqlConnection mycon = new MySqlConnection();
            mycon.ConnectionString = constr;
            mycon.Open();

            //查询数据
            string get_subject_id = "select subject_id from subject where subject_name = '"+ comboBox1.Text +"' ";
            MySqlCommand mycom = new MySqlCommand();
            mycom.CommandText = get_subject_id;
            MySqlDataAdapter myDA = new MySqlDataAdapter();
            myDA.SelectCommand = mycom;
            myDA.SelectCommand.Connection = mycon;
            DataSet myDS = new DataSet();
            int a = myDA.Fill(myDS);
            if (a > 0)  //查询到结果
            {
                id = myDS.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("没有该门课程\n请重新选择");
                this.comboBox1.Text = "";  //清除内容
                comboBox1.Focus();  //聚焦comboBox1
            }
            
            //录入数据
            for(int i = 0 ; i < dataGridView1.RowCount-1 ; i++)
            {
                string s_score = "insert into score (subject_id,subject_name,student_id,student_name,student_class,score) values ('"+id+"','"+comboBox1.Text.Trim().ToString()+"','"+dataGridView1.Rows[i].Cells[0].Value+"','"+dataGridView1.Rows[i].Cells[1].Value+"','"+dataGridView1.Rows[i].Cells[2].Value+"','"+dataGridView1.Rows[i].Cells[3].Value+"')";
                mycom.CommandText = s_score;
                mycom.ExecuteNonQuery();   //执行语句
            }
            mycon.Close();   //关闭连接
            mycon.Dispose();  //??释放对象
            int count = this.dataGridView1.RowCount - 1;

            MessageBox.Show("录入成功\n已录入成绩"+ count +"人");
            dataGridView1.Rows.Clear(); //初始化dataGridView控件
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
