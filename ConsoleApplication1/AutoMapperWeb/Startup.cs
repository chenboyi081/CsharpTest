using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoMapperWeb.Startup))]
namespace AutoMapperWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
