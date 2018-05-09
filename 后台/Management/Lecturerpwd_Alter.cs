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
    public partial class Lecturerpwd_Alter : Form
    {
        public Lecturerpwd_Alter()
        {
            InitializeComponent();
        }

        Lecturer_Bll lb = new Lecturer_Bll();
        Lecturer l = new Lecturer();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == null && textBox2.Text.Trim() == null)
                    MessageBox.Show("请输入原密码！");
                if (textBox2.Text.Trim() == null)
                    MessageBox.Show("请再次输入原密码");
                if (textBox1.Text.Trim() != textBox2.Text.Trim())
                    MessageBox.Show("两次密码输入不一致,请检查后重新输入!");
                else if (textBox1.Text.Trim() == textBox2.Text.Trim())
                {

                    l.L_NAME = Helper.L_NAME;
                    l.L_PASS = textBox1.Text.Trim();
                    bool flag = lb.ExistsUsers(l);
                    if (flag)
                    {
                        button1.Enabled = false;
                        label3.Show();
                        textBox3.Show();
                        button2.Show();

                    }
                    else
                    {
                        MessageBox.Show("密码错误！");
                    }

                }
            }
            catch
            { }
        }

        private void Lecturerpwd_Alter_Load(object sender, EventArgs e)
        {
            label3.Hide();
            textBox3.Hide();
            button2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            l.L_PASS = textBox3.Text.Trim();
            int i=lb.Alterpwd_Lecturer(l);
            if (i > 0)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }
    }
}
