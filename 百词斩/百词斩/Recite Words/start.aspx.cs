using Management_Bll;
using Management_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 百词斩.Recite_Words
{
    public partial class start : System.Web.UI.Page
    {
        public static int c_id;  //单词包ID
        public static int u_id;//用户ID
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserCollect_Bll uc_b = new UserCollect_Bll();
                Coures_Bll cb = new Coures_Bll();
                
                Button1.Attributes.Add("onmouseout", "this.src='Images/index_btn.png'");
                Button1.Attributes.Add("onmouseover", "this.src='Images/index_btn_hover.png'");

                u_id = Convert.ToInt32(Session["ID"].ToString());
                UserCollect uc = new UserCollect();
                uc = uc_b.GetUserCollect(u_id);
                c_id = uc.C_ID;
                //Response.Write("<script>alert('" + c_id + "')</script>");

                lab_view.Text = cb.GetCourse(c_id).C_NAME.ToString();
                lab_view.DataBind();//获取单词包名称

                Bind();//剩余天数

                UserDownload ud = new UserDownload();
                UserDownload_Bll ud_b = new UserDownload_Bll();
                int count = ud_b.GetCount(Convert.ToInt32(Session["ID"]), c_id);
                lab_view_finish.Text = count.ToString();
                lab_view_finish.DataBind();//完成单词数

                lab_view_number.Text = cb.GetCourse(c_id).C_vocabulary.ToString();
                lab_view_number.DataBind();//该单词包的总单词数

                DateTime now = DateTime.Now.Date;
                DateTime ts = DateTime.Parse(uc_b.GetUserCollectUid(u_id).UC_StartDay.ToString()).Date;
                TimeSpan t1 = ts.Subtract(now);//计算开始时间到结束时间天数差
                TimeSpan t2 = now.Subtract(now);//计算开始时间到结束时间天数差

                lab_xinxue.Text = "0";
                //if(t1!=t2)
                //{
                //    lab_xinxue.Text = "0";
                //}
                //else
                //{
                //    lab_xinxue.Text = Convert.ToString(Session["xinxue"].ToString());
                //}
                //获取今日新目标
                lab_view_words.Text = uc_b.GetUserCollectUid(u_id).UC_EveWord.ToString();
                lab_view_words.DataBind();//获取今日目标

                Users_Bll ub = new Users_Bll();
                Users u = new Users();
                u = ub.GetUser(Convert.ToInt32(Session["ID"]));
                Lab_name.Text = u.U_NAME;
            }
        }

        public void Bind()
        {
            UserCollect_Bll uc_b = new UserCollect_Bll();
            DateTime now = DateTime.Now.Date;
            DateTime myregistertime = DateTime.Parse(uc_b.GetUserCollectByUIDandCID(u_id,c_id).UC_EndDay.ToString()).Date;
            TimeSpan ts = myregistertime.Subtract(now);//计算开始时间到结束时间天数差
            int t1 = ts.Days;
            // int t2 =Convert.ToInt32( BCZ.BLL.UserCollectBusiness.GetUserCollectByUIDandCID(u_id,c_id).uc_Days.ToString());
            lab_view_days.Text = t1.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Study_Words.aspx",false);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Review Words/Review_Words.aspx");
        }
    }
}