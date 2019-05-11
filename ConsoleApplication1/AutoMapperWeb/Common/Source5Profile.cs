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
    public class Source5Profile:Profile
    {
        public Source5Profile() {
            //Source->Destination
            CreateMap<Source5, Destination5>()
                .ForMember(dest => dest.Value, opt =>
                {
                    opt.Condition(src => (src.Value >= 10));
                });
        }
    }
}