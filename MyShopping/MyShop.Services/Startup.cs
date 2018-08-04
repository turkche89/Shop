using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShop.Services.Startup))]
namespace MyShop.Services
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
