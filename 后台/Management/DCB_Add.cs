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
using Management_Bll;

namespace Management
{
    public partial class DCB_Add : Form
    {
        public DCB_Add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DCB_Add_Load(object sender, EventArgs e)
        {
            CourseContentType_Bll cct_b = new CourseContentType_Bll();
            List<CourseContentType> c = cct_b.QueryCourseContentTypeAll();
            comboBox1.DataSource = c;
            comboBox1.DisplayMember = "CCT_NAME";
            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Coures c = new Coures();
                if (textBox3.Text == null)
                {
                    MessageBox.Show("单词包名称不能为空");
                    return;
                }
                else if (textBox4.Text == null)
                {
                    MessageBox.Show("单词本英语个数不能为空");
                    return;
                }
                else
                {
                    CourseContentType cct = new CourseContentType();
                    cct.CCT_NAME = comboBox1.Text.Trim();
                    CourseContentType_Bll cct_b = new CourseContentType_Bll();
                    int id=Convert.ToInt32(cct_b.QueryCourseContTypeID(cct));
                    c.C_NAME = textBox3.Text.Trim();
                    c.CCT_ID = id;
                    c.C_vocabulary = Convert.ToInt32(textBox4.Text.ToString());
                    c.C_RELEASEDATE = DateTime.Now.ToString();
                }
                Coures_Bll cb = new Coures_Bll();
                int i = cb.AddCourses(c);
                if (i > 0)
                    MessageBox.Show("添加成功！");
                else
                    MessageBox.Show("添加失败！");
            }
            catch
            {
                MessageBox.Show("出现异常");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
