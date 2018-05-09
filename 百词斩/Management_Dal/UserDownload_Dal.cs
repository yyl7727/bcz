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
    public class UserDownload_Dal
    {
        /// <summary>
        /// 添加用户单词
        /// </summary>
        /// <param name="userdownload"></param>
        /// <returns></returns>
        public bool AddUserDownload(UserDownload userdownload)
        {
            string sql = "insert into UserDownload values(@U_ID,@C_ID,@CD_ID,@CD_IsBei,@UD_CUT,@UD_STUDY,@UD_Review,@UD_Data,@UD_Status)";
            SqlParameter[] p = {
                    new SqlParameter("@C_ID",userdownload.C_ID),
                    new SqlParameter("@CD_ID",userdownload.CD_ID),
                    new SqlParameter("@U_ID",userdownload.U_ID),
                    new SqlParameter("@CD_IsBei",userdownload.CD_IsBei),
                    new SqlParameter("@UD_CUT",userdownload.UD_CUT),
                    new SqlParameter("@UD_STUDY",userdownload.UD_STUDY),
                    new SqlParameter("@UD_Review",userdownload.UD_Review),
                    new SqlParameter("@UD_Data",userdownload.UD_Data),
                    new SqlParameter("@UD_Status",userdownload.UD_Status)
                              };
            int i = SQLHelper.ExecuteNonQuery(sql, CommandType.Text, p);
            return i > 0;
        }
        /// <summary>
        /// 修改用户单词
        /// </summary>
        /// <param name="userdownload"></param>
        /// <returns></returns>
        public bool ModifyUserDownload(UserDownload userdownload)
        {
            string sql = "update UserDownload set C_ID=@C_ID,CD_ID=@CD_ID,U_ID=@U_ID,CD_IsBei=@CD_IsBei,UD_CUT=@UD_CUT,UD_STUDY=@UD_STUDY,UD_Review=@UD_Review where UD_ID=@UD_ID";
            SqlParameter[] p = {
                    new SqlParameter("@UD_ID",userdownload.UD_ID),
                    new SqlParameter("@C_ID",userdownload.C_ID),
                    new SqlParameter("@CD_ID",userdownload.CD_ID),
                    new SqlParameter("@U_ID",userdownload.U_ID),
                    new SqlParameter("@CD_IsBei",userdownload.CD_IsBei),
                    new SqlParameter("@UD_CUT",userdownload.UD_CUT),
                    new SqlParameter("@UD_STUDY",userdownload.UD_STUDY),
                    new SqlParameter("@UD_Review",userdownload.UD_Review)
                              };
            int i = SQLHelper.ExecuteNonQuery(sql, CommandType.Text, p);
            return i > 0;
        }
        /// <summary>
        /// 删除用户单词
        /// </summary>
        /// <param name="udID"></param>
        /// <returns></returns>
        public bool DeleteUserDownload(int udID)
        {
            string sql = "delete * from UserDownload where ud_Id=@ud_Id";
            SqlParameter[] p = {
                              new SqlParameter("@c_Id",udID)
                              };
            int i = SQLHelper.ExecuteNonQuery(sql, CommandType.Text, p);
            return i > 0;
        }
        /// <summary>
        /// 获取所有用户单词列表
        /// </summary>
        /// <returns></returns>
        public List<UserDownload> GetAllUserDownload()
        {
            string sql = "select * from UserDownload";
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, null);
            List<UserDownload> list = new List<UserDownload>();
            while (sdr.Read())
            {
                UserDownload userdownload = new UserDownload();
                userdownload.UD_ID = Convert.ToInt32(sdr["UD_ID"]);
                userdownload.C_ID = Convert.ToInt32(sdr["C_ID"]);
                userdownload.CD_ID = Convert.ToInt32(sdr["CD_ID"]);
                userdownload.U_ID = Convert.ToInt32(sdr["U_ID"]);
                userdownload.CD_IsBei = Convert.ToInt32(sdr["CD_IsBei"]);
                userdownload.UD_CUT = Convert.ToInt32(sdr["UD_CUT"]);
                userdownload.UD_STUDY = Convert.ToDateTime(sdr["UD_STUDY"]);
                userdownload.UD_Review = Convert.ToDateTime(sdr["UD_Review"]);

                list.Add(userdownload);
            }
            return list;
        }
        /// <summary>
        /// 获取指定用户的用户单词列表
        /// </summary>
        /// <param name="uID"></param>
        /// <returns></returns>
        public List<UserDownload> GetUserDownloadByUID(int uID)
        {
            string sql = "select * from UserDownload where U_ID=@U_ID";
            SqlParameter[] p = {
                               new SqlParameter("@U_ID",uID)
                               };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, p);
            List<UserDownload> list = new List<UserDownload>();
            while (sdr.Read())
            {
                UserDownload userdownload = new UserDownload();
                userdownload.UD_ID = Convert.ToInt32(sdr["UD_ID"]);
                userdownload.C_ID = Convert.ToInt32(sdr["C_ID"]);
                userdownload.CD_ID = Convert.ToInt32(sdr["CD_ID"]);
                userdownload.U_ID = Convert.ToInt32(sdr["U_ID"]);
                userdownload.CD_IsBei = Convert.ToInt32(sdr["CD_IsBei"]);
                userdownload.UD_CUT = Convert.ToInt32(sdr["UD_CUT"]);
                userdownload.UD_STUDY = Convert.ToDateTime(sdr["UD_STUDY"]);
                userdownload.UD_Review = Convert.ToDateTime(sdr["UD_Review"]);

                list.Add(userdownload);
            }
            return list;
        }
        /// <summary>
        /// 获取指定用户指定单词包的列表 
        /// </summary>
        /// <param name="uID"></param>
        /// <param name="cID"></param>
        /// <returns></returns>
        public List<UserDownload> GetUserDownloadByUIDandCID(int uID, int cID)
        {
            string sql = "select * from UserDownload where U_ID=@U_ID and C_ID=@C_ID";
            SqlParameter[] p = {
                               new SqlParameter("@U_ID",uID),
                                new SqlParameter("@C_ID",cID)
                               };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, p);
            List<UserDownload> list = new List<UserDownload>();
            while (sdr.Read())
            {
                UserDownload userdownload = new UserDownload();
                userdownload.UD_ID = Convert.ToInt32(sdr["UD_ID"]);
                userdownload.C_ID = Convert.ToInt32(sdr["C_ID"]);
                userdownload.CD_ID = Convert.ToInt32(sdr["CD_ID"]);
                userdownload.U_ID = Convert.ToInt32(sdr["U_ID"]);
                userdownload.CD_IsBei = Convert.ToInt32(sdr["CD_IsBei"]);
                userdownload.UD_CUT = Convert.ToInt32(sdr["UD_CUT"]);
                userdownload.UD_STUDY = Convert.ToDateTime(sdr["UD_STUDY"]);
                userdownload.UD_Review = Convert.ToDateTime(sdr["UD_Review"]);
                list.Add(userdownload);
            }
            return list;
        }
        /// <summary>
        /// 获取指定用户指定单词包指定单词的用户单词对象
        /// </summary>
        /// <param name="uID"></param>
        /// <param name="cID"></param>
        /// <param name="cdID"></param>
        /// <returns></returns>
        public UserDownload GetUserDownload(int uID, int cID, int cdID)
        {
            string sql = "select * from UserDownload where U_ID=@U_ID and C_ID=@C_ID and CD_ID=@CD_ID";
            SqlParameter[] p = {
                               new SqlParameter("@U_ID",uID),
                                new SqlParameter("@C_ID",cID),
                                new SqlParameter("@CD_ID",cdID)
                               };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, p);
            UserDownload userdownload = new UserDownload();
            while (sdr.Read())
            {
                userdownload.UD_ID = Convert.ToInt32(sdr["UD_ID"]);
                userdownload.C_ID = Convert.ToInt32(sdr["C_ID"]);
                userdownload.CD_ID = Convert.ToInt32(sdr["CD_ID"]);
                userdownload.U_ID = Convert.ToInt32(sdr["U_ID"]);
                userdownload.CD_IsBei = Convert.ToInt32(sdr["CD_IsBei"]);
                userdownload.UD_CUT = Convert.ToInt32(sdr["UD_CUT"]);
                userdownload.UD_STUDY = Convert.ToDateTime(sdr["UD_STUDY"]);
                userdownload.UD_Review = Convert.ToDateTime(sdr["UD_Review"]);
            }
            return userdownload;
        }
        /// <summary>
        /// 获取指定用户指定单词包指定单词的用户单词对象
        /// </summary>
        /// <param name="udID"></param>
        /// <returns></returns>
        public UserDownload GetUserDownload(int udID)
        {
            string sql = "select * from UserDownload where UD_ID=@UD_ID";
            SqlParameter[] p = {
                               new SqlParameter("@UD_ID",udID)
                               };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, p);
            UserDownload userdownload = new UserDownload();
            while (sdr.Read())
            {
                userdownload.UD_ID = Convert.ToInt32(sdr["UD_ID"]);
                userdownload.C_ID = Convert.ToInt32(sdr["C_ID"]);
                userdownload.CD_ID = Convert.ToInt32(sdr["CD_ID"]);
                userdownload.U_ID = Convert.ToInt32(sdr["U_ID"]);
                userdownload.CD_IsBei = Convert.ToInt32(sdr["CD_IsBei"]);
                userdownload.UD_CUT = Convert.ToInt32(sdr["UD_CUT"]);
                userdownload.UD_STUDY = Convert.ToDateTime(sdr["UD_STUDY"]);
                userdownload.UD_Review = Convert.ToDateTime(sdr["UD_Review"]);
            }
            return userdownload;
        }

        /// <summary>
        /// 返回用户已学单词数量
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="cid"></param>
        /// <returns></returns>
        public int GetCount(int uid, int cid)
        {
            string sqlTest = "select count(*) from UserDownload where U_ID=@U_ID and C_ID=@C_ID";
            SqlParameter[] par = new SqlParameter[2]
            {
                new SqlParameter("@U_ID",uid),
                new SqlParameter ("@C_ID",cid)
            };

            object obj = SQLHelper.ExecuteScalar(sqlTest, CommandType.Text, par);
            return int.Parse(obj.ToString());
        }

        public UserDownload GetUserDownload(int uID,  int cdID)
        {
            string sql = "select * from UserDownload where U_ID=@U_ID and CD_ID=@CD_ID";
            SqlParameter[] p = {
                               new SqlParameter("@U_ID",uID),
                                new SqlParameter("@CD_ID",cdID)
                               };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, p);
            UserDownload userdownload = new UserDownload();
            while (sdr.Read())
            {
                userdownload.UD_ID = Convert.ToInt32(sdr["UD_ID"]);
                userdownload.C_ID = Convert.ToInt32(sdr["C_ID"]);
                userdownload.CD_ID = Convert.ToInt32(sdr["CD_ID"]);
                userdownload.U_ID = Convert.ToInt32(sdr["U_ID"]);
                userdownload.CD_IsBei = Convert.ToInt32(sdr["CD_IsBei"]);
                userdownload.UD_CUT = Convert.ToInt32(sdr["UD_CUT"]);
                userdownload.UD_STUDY = Convert.ToDateTime(sdr["UD_STUDY"]);
                userdownload.UD_Review = Convert.ToDateTime(sdr["UD_Review"]);
            }
            return userdownload;
        }
    }
}
