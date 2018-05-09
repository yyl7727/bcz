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
    public partial class DCBType_Add : Form
    {
        public DCBType_Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CourseContentType cct = new CourseContentType();
                //if (textBox1.Text == null)
                //{
                //    MessageBox.Show("单词包类型ID不可为空");
                //    return;
                //}
                if (textBox2.Text == null)
                {
                    MessageBox.Show("单词包类型名称不可为空");
                    return;
                }
                else
                {
                    //cct.CCT_ID = Convert.ToInt32(textBox1.Text.Trim());
                    cct.CCT_NAME = textBox2.Text.Trim();
                    cct.CCT_DESC = textBox3.Text.Trim();
                }
                CourseContentType_Bll cctb = new CourseContentType_Bll();
                int i = cctb.AddCourseContentType(cct);
                if (i > 0)
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            catch
            {
                MessageBox.Show("添加异常");
            }
            
        }
    }
}
