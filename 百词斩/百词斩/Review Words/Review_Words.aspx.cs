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

namespace 百词斩.Review_Words
{
    public partial class Review_Words : System.Web.UI.Page
    {
        int rank = 1;
        int cdid;
        List<CourseDetails> list = new List<CourseDetails>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["rank"] != null)
                rank = Convert.ToInt32(Request.QueryString["rank"]);

            string cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ToString();
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            //cmd.CommandText = "select cd_Name,ud_State from UserDownload";

            cmd.CommandText = " select top 1 * from CourseDetails where CD_ID in(select CD_ID from UserDownload where U_ID=@u_id and UD_CUT=0 and cd_id=@cd_id)";
            cmd.Parameters.AddWithValue("@u_id", Convert.ToInt32(Session["ID"]));
            cmd.Parameters.AddWithValue("@cd_id", rank);
            SqlDataReader sdr = cmd.ExecuteReader();
            CourseDetails cd = new CourseDetails();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    cd.CD_ID = Convert.ToInt32(sdr["CD_ID"]);
                    cd.C_ID = Convert.ToInt32(sdr["C_ID"]);
                    cd.CD_NAME = sdr["CD_NAME"].ToString();
                    cd.CD_YINBIAO = sdr["CD_YINBIAO"].ToString();
                    cd.CD_Mean = sdr["CD_Mean"].ToString();
                    cd.CD_RIGHT_PIC = (byte[])sdr["CD_RIGHT_PIC"];
                    cd.CD_WRONG_PIC1 = (byte[])sdr["CD_WRONG_PIC1"];
                    cd.CD_WRONG_PIC2 = (byte[])sdr["CD_WRONG_PIC2"];
                    cd.CD_WRONG_PIC3 = (byte[])sdr["CD_WRONG_PIC3"];
                    cd.CD_SENEng = sdr["CD_SENEng"].ToString();
                    cd.CD_SENChi = sdr["CD_SENChi"].ToString();
                    cd.CD_VIDEO = sdr["CD_VIDEO"].ToString();
                }
            }
            else
            {
                Response.Redirect("../List/list.aspx");
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('复习完毕.');</script>");
            }
            sdr.Close();
            cn.Close();
            cdid = cd.CD_ID;
            Learning_Words.Text = cd.CD_NAME;
            Learning_Words_Sentence.Text = cd.CD_SENEng;
            Pic_1.ImageUrl = "getpic1.aspx?cd_id=" + cd.CD_ID;
            Pic_2.ImageUrl = "getpic2.aspx?cd_id=" + cd.CD_ID;
            Pic_3.ImageUrl = "getpic3.aspx?cd_id=" + cd.CD_ID;
            Pic_4.ImageUrl = "getpic4.aspx?cd_id=" + cd.CD_ID;


        }


        protected void btn_Cut_Word_Click(object sender, EventArgs e)
        {

        }

        protected void Pic_1_Click(object sender, ImageClickEventArgs e)
        {
            UserDownload_Bll ud_b = new UserDownload_Bll();
            UserDownload ud = new UserDownload();
            ud = ud_b.GetUserDownload(2, cdid);
            ud.UD_Review = DateTime.Now;
            ud_b.ModifyUserDownload(ud);
            rank = rank + 1;
            Response.Redirect("Review_Words.aspx?rank=" + rank + "");
        }

        protected void Pic_2_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Pic_3_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Pic_4_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Words_Prompt_Click(object sender, EventArgs e)
        {

        }

        protected void SoundPlayer_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}