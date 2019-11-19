using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBase
{
    /// <summary>
    /// For循环
    /// </summary>
    public class _04For
    {
        //循环四要素：初始条件，循环条件，循环体，状态改变。
        //for(初始条件;循环条件;状态改变)
        //{
        //循环体
        //    }

        //    给出初始条件，先判断是否满足循环条件，如果不满足条件则跳过for语句，如果满足则进入for语句执行，for语句内的代码执行完毕后，将按照状态改变，改变变量，然后判断是否否和循环条件，符合则继续执行for语句内的代码，直到变量i不符合循环条件则终止循环，或者碰到break命令，直接跳出当前的for循环。

        //break ——中断循环，跳出最近的循环循环
        //continue——停止本次循环，进入下次循环

        //循环（for）和分支语句（if  else等）一样可以相互嵌套


        #region 输入一个整数，计算从1加到这个数的结果 +SumNum
        public void SumNum()
        {
            Console.Write("请输入一个正整数：");
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= a; i++)
            {
                sum += i;//sum=sum+i;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
        #endregion

        #region 输入一个正整数，求阶乘
        public void MultiplyNum()
        {
            Console.Write("请输入一个正整数：");
            int a = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= a; i++)
            {
                sum *= i;//sum=sum*i;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
        #endregion

        #region 输入一个正整数，求阶乘的和1!+2!+...+n!
        public void AddMultiNum()
        {
            Console.Write("请输入一个正整数：");
            int a = int.Parse(Console.ReadLine());
            int sum = 1;
            int sum1 = 0;
            for (int i = 1; i <= a; i++)
            {
                sum *= i;//sum=sum*i;
                if (i == 4)//不想要4的
                {
                    continue;//终止本次循环，继续下次循环
                }
                sum1 += sum;
            }

            Console.WriteLine(sum1);
            Console.ReadLine();
        }
        #endregion


        #region 游戏关卡积分
        public void CGuan()
        {
            //一个游戏，前20关是每一关自身的分数，
            //21 - 30关每一关是10分
            //31 - 40关，每一关是20分
            //41 - 49关，每一关是30分
            //50关，是100分
            //输入你现在闯到的关卡数，求你现在拥有的分数
            Console.Write("请输入你已经到第几关：");
            int guan = int.Parse(Console.ReadLine());
            int sum = 0;
            if (guan >= 1 && guan <= 50)
            {
                for (int i = 1; i <= guan; i++)
                {
                    if (guan <= 20)
                    {
                        sum += i;
                    }
                    else if (guan > 20 && i <= 30)
                    {
                        sum += 10;
                    }
                    else if (guan > 30 && guan <= 40)
                    {
                        sum += 20;
                    }
                    else if (guan > 40 && guan < 30)
                    {
                        sum += 30;
                    }
                    else
                    {
                        sum += 100;
                    }
                }

                Console.WriteLine("你的关卡总积分："+ sum);
            }
            else
            {
                Console.WriteLine("输入有误！");
            }
            Console.ReadLine();
        }
        #endregion


        #region 求最大值和最小值
        public void GetMaxAndMin()
        {
            int[] arr = new int[] { 3, 5, 7, 10, 2, 6, 4 };
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("最大值：" + max + "; 最小值" + min);
            Console.ReadKey();
        }
        #endregion

        #region 穷举：100元买2元的铅笔，5元的铅笔盒，10元的文件夹，15元的彩笔，刚好花光，每样物品必须有一种，一共有多少种可能性
        public void QiongJu()
        {
            //100元买2元的铅笔，5元的铅笔盒，10元的文件夹，15元的彩笔，刚好花光，每样物品必须有一种，一共有多少种可能性？
            int count = 0;
            for (int qb = 1; qb < 50; qb++)
            {
                for (int he = 1; he < 20; he++)
                {
                    for (int jia = 1; jia < 10; jia++)
                    {
                        for (int cai = 1; cai < 7; cai++)
                        {
                            if (qb * 2 + he * 5 + jia * 10 + cai * 15 == 100)
                            {
                                count++;
                                Console.WriteLine("铅笔：{0}，铅笔盒：{1}，文件夹：{2}，彩笔：{3}", qb, he, jia, cai);
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
        #endregion

        #region 用 for 循环的嵌套打印一个菱形
        public void GetLingX()
        {
            Console.WriteLine("请输入边长：");
            int ii = int.Parse(Console.ReadLine());
            Console.WriteLine("打印出来的菱形为：");
            //打印上面的三角形
            for (int g = 0; g < ii; g++)
            {

                for (int n = ii - g; n > 1; n--)
                {
                    Console.Write("  ");
                }
                for (int m = 1; m <= g; m++)
                {
                    Console.Write(" #");
                }

                for (int p = 1; p <= g; p++)
                {
                    Console.Write(" #");
                }
                Console.WriteLine(" #");
            }
            //打印下面的三角形
            for (int j = 0; j < ii - 1; j++)
            {
                for (int a = 1; a <= j + 1; a++)
                {
                    Console.Write("  ");
                }
                for (int b = ii - j; b > 2; b--)
                {
                    Console.Write(" #");
                }
                for (int c = ii - j; c > 2; c--)
                {
                    Console.Write(" #");
                }
                Console.WriteLine(" #");
            }
        } 
        #endregion
    }
}
