using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace CsharpTest
{
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
            ////SE.consoleReadLine();   //从控制台读取输入
            ////SE.escapeSymbol();      //字符串的转义符
            ////SE.placeholder();       //占位符
            ////SE.arithmeticExpression(); //算数表达式
            ////SE.typeConversion02(); //强制类型转换
            ////SE.typeConversion03(); //Parse转换 
            //SE.typeConversion04();  //Convert和Trypase
            //SE.typeConversion05();  //ToString
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
            GreetingDelegate delegate2 = new GreetingDelegate(DelegateTest.EnglishGreeting);
            delegate2 += DelegateTest.ChineseGreeting;
            DelegateTest.GreetPeople("Liker", delegate2);
            Console.WriteLine();

            delegate2 -= DelegateTest.EnglishGreeting;
            DelegateTest.GreetPeople("李志中", delegate2);

            #endregion

            Console.ReadKey();
        }

       
    }
}
