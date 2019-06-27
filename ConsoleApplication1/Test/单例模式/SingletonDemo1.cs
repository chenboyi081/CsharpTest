using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.单例模式
{
    /// <summary>
    /// 静态变量实现单例模式，这种方式是将只有一个实例的事情交给了公共语言运行时CLR，让它来保证单例
    /// </summary>
    public class SingletonDemo1
    {
        /// <summary>
        /// 私有静态实例变量
        /// </summary>
        private static SingletonDemo1 singleton1 = new SingletonDemo1();

        /// <summary>
        /// 这个方法是用于外部调用得到实例的，因为上面的变量是私有的，外部无法访问
        /// </summary>
        /// <returns></returns>
        public static SingletonDemo1 init() {
            return singleton1;
        }
    }
}
