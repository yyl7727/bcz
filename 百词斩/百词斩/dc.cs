using RepastBLL;
using RepastModel;
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
    public partial class dc : Form
    {
        public dc()
        {
            InitializeComponent();
        }
        //显示单词的方法
        public void dcx()
        {
            Lv1.Items.Clear();
            wordsManager wd = new wordsManager();
            List<Coursedetails> c = wd.wor();
            foreach (Coursedetails cc in c)
            {
             ListViewItem tt = new ListViewItem(cc.C_id.ToString());
                string im = cc.Cd_right_pic.ToString();
                string im2 = cc.Cd_wrong_pic1.ToString();
                string im3 = cc.Cd_wrong_pic2.ToString();
                string im4 = cc.Cd_wrong_pic3.ToString();
                Lv1.SmallImageList = imageList1;

                this.imageList1.Images.Add(Image.FromFile(im));
                this.imageList1.Images.Add(Image.FromFile(im2));
                this.imageList1.Images.Add(Image.FromFile(im3));
                this.imageList1.Images.Add(Image.FromFile(im4));

                tt.SubItems.Add(cc.Cd_name.ToString());
                tt.SubItems.Add(cc.Cd_yinbiao.ToString());
                tt.SubItems.Add(cc.Cd_mean.ToString());
                tt.SubItems.Add(cc.Cd_sentence.ToString());
                

                Lv1.Items.Add(tt);
         
                //    pictureBox1.Image = Image.FromFile(im);
                //    pictureBox2.Image = Image.FromFile(im2);
                //    pictureBox3.Image = Image.FromFile(im3);
                //    pictureBox4.Image = Image.FromFile(im4);
                //    lv3.Items.Add(tt);
                //}

          
               
            }
        }
        private void dc_Load(object sender, EventArgs e)
        {

            dcx();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //显示图片
        private void Lv1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Lv1.SelectedItems[0].Text);
            RepastBLL.wordsManager w = new RepastBLL.wordsManager();

            RepastModel.Coursedetails ccc = w.picbyid(id);
             
                string pic1 = ccc.Cd_right_pic.ToString();
                string pic2 = ccc.Cd_wrong_pic1.ToString();
                string pic3 = ccc.Cd_wrong_pic2.ToString();
                string pic4 = ccc.Cd_wrong_pic3.ToString();
                pictureBox1.Image = Image.FromFile(pic1);
                pictureBox2.Image = Image.FromFile(pic2);
                pictureBox3.Image = Image.FromFile(pic3);
                pictureBox4.Image = Image.FromFile(pic4);
         
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dctj ddd = new dctj();
            ddd.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dh daohang = new dh();
            daohang.Show();
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            dcx();
            MessageBox.Show("刷新成功");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32( Lv1.SelectedItems[0].Text);
            RepastBLL.wordsManager wm = new RepastBLL.wordsManager();
            int d = wm.deletebyid(id);
            if (d > 0)
            {
                MessageBox.Show("删除成功");
                dcx();

            }
            else
                MessageBox.Show("删除失败");
        }
    }
}
