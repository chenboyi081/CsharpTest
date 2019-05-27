using AutoMapper;
using AutoMapper.QueryableExtensions;
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
            #region 1、扁平化映射（Flattening
            //ViewBag.Tips = "1、扁平化映射（Flattening）";
            //默认情况下，我们的Source类和Destination类是根据属性名称进行匹配映射的。
            //除此之外，默认的映射规则还有下面两种情况，我们称之为扁平化映射，即当Source类中不包含Destination类中的属性的时候，AutoMapper会将Destination类中的属性进行分割，或匹配“Get”开头的方法


            //我们在进行映射的时候，不需要进行特殊的配置，既可以完成从Order到OrderDto的映射。
            //Customer customer = new Customer() { Name = "Tom" };
            //Order order = new Order() { Customer = customer };
            //OrderDto orderDto = Mapper.Map<OrderDto>(order);
            #endregion

            #region 指定映射字段（Projection）
            //指定映射字段（Projection）
            //ViewBag.Tips = "2、指定映射字段（Projection）";

            //CalendarEvent calendarEvent = new CalendarEvent()
            //{
            //    Date = DateTime.Now,
            //    Title = "Demo Event"
            //};
            //CalendarEventForm calendarEventForm = Mapper.Map<CalendarEventForm>(calendarEvent); 
            #endregion


            #region 验证配置项（Configuration Validation）
            //ViewBag.Tips = "3、验证配置项（Configuration Validation）";
            //Source1 s1 = new Source1()
            //{
            //    AnotherValue = "test",
            //    SomeValue = 1
            //};
            //Mapper.Map<Destination1>(s1);
            //Mapper.AssertConfigurationIsValid();        //以上会报错Unmapped members were found. Review the types and members below.
            #endregion


            #region 4、自定义解析器（Custom value resolvers）
            //ViewBag.Tips = "4、自定义解析器（Custom value resolvers）";
            //Source2 src = new Source2()
            //{
            //    Value1 = 1,
            //    Value2 = 2
            //};
            //Destination2 dest = Mapper.Map<Destination2>(src); 
            #endregion

            #region 5、自定义类型转换器（Custom type converters）
            //ViewBag.Tips = "5、自定义类型转换器（Custom type converters）";
            //Source3 src = new Source3()
            //{
            //    Value1 = "110",
            //    Value2 = "01/01/2000",
            //    Value3 = "String"
            //};


            //Destination3 dest = Mapper.Map<Destination3>(src);

            #endregion


            #region 空值替换（Null substitution）
            //ViewBag.Tips = "6、空值替换（Null substitution）";
            //Source4 src = new Source4();
            //Destination4 dest = Mapper.Map<Destination4>(src);
            #endregion

            #region 条件映射（Conditional mapping）
            ViewBag.Tips = "7、条件映射（Conditional mapping）";
            Source5 src = new Source5() { Value = 30 };         //Value如果符合条件会显示，否则会显示成0
            Destination5 dest = Mapper.Map<Destination5>(src);

            #endregion



            #region Queryable的扩展方法1.0(比如使用EF,NHibernate 这些ORM框架时，AutoMapper有Queryable的扩展方法）:ProjectTo

            int orderId = 1;
            //参考自Queryable Extensions：https://docs.automapper.org/en/v7.0.1/Queryable-Extensions.html#preventing-lazy-loading-select-n-1-problems
            //使用实体框架作为示例，假设您有一个OrderLine与实体有关系的实体Item。
            //如果要将其映射到OrderLineDTO带有Items Name属性的，则标准Mapper.Map调用将导致实体框架查询整个表OrderLine和Item表。

            //using (var ctx = new orderContext())
            //{
            //    List<OrderLineDTO> list = ctx.OrderLines.Where(ol => ol.OrderId == orderId)
            // .ProjectTo<OrderLineDTO>().ToList();       //这.ProjectTo<OrderLineDTO>()将告诉AutoMapper的映射引擎向select IQueryable 发出一个子句，该子句将通知实体框架它只需要查询Item表的Name列，就像手动将你IQueryable的OrderLineDTO一个Select子句投射到一个子句一样。
            //    //projectto提高了查询效率
            //    //注意事项看链接
            //}

            #endregion

            #region Queryable的扩展方法2.0 其他：下面的代码无法运行，但是可以学习
            //-----------------------------------自定义投影（使用MapFrom（而不是ResolveUsing）为目标成员提供自定义表达式）
            //        Mapper.Initialize(cfg => cfg.CreateMap<Customer, CustomerDto>()
            //.ForMember(d => d.FullName, opt => opt.MapFrom(c => c.FirstName + " " + c.LastName))
            //.ForMember(d => d.TotalContacts, opt => opt.MapFrom(c => c.Contacts.Count()));

            //------------------------------------自定义类型转换(有时，您需要完全替换从源类型到目标类型的类型转换。在正常的运行时映射中，这是通过ConvertUsing方法完成的。要在LINQ投影中执行模拟，请使用ProjectUsing方法)
            //cfg.CreateMap<Source, Dest>().ProjectUsing(src => new Dest { Value = 10 });

            //------------------------------------自定义目标类型构造函数（如果目标类型具有自定义构造函数但您不想覆盖整个映射，请使用ConstructProjectionUsing方法）
            //        cfg.CreateMap<Source, Dest>()
            //.ConstructProjectionUsing(src => new Dest(src.Value + 10));

            //------------------------------------字符串转换
            //public class Order
            //{
            //    public OrderTypeEnum OrderType { get; set; }
            //}
            //public class OrderDto
            //{
            //    public string OrderType { get; set; }
            //}
            //var orders = dbContext.Orders.ProjectTo<OrderDto>().ToList();
            //orders[0].OrderType.ShouldEqual("Online");

            //------------------------------------显式扩展（ToLearn：待学习）
            //        dbContext.Orders.ProjectTo<OrderDto>(
            //dest => dest.Customer,
            //dest => dest.LineItems);
            //        // or string-based
            //        dbContext.Orders.ProjectTo<OrderDto>(
            //            null,
            //            "Customer",
            //            "LineItems");

            //聚合
            //        cfg.CreateMap<Course, CourseModel>()
            //.ForMember(m => m.EnrollmentsStartingWithA,
            //      opt => opt.MapFrom(c => c.Enrollments.Where(e => e.Student.LastName.StartsWith("A")).Count()));     //将TotalContacts属性重命名为ContactsCount，则AutoMapper将与Count()扩展方法匹配

            //参数化（ToLearn：待学习）
            //dbContext.Courses.ProjectTo<CourseModel>(Config, new { currentUserName = Request.User.Name });


            #endregion

            return View(dest);
        }
    }
}