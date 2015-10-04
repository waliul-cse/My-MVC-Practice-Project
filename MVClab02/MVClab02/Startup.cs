using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVClab02.Startup))]
namespace MVClab02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
