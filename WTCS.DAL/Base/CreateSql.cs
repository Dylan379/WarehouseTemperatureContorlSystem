using Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WTCS.DAL.Base
{
    public class CreateSql
    {

        /// <summary>
        /// 生成插入sql语句和参数列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="cols"></param>
        /// <param name="isReturn"></param>
        /// <returns></returns>
        public static SqlModel GetInsertSqlAndParas<T>(T t, string cols, int isReturn)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = PropertyHelper.GetTypeProperties<T>(cols);
            string primaryKeyName = type.GetPrimary();

            //生成要插入的列  insert into tablename (Id,Name,Age...)
            string columns = string.Join(",", properties.Where(p => p.Name != primaryKeyName).Select(p => $"[{p.GetColName()}]"));
            //生成要插入的参数
            string paraColumns = string.Join(",", properties.Where(p => p.Name != primaryKeyName).Select(p => $"@{p.GetColName()}"));
            //参数数组的生成
            SqlParameter[] sqlParameters = CreateParameters<T>(properties, t);

            //SQL语句
            string sql = $"INSERT INTO [{type.GetTName()}] ({columns}) VALUES ({paraColumns})";

            if (isReturn == 1)
                sql += ";select @@ identity"; //获取刚刚生成的主键值
            return new SqlModel() { Sql = sql, SqlParaArray = sqlParameters };
        }

        /// <summary>
        /// 创建生成更新sql语句和参数列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="cols"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>

        public static SqlModel GetUpdateSqlAndParas<T>(T t, string cols, string strWhere)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = PropertyHelper.GetTypeProperties<T>(cols);
            string primaryKeyName = type.GetPrimary();

            //生成要更新的列 {1}  update tableName set col1 = @col1,col2 = @col2,....
            string columns = string.Join(",", properties.Where(p => p.Name != primaryKeyName)
                                                        .Select(p => string.Format("[{0}]=@{0}", p.GetColName())));
            //参数数组的生成
            SqlParameter[] sqlParameters = CreateParameters<T>(properties, t);
            //额外条件为空,则按主键查找
            if (string.IsNullOrEmpty(strWhere))
            {
                strWhere = $"{primaryKeyName}=@{primaryKeyName}";
            }
            //SQL语句
            string sql = $"UPDATE [{type.GetTName()}] SET {columns} WHERE {strWhere}";
            return new SqlModel() { Sql = sql, SqlParaArray = sqlParameters };
        }


        private static SqlParameter[] CreateParameters<T>(PropertyInfo[] properties, T t)
        {
            // 取出对象t中p属性值 ??判断是否为NULL
            SqlParameter[] arrParas = properties.Select(p => new SqlParameter("@" + p.GetColName(), p.GetValue(t) ?? DBNull.Value)).ToArray();
            return arrParas;
        }


    }
}
