using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FPTApplication.Startup))]
namespace FPTApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
