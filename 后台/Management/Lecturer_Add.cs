using Management_Bll;
using Management_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class Lecturer_Add : Form
    {
        public Lecturer_Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Lecturer l = new Lecturer();
                if (textBox2.Text == null)
                {
                    MessageBox.Show("请输入管理员用户名！");
                    return;
                }
                else if (textBox3.Text == null)
                {
                    MessageBox.Show("请输入管理员密码！");
                    return;
                }
                else
                {
                    //l.L_ID = Convert.ToInt32(textBox1.Text.Trim());
                    l.L_NAME = textBox2.Text.Trim();
                    l.L_PASS = textBox3.Text.Trim();
                    l.L_VDATE = DateTime.Now.ToString();
                }
                Lecturer_Bll lb = new Lecturer_Bll();
                int i=lb.Add_User(l);
                if (i > 0)
                {
                    MessageBox.Show("添加成功！");
                    Close();
                }
                else
                    MessageBox.Show("添加失败！");
            }
            catch
            {
                MessageBox.Show("出现异常,检查用户名是否重复！");
                Close();
            }
        }
    }
}
