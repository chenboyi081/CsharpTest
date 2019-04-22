using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// 枚举练习
    /// C# enum枚举 枚举类 很全的枚举说明和使用:https://www.cnblogs.com/sunShineJing/articles/2814619.html
    /// </summary>
    public class EnumTest
    {
        /// <summary>
        /// Enum.Parse方法：将一个或多个枚举常数的名称或数字值的字符串表示转换成等效的枚举对象。一个参数指定该操作是否不区分大小写。
        /// .ToString:将枚举对象转换成对应的值
        /// </summary>
        public void GetDirection01()
        {

            Console.WriteLine("请输入你的方向:");
            string strDir = Console.ReadLine();

            Direction dir = (Direction)Enum.Parse(typeof(Direction), strDir, true);
            Console.WriteLine(dir);     


            Direction dir1 = Direction.South;
            string s = dir1.ToString("d");

            Console.WriteLine(s);
        }


        /// <summary>
        /// Enmu测试2
        /// </summary>
        public void GetDirection02()
        {
            //Console.WriteLine("请选择你的方向:  0.东 1.西  2.南 3.北");
            int i = 2;
            Direction dir = (Direction)i;
            Console.WriteLine(dir);

            Direction dir2 = Direction.East;
            int i2 = (int)dir2;
            Console.WriteLine(i2);
        }


        public void GetDirection03(TimeOfDay time)
        {
            string result = string.Empty;
            switch (time)
            {
                case TimeOfDay.Moning:
                    result = "上午";
                    break;
                case TimeOfDay.Afternoon:
                    result = "下午";
                    break;
                case TimeOfDay.Evening:
                    result = "晚上";
                    break;
                default:
                    result = "未知";
                    break;
            }
            Console.WriteLine(result);
        }

        public void GetDirection04(TimeOfDay time)
        {
            string result = string.Empty;

            Console.WriteLine(result);
        }

        /// <summary>
        /// 从枚举类型和它的特性读出并返回一个键值对
        /// </summary>
        /// <param name="enumType">Type,该参数的格式为typeof(需要读的枚举类型)</param>
        /// <returns>键值对</returns>
        public static NameValueCollection GetNVCFromEnumValue(Type enumType)
        {
            NameValueCollection nvc = new NameValueCollection();
            Type typeDescription = typeof(DescriptionAttribute);
            System.Reflection.FieldInfo[] fields = enumType.GetFields();
            string strText = string.Empty;
            string strValue = string.Empty;
            foreach (FieldInfo field in fields)
            {
                if (field.FieldType.IsEnum)
                {
                    strValue = ((int)enumType.InvokeMember(field.Name, BindingFlags.GetField, null, null, null)).ToString();
                    object[] arr = field.GetCustomAttributes(typeDescription, true);
                    if (arr.Length > 0)
                    {
                        DescriptionAttribute aa = (DescriptionAttribute)arr[0];
                        strText = aa.Description;
                    }
                    else
                    {
                        strText = field.Name;
                    }
                    nvc.Add(strText, strValue);
                }
            }
            return nvc;
        }
    }

    public enum TimeOfDay
    {
        [Description("上午")]
        Moning = 0,
        [Description("下午")]
        Afternoon = 1,
        [Description("晚上")]
        Evening = 2,
    };

    enum Direction : byte
    {
        East = 0,
        South = 1,
        Middle = 4,
        West = 2,
        North = 3
    }

    enum State
    {
        在线, 离线, 吃饭, Q我吧
    }

    enum ZhengZhiMianMao
    {
        共产党员,
        共青团员,
        少先队员,
        九三学社,
        其他党派,
        群众
    }
}
