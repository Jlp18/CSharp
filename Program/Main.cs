using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void quit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("是否退出本系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }

        }

        private void manager_button_Click(object sender, EventArgs e)
        {
            grade_management gm = new grade_management();
            gm.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Visible = false;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            search newsearch = new search();
            newsearch.ShowDialog();
        }

        private void Main_close(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出本系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void fenxi_button_Click(object sender, EventArgs e)
        {
            analysis anls = new analysis();
            anls.ShowDialog();
        }

        private void tongji_button_Click(object sender, EventArgs e)
        {
            statistics stat = new statistics();
            stat.ShowDialog();
        }





    }
}
