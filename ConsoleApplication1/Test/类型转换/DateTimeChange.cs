using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.类型转换
{
    public class DateTimeChange
    {
        /// <summary>
        /// 
        /// </summary>
        public void DateTimeToString()
        {
            DateTime dt = DateTime.Now;
            //string.Format("{0:u}", dt);
            Console.WriteLine(string.Format("{0:s}", dt));
            //Console.WriteLine(dt.ToString());
            //Console.WriteLine(string.Format("{0}", dt));
            //Console.WriteLine(dt.ToLocalTime().ToString());
            Console.WriteLine(dt.ToString("yyyy/MM/dd HH:mm:ss:ffff"));         //自定义格式
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss"));         //自定义格式

            //DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:ffff")
        }
    }
}
