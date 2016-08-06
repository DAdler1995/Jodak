using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jodak.Startup))]
namespace Jodak
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
