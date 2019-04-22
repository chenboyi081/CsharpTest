using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// 枚举练习
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
    }

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
