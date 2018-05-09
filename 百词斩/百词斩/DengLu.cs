using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 百词斩
{
    public partial class DengLu : Form
    {
        public DengLu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zh = textBox1.Text;
            string mm = textBox2.Text;
            RepastModel.Users u = new RepastModel.Users();
            u.U_name = zh;
            u.U_password = mm;
            

            RepastBLL.wordsManager w = new RepastBLL.wordsManager();
             bool b = w.login(u);
            if (b)
            {
                MessageBox.Show("登录成功");
                Main m = new Main();
                m.Show();

            }
            else
                MessageBox.Show("登录失败");
        }
    }
}
