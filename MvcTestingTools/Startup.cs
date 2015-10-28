using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTestingTools.Startup))]
namespace MvcTestingTools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
