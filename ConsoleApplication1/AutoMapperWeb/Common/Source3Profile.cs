using AutoMapper;
using AutoMapperWeb.Models;
using AutoMapperWeb.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace AutoMapperWeb.Common
{

    public class DateTimeTypeConverter : ITypeConverter<string, DateTime>
    {
        public DateTime Convert(string source, DateTime destination, ResolutionContext context)
        {
            return System.Convert.ToDateTime(source);
        }
    }

    public class TypeTypeConverter : ITypeConverter<string, Type>
    {
        public Type Convert(string source, Type destination, ResolutionContext context)
        {
            return Assembly.GetExecutingAssembly().GetType(source);
        }
    }


    public class Source3Profile:Profile
    {
        public Source3Profile() {
            //string->int
            CreateMap<string, int>().ConvertUsing(s => Convert.ToInt32(s));
            //string->DateTime
            CreateMap<string, DateTime>().ConvertUsing(new DateTimeTypeConverter());
            //string->Type
            CreateMap<string, Type>().ConvertUsing(new TypeTypeConverter());

            //Source->Destination
            CreateMap<Source3, Destination3>();
        }
    }
}