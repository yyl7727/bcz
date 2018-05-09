using Management_Dal;
using Management_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Bll
{
    public class CourseContentType_Bll
    {
        CourseContentType_Dal cct_dal = new CourseContentType_Dal();

        /// <summary>
        /// 单词包类型添加
        /// </summary>
        /// <param name="cct"></param>
        /// <returns></returns>
        public int AddCourseContentType(CourseContentType cct)
        {
            return cct_dal.AddCoursesContentType(cct);
        }

        /// <summary>
        /// 显示所有单词包类别
        /// </summary>
        /// <returns></returns>
        public List<CourseContentType> QueryCourseContentTypeAll()
        {
            return cct_dal.QueryCourseContentTypeAll();
        }

        /// <summary>
        /// 根据名称查找单词包类型ID
        /// </summary>
        /// <param name="cct"></param>
        /// <returns></returns>
        public object QueryCourseContTypeID(CourseContentType cct)
        {
            return cct_dal.QueryCourseContTypeID(cct);
        }
    }
}
