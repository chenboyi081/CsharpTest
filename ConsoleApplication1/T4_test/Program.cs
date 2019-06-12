using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;

namespace T4_test
{
    class Program
    {
        static void Main(string[] args)
        {
            new C04CodeGeneratorTest().TestMethod();
            // Allow user to see the output:  
            Console.ReadLine();
        }
    }
}
