using Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class AttributeHelper
    {
        /// <summary>
        /// 获取映射表名
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetTName(this Type type)
        {
            string tableName = string.Empty;
            //获取指定类型的自定义特性
            object[] attrs = type.GetCustomAttributes(false);
            foreach (var attr in attrs)
            {
                if (attr is TableAttribute)
                {
                    TableAttribute tableAttribute = attr as TableAttribute;
                    tableName = tableAttribute.TableName;
                }

                if (string.IsNullOrEmpty(tableName))
                {
                    tableName = type.Name;
                }
            }
            return tableName;
        }

        /// <summary>
        /// 获取映射列名
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns></returns>

        public static string GetColName(this PropertyInfo propertyInfo)
        {
            string columnName = string.Empty;
            //获取指定类型的自定义特性
            object[] attrs = propertyInfo.GetCustomAttributes(false);
            foreach (var attr in attrs)
            {
                if (attr is ColumnAttribute)
                {
                    ColumnAttribute columnAttribute = attr as ColumnAttribute;
                    columnName = columnAttribute.ColumnName;
                }
            }
            if (string.IsNullOrEmpty(columnName))
                columnName = propertyInfo.Name;
            return columnName;
        }

        /// <summary>
        /// 获取主键名
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetPrimary(this Type type)
        {
            object[] attrs = type.GetCustomAttributes(false);

            foreach (var attr in attrs)
            {
                if (attr is PrimaryKeyAttribute)
                {
                    PrimaryKeyAttribute primaryKeyAttribute = attr as PrimaryKeyAttribute;
                    return primaryKeyAttribute.PrimaryKeyName;
                }
            }
            return null;
        }

        /// <summary>
        /// 判断是否为主键
        /// </summary>
        /// <param name="type"></param>
        /// <param name="propertyInfo"></param>
        /// <returns></returns>
        public static bool IsPrimary(this Type type, PropertyInfo propertyInfo)
        {
            string primaryKeyName = type.GetPrimary();
            string columnName = propertyInfo.GetColName(); //指定属性映射列名
            return (primaryKeyName == columnName);

        }

        /// <summary>
        /// 判断是否是自增
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsIncrement(this Type type)
        {
            object[] attrs = type.GetCustomAttributes(false);

            foreach (var attr in attrs)
            {
                if (attr is PrimaryKeyAttribute)
                {
                    PrimaryKeyAttribute primaryKeyAttribute = attr as PrimaryKeyAttribute;
                    return primaryKeyAttribute.autoIncrement;
                }
            }
            return false;
        }

    }
}
