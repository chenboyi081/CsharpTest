using AutoMapper;
using AutoMapperWeb.Common;
using AutoMapperWeb.Models;
using AutoMapperWeb.Models.Dto;
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

            //var configuration = new MapperConfiguration(cfg => cfg.AddProfile<ATProfile>());        //使用了AutoMapperConfiguration之后就不用这一句了
            //var bookviewmodel = configuration.CreateMapper().Map<BookViewModel>(book);

            var productDTO = Mapper.Map<ProductDTO>(productEntity);

            var bookviewmodel = Mapper.Map<BookViewModel>(book);
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

        public ActionResult AutoMappeTemp1()
        {
            ViewBag.Tips = "1、扁平化映射（Flattening）";
            //默认情况下，我们的Source类和Destination类是根据属性名称进行匹配映射的。
            //除此之外，默认的映射规则还有下面两种情况，我们称之为扁平化映射，即当Source类中不包含Destination类中的属性的时候，AutoMapper会将Destination类中的属性进行分割，或匹配“Get”开头的方法


            //我们在进行映射的时候，不需要进行特殊的配置，既可以完成从Order到OrderDto的映射。
            Customer customer = new Customer() { Name = "Tom" };
            Order order = new Order() { Customer = customer };
            OrderDto orderDto = Mapper.Map<OrderDto>(order);
            return View(orderDto);
        }
    }
}