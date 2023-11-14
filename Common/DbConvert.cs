using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class DbConvert
    {

        /// <summary>
        /// DataRow转换为实体类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataRow"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        private static T DataRowToModel<T>(DataRow dataRow, string cols)
        {
            T model = Activator.CreateInstance<T>();
            Type type = typeof(T);
            if (dataRow != null)
            {
                //获取指定列名的属性数组
                var properties = PropertyHelper.GetTypeProperties<T>(cols);
                foreach (var property in properties)
                {
                    string colName = property.GetColName();
                    if (dataRow[colName] is DBNull)
                    {
                        property.SetValue(model, null);
                    }
                    else
                    {
                        SetPropertyValue<T>(model, dataRow[colName], property);
                    }
                }
                return model;

            }
            else
                return default(T);
        }

        /// <summary>
        /// SqlDataReader转换为实体类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlDataReader"></param>
        /// <param name="cols"></param>
        /// <returns></returns>

        private static T SqlDataReaderModel<T>(SqlDataReader sqlDataReader, string cols)
        {
            T model = Activator.CreateInstance<T>();
            Type type = typeof(T);
            //获取指定列名的属性数组
            var properties = PropertyHelper.GetTypeProperties<T>(cols);
            if (sqlDataReader.Read())
            {
                foreach (var property in properties)
                {
                    string colName = property.GetColName();
                    if (sqlDataReader[colName] is DBNull)
                    {
                        property.SetValue(model, null);
                    }
                    else
                    {
                        SetPropertyValue<T>(model, sqlDataReader[colName], property);
                    }
                }
                return model;

            }
            else
                return default(T);
        }


        /// <summary>
        /// DataTable 转换为List<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataTable"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static List<T> DataTableToList<T>(DataTable dataTable, string cols)
        {
            List<T> list = new List<T>();
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    //将每行转换为一个对象
                    T model = DataRowToModel<T>(dataRow, cols);
                    list.Add(model);
                }
            }
            return list;
        }

        public static List<T> SqlDataReaderToList<T>(SqlDataReader sqlDataReader, string cols)
        {
            List<T> list = new List<T>();
            Type type = typeof(T);

            var properties = PropertyHelper.GetTypeProperties<T>(cols);
            while (sqlDataReader.Read())
            {
                T model = Activator.CreateInstance<T>();
                foreach (var property in properties)
                {
                    string colName = property.GetColName();
                    if (sqlDataReader[colName] is DBNull)
                    {
                        property.SetValue(model, null);
                    }
                    else
                    {
                        SetPropertyValue<T>(model, sqlDataReader[colName], property);
                    }
                }
                list.Add(model);
            }
            return list;
        }


        //设置属性值  属性的数据类型Nullable<int>
        private static void SetPropertyValue<T>(T model, object obj, PropertyInfo property)
        {

            //如果属性是泛型类型  且 泛型类型的定义是Nullable<>
            if (property.PropertyType.IsGenericType &&
                property.PropertyType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                //将得到的值转换为Nullable类型的基础类型,避免装箱拆箱等
                property.SetValue(model, Convert.ChangeType(obj,
                    Nullable.GetUnderlyingType(property.PropertyType)));
            }
            else
            {
                property.SetValue(model, Convert.ChangeType(obj, property.PropertyType));
            }
        }

    }
}
