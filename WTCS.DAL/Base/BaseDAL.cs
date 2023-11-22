using Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTCS.DbUtility;

namespace WTCS.DAL.Base
{
    public class BaseDAL<T> : BQuery<T> where T : class
    {

        /// <summary>
        /// 单个插入sql操作
        /// </summary>
        /// <param name="t"></param>
        /// <param name="strCols"></param>
        /// <param name="isReturn"></param>
        /// <returns></returns>
        public int Add(T t, string strCols, int isReturn)
        {
            if (t == null)
                return 0;
            //获取生成的sql和参数列表
            SqlModel insert = CreateSql.GetInsertSqlAndParas<T>(t, strCols, isReturn);
            //执行SQL命令
            if (isReturn == 0)//受影响的行数
                return SqlHelper.ExecuteNonQuery(insert.Sql, 1, insert.SqlParaArray);
            else
            {
                object old = SqlHelper.ExecuteScalar(insert.Sql, 1, insert.SqlParaArray);
                if (old != null && old.ToString() != "")
                    return int.Parse(old.ToString());
                else
                    return 0;
            }

        }


        /// <summary>
        /// 批量插入
        /// </summary>
        /// <param name="list"></param>
        /// <param name="strCols"></param>
        /// <returns></returns>
        public bool AddList(List<T> list, string strCols)
        {
            if (list == null || list.Count == 0)
                return false;

            List<CommandInfo> comList = new List<CommandInfo>();
            foreach (T t in list)
            {
                SqlModel insert = CreateSql.GetInsertSqlAndParas<T>(t, strCols, 0);
                CommandInfo com = new CommandInfo(insert.Sql, false, insert.SqlParaArray);
                comList.Add(com);
            }

            return SqlHelper.ExecuteTrans(comList);
        }

        /// <summary>
        /// 修改信息实体
        /// </summary>
        /// <param name="t"></param>
        /// <param name="strCols">要修改的列</param>
        /// <param name="strWhere">其他附加条件</param>
        /// <param name="parameters">参数数组</param>
        /// <returns></returns>
        public bool Update(T t, string strCols, string strWhere, params SqlParameter[] parameters)
        {
            if (t == null)
                return false;
            SqlModel update = CreateSql.GetUpdateSqlAndParas<T>(t, strCols, strWhere);
            List<SqlParameter> parasList = update.SqlParaArray.ToList();
            if (parameters != null && parameters.Length > 0)
                parasList.AddRange(parameters);
            //执行sql语句
            return SqlHelper.ExecuteNonQuery(update.Sql, 1, parasList.ToArray()) > 0;
        }

        /// <summary>
        /// 修改实体,以主键为定位
        /// </summary>
        /// <param name="t"></param>
        /// <param name="strCols">包括主键列</param>
        /// <returns></returns>
        public bool Update(T t, string strCols)
        {
            if (t == null)
                return false;
            else
                return Update(t, strCols, "");
        }

        /// 批量更新
        /// </summary>
        /// <param name="list"></param>
        /// <param name="strCols"></param>
        /// <returns></returns>
        public bool UpdateList(List<T> list, string strCols)
        {
            if (list == null || list.Count == 0)
                return false;

            List<CommandInfo> comList = new List<CommandInfo>();
            foreach (T t in list)
            {
                SqlModel update = CreateSql.GetUpdateSqlAndParas<T>(t, strCols, "");
                CommandInfo com = new CommandInfo(update.Sql, false, update.SqlParaArray);
                comList.Add(com);
            }

            return SqlHelper.ExecuteTrans(comList);
        }

        /// <summary>
        /// 按条件删除数据(假删除,包含可以恢复)  真删除---Delete
        /// </summary>
        /// <param name="actType">删除的类型 0-假删除 1-真删除</param>
        /// <param name="strWhere">条件</param>
        /// <param name="isDeleted">删除标记</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public bool Delete(int delType, string strWhere, int isDeleted, SqlParameter[] parameters)
        {
            Type type = typeof(T);
            string delSql = "";
            if (delType == 1)
                delSql = CreateSql.CreatDeleteSql<T>(strWhere);
            else
                delSql = CreateSql.CreatLogicDeleteSql<T>(strWhere, isDeleted);
            List<CommandInfo> list = new List<CommandInfo>();
            //可能是批量的删除或修改
            list.Add(new CommandInfo
            {
                CommandText = delSql,
                IsProc = false,
                Paras = parameters
            });
            return SqlHelper.ExecuteTrans(list);
        }

        /// <summary>
        /// 按照ID进行删除
        /// </summary>
        /// <param name="id">主键Id</param>
        /// <param name="delType">删除类型 0-假删除 1-真删除</param>
        /// <param name="isDeleted">删除标记</param>
        /// <returns></returns>
        public bool Delete(int id, int delType, int isDeleted)
        {
            Type type = typeof(T);
            string strWhere = $"[{type.GetPrimary()}]=@Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            return Delete(delType, strWhere, isDeleted, parameters);
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="idList"></param>
        /// <param name="delType"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public bool DeleteList(List<int> idList, int delType, int isDeleted)
        {
            Type type = typeof(T);
            List<CommandInfo> comList = new List<CommandInfo>();
            foreach (int id in idList)
            {
                string strWhere = $"[{type.GetPrimary()}]=@Id";
                string delSql = "";
                if (delType == 1)
                    delSql = CreateSql.CreatDeleteSql<T>(strWhere);
                else
                    delSql = CreateSql.CreatLogicDeleteSql<T>(strWhere, isDeleted);
                SqlParameter[] parameters = { new SqlParameter("@Id", id) };
                CommandInfo com = new CommandInfo(delSql, false, parameters);
                comList.Add(com);
            }
            return SqlHelper.ExecuteTrans(comList);
        }
    }
}
