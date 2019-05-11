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
    public class Source4Profile:Profile
    {
        public Source4Profile() {
            //Source->Destination
            CreateMap<Source4, Destination4>()
                .ForMember(dest => dest.Value, opt =>
                {
                    opt.NullSubstitute("原始值为NULL");
                });
        }
    }
}