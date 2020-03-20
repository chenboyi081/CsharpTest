using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBase
{
    //-------------------------------------静态类只能包含静态成员
    //1.只能包含静态成员
    // 2.不能被继承
    // 3.不能被实例化，没有构造函数
    public static class A
    {
        public static int a = 1;
    }

    //-------------------------------------静态成员：
    //1.静态成员属于类，无论创造了多少类的实例，静态成员只有一份。
    //2.由上条可得：在一个类中，非静态函数可以操作静态成员（因为静态成员就一份），但静态函数不可以操作非静态成员（有很多对象没办法知道改操作哪个）
    //3.初始化：先初始化静态成员，再初始化非静态成员。


    //静态构造函数：
    //1.静态构造函数不使用访问修饰符或不具有参数。
    //2.在创建第一个实例或引用任何静态成员之前，将自动调用静态构造函数以初始化类。
    //3.不能直接调用静态构造函数。
    public class _0Static
    {
        static _0Static()
        {
            Console.WriteLine("静态构造函数");  //执行顺序 2
        }
        public _0Static()
        {
            Console.WriteLine("构造函数");   //执行顺序 3
        }
        //public static int a = 1;  如果在b前初始化并赋值，b的初始化值才是2
        public static int b = getB();
        public static int a;
        public int c;
        public static int getB()
        {
            Console.WriteLine("静态方法");  //执行顺序 1
            return (a + 1);
        }

        //静态非静态的互相调用=================
        public static void setC()
        {
            //c = 4;  错误 静态方法不可以操作非静态变量
        }
        public void setA()
        {
            a = 3;  //正确
        }
    }
}
