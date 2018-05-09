using Management_Model;
using RepastHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Dal
{
    public class CourseDetails_Dal
    {
        public int AddCoursesDetails(CourseDetails cd)
        {
            string sql =
                "insert into coursedetails(C_ID,CD_NAME,CD_YINBIAO,CD_MEAN,CD_RIGHT_PIC,CD_WRONG_PIC1,CD_WRONG_PIC2,CD_WRONG_PIC3,CD_SENEng,CD_SENChi,CD_VIDEO) values(@id,@name,@yb,@mean,@rightpic,@wrongpic1,@wrongpic2,@wrongpic3,@eng,@Chi,@video)";
            SqlParameter[] par = new SqlParameter[11]
            {
               new SqlParameter("@id",cd.C_ID),
               new SqlParameter("@name",cd.CD_NAME),
               new SqlParameter("@yb",cd.CD_YINBIAO),
               new SqlParameter("@mean",cd.CD_Mean),
               new SqlParameter("@rightpic",cd.CD_RIGHT_PIC),
               new SqlParameter("@wrongpic1",cd.CD_WRONG_PIC1),
               new SqlParameter("@wrongpic2",cd.CD_WRONG_PIC2),
               new SqlParameter("@wrongpic3",cd.CD_WRONG_PIC3),
               new SqlParameter("@eng",cd.CD_SENEng),
               new SqlParameter("@Chi",cd.CD_SENChi),
               new SqlParameter("@video",cd.CD_VIDEO)
            };
            return SQLHelper.ExecuteNonQuery(sql, CommandType.Text, par);
        }

        /// <summary>
        /// 根据单词包id查找单词
        /// </summary>
        /// <param name="cd"></param>
        /// <returns></returns>
        public List<CourseDetails> CourseDetail_Id(CourseDetails cd)
        {
            string sql = "select * from CourseDetails where C_ID=@id";
            SqlParameter[] par = new SqlParameter[1]
            {
               new SqlParameter("@id",cd.C_ID)
               
            };
            List<CourseDetails> list = new List<CourseDetails>();
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, par);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    cd.CD_ID = Convert.ToInt32(sdr["CD_ID"]);
                    cd.CD_NAME= sdr["CD_NAME"].ToString();
                    cd.CD_YINBIAO= sdr["CD_YINBIAO"].ToString();
                    cd.CD_Mean= sdr["CD_Mean"].ToString();
                    cd.CD_RIGHT_PIC= (byte[])sdr["CD_RIGHT_PIC"];
                    cd.CD_WRONG_PIC1= (byte[])sdr["CD_WRONG_PIC1"];
                    cd.CD_WRONG_PIC2= (byte[])sdr["CD_WRONG_PIC2"];
                    cd.CD_WRONG_PIC3= (byte[])sdr["CD_WRONG_PIC3"];
                    cd.CD_SENEng= sdr["CD_SENEng"].ToString();
                    cd.CD_SENChi= sdr["CD_SENChi"].ToString();
                    cd.CD_VIDEO= sdr["CD_VIDEO"].ToString();
                    list.Add(cd);
                }
            }
            sdr.Close();
            return list;
        }

        /// <summary>
        /// 根据单词包返回第一条单词的记录
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public CourseDetails QueryCourseDetails1(int cid)
        {
            string sql = "select top 1 * from CourseDetails where c_id=@cid";
            SqlParameter[] par = new SqlParameter[1]
            {
               new SqlParameter("@cid",cid)
            };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, par);
            CourseDetails cd = new CourseDetails();
            while (sdr.Read())
            {
                cd.C_ID = Convert.ToInt32(sdr["C_ID"]);
                cd.CD_ID = Convert.ToInt32(sdr["CD_ID"]);
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
            return cd;
        }

        /// <summary>
        /// 根据单词包id和单词id返回第一条单词的记录
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public CourseDetails QueryCourseDetails1(int cid,int cdid)
        {
            string sql = "select top 1 * from CourseDetails where c_id=@cid and CD_ID=@cdid";
            SqlParameter[] par = new SqlParameter[]
            {
               new SqlParameter("@cid",cid),
               new SqlParameter("@cdid",cdid)
            };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, par);
            CourseDetails cd = new CourseDetails();
            while (sdr.Read())
            {
                cd.C_ID = Convert.ToInt32(sdr["C_ID"]);
                cd.CD_ID = Convert.ToInt32(sdr["CD_ID"]);
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
            return cd;
        }
    }
}
