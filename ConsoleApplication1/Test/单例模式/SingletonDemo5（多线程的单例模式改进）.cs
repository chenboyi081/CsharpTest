using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.单例模式
{
    /// <summary>
    /// 多线程的单例模式改进，lock之前，判断实例是否已经创建，如果创建了就直接返回，从而改进性能
    /// </summary>
    public class SingletonDemo5
    {
        /// <summary>
        /// 私有静态实例变量
        /// </summary>
        private static SingletonDemo5 singleton5 = null;

        /// <summary>
        /// 增加一个私有静态的object变量，用于lock
        /// </summary>
        private static object singletonLock = new object();

        /// <summary>
        /// 用于外部调用得到实例的方法（多线程适用）
        /// </summary>
        /// <returns></returns>
        public static SingletonDemo5 init()
        {
            if (singleton5  == null)
            {
                lock (singletonLock)
                {
                    //以下在Program.cs中运行会发现：只初始化也就是init new一次，但是会多次lock
                    Console.WriteLine("init lock " + DateTime.Now);
                    if (singleton5 == null)
                    {
                        Console.WriteLine("init new " + DateTime.Now);
                        singleton5 = new SingletonDemo5();
                    }
                }
            }
            return singleton5;
        }
    }
}
