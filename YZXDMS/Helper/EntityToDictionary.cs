using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YZXDMS.Helper
{
    /// <summary>
    /// 实体\字典转换类
    /// </summary>
    public class EntityToDictionary
    {
        /// <summary>  
        /// 将对象属性转换为key-value对  
        /// </summary>  
        /// <param name="o"></param>  
        /// <returns></returns>  
        public static Dictionary<String, Object> ToMap(Object o)
        {
            Dictionary<String, Object> map = new Dictionary<string, object>();

            Type t = o.GetType();

            PropertyInfo[] pi = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo p in pi)
            {
                MethodInfo mi = p.GetGetMethod();

                if (mi != null && mi.IsPublic)
                {
                    map.Add(p.Name, mi.Invoke(o, new Object[] { }));
                }
            }

            return map;
        }

        /// <summary>
        /// 将对象属性转换为key-value对，移除指定元素
        /// </summary>
        /// <param name="o"></param>
        /// <param name="removeProperty"></param>
        /// <returns></returns>
        public static Dictionary<String, Object> ToMap(Object o,string removeProperty)
        {
            Dictionary<String, Object> map = new Dictionary<string, object>();

            Type t = o.GetType();

            PropertyInfo[] pi = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo p in pi)
            {
                MethodInfo mi = p.GetGetMethod();
                //p.Name.ToUpper() != removeProperty.ToUpper()
                //string.Compare(p.Name,removeProperty,true)
                if (mi != null && mi.IsPublic && p.Name.ToUpper() != removeProperty.ToUpper())
                {
                    map.Add(p.Name, mi.Invoke(o, new Object[] { }));
                }
            }
            return map;
        }
    }
}
