using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(个人练习1.Startup))]
namespace 个人练习1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
