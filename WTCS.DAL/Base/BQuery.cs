using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTCS.DbUtility;

namespace WTCS.DAL.Base
{
    public class BQuery<T>
    {
        /// <summary>
        /// 按条件查询获取实体信息
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="strCols">指定列</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public T GetModel(string strWhere, string strCols, params SqlParameter[] parameters)
        {
            //生成查询语句
            string selectSql = CreateSql.CreatSelectSql<T>(strWhere, strCols);
            //生成reader对象
            SqlDataReader reader = SqlHelper.ExecuteReader(selectSql, 1, parameters);
            //转换为实体对象
            T model = DbConvert.SqlDataReaderToModel<T>(reader, strCols);
            reader.Close();
            return model;
        }

        /// <summary>
        /// 根据Id获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <param name="strCols"></param>
        /// <returns></returns>
        public T GetById(int id, string strCols)
        {
            Type type = typeof(T);
            //构建条件
            string strWhere = $"[{type.GetPrimary()}]=@Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            return GetModel(strWhere, strCols, parameters);
        }

        /// <summary>
        /// 判断是否存在
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public bool Exists(string strWhere, params SqlParameter[] parameters)
        {
            Type type = typeof(T);
            string sql = $"SELECT COUNT(1) FROM {type.GetTName()} WHERE {strWhere}";
            object val = SqlHelper.ExecuteScalar(sql, 1, parameters);
            if (int.Parse(val.ToString()) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 通过名字查询
        /// </summary>
        /// <param name="sName">名称列名</param>
        /// <param name="vName">名称对应值</param>
        /// <returns></returns>
        public bool ExistsByName(string sName, string vName)
        {
            string strWHere = $"{sName}=@{sName}";
            strWHere += "and IsDeleted=0";//有效数据中查询
            SqlParameter[] parameters = { new SqlParameter($"@{sName}", vName) };
            return Exists(strWHere, parameters);
        }

        /// <summary>
        /// 同一级别下,检查是否同名
        /// </summary>
        /// <param name="sName">名称列名</param>
        /// <param name="vName">名称值</param>
        /// <param name="sParent">父级Id列名</param>
        /// <param name="parId">父级Id</param>
        /// <returns></returns>
        public bool ExistsByName(string sName, string vName, string sParent, int parId)
        {
            string strWhere = $"{sName}=@{sName}";
            if (parId > 0)
                strWhere += $" and {sParent}=@{sParent}";
            strWhere += " and IsDeleted=0";
            SqlParameter[] paras = {
                                new SqlParameter($"@{sName}", vName),
                                 new SqlParameter($"@{sParent}", parId)
                       };
            return Exists(strWhere, paras);
        }

        /// <summary>
        /// 获取所有列表
        /// </summary>
        /// <param name="strCols"></param>
        /// <param name="isDeleted">删除标识值 0-未删除 1-已删除</param>
        /// <returns></returns>
        public List<T> GetModelList(string strCols, int isDeleted)
        {
            return GetModelList($"IsDeleted={isDeleted}", strCols);
        }

        /// <summary>
        /// 按条件查询返回实体列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="strCols"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public List<T> GetModelList(string strWhere, string strCols, params SqlParameter[] parameters)
        {
            //生成查询语句
            string selectSql = CreateSql.CreatSelectSql<T>(strWhere, strCols);
            //生成reader对象
            SqlDataReader reader = SqlHelper.ExecuteReader(selectSql, 1, parameters);
            //转换为实体对象
            List<T> list = DbConvert.SqlDataReaderToList<T>(reader, strCols);
            reader.Close();
            return list;
        }

        /// <summary>
        /// 按条件返回带序号的列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="strCols">不能包含Id</param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public List<T> GetRowsModelList(string strWhere, string strCols, params SqlParameter[] parameters)
        {
            //生成查询语句
            string selectSql = CreateSql.CreatRowsSelectSql<T>(strWhere, strCols);
            //生成reader对象
            SqlDataReader reader = SqlHelper.ExecuteReader(selectSql, 1, parameters);
            //转换为实体对象
            List<T> list = DbConvert.SqlDataReaderToList<T>(reader, strCols + ",Id");
            reader.Close();
            return list;
        }


        /// <summary>
        /// 执行sql语句或存储过程,返回一个datatable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProc"></param>
        /// <param name="strCols"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataTable GetList(string sql, int isProc, params SqlParameter[] parameters)
        {
            DataTable dataTable = SqlHelper.GetDataTable(sql, isProc, parameters);
            return dataTable;
        }

        /// <summary>
        /// 执行sql语句或存储过程,返回一个dataset
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProc"></param>
        /// <param name="strCols"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string sql, int isProc, params SqlParameter[] parameters)
        {
            DataSet dataTable = SqlHelper.GetDataSet(sql, isProc, parameters);
            return dataTable;
        }


        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <param name="sql"></param>
        /// <param name="strCols"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        //public PageModel<T> GetPageList(string sql, string strCols, int startIndex, int pageSize)
        //{
        //    SqlParameter[] paras ={
        //                new SqlParameter("@sql",sql),
        //                new SqlParameter("@startIndex",startIndex),
        //                new SqlParameter("@endIndex",startIndex +pageSize -1)
        //                         };
        //    DataSet ds = GetDataSet("proc_Page", 2, paras);
        //    int total = (int)ds.Tables[0].Rows[0][0];
        //    List<T> list = DbConvert.DataTableToList<T>(ds.Tables[1], strCols);
        //    return new PageModel<T>() { TotalCount = total, ReList = list };
        //}

    }
}
