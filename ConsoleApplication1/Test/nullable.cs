using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// nullable类型测试
    /// </summary>
    public class nullable
    {
        int? nullIntValue = new Nullable<int>();

        /// <summary>
        /// 测试显示nullable类型
        /// </summary>
        public void print()
        {
            int? intTest = 999;
            Console.WriteLine(intTest.ToString());
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

