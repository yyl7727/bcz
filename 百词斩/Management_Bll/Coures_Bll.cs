using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management_Dal;
using Management_Model;

namespace Management_Bll
{
    public class Coures_Bll
    {
        Coures_Dal DALCourses = new Coures_Dal();
        /// <summary>
        /// 增加单词包
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public int AddCourses(Coures l)
        {
            return DALCourses.AddCourses(l);
        }

        /// <summary>
        /// 根据单词包名字查询id
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public object QueryCouresID(Coures c)
        {
            return DALCourses.QueryCourseID(c);
        }

        /// <summary>
        /// 显示单词包
        /// </summary>
        /// <returns></returns>
        public List<Coures> QueryCouresAll()
        {
            return DALCourses.QueryCouresAll();
        }

        /// <summary>
        /// 根据ID获取指定单词包
        /// </summary>
        /// <param name="cID"></param>
        /// <returns></returns>
        public Coures GetCourse(int cID)
        {
            return DALCourses.GetCourse(cID);

        }
    }
}
