using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;
using PAGE;

namespace T4_test
{
    class Program
    {
        static void Main(string[] args)
        {

            #region C06  运行时文本模板-继承模式
            //C06RTTemplateSon t1 = new C06RTTemplateSon();
            //string result = t1.TransformText();
            //Console.WriteLine(result); 
            #endregion

            #region C05RuntimeTextTemplate 运行时文字模板
            //List<MyData> list = new List<MyData>() { new MyData { Value =1,Name="春天在哪里啊？"}, new MyData { Value = 2, Name = "好一朵美丽的茉莉花！" } };
            //C05RuntimeTextTemplate rtt = new C05RuntimeTextTemplate(list);
            //string rrtContent = rtt.TransformText();
            //System.IO.File.WriteAllText("ouputPage.html", rrtContent); 
            #endregion

            #region C04CodeGeneratorTest 生成类从XML中
            //new C04CodeGeneratorTest().TestMethod();
            //// Allow user to see the output:  
            //Console.ReadLine(); 
            #endregion

            Console.ReadKey();
        }
    }
}
