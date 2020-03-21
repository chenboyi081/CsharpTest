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
        //参考:https://m.jb51.net/article/360.htm

        #region 一、字符串匹配
        /// <summary>
        /// 判断是否为数字(开头和结尾都是数字)
        /// </summary>
        public void IsNumic(string strNum)
        {
            RegexStr = "^[0-9]+$"; //匹配字符串的开始和结束是否为0-9的数字[定位字符]
            Console.WriteLine("判断" + strNum + "是否为数字:{0}", Regex.IsMatch(strNum, RegexStr));
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

        /// <summary>
        /// 匹配以Hello开头的任意字符
        /// </summary>
        /// <param name="str"></param>
        public void IsBeginHello(string str)
        {
            RegexStr = @"^Hello[\w\W]*"; //已Hello开头的任意字符(\w\W：组合可匹配任意字符)
            Console.WriteLine(str + "是否以Hello开头:{0}", Regex.IsMatch(str, RegexStr, RegexOptions.IgnoreCase));
            //RegexOptions.IgnoreCase：指定不区分大小写的匹配。
        }
        #endregion

        #region 二、字符串查找
        /// <summary>
        /// 获取链接标签中的链接地址
        /// </summary>
        /// <param name=""></param>
        public void getLinkValue(string strHerf)
        {
            RegexStr = @"href=""[\S]+"""; // ""匹配"
            Match mt = Regex.Match(strHerf, RegexStr);
            Console.WriteLine("{0}。", strHerf);
            Console.WriteLine("获得href中的值：{0}。", mt.Value);
        }

        /// <summary>
        /// 获取H1标题中的值
        /// </summary>
        /// <param name="strHead"></param>
        public void getHeadValue(string strHead)
        {
            RegexStr = @"<h[^23456]>[\S]+<h[1]>"; //<h[^23456]>:匹配h除了2,3,4,5,6之中的值,<h[1]>:h匹配包含括号内元素的字符
            Console.WriteLine("{0}。getHeadValue：{1}", strHead, Regex.Match(strHead, RegexStr, RegexOptions.IgnoreCase).Value);
            //RegexOptions.IgnoreCase:指定不区分大小写的匹配。
        }


        /// <summary>
        /// 匹配ab和字母 或 ij和字母
        /// </summary>
        /// <param name="str"></param>
        public void getABorIJbegin(string str)
        {
            RegexStr = @"ab\w+|ij\w{1,}"; //匹配ab和字母 或 ij和字母
            Console.WriteLine("{0}。多选结构：{1}", str, Regex.Match(str, RegexStr).Value);
        }

        /// <summary>
        /// 匹配名字
        /// </summary>
        /// <param name="strName"></param>
        public void getReName(string strName)
        {
            RegexStr = @"张三?丰"; //?匹配前面的子表达式零次或一次。
            Console.WriteLine("{0}。可选项元素：{1}", strName, Regex.Match(strName, RegexStr).Value);
        }


        /// <summary>
        /// 匹配特殊字符
        /// </summary>
        /// <param name="str"></param>
        public void getSpeicalStr(string str)
        {
            RegexStr = @"Asp\.net"; //匹配Asp.net字符，因为.是元字符他会匹配除换行符以外的任意字符。这里我们只需要他匹配.字符即可。所以需要转义\.这样表示匹配.字符
            Console.WriteLine("{0}。匹配Asp.net字符：{1}", str, Regex.Match(str, RegexStr).Value);
        }
        #endregion

        #region 三、贪婪匹配和懒惰匹配,以及分组
        /// <summary>
        /// 贪婪匹配和懒惰匹配
        /// </summary>
        /// <param name="str"></param>
        public void greedAndLazy(string str = "fooot")
        {
            //贪婪匹配
            RegexStr = @"f[o]+";
            Match m1 = Regex.Match(str, RegexStr);
            Console.WriteLine("{0}贪婪匹配(匹配尽可能多的字符)：{1}", str, m1.ToString());

            //懒惰匹配
            RegexStr = @"f[o]+?";
            Match m2 = Regex.Match(str, RegexStr);
            Console.WriteLine("{0}懒惰匹配(匹配尽可能少重复)：{1}", str, m2.ToString());
        }

        /// <summary>
        /// 在做爬虫时我们经常获得a标签中一些有用信息。如href,title和显示内容等。
        /// </summary>
        /// <param name="href"></param>
        public void getHrefInfo(string TaobaoLink = "<a href=\"http://www.taobao.com\" title=\"淘宝网 - 淘！我喜欢\" target=\"_blank\">淘宝</a>")
        {
            RegexStr = @"<a[^>]+href=""(\S+)""[^>]+title=""([\s\S]+?)""[^>]+>(\S+)</a>";
            Match mat = Regex.Match(TaobaoLink, RegexStr);
            for (int i = 0; i < mat.Groups.Count; i++)
            {
                Console.WriteLine("第" + i + "组：" + mat.Groups[i].Value);
            }
        }


        //(?<name>exp) 分组取名
        //当我们匹配分组信息过多后，在某种场合只需取当中某几组信息。这时我们可以对分组取名。通过分组名称来快速提取对应信息。
        /// <summary>
        /// 获取简历中的信息
        /// </summary>
        public void getInfoByGroupName()
        {
            string Resume = "基本信息姓名:CK|求职意向:.NET软件工程师|性别:男|学历:本专|出生日期:1988-08-08|户籍:湖北.孝感|E - Mail:9245162@qq.com|手机:15000000000";
            RegexStr = @"姓名:(?<name>[\S]+)\|\S+性别:(?<sex>[\S]{1})\|学历:(?<xueli>[\S]{1,10})\|出生日期:(?<Birth>[\S]{10})\|[\s\S]+手机:(?<phone>[\d]{11})";
            Match matc = Regex.Match(Resume, RegexStr);
            Console.WriteLine("姓名：{0},手机号：{1}", matc.Groups["name"].ToString(), matc.Groups["phone"].ToString());
        }

        /// <summary>
        /// 获得页面中A标签中href值
        /// </summary>
        public void getAllHrefValue()
        {
            string PageInfo = @"<html>
                     <div id=""div1"">
                      <a href=""http://www.baidu.con"" target=""_blank"">百度</a>
                      <a href=""http://www.taobao.con"" target=""_blank"">淘宝</a>
                      <a href=""http://www.cnblogs.com"" target=""_blank"">博客园</a>
                      <a href=""http://www.google.con"" target=""_blank"">google</a>
                     </div>
                     <div id=""div2"">
                      <a href=""/zufang/"">整租</a>
                      <a href=""/hezu/"">合租</a>
                      <a href=""/qiuzu/"">求租</a>
                      <a href=""/ershoufang/"">二手房</a>
                      <a href=""/shangpucz/"">商铺出租</a>
                     </div>
                    </html>";
            RegexStr = @"<a[^>]+href=""(?<href>[\S]+?)""[^>]*>(?<text>[\S]+?)</a>";
            MatchCollection mc = Regex.Matches(PageInfo, RegexStr);
            foreach (Match item in mc)
            {
                Console.WriteLine("href:{0}--->text:{1}", item.Groups["href"].ToString(), item.Groups["text"].ToString());
            }
        }
        #endregion

        #region 四、Replace 替换字符串
        //Replace 替换字符串

        /// <summary>
        /// 过滤不良词汇
        /// </summary>
        /// <param name="PageInputStr"></param>
        public void replaceWords(string PageInputStr = "靠.TMMD,今天真不爽....")
        {
            RegexStr = @"靠|TMMD|妈的";
            Regex rep_regex = new Regex(RegexStr);
            Console.WriteLine("用户输入信息：{0}", PageInputStr);
            Console.WriteLine("页面显示信息：{0}", rep_regex.Replace(PageInputStr, "***"));
        }
        #endregion

        #region 五、 Split 拆分字符串
        //Split 拆分字符串
        public void splitWords(string SplitInputStr = "1xxxxx.2ooooo.3eeee.4kkkkkk.")
        {
            RegexStr = @"\d";
            Regex spl_regex = new Regex(RegexStr);
            string[] str = spl_regex.Split(SplitInputStr);
            foreach (string item in str)
            {
                Console.WriteLine(item);
            }
        } 
        #endregion

    }
}
