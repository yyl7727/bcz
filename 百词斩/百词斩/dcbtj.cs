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
    public partial class dcbtj : Form
    {
        public dcbtj()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           dh m = new dh();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepastModel.coursecontenttype c = new RepastModel.coursecontenttype();
            c.Cct_id = int.Parse(tB1.Text);
            c.Cct_name = tB2.Text;
            c.Cct_desc = tB3.Text;
            RepastBLL.CoursecontenttypeManager cm = new RepastBLL.CoursecontenttypeManager();
            int temp = cm.adddcb(c);
            if(temp>0)
            {
                MessageBox.Show("添加成功");

            }
            if(temp<0)
            {
                MessageBox.Show("添加失败");

            }

        }
    }
}
