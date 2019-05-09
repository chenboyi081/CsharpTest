using AutoMapper;
using AutoMapperWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperWeb.Common
{
    public class ATProfile: Profile
    {
        public ATProfile()

        {

            //映射关系配置

            CreateMap<ProductEntity, ProductDTO>();
            CreateMap<Book, BookViewModel>().ForMember(t => t.Author, s => s.MapFrom(u => u.Author.Name));

        }
    }
}