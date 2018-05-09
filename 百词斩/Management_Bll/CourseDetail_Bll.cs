using Management_Dal;
using Management_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Bll
{
    public class CourseDetail_Bll
    {
        CourseDetails_Dal cdd = new CourseDetails_Dal();

        /// <summary>
        /// 添加单词
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public int AddCoursesDetails(CourseDetails l)
        {
            return cdd.AddCoursesDetails(l);
        }

        /// <summary>
        /// 显示单词
        /// </summary>
        /// <param name="cd"></param>
        /// <returns></returns>
        public List<CourseDetails> CourseDetail_All(CourseDetails cd)
        {
            return cdd.CourseDetail_Id(cd);
        }

        /// <summary>
        /// 根据单词包返回第一条单词的记录
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public CourseDetails QueryCourseDetails1(int cid)
        {
            return cdd.QueryCourseDetails1(cid);
        }

        /// <summary>
        /// 根据单词包id和单词id返回第一条单词的记录
        /// </summary>
        /// <param name="cid"></param>
        /// <param name="cdid"></param>
        /// <returns></returns>
        public CourseDetails QueryCourseDetails1(int cid, int cdid)
        {
            return cdd.QueryCourseDetails1(cid, cdid);
        }
    }
}
