using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutLibTest
{
    public class HtmlAgilityPackTest
    {
        //参考：HtmlAgilityPack解析html文档 https://www.cnblogs.com/springsnow/p/11388673.html
        public static List<Result> test()
        {
            List<Result> list = new List<Result>();
            HtmlWeb htmlWeb = new HtmlWeb();
            htmlWeb.OverrideEncoding = Encoding.UTF8;//编码，这里网上有些很多写法都不正确
            string url = "http://www.cnblogs.com/";
            HtmlAgilityPack.HtmlDocument htmlDoc = htmlWeb.Load(url);
            //选择博客园首页文章列表
            htmlDoc.DocumentNode.SelectNodes("//div[@id='post_list']/div[@class='post_item']").AsParallel().ToList().ForEach(ac =>
            {
                //抓取图片，因为有空的，所以拿变量存起来
                HtmlNode node = ac.SelectSingleNode(".//p[@class='post_item_summary']/a/img");
                list.Add(new Result
                {
                    url = ac.SelectSingleNode(".//a[@class='titlelnk']").Attributes["href"].Value,
                    title = ac.SelectSingleNode(".//a[@class='titlelnk']").InnerText,
                    //图片如果为空，显示默认图片
                    img = node == null ? "http ://www.cnblogs.com//Content/img/avatar.png" : node.Attributes["src"].Value,
                    content = ac.SelectSingleNode(".//p[@class='post_item_summary']").InnerText
                });
            });
            return list;
        }

        public static void test2() {

        }
    }
}
