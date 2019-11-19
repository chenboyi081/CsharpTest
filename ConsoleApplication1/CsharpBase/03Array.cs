using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBase
{
    /// <summary>
    /// 数组
    /// </summary>
    public class _03Array
    {

        #region 1.0 声明、赋值、访问数组 + ArrayApplication()
        public void ArrayApplication()
        {
            int[] n = new int[10]; /* n 是一个带有 10 个整数的数组 */
            int i, j;


            /* 初始化数组 n 中的元素 */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* 输出每个数组元素的值 */
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
        }
        #endregion

        #region Array类常用方法以及属性
        public void ArrayMethod()
        {
            int num;
            int num2;

            int[] n = new int[] { 5, 2, 3, 4, 1 };
            int[] n2 = new int[5];
            num = n.Length;                        //获取元素总数
            num2 = n.Rank;                          //获取秩(维度)
            Console.WriteLine("元素总数:" + num + ";秩(维度):"+ num2);

            n.CopyTo(n2, 0);                        //将n复制到n2

            //***bool is_eq = Array.Equals(n,n2);     //该方法无法比较两个数组是否相等,使用下面方法比较。
            bool is_eq = Enumerable.SequenceEqual(n, n2);              //引用System.Linq    is_eq = true
            n2[4] = 1109;
            is_eq = Enumerable.SequenceEqual(n, n2);               //is_eq = false
            num = Array.IndexOf(n, 109);                   //4 获取值在数组中的索引位置
            Array.Sort(n);                     //正序排列
            Array.Reverse(n);                  //倒序排列
            Array.Clear(n, 0, 4);                //清空索引为0到4的数（设置为0、false或null取决于类型）
        }
        #endregion

        /// <summary>
        /// 选择排序（升序排列）
        /// </summary>
        /// <param name="dblArray"></param>
        public void SelectSort(ref double[] dblArray)
        {
            //选择排序基本思想： 每一趟从待排序的数据元素中选出最小（或最大）的一个元素，顺序放在已排好序的数列的最后，直到全部待排序的数据元素排完。
            for (int i = 0; i < dblArray.Length; i++)
            {
                double MinValue = dblArray[i];
                int MinValueIndex = i;
                for (int j = i + 1; j < dblArray.Length; j++)
                {
                    if (MinValue > dblArray[j])
                    {
                        MinValue = dblArray[j];
                        MinValueIndex = j;
                    }
                }
                ExChangeValue(ref dblArray[i], ref dblArray[MinValueIndex]);
            }

            string arrStr = "选择排序后的数组：";
            for (int i = 0; i < dblArray.Length; i++)
            {
                arrStr += dblArray[i].ToString() + ",";
            }
            Console.WriteLine(arrStr.Substring(0,arrStr.Length -1));
            Console.ReadKey();
        }

        /// <summary>
        /// 冒泡算法
        /// </summary>
        /// <param name="abarray"></param>
        /// <param name="IsAscending"></param>
        public void BubbleArithmetic(double[] abarray, bool IsAscending)
        {
            if (abarray.Length > 0)
            {
                for (int i = abarray.Length - 1; i >= 0; i--)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (CheckAccordCondition(abarray[i], abarray[j], IsAscending))
                        {
                            ExChangeValue(ref abarray[i], ref abarray[j]);
                        }
                    }
                }
            }

            string arrStr = "冒泡排序后的数组：";
            for (int i = 0; i < abarray.Length; i++)
            {
                arrStr += abarray[i].ToString() + ",";
            }
            Console.WriteLine(arrStr.Substring(0, arrStr.Length - 1));
            Console.ReadKey();
        }

        /// <summary>
        /// 是否符合条件
        /// </summary>
        /// <param name="data1"></param>
        /// <param name="data2"></param>
        /// <param name="IsAscending"></param>
        /// <returns></returns>
        private bool CheckAccordCondition(double data1, double data2, bool IsAscending)
        {
            if (data1 > data2)
            {
                return IsAscending == true ? true : false;
            }
            else
            {
                return IsAscending == true ? false : true;
            }
        }

        /// <summary>
        /// 交换数据
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        private void ExChangeValue(ref double A, ref double B)
        {
            double Temp = A;
            A = B;
            B = Temp;
        }
    }
}
