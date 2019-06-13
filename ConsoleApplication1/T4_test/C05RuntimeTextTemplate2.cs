using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAGE
{
    public partial class C05RuntimeTextTemplate
    {
        private List<MyData> m_data;
        public C05RuntimeTextTemplate(List<MyData> data) { this.m_data = data; }
    }

    public class MyData{

            public int Value { get; set; }
            public string Name { get; set; }

    }
}

