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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("C:\\Users\\Administrator\\Desktop\\bczno.2\\mybcz\\mybcz\\bin\\Debug\\center.jpg");
        }

        public string namea;
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
                namea = u.U_name;
                //Main m = new Main();
                //m.Show();          
                dh d = new dh();
                namea = textBox1.Text;

                d.Show();
            }
            else
                MessageBox.Show("登录失败");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
