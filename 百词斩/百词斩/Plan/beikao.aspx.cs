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
    public partial class beikao : System.Web.UI.Page
    {
        public static int c_id;  //单词包ID
        public static int daycount;  //每天背单词数 
        public static int u_id;//用户ID 
        public static int days;//用户完成天数
        public static string id_email;//用户邮箱  

        public static int p;//判定用户计划是否存在
        UserCollect_Bll uc_b = new UserCollect_Bll();

        protected void Page_Load(object sender, EventArgs e)
        {
            Coures_Bll cb = new Coures_Bll();
            if (!Page.IsPostBack)
            {
                dl_Customer.DataSource = cb.QueryCouresAll();
                dl_Customer.DataBind();//获取单词包名字和数量

                myRegisterTime.Attributes.Add("onfocus", "javascript:myclick()");
            }
            img_but.Attributes.Add("onmouseout", "this.src='images/set_btn.png'");
            img_but.Attributes.Add("onmouseover", "this.src='images/set_btn_hover.png'");
            u_id = Convert.ToInt32(Session["ID"].ToString());
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate > DateTime.Now.AddDays(-1.0))
            {
                myRegisterTime.Text = Calendar1.SelectedDate.ToShortDateString();

                Calendar1.Visible = false;
                Bind();
            }
            else
            {
                Calendar1.SelectedDate = DateTime.Now;
            }
        }


        public void Bind()
        {
            UserCollect_Bll uc_b=new UserCollect_Bll();
            Coures_Bll cb = new Coures_Bll();
            DateTime now = DateTime.Now.Date;

            DateTime myregistertime = DateTime.Parse(myRegisterTime.Text.Trim()).Date;
            TimeSpan ts = myregistertime.Subtract(now);//计算开始时间到结束时间天数差
            days = ts.Days;
            daycount = Convert.ToInt32(uc_b.GetUserCollectByUIDandCID(u_id, c_id).UC_EveWord.ToString());
            if (days > 0)
            {
                daycount = Convert.ToInt32(cb.GetCourse(c_id).C_vocabulary.ToString()) / days;
            }
            lab_words.Text = daycount.ToString();//总单词数除以天数得到每天单词数
        }

        protected void img_but_Click(object sender, ImageClickEventArgs e)
        {

            UserCollect_Bll uc_b = new UserCollect_Bll();
            UserDownload_Bll ud_d = new UserDownload_Bll();
            if (dl_Customer.SelectedIndex!= null)
            {
                p = Convert.ToInt32(uc_b.GetUserCollectByUID(u_id).UC_ID.ToString());
                if (p > 0)
                {
                    //修改计划
                    UserCollect updatuc = new UserCollect();
                    updatuc.U_ID = u_id;
                    updatuc.C_ID = c_id;
                    updatuc.UC_StartDay = DateTime.Now;
                    updatuc.UC_EndDay = Convert.ToDateTime(myRegisterTime.Text);
                    updatuc.UC_ComDay = Convert.ToInt32(days);
                    updatuc.UC_EveWord = daycount;
                    //Response.Write("<script>alert('" + p + "')</script>");
                    bool flag=uc_b.ModifyUserCollectbyuid(updatuc);
                    if (flag)
                    {
                        Response.Write("<script>alert('修改计划成功')</script>");

                        #region 
                        //向动态表添加用户动态数据
                        UserDownload ud = new UserDownload();
                        
                        //if (BCZ.BLL.UserNewsBusiness.AddUserNews(usernews))
                        //{
                        //}
                        #endregion

                        Session["c_id"] = c_id;//获取单词包id用于传值
                        Response.Write("<script>window.top.location='../Recite Words/start.aspx'</script>");

                    }
                    else
                    {
                        Response.Write("<script>alert('修改计划不成功')</script>");
                    }
                }
                else
                {
                    
                    //添加计划
                    UserCollect adduc = new UserCollect();

                    adduc.U_ID = u_id;
                    adduc.C_ID = c_id;
                    adduc.UC_StartDay = DateTime.Now;
                    adduc.UC_EndDay = Convert.ToDateTime(myRegisterTime.Text);
                    adduc.UC_ComDay = Convert.ToInt32(days);
                    adduc.UC_EveWord = daycount;

                    if (uc_b.AddUserCollect(adduc))
                    {
                        Response.Write("<script>alert('添加计划成功')</script>");

                        #region
                        //向用户进度表添加数据
                        //UserDownload ud = new UserDownload();
                        //ud.
                        //string str = "今天我添加了" + BCZ.BLL.CourseBusiness.GetCourse(c_id).c_Name + "的计划";
                        //usernews.un_Content = str;
                        //usernews.un_PublishTime = DateTime.Now.ToString();
                        //usernews.u_Id = u_id;
                        //if (BCZ.BLL.UserNewsBusiness.AddUserNews(usernews))
                        //{
                        //}
                        #endregion

                        Session["c_id"] = c_id;//获取单词包id用于传值
                        //Response.Redirect("../Recite Words/start.aspx", true);
                        Response.Write("<script>window.top.location='../Recite Words/start.aspx'</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('添加计划不成功')</script>");
                    }
                }
            }
        }

        protected void dl_Customer_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Coures_Bll cb = new Coures_Bll();
            c_id = int.Parse(e.Item.ItemIndex.ToString())+1;

            lab_words.Text = cb.GetCourse(c_id).C_vocabulary.ToString();
            lab_words.DataBind();

            //myRegisterTime.Text = uc_b.GetUserCollectByUIDandCID(u_id, c_id).UC_EndDay.ToString();
            //myRegisterTime.DataBind();
        }
    }
}