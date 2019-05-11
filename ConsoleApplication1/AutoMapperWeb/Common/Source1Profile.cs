using AutoMapper;
using AutoMapperWeb.Models;
using AutoMapperWeb.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperWeb.Common
{
    public class Source1Profile: Profile
    {
        public Source1Profile()
        {
            CreateMap<Source1, Destination1>();

            ////因为字段不对称，直接使用上面的内容会报错
            ////正确方法1：指定映射字段
            //CreateMap<Source1, Destination1>()
            // .ForMember(dest => dest.SomeValuefff, opt =>
            // {
            //     opt.MapFrom(src => src.SomeValue);
            // });
            ////正确方法2：使用Ignore方法
            //CreateMap<Source1, Destination1>()
            // .ForMember(dest => dest.SomeValuefff, opt =>
            // {
            //     opt.Ignore();
            // });
            //正确方法3：或者使用自定义解析器
        }
    }
}