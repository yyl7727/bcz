using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 百词斩.Recite_Words
{
    public partial class ShowTureWord : System.Web.UI.Page
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();//引用系统自带的发音对象
        string Pic_Path;
        protected void Page_Load(object sender, EventArgs e)
        {
            True_Pic.ImageUrl= "getpic1.aspx?cd_id=" + Convert.ToInt32(Session["cd_id"]);
            Learning_Words.Text = Session["cd_name"].ToString();
            Learning_Words_Sentence.Text = Session["CD_SENEng"].ToString();
        }

        protected void SoundPlayer_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Words_Prompt_Click(object sender, EventArgs e)
        {
            int xx = Convert.ToInt32(Session["xx"]);
            Response.Redirect("Study_Words.aspx?xx="+ xx +"");
        }
    }
}