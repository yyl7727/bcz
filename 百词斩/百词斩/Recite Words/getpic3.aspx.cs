using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 百词斩.Recite_Words
{
    public partial class getpic3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Expires = 0;
            Response.Buffer = true;
            Response.Clear();
            int cd_id = Convert.ToInt32(Request.Params["cd_id"]);
            GetPic(cd_id);
        }

        public void GetPic(int cd_id)
        {
            string str = ConfigurationManager.ConnectionStrings["cnstr"].ToString();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "select cd_wrong_pic2 from CourseDetails where cd_id=@cd_id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cd_id", cd_id);
            SqlDataReader dr1 = cmd.ExecuteReader();
            dr1.Read();
            if (dr1.HasRows)
            {
                byte[] photo1 = null;
                if (dr1[0] != null)
                    photo1 = (byte[])dr1[0];
                Response.ContentType = "image/jpeg";
                Response.BinaryWrite(photo1);
                Response.End();
            }
            dr1.Close();
            conn.Close();
        }
    }
}