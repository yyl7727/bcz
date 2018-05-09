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
    public class User_Dal
    {
        /// <summary>
        /// 判断是否存在该用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int ExistsUsers(Users user)
        {
            string sqlTest = "select count(*) from Users where U_NAME=@usersnaem and U_PASSWORD=@userspwd";
            SqlParameter[] par = new SqlParameter[2]
            {
                new SqlParameter("@usersnaem",user.U_NAME),
                new SqlParameter ("@userspwd",user.U_PASSWORD)
            };

            object obj = SQLHelper.ExecuteScalar(sqlTest, CommandType.Text, par);
            return int.Parse(obj.ToString());
        }

        /// <summary>
        /// 查询当前登录用户的ID
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public object QueryUserID(Users user)
        {
            string sqlTest =
                    @"select U_id from Users where U_NAME=@usersname and U_PASSWORD=@userspwd";
            SqlParameter[] par =
            {
                new SqlParameter ("@usersname",user.U_NAME),
                new SqlParameter ("@userspwd",user.U_PASSWORD)
            };
            return SQLHelper.ExecuteScalar(sqlTest, CommandType.Text, par);
        }

        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int Add_User(Users user)
        {
            string sql = "insert into Users(U_NAME,U_PASSWORD,U_REGISTERTIME) values(@a,@b,@c)";

            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter ("@a",user.U_NAME),
                new SqlParameter ("@b",user.U_PASSWORD),
                new SqlParameter ("@c",user.U_REGISTERTIME)
            };
            return SQLHelper.ExecuteNonQuery(sql, CommandType.Text, par);
        }

        /// <summary>
        /// 根据id获取指定用户对象
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public Users GetUser(int userID)
        {
            string sql = "select * from Users where U_ID=@u_Id";
            SqlParameter[] p = {
                               new SqlParameter("@u_Id",userID)
                               };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, p);
            Users user = new Users();
            while (sdr.Read())
            {
                user.U_ID = Convert.ToInt32(sdr["U_ID"]);
                user.U_NAME = sdr["U_NAME"].ToString();
                user.U_PASSWORD = sdr["U_PASSWORD"].ToString();
                user.U_REGISTERTIME = sdr["U_REGISTERTIME"].ToString();
            }
            return user;
        }

        /// <summary>
        /// 根据用户名获取指定用户对象
        /// </summary>
        /// <param name="lName"></param>
        /// <returns></returns>
        public Users GetUser(string u_Name)
        {
            string sql = "select * from Users where U_NAME=@u_Name";
            SqlParameter[] p = {
                               new SqlParameter("@u_Name",u_Name)
                               };
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, p);
            Users user = new Users();
            while (sdr.Read())
            {
                user.U_ID = Convert.ToInt32(sdr["U_ID"]);
                user.U_NAME = sdr["U_NAME"].ToString();
                user.U_PASSWORD = sdr["U_PASSWORD"].ToString();
                user.U_REGISTERTIME = sdr["U_REGISTERTIME"].ToString();
            }
            return user;
        }

        /// <summary>
        /// 获取所有用户列表
        /// </summary>
        /// <returns></returns>
        public List<Users> GetAllUser()
        {
            string sql = "select * from Users order by U_REGISTERTIME desc order by U_REGISTERTIME desc";
            SqlDataReader sdr = SQLHelper.ExecuteReader(sql, CommandType.Text, null);
            List<Users> list = new List<Users>();
            while (sdr.Read())
            {
                Users user = new Users();
                user.U_ID = Convert.ToInt32(sdr["U_ID"]);
                user.U_NAME = sdr["U_NAME"].ToString();
                user.U_PASSWORD = sdr["U_PASSWORD"].ToString();
                user.U_REGISTERTIME = sdr["U_REGISTERTIME"].ToString();
            }
            return list;
        }
    }
}

