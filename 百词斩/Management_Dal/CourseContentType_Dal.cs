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
    public class CourseContentType_Dal
    {
        /// <summary>
        /// 添加单词包类型
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int AddCoursesContentType(CourseContentType cct)
        {
            string sql = "insert into CourseContentType(CCT_NAME,CCT_DESC) values(@name,@desc)";
            SqlParameter[] par = new SqlParameter[2]
            {
               //new SqlParameter("@id",cct.CCT_ID),
               new SqlParameter("@name",cct.CCT_NAME),
               new SqlParameter("@desc",cct.CCT_DESC),
            };
            return SQLHelper.ExecuteNonQuery(sql, CommandType.Text, par);
        }

        /// <summary>
        /// 查询所有单词包类别
        /// </summary>
        /// <returns></returns>
        public List<CourseContentType> QueryCourseContentTypeAll()
        {
            string sql = "select * from coursecontenttype";
            List<CourseContentType> list = new List<CourseContentType>();
            SqlDataReader msdr = SQLHelper.ExecuteReader(sql, CommandType.Text, null);
            if (msdr.HasRows)
            {
                while (msdr.Read())
                {
                    CourseContentType cct = new CourseContentType();
                    cct.CCT_ID = int.Parse(msdr["CCT_ID"].ToString());
                    cct.CCT_NAME = msdr["CCT_NAME"].ToString();
                    cct.CCT_DESC = msdr["CCT_DESC"].ToString();
                    list.Add(cct);
                }
            }
            msdr.Close();
            return list;
        }

        /// <summary>
        /// 查询单词包类别id
        /// </summary>
        /// <param name="cd"></param>
        /// <returns></returns>
        public object QueryCourseContTypeID(CourseContentType cd)
        {
            string sqlTest =
                    @"select CCT_ID from CourseContentType where CCT_NAME=@name";
            SqlParameter[] par =
            {
                new SqlParameter ("@name",cd.CCT_NAME)
            };
            return SQLHelper.ExecuteScalar(sqlTest, CommandType.Text, par);
        }
    }
}
