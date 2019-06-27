using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.单例模式
{
    /// <summary>
    /// 静态构造函数实现单例模式，显示实现无参静态构造函数，在其中初始化静态实例，同样是使用CLR来保证单例的
    /// </summary>
    public class SingletonDemo2
    {
        /// <summary>
        /// 私有静态实例变量
        /// </summary>
        private static SingletonDemo2 singleton2 = null;

        /// <summary>
        /// 显示实现静态构造函数，初始化私有静态实例变量
        /// </summary>
        static SingletonDemo2() {
            singleton2 = new SingletonDemo2();
        }

        /// <summary>
        /// 这个方法是用于外部调用得到实例的，因为上面的变量是私有的，外部无法访问
        /// </summary>
        /// <returns></returns>
        public static SingletonDemo2 init() {
            return singleton2;
        }
    }
}
