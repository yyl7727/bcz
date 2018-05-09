using Management_Bll;
using Management_Dal;
using Management_Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Speech.Synthesis;
using System.Threading;
using System.Web.UI;

namespace 百词斩.Recite_Words
{
    public partial class Study_Words : System.Web.UI.Page
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();//引用系统自带的发音对象
        int GetCourseID;//获取用户有计划中 单词包的ID
        int Words_ID;//用来从数据库中提出单词序号
        string Words_name;
        int xx = 0;

        CourseDetails_Dal cd_d = new CourseDetails_Dal();
        CourseDetails cd = new CourseDetails();

        static string cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ToString();
        SqlConnection conn = new SqlConnection(cnstr);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["xx"] != null)
                xx = Convert.ToInt32(Request.QueryString["xx"]);
            //进入页面后 首先加载出第一个单词的信息
            if (xx<2)
            {
                if (Session["ID"] != null)
                {
                    if (Session["c_id"] == null)
                        Session["c_id"] = 1;
                    UserCollect_Bll uc_b = new UserCollect_Bll();
                    UserCollect uc = new UserCollect();
                    uc = uc_b.GetUserCollect(Convert.ToInt32(Session["ID"]));
                    GetCourseID = uc.C_ID;
                    CourseDetail_Bll cd_b = new CourseDetail_Bll();
                    CourseDetails cd = new CourseDetails();
                    cd = cd_b.QueryCourseDetails1(GetCourseID);
                    Session["c_id"] = GetCourseID;
                    Words_ID = cd.CD_ID;
                    xx = Words_ID;
                    Session["cd_id"] = Words_ID;
                    Words_name = cd.CD_NAME;
                    Learning_Words.Text = Words_name;
                    Learning_Words_Sentence.Text = cd.CD_SENEng;
                    Pic_1.ImageUrl = "getpic1.aspx?cd_id=" + Words_ID;
                    Pic_2.ImageUrl = "getpic2.aspx?cd_id=" + Words_ID;
                    Pic_3.ImageUrl = "getpic3.aspx?cd_id=" + Words_ID;
                    Pic_4.ImageUrl = "getpic4.aspx?cd_id=" + Words_ID;
                }
            }
            else
            {
                UserCollect_Bll uc_b = new UserCollect_Bll();
                UserCollect uc = new UserCollect();
                uc = uc_b.GetUserCollect(Convert.ToInt32(Session["ID"]));
                GetCourseID = uc.C_ID;
                CourseDetail_Bll cd_b = new CourseDetail_Bll();
                CourseDetails cd = new CourseDetails();
                cd = cd_b.QueryCourseDetails1(GetCourseID, xx);
                Session["c_id"] = GetCourseID;
                Words_ID = cd.CD_ID;
                Session["cd_id"] = Words_ID;
                Words_name = cd.CD_NAME;
                Learning_Words.Text = Words_name;
                Learning_Words_Sentence.Text = cd.CD_SENEng;
                Pic_1.ImageUrl = "getpic1.aspx?cd_id=" + Words_ID;
                Pic_2.ImageUrl = "getpic2.aspx?cd_id=" + Words_ID;
                Pic_3.ImageUrl = "getpic3.aspx?cd_id=" + Words_ID;
                Pic_4.ImageUrl = "getpic4.aspx?cd_id=" + Words_ID;
            }
        }
                    //Session["fuxi"] = false;
                    //Session["xx"] = 1;
                    //xx = 1;
                    //sql = "select top 1 * from CourseDetails where cd_id not in (select cd_id from UserDownload join [Users] on UserDownload.u_id=[Users].u_id where UserDownload.c_id=" + Session["c_id"] + ")and CourseDetails.c_id=" + Session["c_id"] + "";
                    //str = ConfigurationManager.ConnectionStrings["cnstr"].ToString();
                    //conn = new SqlConnection(str);
                    //SqlCommand scmd = new SqlCommand(sql, conn);
                    //conn.Open();
                    //sdr = scmd.ExecuteReader();
                    //if (sdr.Read())
                    //{
                    //    GetCourseID = Convert.ToInt32(sdr["c_id"]);
                    //    Session["c_id"] = GetCourseID;
                    //    Words_ID = Convert.ToInt32(sdr["cd_id"]);
                    //    Session["cd_id"] = Words_ID;
                    //    Words_name = sdr["cd_name"].ToString();
                    //    Learning_Words.Text = Words_name;
                    //    Learning_Words_Sentence.Text = sdr["CD_SENEng"].ToString();
                    //    sdr.Close();
                    //    conn.Close();
                    //}
                    ////else
                    ////{
                    ////    Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('到底了，没词了，学习完成');</script>");
                    ////    Response.Redirect("../Plan/Select.aspx");
                    ////}
                    //sql = "select top 1 * from CourseDetails where cd_id not in(select cd_id from UserDownload join [users] on UserDownload.u_id=[Users].u_id where UserDownload.u_id=@u_id) and CourseDetails.c_id=" + Session["c_id"] + "";
                    //str = ConfigurationManager.ConnectionStrings["cnstr"].ToString();
                    //conn = new SqlConnection(str);
                    //conn.Open();
                    //scmd = new SqlCommand(sql, conn);
                    //scmd.Parameters.AddWithValue("@u_id", Session["ID"]);
                    //sdr = scmd.ExecuteReader();
                    ////dl_Couresdetails.DataSource = sdr;
                    ////dl_Couresdetails.DataBind();
                    //sdr.Close();
                    //conn.Close();
                
                //sql = "select u_id from [user] where u_Email=@email";
                //conn = new SqlConnection(str);
                //conn.Open();
                //cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@email", Session["Email"]);
                //GetUserID = cmd.ExecuteScalar().ToString();
                //Session["u_id"] = GetUserID;
                //conn.Close();
                //sql = "select count(*) from UserDownload join [users] on UserDownload.u_id=[Users].u_id where UserDownload.u_id=@u_id and UD_CUT= 0 and UD_Review!= @date";
                //conn = new SqlConnection(str);
                //conn.Open();
                //cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@u_id", Session["ID"]);
                //cmd.Parameters.AddWithValue("@date", DateTime.Now);
                //Has_Learn_Number.Text = cmd.ExecuteScalar().ToString();
                //conn.Close();
                //sql = "select count(*) from UserDownload join [users] on UserDownload.u_id=[Users].u_id where UserDownload.u_id=@u_id and ud_study=@date";
                //conn = new SqlConnection(str);
                //conn.Open();
                //cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@u_id", Session["ID"]);
                //cmd.Parameters.AddWithValue("@date", DateTime.Now);
                //Study_Words_EveryDay.Text = cmd.ExecuteScalar().ToString();
                //Session["xinxue"] = cmd.ExecuteScalar().ToString();
                //conn.Close();
            
            
        
        protected void Words_Prompt_Click(object sender, EventArgs e)
        {
            Session["cd_id"] = Words_ID;
            Session["CD_SENEng"] = Learning_Words_Sentence.Text;
            Session["cd_name"] = Words_name;
            Session["xx"] = xx;
            Response.Redirect("ShowTureWord.aspx");
        }

        protected void Pic_4_Click(object sender, ImageClickEventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('少侠很抱歉,你选择错误.');</script>");
            Session["cd_id"] = Words_ID;
            Session["CD_SENEng"] = Learning_Words_Sentence.Text;
            Session["cd_name"] = Words_name;
            Session["xx"] = xx;
            Response.Redirect("ShowTureWord.aspx");
        }


        protected void Pic_3_Click(object sender, ImageClickEventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('少侠很抱歉,你选择错误.');</script>");
            Session["cd_id"] = Words_ID;
            Session["CD_SENEng"] = Learning_Words_Sentence.Text;
            Session["cd_name"] = Words_name;
            Session["xx"] = xx;
            Response.Redirect("ShowTureWord.aspx");
        }

        protected void Pic_2_Click(object sender, ImageClickEventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('少侠很抱歉,你选择错误.');</script>");
            Session["cd_id"] = Words_ID;
            Session["CD_SENEng"] = Learning_Words_Sentence.Text;
            Session["cd_name"] = Words_name;
            Session["xx"] = xx;
            Response.Redirect("ShowTureWord.aspx");
        }

        protected void Pic_1_Click(object sender, ImageClickEventArgs e)
        {
            UserDownload ud = new UserDownload();
            UserDownload_Bll ud_b = new UserDownload_Bll();
            ud=ud_b.GetUserDownload(Convert.ToInt32(Session["ID"]), Convert.ToInt32(Session["c_id"]), Convert.ToInt32(Session["cd_id"]));
            if (ud.UD_ID<1)
            {
                UserDownload ud1 = new UserDownload();
                UserDownload_Bll ud_b1 = new UserDownload_Bll();
                ud1.C_ID = Convert.ToInt32(Session["c_id"]);
                ud1.CD_ID = Convert.ToInt32(Session["cd_id"]);
                ud1.U_ID = Convert.ToInt32(Session["ID"]);
                ud1.CD_IsBei = 1;
                ud1.UD_CUT = 0;
                ud1.UD_STUDY = DateTime.Now;
                ud1.UD_Review = DateTime.Now;
                ud1.UD_Data = 0;
                ud1.UD_Status = 0;
                bool i = ud_b1.AddUserDownload(ud1);
                if (i)
                {
                    xx = ud1.CD_ID + 1;
                    Response.Redirect("Study_Words.aspx?xx=" + xx + "",false);
                }
            }
        }

        protected void btn_Cut_Word_Click(object sender, EventArgs e)
        {
            string sql = "insert into userdownload values (@GetCouseID,@Words_ID,@GetUserID,0,1,@date,'1995-05-17')";
            string str = ConfigurationManager.ConnectionStrings["cnstr"].ToString();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@GetCouseID", Convert.ToInt32(Session["c_id"]));
            cmd.Parameters.AddWithValue("@Words_ID", Convert.ToInt32(Session["cd_id"]));
            cmd.Parameters.AddWithValue("@GetUserID", Convert.ToInt32(Session["u_id"]));
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString().ToString());
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
                Response.Redirect("Study_Words.aspx");
        }

        protected void SoundPlayer_Click(object sender, ImageClickEventArgs e)
        {
            ss.Speak(Learning_Words.Text);
            ss.Speak(Learning_Words_Sentence.Text);
            Response.Redirect("Study_Words.aspx?xx=" + xx + "");
        }
    }
}