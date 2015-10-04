using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLession01.Startup))]
namespace MVCLession01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
