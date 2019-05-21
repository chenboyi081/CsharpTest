using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型.泛型方法
{
    /// <summary>
    /// 泛型方法的特点：
    /// 1、泛型方法可以放到普通类和泛型类中
    /// </summary>
    public class GenMethod
    {
        /// <summary>
        /// 第1个方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public T CreateInstance<T>(T t)
        {
            //TODO:泛型方法的具体业务逻辑代码根据需求决定
            return t;
        }

        //第2个方法
        public T CreateInstance<T>() where T : new()
        {
            //TODO:泛型方法的具体业务逻辑代码根据需求决定
            return new T();
        }

        //第3个方法
        public T CreateInstance<T>(string str) where T : new()
        {
            //TODO:泛型方法的具体业务逻辑代码根据需求决定
            return new T();
        }

        //此方法由于和第3个方法冲突不能构成重载
        //public V CreateInstance<V>(string str) where V : new()
        //{
        //    //TODO:泛型方法的具体业务逻辑代码根据需求决定
        //    return new V();
        //}

        //第4个方法
        public T CreateInstance<T, V>(string str) where T : new()
        {
            //TODO:泛型方法的具体业务逻辑代码根据需求决定
            return new T();
        }
    }

    public class GenMethod1<T>
    {
        /// <summary>
        /// 第1个方法
        /// 由于CreateInstance的类型占位符不属于类中的类型占位符，所以不能省略
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public V CreateInstance<V>(V t)
        {
            //TODO:泛型方法的具体业务逻辑代码根据需求决定
            return t;
        }

        //第2个方法
        /// <summary>
        /// 由于CreateInstance<T>中的T和GenMethod1<T>是同一个，所以可以将CreateInstance中的<T>省略
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T CreateInstance<T>() where T : new()
        {
            //TODO:泛型方法的具体业务逻辑代码根据需求决定
            return new T();
        }

        //第3个方法
        public T CreateInstance<T>(string str) where T : new()
        {
            //TODO:泛型方法的具体业务逻辑代码根据需求决定
            return new T();
        }

        //此方法由于和第3个方法冲突不能构成重载
        //public V CreateInstance<V>(string str) where V : new()
        //{
        //    //TODO:泛型方法的具体业务逻辑代码根据需求决定
        //    return new V();
        //}

        //第4个方法
        public T CreateInstance<T, V>(string str) where T : new()
        {
            //TODO:泛型方法的具体业务逻辑代码根据需求决定
            return new T();
        }
    }
}
