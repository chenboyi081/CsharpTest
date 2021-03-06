﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace CsharpTest
{
    using CsharpBase;
    using OutLibTest;
    class Program
    {
        static void Main(string[] args)
        {

            #region 01数据类型和变量
            //CsharpBase._01VariablesandDatatypes VD = new CsharpBase._01VariablesandDatatypes();
            //VD.test1();
            //VD.test2();
            //VD.longtype();  //求long类型最大和最小值 
            //VD.decAndFloat();  //decimal,double,float
            #endregion

            #region 02表达式/占位符转义符等符号/类型转换
            //CsharpBase._02SymbolsAndExpressions SE = new CsharpBase._02SymbolsAndExpressions();
            //SE.consoleReadLine();   //从控制台读取输入
            //SE.escapeSymbol();      //字符串的转义符
            //SE.placeholder();       //占位符
            //SE.arithmeticExpression(); //算数表达式
            //SE.typeConversion02(); //强制类型转换
            //SE.typeConversion03(); //Parse转换 
            //SE.typeConversion04();  //Convert和Trypase
            //SE.typeConversion05();  //ToString
            #endregion

            #region 04For循环的应用
            CsharpBase._04For FR = new CsharpBase._04For();
            //FR.SumNum();    //输入一个整数，计算从1加到这个数的结果
            //FR.MultiplyNum();   //输入一个正整数，求阶乘
            //FR.AddMultiNum(); //输入一个正整数，求阶乘的和1!+2!+...+ n!
            //FR.CGuan();     //游戏闯关计分
            //FR.GetMaxAndMin(); //求最大值和最小值
            //FR.QiongJu();   //穷举：100元买2元的铅笔，5元的铅笔盒，10元的文件夹，15元的彩笔，刚好花光，每样物品必须有一种，一共有多少种可能性
            //FR.GetLingX();  //用 for 循环的嵌套打印一个菱形
            #endregion

            #region 03数组
            //CsharpBase._03Array AR = new CsharpBase._03Array();
            //AR.ArrayApplication(); //声明、赋值、访问数组
            //AR.ArrayMethod();   //Array类常用方法以及属性
            //double[] arr = new double[] { 3,2,5,1,7,4,9,6};
            //AR.SelectSort(ref arr);     //选择排序
            //AR.BubbleArithmetic(arr,true);      //冒泡排序
            #endregion

            #region 05集合
            //_05Collection clc = new _05Collection();
            //clc.ArrayListTest();      
            //clc.HashtableTest();
            //clc.ListTTest();
            //clc.DictionaryTTest(); 
            #endregion

            #region 静态类，静态成员，静态构造函数

            //Console.WriteLine("out ---" + A.a);   //1

            //#region 静态构造函数测试
            ////_0Static b = new _0Static();   如果将实例化放在最前，执行顺序也是相同的（总是先初始化静态）
            //_0Static.a = 1;
            //Console.WriteLine("out ---" + _0Static.a + " " + _0Static.b);//1  //1
            //_0Static b = new _0Static();
            //b.setA();
            //Console.WriteLine("out ---" + _0Static.a);  //3  
            //#endregion
            #endregion

            #region 06正则表达式
            //_06RegularExpressions re = new _06RegularExpressions();

            //re.IsNumic("R1123");
            //re.IsContainNumic("R1123");
            //re.IsBeginHello("Hello cboii");
            //re.IsBeginHello("Hi cboii");

            //re.getLinkValue("<a href=\"http://www.baidu.com\" target=\"_blank\">百度</a>");
            //re.getLinkValue("<a href=\"     http://www.cboii.com\" target=\"_blank\">我的网站</a>");
            //re.getHeadValue("<H1>标题<H1>");
            //re.getHeadValue("<h2>小标<h2>");
            //re.getABorIJbegin("abcd");
            //re.getABorIJbegin("ab呵呵呵呵_");
            //re.getABorIJbegin("efgh");
            //re.getABorIJbegin("ijk");
            //re.getReName("张三丰");
            //re.getReName("张丰");
            //re.getReName("张飞");
            //re.getSpeicalStr("Java Asp.net SQLServer");
            //re.getSpeicalStr("C# Java");

            //re.greedAndLazy();
            //re.getHrefInfo();
            //re.getInfoByGroupName();
            //re.getAllHrefValue();

            //re.replaceWords();
            //re.splitWords();
            #endregion

            #region 字符串练习
            //StringTest ST = new StringTest();

            //ST.StringTest_operationalcharacter();
            //ST.StringTest_escapeSequence();
            //ST.StringTest_LiteralCharacter();
            //ST.StringTest_statement();
            //ST.StringTest_OrdinalComparison();
            //ST.StringTest_ReferenceEquals();
            //ST.StringTest_IndexOf();
            //ST.StringTest_RegularExpressions(); 
            #endregion

            #region 枚举类测试
            //Test.EnumTest ET = new Test.EnumTest();
            //ET.GetDirection01();
            //ET.GetDirection02();

            //TimeOfDay time = TimeOfDay.Afternoon;
            //ET.GetDirection03(time);

            //EnumTest.GetNVCFromEnumValue(typeof(TimeOfDay));        //从枚举类型和它的特性读出并返回一个键值对

            #endregion

            #region NPOI练习
            //NPOI_Test.NPOI.MonthlySalaryReport msr = new Test.NPOI.MonthlySalaryReport();
            //msr.ExportMonthSalaryReport(); 
            #endregion

            #region 类型转换
            //Test.类型转换.DecimalChange dc = new Test.类型转换.DecimalChange();
            //dc.DecimalToString();
            //Test.类型转换.DateTimeChange dtc = new Test.类型转换.DateTimeChange();
            //dtc.DateTimeToString(); 
            #endregion

            #region 委托练习
            //1.0
            //DelegateTest.GreetPeople("Liker", DelegateTest.EnglishGreeting);
            //DelegateTest.GreetPeople("八一", DelegateTest.ChineseGreeting);

            //2.0 同上
            //GreetingDelegate delegate1;
            //delegate1 = DelegateTest.EnglishGreeting;
            //delegate1 += DelegateTest.ChineseGreeting;      //注意这里，第一次用的“=”，是赋值的语法；第二次，用的是“+=”，是绑定的语法。
            //delegate1("Liker");

            //3.0 既然给委托可以绑定一个方法，那么也应该有办法取消对方法的绑定，很容易想到，这个语法是“-=”：
            //GreetingDelegate delegate2 = new GreetingDelegate(DelegateTest.EnglishGreeting);
            //delegate2 += DelegateTest.ChineseGreeting;
            //DelegateTest.GreetPeople("Liker", delegate2);
            //Console.WriteLine();

            //delegate2 -= DelegateTest.EnglishGreeting;
            //DelegateTest.GreetPeople("李志中", delegate2);

            #endregion

            #region EF CodeFirst
            //DBContext.SchoolContext db = new DBContext.SchoolContext();
            //db.Database.CreateIfNotExists();
            ////Model.Student stud = new Model.Student();
            ////stud.StudentName = "test";

            ////同上
            ////Model.Student stud = new Model.Student() { StudentName = "New Student" }
            ////db.Students.Add(stud);
            ////db.SaveChanges();
            //Console.WriteLine("成功生成数据库和表！");
            #endregion

            #region 模拟多线程去实例化 仅单线程适用 的单例模式
            //模拟多线程去实例化 仅单线程适用 的单例模式
            //TaskFactory task = new TaskFactory();
            //List<Task> lstTask = new List<Task>();
            //for (int i = 0; i < 5; i++)
            //{
            //    lstTask.Add(task.StartNew(() =>
            //    {
            //        //Test.单例模式.SingletonDemo3 singleton3 = Test.单例模式.SingletonDemo3.init();
            //        //Test.单例模式.SingletonDemo4 singleton4 = Test.单例模式.SingletonDemo4.init();
            //        Test.单例模式.SingletonDemo5 singleton5 = Test.单例模式.SingletonDemo5.init();
            //    }));
            //} 
            #endregion



            #region 外部库使用Test
            List<Result>  list = HtmlAgilityPackTest.test();
            foreach (Result item in list)
            {
                Console.WriteLine(item.title);
            }
            #endregion

            Console.ReadKey();
        }

       
    }
}
