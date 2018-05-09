using Management_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepastHelper;

namespace Management_Dal
{
    public class Coures_Dal
    {
        /// <summary>
        /// 添加单词包
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int AddCourses(Coures c)
        {
            string sql = "insert into coures(C_NAME,CCT_ID,C_RELEASEDATE,C_VOCABULARY) values(@name,@type,@releasedate,@vocabulary)";
            SqlParameter[] par = new SqlParameter[4]
            {
               new SqlParameter("@name",c.C_NAME),
               new SqlParameter("@type",c.CCT_ID),
               new SqlParameter("@releasedate",c.C_RELEASEDATE),
               new SqlParameter("@vocabulary",c.C_vocabulary)
            };
            return SQLHelper.ExecuteNonQuery(sql, CommandType.Text, par);
        }

        /// <summary>
        /// 显示所有单词包
        /// </summary>
        /// <returns></returns>
        public List<Coures> QueryCouresAll()
        {
            string sql = "select * from coures";
            List<Coures> list = new List<Coures>();
            SqlDataReader msdr = SQLHelper.ExecuteReader(sql, CommandType.Text, null);
            if (msdr.HasRows)
            {
                while (msdr.Read())
                {
                    Coures c = new Coures();
                    c.CCT_ID = int.Parse(msdr["C_ID"].ToString());
                    c.C_NAME = msdr["C_NAME"].ToString();
                    c.C_vocabulary= int.Parse(msdr["C_vocabulary"].ToString());
                    list.Add(c);
                }
            }
            msdr.Close();
            return list;
        }

        /// <summary>
        /// 查询单词包id
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public object QueryCourseID(Coures c)
        {
            string sqlTest =
                    @"select C_ID from Coures where C_NAME=@name";
            SqlParameter[] par =
            {
                new SqlParameter ("@name",c.C_NAME)
            };
            return SQLHelper.ExecuteScalar(sqlTest, CommandType.Text, par);
        }

        /// <summary>
        /// 根据单词包id获取指定单词包
        /// </summary>
        /// <param name="cID"></param>
        /// <returns></returns>
        public Coures GetCourse(int cID)
        {
            string sql = "select * from Coures where C_ID=@C_ID";
            SqlParameter[] p = {
                              new SqlParameter("@C_ID",cID)
                              };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, p);
            Coures course = new Coures();
            while (sdr.Read())
            {
                course.C_ID = Convert.ToInt32(sdr["C_ID"]);
                course.C_NAME = sdr["C_NAME"].ToString();
                course.CCT_ID = Convert.ToInt32(sdr["CCT_ID"]);
                course.C_RELEASEDATE = sdr["C_RELEASEDATE"].ToString();
                course.C_vocabulary = Convert.ToInt32(sdr["C_vocabulary"]);
            }
            return course;
        }
    }
}
