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
using 百词斩;

namespace Management
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            this.Text = "后台管理系统";
        }

        List<CourseDetails> list_cd = new List<CourseDetails>();

        private void 添加单词包ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 添加单词
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加单词ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DC_Add word_Add = new DC_Add();
            word_Add.ShowDialog();
        }

        /// <summary>
        /// 添加单词包
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加单词包ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DCB_Add wordBag_Add = new DCB_Add();
            wordBag_Add.ShowDialog();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            timer1.Start();//动态显示时间
            CourseDetail_Bll cd_b = new CourseDetail_Bll();
            toolStripStatusLabel2.Text=cd_b.GetCount().ToString();
        }

        /// <summary>
        /// timer控制动态显示时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel5.Text = DateTime.Now.ToString();
        }

        private void toolStripStatusLabel5_DoubleClick(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 单击时间弹出备份还原窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {
            Backup bak = new Backup();
            bak.ShowDialog();
        }

        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Lecture_Management lm = new Lecture_Management();
            lm.ShowDialog();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFrm lf = new LoginFrm();
            lf.Show();
        }

        private void 添加单词包类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DCBType_Add dcbt_add = new DCBType_Add();
            dcbt_add.ShowDialog();
        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dcb_list_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 显示单词ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dc dc = new dc();
            dc.Show();
        }
    }
}
