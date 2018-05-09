using Management_Dal;
using Management_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Bll
{
    public class UserDownload_Bll
    {
        UserDownload_Dal ud_d = new UserDownload_Dal();
        /// <summary>
        /// 添加用户进度
        /// </summary>
        /// <param name="userdownload"></param>
        /// <returns></returns>
        public bool AddUserDownload(UserDownload userdownload)
        {
            return ud_d.AddUserDownload(userdownload);
        }
        /// <summary>
        /// 修改用户进度
        /// </summary>
        /// <param name="userdownload"></param>
        /// <returns></returns>
        public bool ModifyUserDownload(UserDownload userdownload)
        {
            return ud_d.ModifyUserDownload(userdownload);
        }
        /// <summary>
        /// 删除用户进度
        /// </summary>
        /// <param name="udID"></param>
        /// <returns></returns>
        public bool DeleteUserDownload(int udID)
        {
            return ud_d.DeleteUserDownload(udID);
        }
        /// <summary>
        /// 获取所有用户进度列表
        /// </summary>
        /// <returns></returns>
        public List<UserDownload> GetAllUserDownload()
        {
            return ud_d.GetAllUserDownload();
        }
        /// <summary>
        /// 获取指定用户的用户进度列表
        /// </summary>
        /// <param name="uID"></param>
        /// <returns></returns>
        public List<UserDownload> GetUserDownloadByUID(int uID)
        {
            return ud_d.GetUserDownloadByUID(uID);
        }
        /// <summary>
        /// 获取指定用户指定进度的列表 
        /// </summary>
        /// <param name="uID"></param>
        /// <param name="cID"></param>
        /// <returns></returns>
        public List<UserDownload> GetUserDownloadByUIDandCID(int uID, int cID)
        {
            return ud_d.GetUserDownloadByUIDandCID(uID, cID);
        }
        /// <summary>
        /// 获取指定用户指定进度包指定进度的用户进度对象
        /// </summary>
        /// <param name="uID"></param>
        /// <param name="cID"></param>
        /// <param name="cdID"></param>
        /// <returns></returns>
        public UserDownload GetUserDownload(int uID, int cID, int cdID)
        {
            return ud_d.GetUserDownload(uID, cID, cdID);
        }
        /// <summary>
        /// 获取指定用户指定进度包指定进度的用户进度对象
        /// </summary>
        /// <param name="udID"></param>
        /// <returns></returns>
        public UserDownload GetUserDownload(int udID)
        {
            return ud_d.GetUserDownload(udID);
        }

        /// <summary>
        /// 返回用户已学单词数量
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="cid"></param>
        /// <returns></returns>
        public int GetCount(int uid, int cid)
        {
            return ud_d.GetCount(uid, cid);
        }

        public UserDownload GetUserDownload(int uID, int cdID)
        {
            return ud_d.GetUserDownload(uID, cdID);
        }
    }
}