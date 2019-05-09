using AutoMapper;
using AutoMapperWeb.Common;
using AutoMapperWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoMapperWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var productEntity = new ProductEntity() { Name = "Visual Studio 2017", Amount = 500 };

            Book book = new Book()
            {
                Title = "Leesin",
                Author = new Author()
                {
                    Name = "Lee"
                }
            };
            //1、Automapper使用静态类创建映射

            //ViewBag.Tips = "1、Automapper使用静态类创建映射";

            //Mapper.Initialize(cfg => cfg.CreateMap<ProductEntity, ProductDTO>());

            //var productDTO = Mapper.Map<ProductDTO>(productEntity);

            //2、Automapper使用实例方法创建映射

            //ViewBag.Tips = "2、Automapper使用实例方法创建映射";

            //MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.CreateMap<ProductEntity,ProductDTO>());

            //var mapper = configuration.CreateMapper();

            //var productDTO = mapper.Map<ProductDTO>(productEntity);

            //3、使用Profie配置实现映射关系

            ViewBag.Tips = "3、使用Profie配置实现映射关系";

            var configuration = new MapperConfiguration(cfg => cfg.AddProfile<ATProfile>());

            var productDTO = configuration.CreateMapper().Map<ProductDTO>(productEntity);

            var bookviewmodel = configuration.CreateMapper().Map<BookViewModel>(book);

            //return View(productDTO);
            return View(bookviewmodel);

            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}