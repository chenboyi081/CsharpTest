using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBase
{
    public class _05Collection
    {

        //ArrayList和Hashtable位于System.Collections下；
        // List<T> 和Dictionary<T,V>位于System.Collections.Generic

        public void ArrayListTest()
        {
            ArrayList al = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);

            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void HashtableTest()
        {
            Hashtable ht = new Hashtable();


            ht.Add("001", "Zara Ali");
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "Joe Holzner");
            ht.Add("004", "Mausam Benazir Nur");
            ht.Add("005", "M. Amlan");
            ht.Add("006", "M. Arif");
            ht.Add("007", "Ritesh Saikia");

            if (ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", "Nuha Ali");
            }
            // 获取键的集合 
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
        }

        public void ListTTest()
        {

            //当T为string时,举例：
            string[] nameArr = { "Ha", "Hunter", "Tom", "Lily", "Jay", "Jim", "Kuku", "Locu" };

            List<string> list = new List<string>(nameArr);

            //---------------------1.0 添加
            //添加一个元素
            list.Add("lucy");
            //添加一组元素
            string[] temArr = { "Harry", "Peter", "Bob"};
            list.AddRange(temArr);
            //插入元素
            list.Insert(1, "Hei");

 

            //---------------------2.0 删除、清空元素
            //删除一个值
            list.Remove("Hunter");
            //删除下标为index的元素
            list.RemoveAt(0);
            //从下标3开始，删除2个元素
            list.RemoveRange(3, 2);
            //清空元素
            //list.Clear();
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
            //---------------------3.0 Contains(是否包含某个元素)
            string cname = "Hunter";
            bool blog = list.Contains(cname);
            Console.WriteLine("是否包含" + cname + ":"+(blog == true ? "是" : "否"));


            //默认是元素第一个字母按升序
            list.Sort();
            //将List里面元素顺序反转
            list.Reverse();
            //从第二个元素开始，反转4个元素
            //list.Reverse(1, 4);
            Console.WriteLine("------------------排序以及反转后：--------------");
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

        }

        public void DictionaryTTest()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            //---------------------1.0 添加
            myDictionary.Add(1, "C#");
            myDictionary.Add(2, "C++");
            myDictionary.Add(3, "ASP.NET");
            myDictionary.Add(4, "MVC");

            if (myDictionary.ContainsKey(1))
            {
                Console.WriteLine("Key:{0},Value:{1}", "1", myDictionary[1]);
            }

            //通过KeyValuePair遍历元素

            foreach (KeyValuePair<int, string> kvp in myDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            //仅遍历键 Keys 属性
            //Dictionary<int, string>.KeyCollection keyCol = myDictionary.Keys;
            //foreach (int key in keyCol)
            //{
            //    Console.WriteLine("Key = {0}", key);
            //}

            //仅遍历值 Valus属性
            //Dictionary<int, string>.ValueCollection valueCol = myDictionary.Values;
            //foreach (string value in valueCol)
            //{
            //    Console.WriteLine("Value = {0}", value);
            //}

            //通过Remove方法移除指定的键值
            myDictionary.Remove(1);
            if (myDictionary.ContainsKey(1))
            {
                Console.WriteLine("Key:{0},Value:{1}", "1", myDictionary[1]);
            }
            else
            {
                Console.WriteLine("不存在 Key : 1");
            }


        }
    }
}
