using Management;
using Management_Bll;
using Management_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public Image GetPicture(object o)
        {
            byte[] imageByte = (byte[])o;
            //将图片字节数组加载入到缓冲流
            MemoryStream imageStream = new MemoryStream(imageByte);
            //从缓冲流生成图片
            Image imageResulet = Image.FromStream(imageStream, true);
            //pictureBox是一个显示图片或者视频的C#控件

            return imageResulet;
        }

        //显示单词的方法
        public void CourseDetails_Show()
        {
            Lv1.Items.Clear();
            CourseDetail_Bll cb = new CourseDetail_Bll();
            List<CourseDetails> c = new List<CourseDetails>();
            c = cb.GetAll();
            foreach (CourseDetails cc in c)
            {
                ListViewItem tt = new ListViewItem(cc.CD_ID.ToString());
                Image im = GetPicture(cc.CD_RIGHT_PIC);
                Image im2 = GetPicture(cc.CD_WRONG_PIC1);
                Image im3 = GetPicture(cc.CD_WRONG_PIC2);
                Image im4 = GetPicture(cc.CD_WRONG_PIC3);
                Lv1.SmallImageList = imageList1;

                this.imageList1.Images.Add(im);
                this.imageList1.Images.Add(im2);
                this.imageList1.Images.Add(im3);
                this.imageList1.Images.Add(im4);

                tt.SubItems.Add(cc.CD_NAME.ToString());
                tt.SubItems.Add(cc.CD_YINBIAO.ToString());
                tt.SubItems.Add(cc.CD_Mean.ToString());
                tt.SubItems.Add(cc.CD_SENEng.ToString());
                

                Lv1.Items.Add(tt);                
            }
        }
        private void dc_Load(object sender, EventArgs e)
        {
            CourseDetails_Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //显示图片
        private void Lv1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Lv1.SelectedItems[0].Text);
            //RepastBLL.wordsManager w = new RepastBLL.wordsManager();
            CourseDetail_Bll cb = new CourseDetail_Bll();
            //RepastModel.Coursedetails ccc = w.picbyid(id);
            CourseDetails c = new CourseDetails();
            c = cb.GetPicById(id);
            Image pic1 = GetPicture(c.CD_RIGHT_PIC);
            Image pic2 = GetPicture(c.CD_WRONG_PIC1);
            Image pic3 = GetPicture(c.CD_WRONG_PIC2);
            Image pic4 = GetPicture(c.CD_WRONG_PIC3);
            pictureBox1.Image = pic1;
            pictureBox2.Image = pic2;
            pictureBox3.Image = pic3;
            pictureBox4.Image = pic4;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DC_Add da = new DC_Add();
            da.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CourseDetails_Show();
            MessageBox.Show("刷新成功");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32(Lv1.SelectedItems[0].Text);
            CourseDetail_Bll cb = new CourseDetail_Bll();
            int d = cb.DeleteByid(id);
            if (d > 0)
            {
                MessageBox.Show("删除成功");
                CourseDetails_Show();

            }
            else
                MessageBox.Show("删除失败");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
