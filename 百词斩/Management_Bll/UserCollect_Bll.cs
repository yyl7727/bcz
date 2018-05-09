using Management_Dal;
using Management_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Bll
{
    public class UserCollect_Bll
    {
        UserCollect_Dal uc_d = new UserCollect_Dal();
        /// <summary>
        /// 添加用户计划
        /// </summary>
        /// <param name="usercollect"></param>
        /// <returns></returns>
        public bool AddUserCollect(UserCollect usercollect)
        {
            return uc_d.AddUserCollect(usercollect);
        }
        /// <summary>
        /// 修改用户计划
        /// </summary>
        /// <param name="usercollect"></param>
        /// <returns></returns>
        public bool ModifyUserCollect(UserCollect usercollect)
        {
            return uc_d.ModifyUserCollect(usercollect);
        }
        /// <summary>
        /// 删除用户计划
        /// </summary>
        /// <param name="ucID"></param>
        /// <returns></returns>
        public bool DeleteUserCollect(int ucID)
        {
            return uc_d.DeleteUserCollect(ucID);
        }
        /// <summary>
        /// 获取所有用户计划列表
        /// </summary>
        /// <returns></returns>
        public List<UserCollect> GetAllUserCollect()
        {
            return uc_d.GetAllUserCollect();
        }
        /// <summary>
        /// 获取指定用户的用户计划列表 
        /// </summary>
        /// <param name="uID"></param>
        /// <returns></returns>
        public UserCollect GetUserCollectByUID(int uID)
        {
            return uc_d.GetUserCollectByUID(uID);
        }
        /// <summary>
        /// 获取指定的用户计划对象 
        /// </summary>
        /// <param name="ucID"></param>
        /// <returns></returns>
        public UserCollect GetUserCollect(int uID)
        {
            return uc_d.GetUserCollect(uID);
        }
        /// <summary>
        /// 获取指定用户制定单词包的用户计划对象
        /// </summary>
        /// <param name="uID"></param>
        /// <param name="cID"></param>
        /// <returns></returns>
        public UserCollect GetUserCollectByUIDandCID(int uID, int cID)
        {
            return uc_d.GetUserCollectByUIDandCID(uID, cID);
        }

        /// <summary>
        /// 根据用户ID获取该用户最近使用的单词包
        /// </summary>
        /// <param name="u_ID"></param>
        /// <returns></returns>
        public UserCollect GetUserCollectUid(int u_ID)
        {
            return uc_d.GetUserCollectUid(u_ID);
        }

        public bool ModifyUserCollectbyuid(UserCollect usercollect)
        {
            return uc_d.ModifyUserCollectbyuid(usercollect);
        }
    }
}
