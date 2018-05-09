using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepastModel;
using RepastBLL;

namespace 百词斩
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void dcbxx()
        {
            lv1.Items.Clear();    
            CoursecontenttypeManager cusmanager = new CoursecontenttypeManager();



            List<coursecontenttype> cc = cusmanager.dcb();  
            foreach(coursecontenttype jj in cc )
            {
                ListViewItem tt = new ListViewItem(jj.Cct_id.ToString());
               
                tt.SubItems.Add(jj.Cct_name.ToString());
                tt.SubItems.Add(jj.Cct_desc.ToString());
                lv1.Items.Add(tt);
                
            }
          
        }
      

        private void Main_Load(object sender, EventArgs e)
        {
            dcbxx();
      

     

        }
    

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lectureFm l = new lectureFm();
            l.Show();
        }

        private void lv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dcbxx();
        }

        private void button2_Click(object sender, EventArgs e)
        {



          


        }
        //添加图片
        public void  tjtp(PictureBox pb)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "请选择要插入的图片";
                    ofd.Filter= "JPG图片|*.jpg|BMP图片|*.bmp|Gif图片|*.gif";
                    ofd.InitialDirectory = Application.StartupPath + @"..\..\pic";
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
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("服务器未发现单词信息");
        }

        private void lv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dctj dc = new dctj();
            dc.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dcbtj d = new dcbtj();
            dcbxx();
            d.Show();
        }

        private void lv3_Click(object sender, EventArgs e)
        {
   
                }

        }
    }

