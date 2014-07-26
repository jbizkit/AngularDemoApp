using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularDemoApp.Startup))]
namespace AngularDemoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
