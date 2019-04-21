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
            CsharpBase._02SymbolsAndExpressions SE = new CsharpBase._02SymbolsAndExpressions();
            //SE.consoleReadLine();   //从控制台读取输入
            //SE.escapeSymbol();      //字符串的转义符
            //SE.placeholder();       //占位符
            //SE.arithmeticExpression(); //算数表达式
            //SE.typeConversion02(); //强制类型转换
            //SE.typeConversion03(); //Parse转换 
            SE.typeConversion04();  //Convert和Trypase
            SE.typeConversion05();  //ToString
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



            Console.ReadKey();
        }

       
    }
}
