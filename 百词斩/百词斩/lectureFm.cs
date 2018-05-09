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
    public partial class lectureFm : Form
    {
        public lectureFm()
        {
            InitializeComponent();
        }
        public void showhy()
        {
            lv1.Items.Clear();
            RepastBLL.lecturerManager lectum = new RepastBLL.lecturerManager();
            List<RepastModel.lecturer> lec = lectum.lect();

            foreach (RepastModel.lecturer ll in lec)
            {
                ListViewItem lv = new ListViewItem(ll.l_id.ToString());
                lv.SubItems.Add(ll.L_vdate);
                lv.SubItems.Add(ll.L_name);
                lv.SubItems.Add(ll.L_pass);
                lv1.Items.Add(lv);
            }
        }
        private void lecture_Load(object sender, EventArgs e)
        {

            showhy();

            }

        private void button1_Click(object sender, EventArgs e)
        {
            #region
            if (tB1.Text == "")
            {
                MessageBox.Show("请输入会员的id");
                return;
            }
            if(tB2.Text=="")
            {
                MessageBox.Show("请输入日期");
                return;
            }
            if(tB3.Text=="")
            {
                MessageBox.Show("请输入账号");
                return;
            }
            if(tB4.Text=="")
            {
                MessageBox.Show("请输入密码");
                return;
            }
            #endregion
            RepastModel.lecturer l = new RepastModel.lecturer();
            l.l_id = int.Parse(tB1.Text);
            l.L_vdate = tB2.Text.ToString();
            l.L_name = tB3.Text.ToString();
            l.L_pass = tB4.Text.ToString();

            RepastBLL.lecturerManager lecma = new RepastBLL.lecturerManager();
            int temp = lecma.addlec(l);
            if(temp>0)
            {
                MessageBox.Show("添加成功");
                showhy();
            }
            else
            {
                MessageBox.Show("添加失败");
                return;
            }

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lv1.SelectedItems[0].Text.ToString());
            RepastBLL.lecturerManager le = new RepastBLL.lecturerManager();
            int d = le.deletebyid(id);
            if (d > 0)
            {
                MessageBox.Show("删除成功");
                showhy();
            }
            else
                MessageBox.Show("删除失败");

        }
    }
    }

