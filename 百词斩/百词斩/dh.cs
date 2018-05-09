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
    public partial class dh : Form
    {
        public dh()
        {
            InitializeComponent();
        }

 
        private void dh_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            Login l = new Login();
            tsl2.Text = "czh";

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.tsl1.Text = System.DateTime.Now.ToString();
           
        }

        private void 点击查看单词ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dc c = new dc();
            c.Show();
        }

        private void 点击进入管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lectureFm l = new lectureFm();
            l.Show();
        }

        private void 点击查看单词包ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
        }

        private void 点击查看用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yh y = new yh();
            y.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                 string name = textBox1.Text.Trim();

           
                RepastBLL.wordsManager wm = new RepastBLL.wordsManager();
                RepastModel.Coursedetails c = wm.byname(name);
                lbid.Text = c.Cd_id.ToString();
                lbname.Text = c.Cd_name.ToString();
                lbmean.Text = c.Cd_mean.ToString();
                lbsentence.Text = c.Cd_sentence.ToString();
            
        
                
            }
         }         
      }

        
 
