using Management_Bll;
using Management_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 百词斩.Plan
{
    public partial class Select : System.Web.UI.Page
    {
        public static int u_id;
        public static string u_name;
        Users_Bll ub = new Users_Bll();
        protected void Page_Load(object sender, EventArgs e)
        {
            u_id = Convert.ToInt32(Session["ID"]);
            u_name=ub.GetUser(u_id).U_NAME.ToString();
            Lab_name.Text = u_name;
        }
    }
}