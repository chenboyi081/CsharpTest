using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 泛型.泛型的类型参数约束;

namespace 泛型.泛型方法的重写
{
    public abstract class GenClassOvrride
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U">必须是T的子类</typeparam>
        /// <param name="t"></param>
        /// <param name="u"></param>
        /// <returns></returns>
        public abstract T SayHi<T, U>(T t, U u) where U : T;//U 必须继承于 T

        public abstract T Think<T>(T t) where T : IAnimal;
    }

    public class subClass : GenClassOvrride
    {
        public override T SayHi<T, U>(T t, U u)
        {
            //return t;
            return default(T);
        }

        public override T Think<T>(T t)
        {
            throw new NotImplementedException();
        }
    }
}
