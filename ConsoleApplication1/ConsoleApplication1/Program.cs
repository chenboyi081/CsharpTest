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
            nullable N = new nullable();
            N.ShowMessage("HELLO WORLD!");

            N.print();

            Console.ReadKey();
        }

       
    }
}
