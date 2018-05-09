using Management_Bll;
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
    public partial class Lecturer_Alter : Form
    {
        public Lecturer_Alter()
        {
            InitializeComponent();
        }

        private void Lecturer_Alter_Load(object sender, EventArgs e)
        {            
            textBox1.Text = Convert.ToString(Helper.id);
            textBox2.Text = Helper.name;
            textBox3.Text = Helper.vdate;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lecturer_Bll lb = new Lecturer_Bll();
            int i=lb.Alter_User(int.Parse(textBox1.Text), textBox2.Text);
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
