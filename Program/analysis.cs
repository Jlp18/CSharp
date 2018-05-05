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
    public partial class analysis : Form
    {
        public analysis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //取出select条件
            string s = this.comboBox1.Text.Trim();

            string constr = "DataBase = test; Data Source = 127.0.0.1;Port = 3307;User Id=root;Password=jlp1996;pooling=false;CharSet=utf8;";
            MySqlConnection mycon = new MySqlConnection();
            mycon.ConnectionString = constr;
            mycon.Open();

            //查询条件
            string ss = "select score from score where subject_name='"+s+"' order by score";
            MySqlCommand mycom = new MySqlCommand(ss , mycon);
            MySqlDataReader read = mycom.ExecuteReader();
            GetInfoList.student_score.Clear();
            float all = 0, pass = 0, sum = 0, lv, avg;  //前半部分变量定义

            float x9 = 0, x8 = 0, x7 = 0, x6 = 0, x0 = 0;  //后半部分变量定义
            float l9, l8, l7, l6, l0;
            while (read.Read())
            {
                GetInfoList.student_score.Add(read.GetInt32(0));
                all++;
                sum += read.GetInt32(0);
                if (read.GetInt32(0) >= 60)
                {
                    pass++;
                }
                if (read.GetInt32(0) >= 90)
                {
                    x9++;
                }
                if (read.GetInt32(0) >= 80 && read.GetInt32(0) < 90)
                {
                    x8++;
                }
                if (read.GetInt32(0) >= 70 && read.GetInt32(0) < 80)
                {
                    x7++;
                }
                if (read.GetInt32(0) >= 60 && read.GetInt32(0) < 70)
                {
                    x6++;
                }
                if (read.GetInt32(0) < 60)
                {
                    x0++;
                }
            }

            //整体情况
            this.textBox1.Text = all.ToString();
            this.textBox2.Text = pass.ToString();
            lv = pass / all * 100;
            avg = sum / all;
            this.textBox3.Text = lv.ToString("f2") + "%";
            this.textBox4.Text = avg.ToString("f3");  //保留两位小数


            //成绩分布
            //90分以上
            l9 = x9 / all * 100;
            this.textBox5.Text = x9.ToString();
            this.textBox10.Text = l9.ToString("f2") + "%";

            //80分以上
            l8 = x8 / all * 100;
            this.textBox6.Text = x8.ToString();
            this.textBox11.Text = l8.ToString("f2") + "%";

            //70分以上
            l7 = x7 / all * 100;
            this.textBox7.Text = x7.ToString();
            this.textBox12.Text = l7.ToString("f2") + "%";

            //60分以上
            l6 = x6 / all * 100;
            this.textBox8.Text = x6.ToString();
            this.textBox13.Text = l6.ToString("f2") + "%";

            //不及格
            l0 = x0 / all * 100;
            this.textBox9.Text = x0.ToString();
            this.textBox14.Text = l0.ToString("f2") + "%";


            this.textBox15.Text = GetInfoList.student_score[(int)all - 1].ToString();  //最高分
            this.textBox16.Text = GetInfoList.student_score[0].ToString();  //最低分

        }

        private void analysis_Load(object sender, EventArgs e)
        {
            this.comboBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            foreach (Control ctr in this.groupBox2.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            this.comboBox1.Text = "";
            this.comboBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
