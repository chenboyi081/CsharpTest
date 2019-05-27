using AutoMapper;
using AutoMapperWeb.Models;
using AutoMapperWeb.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperWeb.Common
{
    public class OrderLineProfile : Profile
    {
        public OrderLineProfile()
        {
            CreateMap<OrderLine, OrderLineDTO>().ForMember(dto => dto.Item, conf => conf.MapFrom(ol => ol.Item.Name));
        }
    }
}