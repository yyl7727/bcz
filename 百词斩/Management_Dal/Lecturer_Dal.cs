using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management_Model;
using RepastHelper;

namespace Management_Dal
{
    public class Lecturer_Dal
    {
        /// <summary>
        /// 判断是否存在该管理员
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int ExistsUsers(Lecturer lecturer)
        {
            string sqlTest = "select count(*) from lecturer where L_NAME=@usersnaem and L_PASS=@userspwd";
            SqlParameter[] par = new SqlParameter[2]
            {
                new SqlParameter("@usersnaem",lecturer.L_NAME),
                new SqlParameter ("@userspwd",lecturer.L_PASS)
            };

            object obj = SQLHelper.ExecuteScalar(sqlTest, CommandType.Text, par);
            return int.Parse(obj.ToString());
        }

        /// <summary>
        /// 查询当前登录管理员的ID
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public object QueryAdminID(Lecturer lecturer)
        {
            string sqlTest =
                    @"select id from Lecturer where L_NAME=@usersname and L_PASS=@userspwd";
            SqlParameter[] par =
            {
                new SqlParameter ("@usersname",lecturer.L_NAME),
                new SqlParameter ("@userspwd",lecturer.L_PASS)
            };
            return SQLHelper.ExecuteScalar(sqlTest, CommandType.Text, par);
        }

        /// <summary>
        /// 增加管理员
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int Add_User(Lecturer lecturer)
        {
            string sql = "insert into lecturer(L_VDATE,L_NAME,L_PASS) values(@a,@b,@c)";

            SqlParameter[] par = new SqlParameter[]
            {
                //new SqlParameter("@a",lecturer.L_ID),
                new SqlParameter ("@a",lecturer.L_VDATE),
                new SqlParameter ("@b",lecturer.L_NAME),
                new SqlParameter ("@c",lecturer.L_PASS)
            };
            return SQLHelper.ExecuteNonQuery(sql, CommandType.Text, par);
        }

        /// <summary>
        /// 删除管理员
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int Delete_User(int i)
        {
            string sql = @"delete from lecturer where L_id=@a";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@a",i),
            };
            return SQLHelper.ExecuteNonQuery(sql, CommandType.Text, par);
        }

        /// <summary>
        /// 查询所有管理员
        /// </summary>
        /// <returns></returns>
        public List<Lecturer> All_Lecturer()
        {
            List<Lecturer> ll = new List<Lecturer>();

            string sqlTest = "select * from Lecturer";

            SqlDataReader sdr = SQLHelper.ExecuteReader(sqlTest, CommandType.Text, null);

            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Lecturer l = new Lecturer();
                    l.L_ID = int.Parse(sdr["L_ID"].ToString());
                    l.L_VDATE = sdr["L_VDATE"].ToString();
                    l.L_NAME = sdr["L_NAME"].ToString();
                    l.L_PASS = sdr["L_PASS"].ToString();

                    ll.Add(l);
                }
            }
            sdr.Close();

            return ll;
        }

        /// <summary>
        /// 修改管理员
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int Alter_User(int i,string name)
        {
            string sql = @"update lecturer set L_NAME = @b where L_ID = @a";
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@a",i),
                new SqlParameter("@b",name)
            };
            return SQLHelper.ExecuteNonQuery(sql, CommandType.Text, par);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <returns></returns>
        public int Alter_pwd(Lecturer l)
        {
            string sql = @"update lecturer set L_PASS=@a where L_NAME=@b";

            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@a",l.L_PASS),
                new SqlParameter ("@b",l.L_NAME)
            };
            return SQLHelper.ExecuteNonQuery(sql, CommandType.Text, par);
        }
    }
}
