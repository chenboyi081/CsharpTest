using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型.协变和逆变
{
    /// <summary>
    /// 定义一个泛型委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="t"></param>
    /// <returns></returns>
    public delegate K Prd<in T, out K>(T t);

    public interface IPig<in T, out K>
    {

    }

    /// <summary>
    /// 子类实现父接口的写法
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    public class pig2<T, K> : IPig<T, K>
    {

    }

    /// <summary>
    /// 错误的
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    //public class Pig1<in T, out K>
    //{
    //}

    /// <summary>
    /// 特点：
    /// 1、协变和逆变只能存在于 泛型接口 和 泛型委托中
    /// 2、in 关键字代表此类型占位符T为逆变，意味着此T只能当做参数传入，不能当做返回值输出
    /// 3、out 关键字代表此类型占位符T为协变，意味着此T只能当做返回值输出，不能当做参数传入
    /// </summary>
    public class InOut
    {
        public InOut()
        {
            List<int> list = new List<int>();
            //list.FindAll(Predicate<int>
        }
    }
}
