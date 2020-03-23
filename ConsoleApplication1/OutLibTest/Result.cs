using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutLibTest
{
    /// <summary>
    /// 页面抓取结果
    /// </summary>
    public class Result
    {
        /// <summary>
        /// 链接
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 头像地址
        /// </summary>
        public string img { get; set; }
        /// <summary>
        /// 正文内容
        /// </summary>
        public string content { get; set; }
    }
}
