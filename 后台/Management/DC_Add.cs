using Management_Bll;
using Management_Dal;
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

namespace Management
{
    public partial class DC_Add : Form
    {
        CourseDetails cd = new CourseDetails();
        public DC_Add()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 将图片转化为2进制保存
        /// </summary>
        /// <param name="op"></param>
        /// <returns></returns>
        public byte[] GetPictureByte(OpenFileDialog op)
        {
            string path = op.FileName.ToString();
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            //通过FileStream对象实例化BinaryReader对象
            BinaryReader br = new BinaryReader(fs);
            //通过BinaryReader类对象的ReadBytes()方法将FileStream类对象转化为二进制数组
            byte[] imgBytesIn = br.ReadBytes(Convert.ToInt32(fs.Length));
            //将图片二进制数组返回
            return imgBytesIn;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        /// <summary>
        /// 添加单词正确图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(op.FileName);
                cd.CD_RIGHT_PIC = GetPictureByte(op);
            }
            this.pictureBox1.ImageLocation = op.FileName;
        }

        /// <summary>
        /// 添加单词音频
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = "E:/百词斩项目/百词斩/百词斩/WordsInformation";
            of.Filter = "All files (*.*)|*.*|mp3 files (*.mp3)|*.mp3";
            if (of.ShowDialog() == DialogResult.OK)
            {
                textBox7.Text = of.FileName;
            }
        }

        private void DC_Add_Load(object sender, EventArgs e)
        {
            Coures_Dal cd = new Coures_Dal();
            List<Coures> lc = new List<Coures>();
            comboBox1.DataSource = cd.QueryCouresAll();
            comboBox1.DisplayMember = "C_NAME";
            comboBox1.Text = "请选择单词包类型";
            
        }

        private void DC_Add_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("新增单词");
        }

        /// <summary>
        /// 添加单词错误图片1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.Image = Image.FromFile(op.FileName);
                cd.CD_WRONG_PIC1 = GetPictureByte(op);
            }
            this.pictureBox2.ImageLocation = op.FileName;
        }

        /// <summary>
        /// 添加错误图片2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox3.Image = Image.FromFile(op.FileName);
                cd.CD_WRONG_PIC2 = GetPictureByte(op);
            }
            this.pictureBox3.ImageLocation = op.FileName;
        }

        /// <summary>
        /// 添加错误图片3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox4.Image = Image.FromFile(op.FileName);
                cd.CD_WRONG_PIC3 = GetPictureByte(op);
            }
            this.pictureBox4.ImageLocation = op.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == null)
                {
                    MessageBox.Show("单词包类型不为空");
                    return;
                }
                if (textBox2.Text == null)
                {
                    MessageBox.Show("单词名称不可为空");
                    return;
                }
                if (textBox3.Text == null)
                {
                    MessageBox.Show("单词音标不可为空");
                    return;
                }
                if (textBox4.Text == null)
                {
                    MessageBox.Show("单词释义不可为空");
                    return;
                }
                if (textBox5.Text == null)
                {
                    MessageBox.Show("英文例句不可为空");
                    return;
                }
                if (textBox6.Text == null)
                {
                    MessageBox.Show("中文例句不可为空");
                    return;
                }
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("请选择单词正确图片");
                    return;
                }
                if (pictureBox2.Image == null)
                {
                    MessageBox.Show("请选择单词错误图片1");
                    return;
                }
                if (pictureBox3.Image == null)
                {
                    MessageBox.Show("请选择单词错误图片2");
                    return;
                }
                if (pictureBox4.Image == null)
                {
                    MessageBox.Show("请选择单词错误图片3");
                    return;
                }
                else
                {
                    Coures c = new Coures();
                    c.C_NAME = comboBox1.Text.Trim();
                    Coures_Bll cb = new Coures_Bll();
                    int id = Convert.ToInt32(cb.QueryCouresID(c));
                    cd.C_ID = id;
                    cd.CD_NAME = textBox2.Text.Trim();
                    cd.CD_YINBIAO = textBox3.Text.Trim();
                    cd.CD_Mean = textBox4.Text.Trim();
                    cd.CD_SENEng = textBox5.Text.Trim();
                    cd.CD_SENChi = textBox6.Text.Trim();
                    cd.CD_VIDEO = textBox7.Text.Trim();
                }
                CourseDetail_Bll cdb = new CourseDetail_Bll();
                int i = cdb.AddCoursesDetails(cd);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
