using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

//我草

namespace RepastHelper
{
    public class SQLHelper
    {
        static string connStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
        /// <summary>
        /// 执行数据库的增删改操作，返回命令影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, CommandType type, SqlParameter[] p)
        {
            int n;
            using (SqlConnection cn = new SqlConnection(connStr))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.CommandType = type;
                    if (p != null)
                        cmd.Parameters.AddRange(p);
                    n = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    throw ex;
                }
            }
            return n;
        }
        /// <summary>
        /// 执行数据库的查询操作，返回DateReader
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, CommandType type, SqlParameter[] p)
        {
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(connStr);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;
                if (p != null)
                    cmd.Parameters.AddRange(p);
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                cn.Close();
                throw ex;
            }
            return dr;
        }
        /// <summary>
        /// 执行数据库的查询操作，返回结果首行首列的Object对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, CommandType type, SqlParameter[] p)
        {
            object o;
            using (SqlConnection cn = new SqlConnection(connStr))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.CommandType = type;
                    if (p != null)
                        cmd.Parameters.AddRange(p);
                    o = cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    throw ex;
                }
            }
            return o;
        }
    }
}
