using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// 字符串处理类
    /// </summary>
    public class StringTest
    {

        string a = "hello";
        string b = "h";

        //Test1: 尽管 string 是引用类型，但定义相等运算符（== 和 !=）是为了比较 string 对象（而不是引用）的值。 这使得对字符串相等性的测试更为直观。 例如：
        public void stringequal()
        {

            b += "ello";
            Console.WriteLine(a == b);        //result:true
            Console.WriteLine((object)a == (object)b);    //result:false
        }

        //Test2:[] 运算符可以用于对 string 的各个字符的只读访问。
        public void StringTest_operationalcharacter()
        {
            char x = a[2];
            Console.WriteLine(x);         //result:l
        }

        /// <summary>
        /// （实用）Test3:字符串文本可包含任何字符。 包括转义序列。 下面的示例使用转义序列 \\ 来表示反斜杠，使用 \u0066 来表示字母 f，使用 \n 来表示换行符。 
        /// </summary>
        public void StringTest_escapeSequence()
        {
            string a = "\\\u0066\n";        //result:\f
            Console.WriteLine(a);
        }



        /// <summary>
        /// Test4:原义字符串以 @ 开头并且也用双引号引起来。 例如： 
        /// </summary>
        public void StringTest_LiteralCharacter()
        {
            string a = @"good morning" + " \n";
            string b = @"c:\Docs\Source\a.txt"; // rather than "c:\\Docs\\Source\\a.txt"
            Console.WriteLine(a + b);
            //若要在一个用 @ 引起来的字符串中包括一个双引号，请使用两对双引号：
            string c = @"""Ahoy!"" cried the captain."; // result:"Ahoy!" cried the captain.
            Console.WriteLine(c);
        }



        /// <summary>
        /// Test5:string的声明方式
        /// </summary>
        public void StringTest_statement()
        {
            string a = string.Empty;
            Console.WriteLine(a);

            string str = "hello";
            string nullStr = null;
            string emptyStr = String.Empty;

            string tempStr = str + nullStr;
            // Output of the following line: hello
            Console.WriteLine(tempStr);

            string s1 = "\x0" + "abc";
            string s2 = "abc" + "\x0";
            // Output of the following line: * abc*
            Console.WriteLine("*" + s1 + "*");
            // Output of the following line: *abc *
            Console.WriteLine("*" + s2 + "*");
            // Output of the following line: 4
            Console.WriteLine(s2.Length);
        }

        /// <summary>
        /// Test6:Ordinal comparison 排序比较
        /// </summary>
        public void StringTest_OrdinalComparison()
        {
            //Internal strings that will never be localized.
            string root = @"C:\users";
            string root2 = @"C:\Users";

            // Use the overload of the Equals method that specifies a StringComparison.
            // Ordinal is the fastest way to compare two strings.
            bool result = root.Equals(root2, StringComparison.Ordinal);
            bool result2 = root.Equals(root2);      //上面这句效率更高

            Console.WriteLine("Ordinal comparison: {0} and {1} are {2}", root, root2,
                                result ? "equal." : "not equal.");
        }

        /// <summary>
        /// Test7:引用类型比较（ReferenceEquals）
        /// </summary>
        public void StringTest_ReferenceEquals()
        {
            // String interning. Are these really two distinct objects?
            string a = "The computer ate my source code.";
            string b = "The computer ate my source code.";

            // ReferenceEquals returns true if both objects
            // point to the same location in memory.
            if (String.ReferenceEquals(a, b))
                Console.WriteLine("a and b are interned.");
            else
                Console.WriteLine("a and b are not interned.");
        }

        /// <summary>
        /// Test8:索引（IndexOf）
        /// </summary>
        public void StringTest_IndexOf()
        {
            string str = "Extension methods have all the capabilities of regular static methods.";
            int first = str.IndexOf("methods") + "methods".Length;
            int last = str.LastIndexOf("methods");
            string str2 = str.Substring(first, last - first);
            System.Console.WriteLine("Substring between \"methods\" and \"methods\": '{0}'", str2);
        }

        /// <summary>
        /// Test9:正则表达式匹配（System.Text.RegularExpressions.Regex.IsMatch）
        /// </summary>
        public void StringTest_RegularExpressions()
        {
            string[] sentences =
                     {
                "C# code",
                "Chapter 2: Writing Code",
                "Unicode",
                "no match here"
            };

            string sPattern = "code";

            foreach (string s in sentences)
            {
                System.Console.Write("{0,24}", s);

                if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    System.Console.WriteLine("  (match for '{0}' found)", sPattern);
                }
                else
                {
                    System.Console.WriteLine();
                }
            }

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
        }

    }
}
