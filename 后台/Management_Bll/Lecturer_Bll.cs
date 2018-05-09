using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management_Dal;
using Management_Model;

namespace Management_Bll
{
    public class Lecturer_Bll
    {
        Lecturer_Dal lt = new Lecturer_Dal();
        /// <summary>
        /// 查询当前登录用户的id
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string QueryAdminID(Lecturer lecturer)
        {
            object obj = lt.QueryAdminID(lecturer);
            return obj.ToString();
        }
        public bool ExistsUsers(Lecturer lecturer)
        {
            int n = lt.ExistsUsers(lecturer);
            if (n > 0)
            {
                return true;
            }
            return false;

        }

        /// <summary>
        /// 查询所有管理员方法
        /// </summary>
        /// <returns></returns>
        public List<Lecturer> All_Lecturer()
        {
            return lt.All_Lecturer();
        }

        /// <summary>
        /// 增加用户的方法
        /// </summary>
        /// <returns></returns>
        public int Add_User(Lecturer lecturer)
        {

            //调用数据层的方法
            return lt.Add_User(lecturer);
        }

        /// <summary>
        /// 删除管理员方法
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int Delete_User(int i)
        {
            return lt.Delete_User(i);
        }

        /// <summary>
        /// 修改管理员方法
        /// </summary>
        /// <param name="i"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public int Alter_User(int i, string name)
        {
            return lt.Alter_User(i, name);
        }

        /// <summary>
        /// 修改管理员密码
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public int Alterpwd_Lecturer(Lecturer l)
        {
            return lt.Alter_pwd(l);
        }
    }
}
