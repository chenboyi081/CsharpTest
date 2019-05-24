using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 新语法
{
    class Program
    {
        /// <summary>
        /// 结合Reflector进行学习效果更佳
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            C1004GroupBy();

            Console.ReadKey();
        }

        #region 0.0 数据构造
        static List<Pig> GetPigList()
        {
            var list = new List<Pig>() { 
            new Pig(){PID=1,Name="八戒", Age=500,TypeID=2},
            new Pig(){PID=2,Name="小猪", Age=500,TypeID=1},
            new Pig(){PID=3,Name="大猪八", Age=500,TypeID=2},
            new Pig(){PID=4,Name="老猪", Age=500,TypeID=4}            
            };

            return list;
        }

        static List<PigType> GetTypeList()
        {
            var list = new List<PigType>() { 
        new PigType(){ TypeID=1, TypeName="家猪"},
        new PigType(){ TypeID=2, TypeName="野猪"},
        new PigType(){ TypeID=3, TypeName="肥猪"},
        new PigType(){ TypeID=4, TypeName="瘦猪"}
            };

            return list;
        }

        #endregion

        #region 1.0 自动属性
        public static void c01autoProperty()
        {
            Pig pig = new Pig();
        }


        #endregion

        #region 2.0 var 隐式类型

        /*
         * var的特点：
         * 1、var在编译器编译的时候根据初始值推断出其的类型
         * 2、不能赋值除了初始值类型之外的其他类型
         * 3、不能将null赋值给var变量
         * 4、var只能在方法体中进行定义,不能在类中，也不能出现在方法的参数中
         */
        public static void c02VarType()
        {
            var i = 100; //经过编译器编译完成后，var会被编译器推断出int类型
            var pig = new Pig() { };
            var pig1 = pig;
            //var str = null;
            //Console.WriteLine(pig1.ToString());
        }

        #endregion

        #region 3.0 参数默认值 和 命名参数

        static void C03Prmrs()
        {
            C0301Parms("八戒", 500);
            C0301Parms();
            C0301Parms("小猪");
            C0301Parms(age: 1500); //命名参数
        }

        /// <summary>
        /// 参数默认值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static void C0301Parms(string name = "八戒", int age = 500)
        {
            Pig pig = new Pig() { Name = name, Age = age };
        }

        #endregion

        #region 4.0 对象/集合 初始化器

        static void C04Init()
        {
            //4.0.1 对象初始化器
            Pig pig = new Pig()
            {
                Name = "老猪",
                Age = 500
            };

            //4.0.2 集合初始化器
            List<Pig> plist = new List<Pig>() {
             new Pig(){ Name="",Age=1}
            };

            //4.0.3 数组初始化器
            Pig[] parr = new Pig[]
            { 
               new Pig(){ Name="",Age=1}
            };
        }

        #endregion

        #region 5.0 匿名类(重点)

        static void C05AnCls()
        {
            var pig = new Pig() { };

            //匿名类的定义形式
            //匿名类的本质：编译器会编译成一个泛型类，将属性名称作为泛型类的类型占位符
            //new对象操作其实就是调用泛型类中的构造函数实现
            var ancObj = new { Name = "八戒", Age = 500 };
            var obj2 = new { Name = 200, Age = "小样" };
            //总结：ancObj和obj2是共用一个泛型类
            var obj1 = new { Name = "小猪", Age = 1, toyname = "泥巴" };//产生一个新的泛型类 

            //将对象序列化成json (注意：在MVC中使用的json序列化器，一般传入的都是匿名类)
        }

        #endregion

        #region 6.0 – 匿名方法(也叫匿名函数，匿名委托) (重点) -根据匿名方法演变成Lambda表达式

        /// <summary>
        /// 匿名方法：要根据委托签名来决定其写法
        /// 例如：public delegate bool Predicate(int obj); <=> delegate(int i) { return i > 10; }
        /// public delegate void Action(int obj); <=> delegate(int i) { i++; }
        /// </summary>
        static void c06AniMethod()
        {
            //1.0 匿名方法的定义的格式:delegate(形参){return -1;}            
            List<int> list = new List<int>() { 1, 2, 3, 79, 90 };
            // FindAdll()方法的参数委托签名格式：public delegate bool Predicate<in T>(T obj);
            //写法1：定义和委托具有相同签名的方法query
            var list1 = list.FindAll(query);

            //写法2:利用匿名方法代替query方法
            var list2 = list.FindAll(delegate(int i) { return i > 10; });

            //写法3：利用Lambda表达式替换匿名方法
            var list3 = list.FindAll(i => i > 10);
            //注意点：Lambda表达式的写法特点：
            /*
             * =>:goes to
             * =>:的左边是表示参数,
             *          如果参数只有一个 则可以省略小括号,
             *          如果参数>=2个则使用(x,y)=>{return x+y;},
             *          如果参数没有,则使用()占位 ()=>{return -1;}
             *=>:的右边表示方法体
             *          如果方法体中只有一个语句，则可以省略{}
             *          如果有返回值，则可以省略return 关键字
             *          如果方法体中有多个语句，则不可以省略{}，并且每条语句的结束符用分号
             */

            //var inum = list.Find(c => c == 90);
            var inum = list.FindAll(c => c == 90 || c == 1); //查找集合list中数字等于90或者等于1
            var list4 = list.FindAll(c => c > 10 && c == 90);

            //
            List<Pig> listpig = new List<Pig>() { 
             new Pig(){ Name="九戒", Age=600},
            new Pig(){ Name="八戒", Age=500},
            new Pig(){ Name="小猪", Age=1},
            new Pig(){ Name="老猪", Age=5}
            };

            var nplist = listpig.FindAll(delegate(Pig p) { return p.Age > 10 && p.Name.Contains("八"); });
            var nplist1 = listpig.FindAll(p => p.Age > 10 && p.Name.Contains("八"));

            Console.WriteLine(string.Join(",", list1));
            Console.WriteLine(string.Join(",", list2));
        }

        static bool query(int i)
        {
            return i > 10;
        }

        #endregion

        #region 7.0 系统内置委托

        #region 7.0.1 System.Predicate<T> 代表返回bool类型的委托   - 用作执行表达式

        static void C0701D()
        {
            List<int> list = new List<int>();
            list.FindAll(c => c > 1);
            //list.Find();
        }

        #endregion

        #region 7.0.2 System.Action 代表无返回类型的委托

        static void C0702D()
        {
            List<int> list = new List<int>() { 1, 3, 5, 2, 4 };
            //1.0 遍历
            //list.ForEach(actioncw);

            //2.0 匿名方法
            // list.ForEach(delegate(int i) { Console.WriteLine(i); });

            //3.0 lambda表达式
            list.ForEach(c => Console.WriteLine(c));
        }

        static void actioncw(int i)
        {
            Console.WriteLine(i);
        }

        #endregion

        #region 7.0.3 System.Comparison<T> 代表返回int类型的委托  - 用作比较两个参数的大小
        static void C0703D()
        {
            List<int> list = new List<int>() { 1, 3, 5, 2, 4 };

            //对list集合进行倒序排列
            //1.0 写法1
            //list.Sort(Comp);

            //2.0写法2
            //list.Sort(delegate(int p, int n) { return n - p; });

            //3.0写法3
            list.Sort((p, n) => n - p);

            //打印,如果有多个语句则不能省略{}
            list.ForEach(c =>
            {
                c++;
                Console.WriteLine(c);
            });
        }

        static int Comp(int p, int n)
        {
            return n - p;
        }

        #endregion

        #region 7.0.4 System.Func 代表有返回类型的委托 (重中之中)

        static void C0704Func()
        {
            //Func泛型委托的其中一种签名：public delegate TResult Func<in T, out TResult>(T arg);
            List<int> list = new List<int>() { 1, 3, 5, 2, 4 };
            //public delegate bool Func<int,  bool>(int arg);

            //1.0 获取list集合中的指定的数据            
            list.FirstOrDefault(c => c == 3);
            // 2.0 利用where方法获取指定的数据
            list.Where(c => c == 3);
        }
        #endregion
        #endregion

        #region 8.0 扩展方法 (重中之中，后面MVC大量使用)

        static void C08ExpMethod()
        {
            DateTime now = DateTime.Now;
            //2.0 将now格式化成yyyy-MM-dd输出
            string nowstr1 = now.ToString("yyyy-MM-dd HH:mm:ss");

            //3.0 
            string nowstr2 = ExpMgr.Fmtyyyymmdd(now);

            //4.0 利用扩展方法
            string nowstr3 = now.Fmtyyyymmdd();

            string nowstr4 = now.Fmtyyyymmddhhmmss("火星");

            Console.WriteLine(nowstr4);

            string str = "HELLO";
            Console.WriteLine(str.ToLower());

        }

        #endregion

        #region 9.0 标准查询运算符(SQO)

        #region 9.0.1  连表查询 Join方法的演示 (常用)

        static void C0901Join()
        {            
            var piglist = GetPigList();
            var typelist = GetTypeList();

            //2.0 链接piglist和typelist 查询出新的集合，属性有 PID,PName,TypeName
            // select  p.PID,PName=p.Name,t.TypeName from piglist p join typelist t on (p.TypeID=t.TypeID)
            //利用 SQO方法Join实现上面sql语句的相同功能
            var nlist = piglist.Join(typelist, p => p.TypeID, t => t.TypeID, (p, t) => new
            {
                p.PID,
                PName = p.Name,
                t.TypeName
            });

            nlist.ToList().ForEach(c => Console.WriteLine(c.ToString()));
        }

        #endregion

        #region 9.0.2  排序 OrderBy() OrderByDescending 方法的演示 （链式编程常用）
        static void C0902OrderBy()
        {
            var list = GetPigList();

            //给list中的数据按照PID进行倒序排列
            //list.Sort((p, p1) => p1.PID - p.PID);
            //list.ForEach(c => Console.WriteLine(c.ToString()));
            //给list中的数据按照PID进行倒序排列
            list.OrderByDescending(c => c.PID).ToList().ForEach(c => Console.WriteLine(c.ToString()));

            //给list中的数据按照PID进行正序排列
            list.OrderBy(c => c.PID).ToList().ForEach(c => Console.WriteLine(c.ToString()));
        }

        #endregion
        #region 9.0.3 多字段排序 OrderBy() 或者OrderByDescending() 排第一个字段，ThenyBy(),ThenyByDescending()排第2个以后的字段(包括第2个) 常用

        static void C0903c()
        {
            var list = GetPigList();
            //要求：先根据list集合中的TypeID进行升序排列,再按照PID进行倒序排列
            // 错误的写法 ：list.OrderBy(c => c.TypeID).OrderByDescending(c => c.PID).ToList().ForEach(c => Console.WriteLine(c.ToString()));

            //正确的写法
            list.OrderBy(c => c.TypeID).ThenByDescending(c => c.PID).ToList().ForEach(c => Console.WriteLine(c.ToString()));
        }


        #endregion
        #region 9.0.4 Select()投影方法的演示 (重点)

        static void C0904Select()
        {
            var list = GetPigList();
            //利用Select投影方法，将Pig对象的集合，投影成匿名类
            list.Where(c => c.TypeID == 2).Select(c => new { c.Name, c.Age }).ToList().ForEach(c => Console.WriteLine(c.ToString()));

        }

        #endregion

        #region 9.0.5 利用Skip().Take() 方法实现分页查询

        static void c0905Page()
        {
            int rowcount = 0;

            //c0905byPage(1, 2, out rowcount);
            c0905byPage(2, 2, out rowcount);
        }

        static void c0905byPage(int pageindex, int pagesize, out int rowcount)
        {
            rowcount = 0;

            var list = GetPigList();
            //需求：从list集合中获取第1页的数据，容量为2
            int skipCount = (pageindex - 1) * pagesize;
            //利用Skip().Take()从集合中实现分页查询
            var pagelist = list.Skip(skipCount).Take(pagesize);

            //将分页数据打印到屏幕
            pagelist.ToList().ForEach(c => Console.WriteLine(c.ToString()));
        }

        #endregion

        #region 9.0.6  GroupBy（）分组查询
        static void C0906GroupBy()
        {
            var list = GetPigList();

            //需求：根据list集合中的Pig对象中的TypeID进行分组
            //sql: select  typeid,count(1) from list group by typeid
            var groupedList = list.GroupBy(c => c.TypeID);
            groupedList.ToList().ForEach(c =>
            {
                Console.WriteLine("----分组号:" + c.Key + "------");
                //将当前分组号中的数据遍历打印
                c.ToList().ForEach(d => Console.WriteLine(d.ToString()));
            });
        }

        #endregion
        #region

        #endregion
        #endregion

        #region 10.0 Linq

        #region 10.1 利用Linq实现Where查询
        static void C101Where()
        {
            var list = GetPigList();

            //需求：利用linq语法查找list中Typeid=2的数据
            //sql:select Name,Age from list c where c.typeid=2 and c.name like '%八%'
            // Contains():相当于 T-SQL语法的 like '%八%'  StartWith("八")《=》like '八%' EndWith("八")<=> like '%八'
            var nlist = (from c in list
                         where c.TypeID == 2 && c.Name.Contains("八")
                         select new { c.Name, c.Age }).ToList();

            nlist.ForEach(c => Console.WriteLine(c.ToString()));
        }

        #endregion

        #region 10.2 利用linq实现集合的排序

        static void C102Orderby()
        {
            var list = GetPigList();

            //1.0 实现list集合根据Pid倒序排列
            //(from c in list
            // orderby c.PID descending
            // select c).ToList().ForEach(c => Console.WriteLine(c.ToString()));

            //2.0 实现list集合根据TypeID正序排列
            (from c in list orderby c.TypeID ascending select c).ToList().ForEach(c => Console.WriteLine(c.ToString()));
        }

        #endregion

        #region 10.3  Join

        static void c1003Join()
        {
            var list = GetPigList();
            var typelist = GetTypeList();

            //利用linq链接list和typelist 实现查询出 p.Name,p.Age,t.TypeName
            var nlist = (from p in list
                         join t in typelist
                         on p.TypeID equals t.TypeID
                         select new { p.Name, p.Age, t.TypeName }).ToList();

            nlist.ForEach(c => Console.WriteLine(c.ToString()));
        }

        #endregion

        #region 10.4 GroupBy

        static void C1004GroupBy()
        {
            var list = GetPigList();

            //需求：根据pig对象中的Typeid分组
            var nlist = (from c in list
                        group c by c.TypeID).ToList();

            nlist.ForEach(c => {
                Console.WriteLine("-------分组号:"+c.Key+"-----");
                //先调用ToList()再点 ForEach()? 
                c.ToList().ForEach(d=>Console.WriteLine(d.ToString()));
            });                          
        }

        #endregion

        #endregion
    }
}
