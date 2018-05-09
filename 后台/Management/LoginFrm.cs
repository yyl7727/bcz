using System.Windows.Forms;
using Management_Bll;
using Management_Model;

namespace Management
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 判断用户是否输入
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool IfInput(string name, string pwd)
        {
            if (name == "")
            {
                MessageBox.Show("请输入用户名");
                comboBox1.Focus();
            }
            else if (pwd == "")
            {
                MessageBox.Show("请输入密码:");
                textBox2.Focus();
            }
            else
                return true;
            return false;
        }
        Lecturer_Bll ub = new Lecturer_Bll();

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                Lecturer u = new Lecturer();
                u.L_NAME = this.comboBox1.Text.Trim();
                u.L_PASS = this.textBox2.Text.Trim();
                //判断用户是否进行了输入
                if (IfInput(u.L_NAME, u.L_PASS))
                {
                    bool b = ub.ExistsUsers(u);
                    if (b)
                    {
                        MainFrm main = new MainFrm();
                        Helper.L_NAME = comboBox1.Text;
                        main.Show();
                        this.Visible = false;
                    }
                    else
                        MessageBox.Show("登陆失败");
                }
            }
            catch
            {

            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginFrm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
