using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBase
{
    /// <summary>
    /// 表达式/占位符转义符等符号/类型转换
    /// </summary>
    public class _02SymbolsAndExpressions
    {
        public void consoleReadLine()
        {
            //请用户输入姓名  然后打个招呼.
            Console.WriteLine("请输入你的姓名:");
            string name = Console.ReadLine();
            Console.WriteLine("你好啊" + name);
        }


        public void escapeSymbol()
        {
            /* 1. 在字符串中,有一些字符是具有特殊的意义的.
                        *    双引号(") 在字符串中代表1个字符串的开始和结束.
                        *    
                        * 2. 字符串转义符:  \ 可以改变后面的字符的原本的意义.
                        *    \"   字符串的双引号 *
                        *    \t   制表符 *
                        *    \\   代表字符串的\  *
                        *    \b   删除前面的字符
                        *    \n   换行  linux
                        *    \r\n 换行  windows *
                        *    
                        * 3. @符号.代表字符串中的\不代表转义,就代表字符串的斜杠(\)
                        *    
                        *    
                        * 
                        */

            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\2052\alinkui.dll";


            string str = "我爱\r\n北京\r\n天安门";


            //string path  = "F:\\Muisc\\经典老歌\\：下辈子不做女人 ....mp3";
            Console.WriteLine(path);
            Console.WriteLine(str);
            Console.ReadKey();
        }

        public void placeholder()
        {
            /* 1.在Console.WriteLine()的时候拼接字符串的另外的方式.
                    *   占位符.
                    *   现在字符串中使用大括弧占位,并在大括弧中为它编号. 一般情况下编号从0开始,依次的递增.
                    *   在字符串的后面,按照顺序的写上要填到坑中的数据.
                    *   填坑的规律: 第0个变量会去填编号为0的坑. 第1个变量会去填编号为1的坑. 第n个变量会去填编号为n的坑
                    *   
                    * 
                    * 
                    * 2. 坑的编号其实你可以随便取的.反正后面的第n个变量填编号为n的坑.
                    *    要求后面的变量的个数 要是 最大坑的编号+1 个.
                    *    
                    * 
                    */

            string name = "jack";
            byte age = 12;
            char gender = '男';

            Console.WriteLine("大家好,我叫" + name + ",我的年龄是" + age + ",我的性别是" + gender);

            Console.WriteLine("大家好,我叫{0},我的年龄是{0},我的性别是{0}", name, age, gender);

        }

        /// <summary>
        /// 算数表达式
        /// </summary>
        public void arithmeticExpression()
        {
            /* 1. 算术运算符
            *    +  -  *   /   %
            *    
            * 2. 算术表达式.
            *    由算术运算符连接起来的式子.
            *    
            *    我们不能光秃秃的写1个表达式, 因为表达式是有结果的,我们必须要处理这个结果.
            *    a. 直接将表达式的结果打印.
            *    b. 将表达式的结果通过赋值符号存储在1个变量中.
            * 
            * 
            * 3. +号. 代表求和运算.
            *    当加号两边的数据类型都是数值类型的时候,那么这个时候+号代表算术求和运算 结果就是数学意义上的和.
            *    当加号任意1边的数据类型是字符串的时候,那么+号代表字符串的连接, 会把两边的数据连接起来组成1个新的字符串.
            *    
            *    算术表达式的结果的类型:
            *    a. byte short int 互相之间参与算术表达式 那么结果就是int类型的.
            *    b. 其他的情况:
            *       如果参与算术表达式的数据的类型是一致的,那么表达式的结果的类型就是这个类型.
            *       如果参与算术表达式的数据的类型不一致,那么表达式的结果的类型是范围最大的那个类型.
            *       
            *    c. 关于范围
            *       整型之间： long>int>short>byte
            *       浮点型: double>float>decimal 
            *       浮点型数据的范围总是比整型的范围大.
            *    
            *    d(了解) uint与ushort=>uint
            *            ushort与ushort=>int
            *            uint与sbyte==>long
            * 
            * 4. -号:  代表数学意义上的求差运算.
            * 5. *号:  代表数学意义上的求积运算
            * 6. /号:  代表数学意义上的求商运算.
            *          需要注意的是 10/4 的结果是2    
            *          因为10和4都是int类型的,所以结果也是int类型的.
            *          
            *          如果需要保留小数部分.
            *          a. 任意的1个数据的类型改为double
            *          b. *1.0 让其类型变为double
            * 
            *    
            * 7. %号: 模  求模运算  求余数.
            *      10%3 结果是10除以3的余数.
            *    
            *  
            * 8. 参与算术表达式的数据只能是数值类型的.还可以是char类型的.
            *    字符串不能参与算术运算.
            *    
            *    当char类型的数据参与算术运算的时候,首先会将这个char类型的数据转换为其所对应的ASCII码 然后再参与运算.
            *    每1个字符都有1个对应的int类型的整数. 这个对应的整数就叫做这个字符的ASCII码
            *    'a'   97
            *    'A'   65
            *    
            * 9. 算术运算的优先级.
            *    先乘除 后加减.
            *    如果同级别 从左到右 依次计算. 
            *    
            *    使用小括弧改变优先级.有小括弧的先算小括弧中的.
            *    小括弧是可以无限制的套用的,但是一定要成对的出现.
            *    
            * 10. decimal类型的数据不能和其他的浮点型数据参与算术运算.因为会丢失精度.
            *     但是decimal类型的数据是可以和其他的整型的数据参与运算的,因为不会丢失精度.
            *     
            *  
            *   
            */

            //练习1：定义两个数分别为10和20，打印出两个数的和
            //int num1 = 10, num2 = 20;
            //int he = num1 + num2;
            //Console.WriteLine(he);


            //计算半径为5的圆的面积并打印出来
            //double r = 12.5; 
            //double area =  3.14 * r * r; 
            //Console.WriteLine("面积为:"+area);



            //某商店T恤的价格为35元/件,裤子的价格为120元/条.小明在该店买了3件T恤和2条裤子,请计算并显示小明应该付多少钱?
            double tshirtPrice = 35.0;
            double kuziPrice = 120.0;
            double price = tshirtPrice * 3 + kuziPrice * 2;
            Console.WriteLine("小明应该付:" + price);
            //假如商店为小明打8.8折,那么小明应该付多少钱呢?
            //购物总计为:XX元,打折后应付为:XX元. 
            double realPrice = price * 0.88;
            Console.WriteLine("打折后的价格:" + realPrice);






            //定义三个变量 用来存储小思的 语数外成绩 求总分和平均分.
            //double _Chinese = 90;
            //double math = 100;
            //double _English = 99; 
            //double totoalScore = _Chinese + math + _English; 
            //double avg =  totoalScore / 3; 
            //Console.WriteLine("总成绩:{0},平均成绩:{1}",totoalScore,avg); 
            ////Console.WriteLine(float.MaxValue);
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(decimal.MaxValue);


            //decimal d1 = 12.123m;
            //int i1 = 12;

            //decimal res = d1 + i1;

            //Console.WriteLine(res);


            //double d1 = 12.45;
            //decimal d2 = 12.45678m;


            //decimal d3 = d1 + d2;


            //Console.WriteLine(d3);
            //int res = (3 + (2 - 5) * 5) * 2; 
            //Console.WriteLine(3 + 2 - 5 * 2);


            //char c = '中';
            //int res =   c + 1;


            //Console.WriteLine(res);


            //string s1 = "中国";
            //string s2 = "日本";

            //int i1 = 12;
            //int i2 = 11;  
            //int res = i1 * i2; 
            //Console.WriteLine(res);

            //int i1 = 10;
            //int i2 = 3;

            //int res =  i1 % i2;


            // Console.WriteLine(res);



            //int i1 = 10;
            //int i2 = 4;
            //Console.WriteLine(i1 / i2);

            //int res = i1 / i2;
            //Console.WriteLine(res);





            //int i1 = 12;
            //double d1 = 2.5;
            //double res =  i1* d1;
            //Console.WriteLine(res);



            //int i1 = 12;
            //int i2 = 2;
            //int res =  i1* i2;
            //Console.WriteLine(res);




            //double d2 = 10.6;
            //int i1 = 10;
            //double res =  d2 - i1;
            //Console.WriteLine(res);



            //double d1 = 10.5;
            //double d2 = 0.4;
            //double d3 =  d1 - d2;
            //Console.WriteLine(d3);





            //int i1 = 2100000000;
            //int i2 = 2100000000;
            //int i3 = i1 + i2;
            //Console.WriteLine(i3);

            //uint i = 12;
            //ushort s = 12;
            //uint res = i + s;


            //ushort s1 = 12;
            //ushort s2 = 11;
            //int s3 =  s1 + s2;


            //uint i1 = 12;
            //sbyte s1 = 12;
            //long  res =  i1 + s1;


            //int i1 = 12;
            //decimal d1 = 12.12m;
            //decimal res =  i1 + d1;
            //Console.WriteLine(res);



            //int i1 = 12;
            //float f1 = 12.12f; 
            //float f2 =  i1 + f1;
            //Console.WriteLine(f2);


            //int i1 = 12;
            //double d1 = 12.12; 
            //double d2 =  i1 + d1; 
            //Console.WriteLine(d2);

            //long l1 = 110;
            //int i1 = 200; 
            //long res =  l1 + i1;
            //Console.WriteLine(res);



            //long l1 = 12;
            //long l2 = 13;

            //long l3 =  l1 + l2;
            //Console.WriteLine(l3);


            //float f1 = 12.11f;
            //float f2 = 12.11f;

            //float f3 = f1 + f2;
            //Console.WriteLine(f3);


            //decimal d1 = 12.12m;
            //decimal d2 = 11.11m;

            //decimal d3 =  d1 + d2;
            //Console.WriteLine(d3);


            //double d1 = 12.12;
            //double d2 = 34.56; 
            //double d3 = d1 + d2;
            //Console.WriteLine(d3);


            //short s1 = 32767;
            //short s2 = 10;

            //int s = s1 + s2;


            //short s1 = 12;
            //short s2 = 190;
            //short s3 = s1 + s2;


            //byte b1 = 12;
            //int i1 = 11;
            //int i2 = b1 + i1;


            //int num1 = 12;
            //int num2 = 20;

            //int res = num1 + num2;


            //int res =  1 + 1;

            //Console.WriteLine(res);

        }


        /// <summary>
        /// 自动类型转换
        /// </summary>
        public void typeConversion01()
        {
            //简单的转换
            int a = 10, b = 3;
            int mod = a % b; //1
            double quo = a / b;   //3.3333  
            Console.WriteLine(mod);
            Console.WriteLine(quo);

            /* 1. 自动类型转换.
             *    将1个byte类型的变量中的值赋值给1个int类型的变量,为什么不报错,数据类型明显不同?
             *    a. byte类型的变量和int类型的变量都是用来存储整型的数据.
             *    b. 无论byte类型的变量中的值是多少,都可以将其放到int类型的变量中去,不会出任何的问题.
             *    
             *    在数据类型兼容的情况下,我们可以将1个小范围的变量的值 直接 赋值给1个大范围的类型的变量.
             *    这样做绝对不会有问题的.
             *    a. 因为他们之间相互兼容
             *    b. 小范围变量的值无论是多少都可以直接放到大范围的变量中.
             *    因为不会有任何问题,所以直接赋值就可以了,C#编译器自动的帮助我们完成转换.
             *    范围: 
             *    所有的数值类型和char类型之间是互相兼容的.
             *    
             *    类型转换:指的是把1个类型的变量的值 拿出来(有的是要经过处理）赋值给另外的1个类型的变量 的过程.
             *    变量的类型一旦声明,就无法改变.
             *    
             *    可以直接将1个char类型的数据赋值给1个int类型的变量.那么这个int类型的变量的值就是这个char类型的数据对应的ASCII码
             *    char类型的数据对应的ASCII码是1个int类型的数据. 
             * 
             *    满足自动类型转换的条件:
             *    a. 数据类型兼容.(所有的数值类型和char类型之间相互兼容) 特别强调字符串和数值类型以及char类型之间不兼容.
             *    b. 目标变量的范围要大于源变量.
             */
        }

        /// <summary>
        /// 强制类型转换
        /// </summary>
        public void typeConversion02()
        {
            /* 2. 强制类型转换.
            *    在数据类型兼容的情况下,我们不能直接将1个大范围的类型的变量的值 直接 赋值给1个小范围的类型的变量.
            *    因为有可能会发生溢出的现象.
            *    当大范围变量中的值 刚好 在小范围的变量中. 这个时候其实是可以的.
            *    当大范围变量中的值超过小范围的变量,那么这个时候就会发生溢出的现象.
            *    所以这个时候 C#编译器就不会帮助我们自动的去完成转换了.
            *    
            *    这个时候我们可以使用强制转换的语法,来让我们的C#系统不考虑溢出的情况.直接将大范围变量中的值赋值给小范围的变量.
            *    如果强制转换的时候.大变量中的值在小变量的范围之内,一切和谐.
            *    但如果不在,那么结果就不是我们想要的了.
            *    所以我们在强制转换的时候,一定要保证大范围变量中的值 要在 小范围的变量中.
            *    
            *    将浮点型强制转换为整型, 会将小数部分活生生的截取掉. 不会做四舍五入.
            *    
            *    强制类型转换的首要前提是:
            *    a. 类型兼容
            *    b. 大范围赋值给小范围.
            * 
            *    可以直接把char类型的数据赋值给int类型的变量.
            *    但是不能直接把int类型的数据赋值给char类型的变量,如果一定要赋值,那么必须使用强制转换的语法.
            *    结果就是以这个int类型的数为ASCII码所对应的字符.
            */


            byte b = 97;
            char c = (char)b;
            Console.WriteLine(c);

            long l = 2200000000;
            int i1 = (int)l;
            Console.WriteLine(i1);

            int i2 = 259;
            byte b1 = (byte)i2;
            Console.WriteLine(b1);

        }


        /// <summary>
        /// Prase转换:  它将字符串转换为其他的类型. 
        /// </summary>
        public void typeConversion03()
        {
            /* 2. Prase转换:  它将字符串转换为其他的类型.
             *    语法:
             *    要将字符串转换为什么类型就   什么类型.Parse(待转换的字符串);
             *    定义1个对应的类型的变量来接受这句代码的结果.就可以得到转换成功后的数据.
             *    eg:
             *    string str = "456";
             *    int num = int.Parse(str);
             *    num变量中就存储的是转换成功的值了.
             *     
             *    需要注意的细节:
             *    a. 只能将字符串转换为其他的类型. Parse的小括弧中只能是字符串.
             *    b. 什么时候可以转换成功?
             *       当字符串的字面量是1个指定类型的时候,那么这个时候就可以将字符串通过Parse转换为这个类型
             *       字面量:字符串去掉双引号的部分.
             *       比如：我要判断1个字符串能否转换为int类型。
             *             将这个字符串去掉双引号后 看它是不是1个int类型的,如果是ok 否则nook
            */

            //请写1个程序,让用户输入两个int类型的数 算出他们的和并打印.
            //Console.WriteLine("请输入第1个数:");
            //string strNumA = Console.ReadLine(); //"12"
            //Console.WriteLine("请输入第2个数:");
            //string strNumB = Console.ReadLine();//"20" 
            ////将用户输入的字符串内容转换为数值类型.
            //int numA = int.Parse(strNumA);
            //int numB = int.Parse(strNumB);
            //Console.WriteLine(numA + numB);

            //string str = "中国";
            //int num =  int.Parse(str);


            //string str = "a";
            //int c = char.Parse(str);//'a' 
            //Console.WriteLine(c);

            //Console.WriteLine(c + 1 - 1);


            //string str = "300";
            //byte s = byte.Parse(str);       //overflow错误
            //Console.WriteLine(s);

            //string str = "190.123";
            //double num = double.Parse(str);
            //Console.WriteLine(num);

            //byte b = 12;
            //int i = b;

            //int i1 = int.Parse(b);

            //string str = "a";
            //char c = char.Parse(str);
            //Console.WriteLine(c + 1);

            //string str = "12";
            //byte b = byte.Parse(str);
            //Console.WriteLine(b + 1);

            //string str = "12.12";
            //double d1 = double.Parse(str);
            //Console.WriteLine(d1 + 1);


            //string str = "12";
            //int num = int.Parse(str); 
            //Console.WriteLine(num + 1); 

        }

        /// <summary>
        /// Convert转换： 万能转换.1). 做自动类型转换的时候. 2). 强制类型转换.3). 转字符串的时候.
        /// a为0.2，null，"" 使用Double.Parse，Convert.ToDouble,Double.TryParse后的不同结果
        /// </summary>
        public void typeConversion04()
        {
            //C#中 Convert与Parse的区别：https://www.cnblogs.com/JackieWu/p/4866132.html

            string a = "0.2";
            //string a = null;
            //string a = "";

            try
            {
                double d1 = Double.Parse(a);
                Console.WriteLine("d1的值为：" + d1);
            }
            catch (Exception err)
            {
                Console.WriteLine("d1转换出错:" + err.Message);
            }

            try
            {
                double d2 = Convert.ToDouble(a);
                Console.WriteLine("d2的值为：" + d2);

            }
            catch (Exception err)
            {
                Console.WriteLine("d2转换出错:" + err.Message);

            }
            try
            {
                double d3;
                Double.TryParse(a, out d3);
                Console.WriteLine("d3的值为：" + d3);
            }
            catch (Exception err)
            {
                Console.WriteLine("d3转换出错:" + err.Message);
            }
        }

        /// <summary>
        /// ToString() 将任意类型的数据转换为字符串.
        /// </summary>
        public void typeConversion05()
        {
            int i = 12;
            string s = i.ToString();
            Console.WriteLine(s);
        }
    }
}
