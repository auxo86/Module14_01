using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Module14_01.Startup))]
namespace Module14_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
