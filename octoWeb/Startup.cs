using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(octoWeb.Startup))]
namespace octoWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
