using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    /// <summary>
    /// 自定义了一个整型集合
    /// </summary>
    public class IntList
    {
        int[] arr = new int[2];
        int index = 0;

        public void Add(int num)
        {
            //1.0 判断如果index超出了数组下标则要将arr扩容 *2 
            if (index >= arr.Length)
            {
                //定义一个新的数组，以原数组的两倍长度
                int[] tmparr = new int[arr.Length * 2];

                //将arr中的数据拷贝到tmparr中
                arr.CopyTo(tmparr, 0);

                //重新赋值
                arr = tmparr;
            }

            arr[index] = num;
            index++;
        }

        public int this[int indx]
        {
            get
            {
                if (indx < arr.Length)
                {
                    return arr[indx];
                }
                else
                {
                    throw new Exception("索引越界");
                }
            }
        }
    }

    public class StringList
    {
        string[] arr = new string[2];
        int index = 0;

        public void Add(string num)
        {
            //1.0 判断如果index超出了数组下标则要将arr扩容 *2 
            if (index >= arr.Length)
            {
                //定义一个新的数组，以原数组的两倍长度
                string[] tmparr = new string[arr.Length * 2];

                //将arr中的数据拷贝到tmparr中
                arr.CopyTo(tmparr, 0);

                //重新赋值
                arr = tmparr;
            }

            arr[index] = num;
            index++;
        }

        public string this[int indx]
        {
            get
            {
                if (indx < arr.Length)
                {
                    return arr[indx];
                }
                else
                {
                    throw new Exception("索引越界");
                }
            }
        }
    }

    //自定义泛型集合
    /// <summary>
    /// 开放类型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyList<T>
    {
        T[] arr = new T[2];
        int index = 0;

        public void Add(T num)
        {
            //1.0 判断如果index超出了数组下标则要将arr扩容 *2 
            if (index >= arr.Length)
            {
                //定义一个新的数组，以原数组的两倍长度
                T[] tmparr = new T[arr.Length * 2];

                //将arr中的数据拷贝到tmparr中
                arr.CopyTo(tmparr, 0);

                //重新赋值
                arr = tmparr;
            }

            arr[index] = num;
            index++;
        }

        public T this[int indx]
        {
            get
            {
                if (indx < arr.Length)
                {
                    return arr[indx];
                }
                else
                {
                    throw new Exception("索引越界");
                }
            }
        }
    }
}
