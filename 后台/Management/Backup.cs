using Management_Dal;
using RepastHelper;
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
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLHelper.ExecuteNonQuery("BAK", CommandType.StoredProcedure, null);
            MessageBox.Show("备份成功");
        }
    }
}
