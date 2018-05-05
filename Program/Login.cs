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
    public partial class Login : Form
    {
        private int errorTime = 3;

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            errorTime = errorTime - 1;

            string username = txtName.Text.Trim();  //获取用户名
            string password = txtPwd.Text.Trim();  //获取密码
            string constr = "Database=test;Data Source=127.0.0.1;Port=3307;User Id=root;Password=jlp1996;pooling=false;CharSet=utf8;";  //设置连接字符串
            MySqlConnection mycon = new MySqlConnection();  //实例化连接对象
            mycon.ConnectionString = constr;
            mycon.Open();

            MySqlCommand mycom = new MySqlCommand();  //创建SQL命令执行对象
            string s1 = "select username , password from tb1 where username = '" + username +"' and password = '"+ password +"'";
            mycom.CommandText = s1;  //执行SQL命令
            MySqlDataAdapter myDA = new MySqlDataAdapter();  //实例化数据适配器
            
            myDA.SelectCommand = mycom;  //让适配器执行SELECT命令
            myDA.SelectCommand.Connection = mycon; //初始化
            DataSet myDS = new DataSet();  //实例化结果数据集
            int n = myDA.Fill(myDS , "tb1");  //将结果放入数据适配器 ， 返回元素个数
            if (n != 0)
            {
                MessageBox.Show("欢迎使用!");  //登录成功

                
                Main main = new Main();
                main.Show();
                this.Visible = false;
            }
            else
            {
                if (errorTime > 0)
                {
                    MessageBox.Show("用户名或密码错误, 请重新输入");
                    txtName.Text = ""; //清空输入框
                    txtPwd.Text = "";
                    txtName.Focus();  //输入光标的位置
                }
                else
                {
                    MessageBox.Show("输入错误已达三次，系统将自动退出");
                    this.Close();
                }
            }
            mycon.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            
            Register register = new Register();
            register.Show();
            this.Visible = false;
        }

    }
}
