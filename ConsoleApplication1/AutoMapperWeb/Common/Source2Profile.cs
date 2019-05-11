using AutoMapper;
using AutoMapperWeb.Models;
using AutoMapperWeb.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperWeb.Common
{
    public class CustomResolver : IValueResolver<Source2, Destination2, int>        //AutoMapper7.0没有ValueResolver，只有IValueResolver
    {
        public int Resolve(Source2 source, Destination2 destination, int destMember, ResolutionContext context)
        {
            return source.Value1 + source.Value2;
        }

        //protected override int ResolveCore(Source source)
        //{
        //    return source.Value1 + source.Value2;
        //}
    }

    public class Source2Profile:Profile
    {
        public Source2Profile() {
            //Source->Destination
            CreateMap<Source2, Destination2>()
                .ForMember(dest => dest.Total, opt =>
                {
                    opt.ResolveUsing<CustomResolver>();
                });
        }
    }
}