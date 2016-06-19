using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coffee.Startup))]
namespace Coffee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
