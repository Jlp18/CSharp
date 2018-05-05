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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            //检查用户是否存在
            string userName = Username.Text.Trim();
            /**
             * 连接数据库
             */
            string constr = "DataBase = test; Data Source = 127.0.0.1;Port = 3307;User Id=root;Password=jlp1996;pooling=false;CharSet=utf8;";
            MySqlConnection mycon = new MySqlConnection();
            mycon.ConnectionString = constr;
            mycon.Open();  //打开数据库


            //查询用户是否存在
            MySqlCommand checkCommand = mycon.CreateCommand();
            string s2 = "select username from tb1 where username = '"+ userName +"'";
            checkCommand.CommandText = s2;
            MySqlDataAdapter check = new MySqlDataAdapter();
            check.SelectCommand = checkCommand; 
            check.SelectCommand.Connection = mycon;  //初始化
            DataSet checkData = new DataSet();
            int n = check.Fill(checkData , "tb1");
            if (n != 0)
            {
                MessageBox.Show("此用户名已存在");
                Username.Text = "";  //清空输入文本框
                Password.Text = "";
                RePassword.Text = "";
            }
            else if (Username.Text == "" || Password.Text == "" || RePassword.Text == "")
            {
                MessageBox.Show("请将信息填写完整");
                Username.Focus();
            }
            else if (RePassword.Text != Password.Text)
            {
                MessageBox.Show("密码不一致");
                Password.Text = ""; //清空输入框
                RePassword.Text = "";
            }
            else
            {
                //注册成功，上传数据
                string s3 = "insert into tb1 (username , password) values ('" + Username.Text + "' , '" + Password.Text + "')";
                MySqlCommand mycom = new MySqlCommand(s3, mycon);
                mycom.ExecuteNonQuery();   //执行语句
                mycon.Close();   //关闭连接
                mycom = null;
                mycon.Dispose();  //??释放对象

                MessageBox.Show("注册成功");
                this.Close();
                Login lg = new Login();
                lg.ShowDialog();
            }

            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Visible = false;
        }

    }
}
