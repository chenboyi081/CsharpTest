using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    
    public delegate void GreetingDelegate(string name);

    /// <summary>
    /// 委托学习
    /// C#中的委托:https://www.cnblogs.com/hushzhang/p/5901052.html
    /// </summary>
    public class DelegateTest
    {
        //我们现在对委托做一个总结：委托是一个类，它定义了方法的类型，使得可以将方法当作另一个方法的参数来进行传递，这种将方法动态地赋给参数的做法，
        //可以避免在程序中大量使用If … Else(Switch)语句，同时使得程序具有更好的可扩展性。


        public static void EnglishGreeting(string name)
        {
            Console.WriteLine("Good Morning, " + name);
        }

        public static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好, " + name);
        }

        public static void GreetPeople(string name, GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name);
        }


    }
}
