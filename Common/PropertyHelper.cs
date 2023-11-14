using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class PropertyHelper
    {
        /// <summary>
        /// 获得指定类型的指定列名的属性数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static PropertyInfo[] GetTypeProperties<T>(string cols)
        {
            Type type = typeof(T);
            List<string> listCols = new List<string>(cols.Split(','));
            //List<string> listCols = StringHelper.GetStrArray(cols);
            //获取所有属性
            PropertyInfo[] properties = type.GetProperties();
            if (listCols != null && listCols.Count > 0)
            {
                properties = properties.Where(p => listCols.Contains(p.GetColName().ToLower())).ToArray();
            }

            return properties;
        }
    }
}
