using Management_Bll;
using Management_Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 百词斩
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_zc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_apsd.Text.Trim() == txt_psd.Text.Trim())
                {
                    Users u = new Users();
                    u.U_NAME = txt_Name.Text.Trim();
                    u.U_PASSWORD = txt_psd.Text.Trim();
                    u.U_REGISTERTIME = DateTime.Now.ToString();
                    u.U_IMG = null;
                    u.U_EMAIL = null;

                    Users_Bll ub = new Users_Bll();
                    int i = ub.Add_User(u);
                    if (i > 0)
                    {
                        Response.Redirect("logins.aspx", false);
                        Response.Write("<script>alert('注册成功');</script>");
                    }
                    else
                        Response.Write("<script>alert('注册失败');</script>");
                }
                else
                    Response.Write("<script>alert('密码输入不一致请检查后重新输入！');</script>");
            }
            catch
            {
                Response.Write("<script>alert('注册失败，已存在的用户名');</script>");
            }
        }

        protected void but_Click(object sender, EventArgs e)
        {
            Response.Redirect("logins.aspx", false);
        }
    }
} 