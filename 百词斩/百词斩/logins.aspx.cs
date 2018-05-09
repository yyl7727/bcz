using Management_Bll;
using Management_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 百词斩
{
    public partial class Login : System.Web.UI.Page
    {
        public static int u_id;//用户ID

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// 判断用户是否进行输入
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool IfInput(string name, string pwd)
        {
            if (name == "")
            {
                Response.Write("<script>alert('请输入用户名!');</script>");
                txt_Name.Focus();
            }
            else if (pwd == "")
            {
                Response.Write("<script>alert('请输入密码！');</script>");
                txt_psd.Focus();
            }
            else
                return true;
            return false;
        }

        Users_Bll ub = new Users_Bll();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Users u = new Users();
                u.U_NAME = txt_Name.Text.Trim();
                u.U_PASSWORD = txt_psd.Text.Trim();
                //判断用户是否进行了输入
                if (IfInput(u.U_NAME,u.U_PASSWORD))
                {
                    bool b = ub.ExistsUsers(u);
                    if (b)
                    {
                        UserCollect_Bll uc_b = new UserCollect_Bll();
                        Response.Cookies["name"].Value = txt_Name.Text.Trim();
                        Session["ID"] = ub.QueryUserID(u).ToString();
                        u_id= Convert.ToInt32(Session["ID"].ToString());
                        Session["c_id"] = uc_b.GetUserCollectUid(u_id).C_ID.ToString();//与数据库中数据进行对比
                        Response.Write("<script>alert('登录成功');</script>");
                        if (Convert.ToInt32(Session["c_id"]) == 0)
                        {
                            Response.Redirect("Plan/Select.aspx", false);
                        }
                        else
                        {
                            Response.Redirect("Recite Words/start.aspx", false);
                        }
                    }
                    else
                        Response.Write("<script>alert('登录失败');</script>");
                }
            }
            catch
            {

            }
        }

        protected void but_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}