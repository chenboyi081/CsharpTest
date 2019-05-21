using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型.泛型类的继承
{
    /// <summary>
    /// 多个类型占位符的 约束写法
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    public class Father1<K, V>
        where K : struct
        where V : class
    {

    }

    public class Father<K, V>
    {

    }

    /// <summary>
    /// 1.0
    /// </summary>
    public class Sub : Father<int, string>
    {

    }

    /// <summary>
    /// 2.0  在后面的 EF和MVC中大量使用
    /// </summary>
    /// <typeparam name="X"></typeparam>
    /// <typeparam name="Y"></typeparam>
    public class Sub1<X, Y> : Father<int, string>
    {

    }

    /// <summary>
    /// 3.0 在后面的 EF和MVC中大量使用
    /// </summary>
    /// <typeparam name="X"></typeparam>
    /// <typeparam name="Y"></typeparam>
    public class Sub2<X, Y> : Father<X, Y>
    {

    }

    /// <summary>
    /// 4.0 错误的演示
    /// </summary>
    /// <typeparam name="X"></typeparam>
    /// <typeparam name="Y"></typeparam>
    //public class Sub3 : Father<X, Y>
    //{

    //}
}
