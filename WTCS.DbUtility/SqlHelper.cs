using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTCS.DbUtility
{
    public class SqlHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        private static readonly string connectStr = ConfigurationManager.ConnectionStrings["connectStr"].ConnectionString;

        /// <summary>
        /// 创建命令
        /// </summary>
        /// <param name="connection">传入sql连接</param>
        /// <param name="sql">sql语句</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="sqlTransaction"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        private static SqlCommand BuilderCommand(SqlConnection connection, string sql,
                                                 int cmdType, SqlTransaction sqlTransaction,
                                                 params SqlParameter[] sqlParameters)
        {
            if (connection == null)
                throw new ArgumentNullException("连接对象不能为空!");
            SqlCommand command = new SqlCommand(sql, connection);
            if (cmdType == 2)
                command.CommandType = CommandType.StoredProcedure;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            if (sqlTransaction != null)
                command.Transaction = sqlTransaction;
            if (sqlParameters != null && sqlParameters.Length > 0)
            {
                command.Parameters.Clear();
                command.Parameters.AddRange(sqlParameters);
            }
            return command;
        }


        /// <summary>
        /// 添加参数集合
        /// </summary>
        /// <param name="command"></param>
        /// <param name="sqlParameters"></param>
        public static void AddParas(IDbCommand command, SqlParameter[] sqlParameters)
        {
            command.Parameters.Clear();
            if (sqlParameters != null && sqlParameters.Length > 0)
            {
                foreach (var item in sqlParameters)
                {
                    command.Parameters.Add(item);
                }
            }
        }


        /// <summary>
        /// 增删改的通用方法
        /// 执行SQL语句或存储过程,返回受影响行数
        /// SQL注入
        /// </summary>
        /// <param name="sql">sql语句或存储过程名</param>
        /// <param name="cmdType">执行脚本类型:1.sql语句,2.存储过程</param>
        /// <param name="sqlParameters">参数列表</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, int cmdType, params SqlParameter[] sqlParameters)
        {
            int result = 0;//返回结果
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                //执行脚本的对象cmd
                SqlCommand command = BuilderCommand(connection, sql, cmdType, null, sqlParameters);
                result = command.ExecuteNonQuery();
                command.Parameters.Clear();
            }

            return result;
        }

        /// <summary>
        /// 执行sql查询,返回第一行第一列的值
        /// </summary>
        /// <param name="sql">sql语句或存储过程名</param>
        /// <param name="cmdType">执行脚本类型:1.sql语句,2.存储过程</param>
        /// <param name="sqlParameters">参数列表</param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, int cmdType, params SqlParameter[] sqlParameters)
        {
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                //执行脚本的对象cmd
                SqlCommand command = BuilderCommand(connection, sql, cmdType, null, sqlParameters);
                object result = command.ExecuteScalar();
                command.Parameters.Clear();
                if (result == null || result == DBNull.Value)
                    return null;
                else
                    return result;
            }
        }

        /// <summary>
        /// 执行sql查询,返回SqlDataReader对象
        /// </summary>
        /// <param name="sql">sql语句或存储过程名</param>
        /// <param name="cmdType">执行脚本类型:1.sql语句,2.存储过程</param>
        /// <param name="sqlParameters">参数列表</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, int cmdType, params SqlParameter[] sqlParameters)
        {
            SqlConnection connection = new SqlConnection(connectStr);
            //执行脚本的对象cmd
            SqlCommand command = BuilderCommand(connection, sql, cmdType, null, sqlParameters);
            SqlDataReader reader;

            try
            {
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception("创建reader对象异常", ex);
            }
        }


        /// <summary>
        /// 执行查询,查询结果填充到DataTable只针对查询一个表的情况
        /// </summary>
        /// <param name="sql">sql语句或存储过程名</param>
        /// <param name="cmdType">执行脚本类型:1.sql语句,2.存储过程</param>
        /// <param name="sqlParameters">参数列表</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, int cmdType, params SqlParameter[] sqlParameters)
        {
            DataTable dataTable = null;
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                //执行脚本的对象cmd
                SqlCommand command = BuilderCommand(connection, sql, cmdType, null, sqlParameters);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                command.Parameters.Clear();
            }

            return dataTable;
        }


        /// <summary>
        /// 执行查询,查询结果填充到DataSet只,针对多个结果集的情况
        /// </summary>
        /// <param name="sql">sql语句或存储过程名</param>
        /// <param name="cmdType">执行脚本类型:1.sql语句,2.存储过程</param>
        /// <param name="sqlParameters">参数列表</param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, int cmdType, params SqlParameter[] sqlParameters)
        {
            DataSet dataSet = null;
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                //执行脚本的对象cmd
                SqlCommand command = BuilderCommand(connection, sql, cmdType, null, sqlParameters);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                command.Parameters.Clear();
            }

            return dataSet;
        }

        public static bool ExecuteTrans(List<string> sqlList)
        {
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();//必要条件
                SqlTransaction sqlTransaction = connection.BeginTransaction();
                SqlCommand command = BuilderCommand(connection, "", 1, sqlTransaction);
                try
                {
                    int count = 0;
                    for (int i = 0; i < sqlList.Count; i++)
                    {
                        if (sqlList[i].Length > 0)
                        {
                            command.CommandText = sqlList[i];
                            command.CommandType = CommandType.Text;
                            count += command.ExecuteNonQuery();
                        }
                    }
                    sqlTransaction.Commit();//提交
                    return true;
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();//回滚 
                    throw new Exception("执行事务出现异常", ex);
                }
            }
        }

        /// <summary>
        /// 事务  批量执行CommandInfo 包括sql,脚本类型,参数列表
        /// </summary>
        /// <param name="comList"></param>
        /// <returns></returns>
        public static bool ExecuteTrans(List<CommandInfo> comList)
        {
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();//必要条件
                SqlTransaction sqlTransaction = connection.BeginTransaction();
                SqlCommand command = BuilderCommand(connection, "", 1, sqlTransaction);
                try
                {
                    int count = 0;
                    for (int i = 0; i < comList.Count; i++)
                    {
                        command.CommandText = comList[i].CommandText;
                        if (comList[i].IsProc)
                            command.CommandType = CommandType.StoredProcedure;
                        else
                            command.CommandType = CommandType.Text;
                        if (comList[i].Paras != null && comList[i].Paras.Length > 0)
                        {
                            command.Parameters.Clear();
                            foreach (var item in comList[i].Paras)
                            {
                                command.Parameters.Add(item);
                            }
                        }
                        count += command.ExecuteNonQuery();
                    }


                    sqlTransaction.Commit();//提交
                    return true;
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();//回滚 
                    throw new Exception("执行事务出现异常", ex);
                }
            }
        }


        /// <summary>
        /// 一个一个执行的命令
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        public static T ExecuteTrans<T>(Func<IDbCommand, T> action)
        {
            using (IDbConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();
                IDbTransaction trans = connection.BeginTransaction();
                IDbCommand command = connection.CreateCommand();
                command.Transaction = trans;
                return action(command);
            }
        }
    }
}
