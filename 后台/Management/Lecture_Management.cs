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
    public partial class Lecture_Management : Form
    {
        public Lecture_Management()
        {
            InitializeComponent();
        }

        List<Lecturer> lecture_List = new List<Lecturer>();

        /// <summary>
        /// 显示会员信息
        /// </summary>
        public void GetLecture()//完成
        {
            listView1.Items.Clear();
            Lecturer_Bll lb = new Lecturer_Bll();
            lecture_List = lb.All_Lecturer();
            foreach (Lecturer l in lecture_List)
            {
                ListViewItem lvi = new ListViewItem(l.L_ID.ToString());
                lvi.SubItems.Add(l.L_VDATE.ToString());
                lvi.SubItems.Add(l.L_NAME.ToString());
                listView1.Items.Add(lvi);
            }
        }

        /// <summary>
        /// 增加管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)//完成
        {
            Lecturer_Add ld = new Lecturer_Add();
            ld.ShowDialog();
        }

        /// <summary>
        /// 删除管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("确定要执行删除操作", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                        Lecturer_Bll lb = new Lecturer_Bll();
                        int temp = lb.Delete_User(id);
                        if (temp > 0)
                        {
                            MessageBox.Show("删除成功！");
                            GetLecture();
                        }
                        else
                            MessageBox.Show("删除成功！");
                    }
                }
                else
                    MessageBox.Show("请选择要删除的对象！");
            }
            catch
            {
                MessageBox.Show("删除出现异常！");
            }
        }

        private void Lecture_Management_Load(object sender, EventArgs e)
        {
            GetLecture();
            toolStripMenuItem2.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// 修改管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count==1)
                {
                    Helper.id = int.Parse(listView1.FocusedItem.SubItems[0].Text);
                    Helper.vdate = listView1.FocusedItem.SubItems[1].Text;
                    Helper.name = listView1.FocusedItem.SubItems[2].Text;
                }
                
            }
            catch
            {
                MessageBox.Show("出现异常！");
            }
            
            Lecturer_Alter la = new Lecturer_Alter();
            la.ShowDialog();
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lecturerpwd_Alter pwd = new Lecturerpwd_Alter();
            pwd.ShowDialog();
        }

        /// <summary>
        /// 刷新显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem5_Click(object sender, EventArgs e)//完成
        {
            listView1.Items.Clear();
            GetLecture();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            Lecturer_Bll lb = new Lecturer_Bll();
            //lb.QueryAdminID();
            toolStripMenuItem2.Enabled = true;
        }
    }
}
