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
        /// 查找所有单词
        /// </summary>
        /// <returns></returns>
        public List<CourseDetails> GetAll()
        {
            return cdd.GetAll();
        }
        /// <summary>
        /// 根据id删除单词
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteByid(int id)
        {
            return cdd.DeleteByid(id);
        }

        /// <summary>
        /// 根据id查找单词图片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CourseDetails GetPicById(int id)
        {
            return cdd.GetPicById(id);
        }

        /// <summary>
        /// 获取单词总数
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return cdd.GetCount();
        }
        }
}
