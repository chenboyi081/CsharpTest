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
            StringTest ST = new StringTest();

            ST.StringTest_operationalcharacter();
            ST.StringTest_escapeSequence();
            ST.StringTest_LiteralCharacter();
            ST.StringTest_statement();
            ST.StringTest_OrdinalComparison();
            ST.StringTest_ReferenceEquals();
            ST.StringTest_IndexOf();
            ST.StringTest_RegularExpressions();

            Console.ReadKey();
        }

       
    }
}
