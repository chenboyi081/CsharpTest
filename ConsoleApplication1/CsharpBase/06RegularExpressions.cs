using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBase
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// 正则表达式
    /// </summary>
    public class _06RegularExpressions
    {
        string RegexStr = string.Empty;
        //参考:https://www.runoob.com/csharp/csharp-regular-expressions.html

         /// <summary>
         /// 判断是否为数字(开头和结尾都是数字)
         /// </summary>
        public void IsNumic(string strNum)
        {
            RegexStr = "^[0-9]+$"; //匹配字符串的开始和结束是否为0-9的数字[定位字符]
            Console.WriteLine("判断"+ strNum + "是否为数字:{0}", Regex.IsMatch(strNum, RegexStr));
        }

        /// <summary>
        ///  匹配字符串中间是否包含数字(这里没有从开始进行匹配噢,任意位子只要有一个数字即可)
        /// </summary>
        /// <param name="strNum"></param>
        public void IsContainNumic(string strNum)
        {
            RegexStr = @"\d+"; //匹配字符串的开始和结束是否为0-9的数字[定位字符]
            Console.WriteLine("判断" + strNum + "是否包含数字:{0}", Regex.IsMatch(strNum, RegexStr));
        }


    }
}
