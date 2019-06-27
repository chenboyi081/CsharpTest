using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.单例模式
{
    /// <summary>
    /// 相对于单线程的单例模式 多线程的单例模式，增加一个静态object变量，在初始化之前lock住这个变量
    /// </summary>
    public class SingletonDemo4
    {
        /// <summary>
        /// 私有静态实例变量
        /// </summary>
        private static SingletonDemo4 singleton4 = null;

        /// <summary>
        /// 增加一个私有静态的object变量，用于lock
        /// </summary>
        private static object singletonLock = new object();

        /// <summary>
        /// 用于外部调用得到实例的方法（多线程适用）
        /// </summary>
        /// <returns></returns>
        public static SingletonDemo4 init()
        {
            lock (singletonLock)
            {
                //以下在Program.cs中运行会发现：只初始化也就是init new一次，但是会多次lock
                Console.WriteLine("init lock " + DateTime.Now);    
                if (singleton4 == null)
                {
                    Console.WriteLine("init new " + DateTime.Now);    
                    singleton4 = new SingletonDemo4();
                }
            }
            return singleton4;
        }
    }
}
