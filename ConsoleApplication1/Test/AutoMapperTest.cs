using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Source
    {
        public string name { get; set; }
        public string InfoUrl { get; set; }
    }

    public class Destination
    {
        public string name { get; set; }
        public string InfoUrl { get; set; }
        public string aa { get; set; }
    }

    public class AutoMapperTest
    {
        public void cwMap()
        {
            Destination des = new Destination()
            {
                InfoUrl = "www.cnblogs.com/zaranet",
                name = "张子浩"
            };
            Mapper.Initialize(x => x.CreateMap<Destination, Source>());
            Source source = AutoMapper.Mapper.Map<Source>(des);
            Console.WriteLine(source.InfoUrl);
        }

    }
}
