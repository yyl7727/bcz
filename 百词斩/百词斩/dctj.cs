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
    public partial class dctj : Form
    {
        public dctj()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                tjtp(this.pictureBox4);
            }
            catch (Exception) { }
        }
        public void tjtp(PictureBox pb)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "请选择图片";
                    ofd.Filter = "JPG图片|*.jpg|BMP图片|*.bmp|Gif图片|*.gif";
                    ofd.InitialDirectory = Application.StartupPath + @"..\..\Image";
                    ofd.CheckFileExists = true;
                    ofd.CheckPathExists = true;
                    ofd.Multiselect = false;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pb.ImageLocation = ofd.FileName;  //PictureBox      

                    }
                    else
                    {
                        MessageBox.Show("你没有选择图片", "信息提示");
                    }
                }
            }
            catch (Exception) { }
        }
     
        
   
        private void button1_Click(object sender, EventArgs e)
        {
       
            try
            {


                RepastModel.Coursedetails cd = new RepastModel.Coursedetails();
                RepastBLL.wordsManager wm = new RepastBLL.wordsManager();
                cd.Cd_id = int.Parse(textBox1.Text);
                cd.C_id = int.Parse(tB1.Text);
                cd.Cd_name = tB2.Text;
                cd.Cd_yinbiao = tB3.Text;
                cd.Cd_mean = tB4.Text;
                cd.Cd_sentence = textBox2.Text;

                cd.Cd_right_pic = pictureBox1.ImageLocation;
                cd.Cd_wrong_pic1 = pictureBox2.ImageLocation;
                cd.Cd_wrong_pic2 = pictureBox3.ImageLocation;
                cd.Cd_wrong_pic3 = pictureBox4.ImageLocation;
                int num = wm.InsertCouresDetails(cd);

                if (num > 0)
                {
                    MessageBox.Show("添加单词成功！！！");

           

                    //GuanLiMain gl = new GuanLiMain();
                    //gl.DanCiInitialze();
                    this.Close();
                    dc d = new dc();
                    d.dcx();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                tjtp(this.pictureBox1);
            }
            catch (Exception) { }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                tjtp(this.pictureBox2);
            }
            catch (Exception) { }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                tjtp(this.pictureBox3);
            }
            catch (Exception) { }
        }

        private void tB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dctj_Load(object sender, EventArgs e)
        {

        }
    }
}
