using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型.泛型的类型参数约束
{
    public class Call
    {
        public Call()
        {
            //1.0 演示调用值类型约束
            Hourse<int> h1 = new Hourse<int>();
            //Hourse<string> h2 = new Hourse<string>();//由于string是引用类型所以违背了Hourse中泛型参数T的约束,所以报错

            //2.0  演示调用引用类型约束
            Hourse1<string> h3 = new Hourse1<string>();
            Hourse1<Pig> h4 = new Hourse1<Pig>();
            //Hourse1<int> h5 = new Hourse1<int>(); //错误的
            
            //3.0 基类约束
            Hourse2<smallPig> h6 = new Hourse2<smallPig>();
            // Hourse2<Cat> h7 = new Hourse2<Cat>(); //错误的

            //4.0 接口约束
            Hourse3<Pig> h8 = new Hourse3<Pig>();
            Hourse3<smallPig> h9 = new Hourse3<smallPig>();
            //Hourse3<Cat> h10 = new Hourse3<Cat>();  // 由于Cat没有实现IAnimal接口，所以报错

            //5.0  UserInfoBll bll =new UserInfoBll()
            Hourse4<UserInfoBll> h11 = new Hourse4<UserInfoBll>();
            //h11.Intance
        }
    }



    /// <summary>
    /// 1.0 约束此类的T只能传入值类型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Hourse<T> where T : struct
    {

    }

    /// <summary>
    /// 2.0 约束此类的T只能传入引用类型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Hourse1<T> where T : class
    {

    }

    /// <summary>
    /// 3.0 基类约束
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Hourse2<T> where T : Pig
    {

    }

    /// <summary>
    /// 4.0 接口约束
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Hourse3<T> where T : IAnimal
    {

    }

    /// <summary>
    /// 5.0 构造器约束
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Hourse4<T> where T : new()
    {
        T t;
        public Hourse4()
        {
            t = new T();
        }

        public T Intance
        {
            get
            {
                return t;
            }
        }
    }
}
