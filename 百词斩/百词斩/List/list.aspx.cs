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
    public partial class list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FreshData();
        }

        private void FreshData()
        {
            string cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ToString();
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            //cmd.CommandText = "select cd_Name,ud_State from UserDownload";

            cmd.CommandText = " select cd_name,cd_mean from CourseDetails where CD_ID in(select CD_ID from UserDownload where U_ID=@u_id and UD_CUT=0)";
            cmd.Parameters.AddWithValue("@u_id", Convert.ToInt32(Session["ID"]));
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                gw_word.DataSource = dr;
                gw_word.DataBind();
            }
            cn.Close();
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            FreshData();
        }

        /// <summary>
        /// 复习单词
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("../Review Words/Review_Words.aspx");
        //}

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("../Review Words/Review_Words.aspx");
        }
    }
}