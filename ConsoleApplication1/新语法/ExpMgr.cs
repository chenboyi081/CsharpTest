using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 新语法
{
    /*
     * 扩展方法的特点：
     * 1、此方法必须是一个静态方法
     * 2、此方法必须存放在静态类中
     * 3、方法的第一个参数的关键字总是以 this开头
     * 4、扩展方法如果和类型中的实例方法同名但是参数不一样，则会和实例方法构成重载
     *      但是 方法名称相同参数也相同，实例方法的优先级要高于扩展方法
     */
    public static class ExpMgr
    {
        public static string Fmtyyyymmdd(this  DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd");
        }

        public static string Fmtyyyymmddhhmmss(this DateTime dt, string from)
        {
            return dt.ToString("yyyy-MM-dd HH:mm:ss") + from;
        }

        public static string ToLower(this string str)
        {
            return str.ToLower() + "来源于扩展方法";
        }
    }
}
