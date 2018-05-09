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
            SqlDataReader msdr = SQLHelper.ExecuteReader(sql, CommandType.Text, par);
            if (msdr.HasRows)
            {
                while (msdr.Read())
                {
                    cd.CD_NAME= msdr["CD_NAME"].ToString();
                    cd.CD_YINBIAO= msdr["CD_YINBIAO"].ToString();
                    cd.CD_Mean= msdr["CD_Mean"].ToString();
                    cd.CD_RIGHT_PIC= (byte[])msdr["CD_RIGHT_PIC"];
                    cd.CD_WRONG_PIC1= (byte[])msdr["CD_WRONG_PIC1"];
                    cd.CD_WRONG_PIC2= (byte[])msdr["CD_WRONG_PIC2"];
                    cd.CD_WRONG_PIC3= (byte[])msdr["CD_WRONG_PIC3"];
                    cd.CD_SENEng= msdr["CD_SENEng"].ToString();
                    cd.CD_SENChi= msdr["CD_SENChi"].ToString();
                    cd.CD_VIDEO= msdr["CD_VIDEO"].ToString();
                    list.Add(cd);
                }
            }
            msdr.Close();
            return list;
        }

        /// <summary>
        /// 查找所有单词
        /// </summary>
        /// <returns></returns>
        public List<CourseDetails> GetAll()
        {
            List<CourseDetails> list = new List<CourseDetails>();
            string sqlTest = "select * from  coursedetails";
            SqlDataReader sdr = SQLHelper.ExecuteReader(sqlTest, CommandType.Text, null);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    CourseDetails cd = new CourseDetails();
                    cd.CD_ID = int.Parse(sdr["cd_id"].ToString());
                    cd.C_ID = int.Parse(sdr["c_id"].ToString());
                    cd.CD_YINBIAO = sdr["cd_name"].ToString();
                    cd.CD_NAME = sdr["cd_name"].ToString();
                    cd.CD_Mean = sdr["cd_mean"].ToString();
                    cd.CD_RIGHT_PIC = (byte[])sdr["cd_right_pic"];
                    cd.CD_WRONG_PIC1 = (byte[])sdr["cd_wrong_pic1"];
                    cd.CD_WRONG_PIC2 = (byte[])sdr["cd_wrong_pic2"];
                    cd.CD_WRONG_PIC3 = (byte[])sdr["cd_wrong_pic3"];
                    cd.CD_SENEng = sdr["CD_SENEng"].ToString();
                    list.Add(cd);
                }
            }
            sdr.Close();
            return list;
        }

        /// <summary>
        /// 根据id删除单词
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteByid(int id)
        {
            string sql = "delete from coursedetails where cd_id=@id";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter ("@id",id),
            };
            return SQLHelper.ExecuteNonQuery(sql, CommandType.Text, par);
        }

        /// <summary>
        /// 根据id查找单词图片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CourseDetails GetPicById(int id)
        {
            CourseDetails c = new CourseDetails();
            string sql = "select cd_right_pic,cd_wrong_pic1,cd_wrong_pic2,cd_wrong_pic3 from coursedetails where cd_id=@id";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, par);
            if (sdr.Read())
            {
                c.CD_RIGHT_PIC = (byte[])sdr["cd_right_pic"];
                c.CD_WRONG_PIC1 = (byte[])sdr["cd_wrong_pic1"];
                c.CD_WRONG_PIC2 = (byte[])sdr["cd_wrong_pic2"];
                c.CD_WRONG_PIC3 = (byte[])sdr["cd_wrong_pic3"];
            }
            return c;
        }

        /// <summary>
        /// 获取单词总数
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            string sql = "select count(*) from coursedetails";
            object obj = SQLHelper.ExecuteScalar(sql, CommandType.Text, null);
            return int.Parse(obj.ToString());
        }
    }
}
