using Management_Dal;
using Management_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Bll
{
    public class Users_Bll
    {
        User_Dal ud = new User_Dal();

        /// <summary>
        /// 判断是否存在该用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool ExistsUsers(Users user)
        {
            int n = ud.ExistsUsers(user);
            if (n > 0)
            {
                return true;
            }
            return false;

        }

        /// <summary>
        /// 查询当前登录用户的ID
        /// </summary>
        /// <param name="lecturer"></param>
        /// <returns></returns>
        public string QueryUserID(Users user)
        {
            object obj = ud.QueryUserID(user);
            return obj.ToString();
        }
        /// <summary>
        /// 查询所有管理员方法
        /// </summary>
        /// <returns></returns>
        //public List<Lecturer> All_Lecturer()
        //{
        //    return lt.All_Lecturer();
        //}

        /// <summary>
        /// 增加用户的方法
        /// </summary>
        /// <returns></returns>
        public int Add_User(Users user)
        {

            //调用数据层的方法
            return ud.Add_User(user);
        }

        /// <summary>
        /// 根据id获取指定用户对象
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public Users GetUser(int userID)
        {
            return ud.GetUser(userID);
        }

        /// <summary>
        /// 根据用户名获取指定用户对象
        /// </summary>
        /// <param name="u_Name"></param>
        /// <returns></returns>
        public Users GetUser(string u_Name)
        {
            return ud.GetUser(u_Name);
        }

        /// <summary>
        /// 获取所有用户列表
        /// </summary>
        /// <returns></returns>
        public List<Users> GetAllUser()
        {
            return ud.GetAllUser();
        }
    }
}
