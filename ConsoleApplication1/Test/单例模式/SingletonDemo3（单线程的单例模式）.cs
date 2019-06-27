using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.单例模式
{
    /// <summary>
    /// 单线程的单例模式，不适用于多线程。仍然还是使用静态实例变量，只是公开一个自定义的实例方法，只有调用这个方法的时候，才会初始化这个实例
    /// </summary>
    public class SingletonDemo3
    {
        /// <summary>
        /// 私有静态实例变量
        /// </summary>
        private static SingletonDemo3 singleton3 = null;


        /// <summary>
        /// 用于外部调用得到实例的方法（仅单线程适用）
        /// </summary>
        /// <returns></returns>
        public static SingletonDemo3 init() {
            if (singleton3 == null)
            {
                Console.WriteLine("SingletonDemo3 init" + DateTime.Now);    //单线程的单例模式，在多线程下测试效果如图所示，实例被创建了多次(结合Program.cs查看)
                singleton3 = new SingletonDemo3();
            }
            return singleton3;
        }
    }
}
