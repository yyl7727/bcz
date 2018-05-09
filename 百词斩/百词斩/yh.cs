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
    public partial class yh : Form
    {
        public yh()
        {
            InitializeComponent();
        }

        private void yh_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            RepastBLL.UsersManager um = new RepastBLL.UsersManager();
            List<RepastModel.Users> u = um.us();
            foreach(RepastModel.Users uu in u)
            {
                ListViewItem tt = new ListViewItem(uu.U_id.ToString());
                tt.SubItems.Add(uu.U_name.ToString());
                tt.SubItems.Add(uu.U_password.ToString());
                listView1.Items.Add(tt);
            }
        }
    }
}
