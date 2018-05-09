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
    public class UserCollect_Dal
    {
        /// <summary>
        /// 添加用户计划
        /// </summary>
        /// <param name="usercollect"></param>
        /// <returns></returns>
        public bool AddUserCollect(UserCollect usercollect)
        {
            string sql = "insert into UserCollect values(@U_ID,@C_ID,@UC_EveWord, @UC_ComDay,@UC_StartDay,@UC_EndDay,@UC_IsRead)";
            SqlParameter[] p = {
              new SqlParameter("@C_ID",usercollect.C_ID),
                new SqlParameter("@U_ID",usercollect.U_ID),
                 new SqlParameter("@UC_StartDay",usercollect.UC_StartDay),
                  new SqlParameter("@UC_EndDay",usercollect.UC_EndDay),
                   new SqlParameter("@UC_ComDay",usercollect.UC_ComDay),
                    new SqlParameter("@UC_EveWord",usercollect.UC_EveWord),
                      new SqlParameter("@UC_IsRead",usercollect.UC_IsRead)
                              };
            int i = SQLHelper.ExecuteNonQuery(sql, CommandType.Text, p);
            return i > 0;
        }
        /// <summary>
        /// 修改用户计划
        /// </summary>
        /// <param name="usercollect"></param>
        /// <returns></returns>
        public bool ModifyUserCollect(UserCollect usercollect)
        {
            string sql = "update UserCollect set UC_EndDay=@UC_EndDay,UC_ComDay=@UC_ComDay,UC_EveWord=@UC_EveWord,UC_IsRead=@UC_IsRead where C_ID =@C_ID and U_ID=@U_ID";
            SqlParameter[] p = {
              new SqlParameter("@C_ID",usercollect.C_ID),
              new SqlParameter("@U_ID",usercollect.U_ID), 
              new SqlParameter("@UC_EndDay",usercollect.UC_EndDay),
              new SqlParameter("@UC_ComDay",usercollect.UC_ComDay),
              new SqlParameter("@UC_EveWord",usercollect.UC_EveWord),
              new SqlParameter("@UC_IsRead",usercollect.UC_IsRead)
                              };
            int i = SQLHelper.ExecuteNonQuery(sql, CommandType.Text, p);
            return i > 0;

        }
        /// <summary>
        /// 删除用户计划
        /// </summary>
        /// <param name="ucID"></param>
        /// <returns></returns>
        public bool DeleteUserCollect(int ucID)
        {
            string sql = "delete * from UserCollect where UC_ID=@UC_ID";
            SqlParameter[] p = {
                              new SqlParameter("@UC_ID",ucID)
                              };
            int i = SQLHelper.ExecuteNonQuery(sql, CommandType.Text, p);
            return i > 0;
        }
        /// <summary>
        /// 获取所有用户计划列表
        /// </summary>
        /// <returns></returns>
        public List<UserCollect> GetAllUserCollect()
        {
            string sql = "select * from UserCollect";
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, null);
            List<UserCollect> list = new List<UserCollect>();
            while (sdr.Read())
            {
                UserCollect usercollect = new UserCollect();
                usercollect.UC_ID = Convert.ToInt32(sdr["UC_ID"]);
                usercollect.C_ID = Convert.ToInt32(sdr["C_ID"]);
                usercollect.U_ID = Convert.ToInt32(sdr["U_ID"]);
                usercollect.UC_StartDay = Convert.ToDateTime(sdr["UC_StartDay"]);
                usercollect.UC_EndDay = Convert.ToDateTime(sdr["UC_EndDay"]);
                usercollect.UC_ComDay = Convert.ToInt32(sdr["UC_ComDay"]);
                usercollect.UC_EveWord = Convert.ToInt32(sdr["UC_EveWord"]);
                usercollect.UC_IsRead = Convert.ToInt32(sdr["UC_IsRead"]);
                list.Add(usercollect);
            }
            return list;
        }
        /// <summary>
        /// 获取指定用户的用户计划列表 
        /// </summary>
        /// <param name="uID"></param>
        /// <returns></returns>
        public UserCollect GetUserCollectByUID(int uID)
        {
            string sql = "select * from UserCollect where U_ID=@U_ID";
            SqlParameter[] p = {
                               new SqlParameter("@U_ID",uID)
                               };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, p);
            List<UserCollect> list = new List<UserCollect>();
            UserCollect usercollect = new UserCollect();
            while (sdr.Read())
            {
 
                usercollect.UC_ID = Convert.ToInt32(sdr["UC_ID"]);
                usercollect.C_ID = Convert.ToInt32(sdr["C_ID"]);
                usercollect.U_ID = Convert.ToInt32(sdr["U_ID"]);
                usercollect.UC_StartDay = Convert.ToDateTime(sdr["UC_StartDay"]);
                usercollect.UC_EndDay = Convert.ToDateTime(sdr["UC_EndDay"]);
                usercollect.UC_ComDay = Convert.ToInt32(sdr["UC_ComDay"]);
                usercollect.UC_EveWord = Convert.ToInt32(sdr["UC_EveWord"]);
                usercollect.UC_IsRead = Convert.ToInt32(sdr["UC_IsRead"]);
            }
            return usercollect;
        }
        /// <summary>
        /// 获取指定的用户计划对象 
        /// </summary>
        /// <param name="uID"></param>
        /// <returns></returns>
        public UserCollect GetUserCollect(int uID)
        {
            string sql = "select * from UserCollect where U_ID=@U_ID";
            SqlParameter[] p = {
                               new SqlParameter("@U_ID",uID)
                               };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, p);
            UserCollect usercollect = new UserCollect();
            while (sdr.Read())
            {
                usercollect.UC_ID = Convert.ToInt32(sdr["UC_ID"]);
                usercollect.C_ID = Convert.ToInt32(sdr["C_ID"]);
                usercollect.U_ID = Convert.ToInt32(sdr["U_ID"]);
                usercollect.UC_StartDay = Convert.ToDateTime(sdr["UC_StartDay"]);
                usercollect.UC_EndDay = Convert.ToDateTime(sdr["UC_EndDay"]);
                usercollect.UC_ComDay = Convert.ToInt32(sdr["UC_ComDay"]);
                usercollect.UC_EveWord = Convert.ToInt32(sdr["UC_EveWord"]);
                usercollect.UC_IsRead = Convert.ToInt32(sdr["UC_IsRead"]);
            }
            return usercollect;
        }
        /// <summary>
        /// 获取指定用户制定单词包的用户计划对象
        /// </summary>
        /// <param name="uID"></param>
        /// <param name="cID"></param>
        /// <returns></returns>
        public UserCollect GetUserCollectByUIDandCID(int uID, int cID)
        {
            string sql = "select * from UserCollect where U_ID=@U_ID and C_ID=@C_ID";
            SqlParameter[] p = {
                               new SqlParameter("@U_ID",uID),
                               new SqlParameter("@C_ID",cID)
                               };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, p);
            UserCollect usercollect = new UserCollect();
            while (sdr.Read())
            {
                usercollect.UC_ID = Convert.ToInt32(sdr["UC_ID"]);
                usercollect.C_ID = Convert.ToInt32(sdr["C_ID"]);
                usercollect.U_ID = Convert.ToInt32(sdr["U_ID"]);
                usercollect.UC_StartDay = Convert.ToDateTime(sdr["UC_StartDay"]);
                usercollect.UC_EndDay = Convert.ToDateTime(sdr["UC_EndDay"]);
                usercollect.UC_ComDay = Convert.ToInt32(sdr["UC_ComDay"]);
                usercollect.UC_EveWord = Convert.ToInt32(sdr["UC_EveWord"]);
                usercollect.UC_IsRead = Convert.ToInt32(sdr["UC_IsRead"]);
            }
            return usercollect;
        }
        
        /// <summary>
        /// 根据uid获取最近的单词包上
        /// </summary>
        /// <param name="u_ID"></param>
        /// <returns></returns>
        public UserCollect GetUserCollectUid(int u_ID)
        {
            string sql = "select top 1 UserCollect.*,Coures.c_Name,Coures.c_vocabulary from UserCollect join Coures on Coures.c_Id=UserCollect.c_Id where u_Id=@u_Id order by uc_startday desc";
            SqlParameter[] p = {
                               new SqlParameter("@u_Id",u_ID)
                               };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, p);
            UserCollect usercollect = new UserCollect();
            while (sdr.Read())
            {
                usercollect.UC_ID = Convert.ToInt32(sdr["UC_ID"]);
                usercollect.C_ID = Convert.ToInt32(sdr["C_ID"]);
                usercollect.U_ID = Convert.ToInt32(sdr["U_ID"]);
                usercollect.UC_StartDay = Convert.ToDateTime(sdr["UC_StartDay"]);
                usercollect.UC_EndDay = Convert.ToDateTime(sdr["UC_EndDay"]);
                usercollect.UC_ComDay = Convert.ToInt32(sdr["UC_ComDay"]);
                usercollect.UC_EveWord = Convert.ToInt32(sdr["UC_EveWord"]);
            }
            return usercollect;
        }

        public bool ModifyUserCollectbyuid(UserCollect usercollect)
        {
            string sql = "update UserCollect set C_ID=@C_ID,UC_StartDay=@UC_StartDay,UC_EndDay=@UC_EndDay,UC_ComDay=@UC_ComDay,UC_EveWord=@UC_EveWord,UC_IsRead=@UC_IsRead where U_ID=@U_ID";
            SqlParameter[] p = {
              new SqlParameter("@C_ID",usercollect.C_ID),
              new SqlParameter("@U_ID",usercollect.U_ID),
              new SqlParameter("@UC_EndDay",usercollect.UC_EndDay),
              new SqlParameter("@UC_ComDay",usercollect.UC_ComDay),
              new SqlParameter("@UC_StartDay",usercollect.UC_StartDay),
              new SqlParameter("@UC_EveWord",usercollect.UC_EveWord),
              new SqlParameter("@UC_IsRead",usercollect.UC_IsRead)
                              };
            int i = SQLHelper.ExecuteNonQuery(sql, CommandType.Text, p);
            return i > 0;

        }
    }
}
