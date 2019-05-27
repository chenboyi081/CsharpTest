using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperWeb.Common
{
    /// <summary>
    /// 该类提供AutoMapper规则配置的入口，它只提供一个静态的方法，在程序第一次运行的时候调用该方法完成配置。
    /// </summary>
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ATProfile>();
                //当有多个Profile的时候，我们可以这样添加：
                //cfg.AddProfile<OtherProfile>();
                cfg.AddProfile<CalendarEventProfile>();
                cfg.AddProfile<Source1Profile>();
                cfg.AddProfile<Source2Profile>();
                cfg.AddProfile<Source3Profile>();
                cfg.AddProfile<Source4Profile>();
                cfg.AddProfile<Source5Profile>();
                cfg.AddProfile<OrderLineProfile>();

            });
        }
    }
}